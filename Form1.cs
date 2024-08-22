using ControleDeEstoqueProauto.Models;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ControleDeEstoqueProauto
{
    public partial class Form1 : Form
    {
        private IEnumerable<Produtos> _produtos;
        public Form1()
        {
            InitializeComponent();
            AtualizarProdutos();
            AvisaProdutosComEstoqueMinimo();
            listBoxProdutos.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxProdutos.DrawItem += new DrawItemEventHandler(listBoxProdutos_DrawItem);
        }
        #region Metodos 
        private async Task AtualizarProdutos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                await AtualizarListaDeProdutos(() => new Produtos().GetAll());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private async Task AvisaProdutosComEstoqueMinimo()
        {
            try
            {
                Produtos produtos = new Produtos();
                var produto = await produtos.GetProductLowStorage();

                if (produto.Count() < 1) { return; }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Atenção os itens abaixo estão com o estoque abaixo do mínimo:");
                sb.AppendLine();

                foreach (var i in produto)
                {
                    sb.AppendLine(i.ToString());
                }

                MessageBox.Show(sb.ToString(), "Itens com estoque baixo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar o estoque mínimo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task RetornaRegistrosComEstoqueMinimo()
        {
            Produtos produtos = new Produtos();
            _produtos = await produtos.GetProductLowStorage();
            listBoxProdutos.Items.Clear();
            listBoxProdutos.Items.AddRange(_produtos.Select(p => p.Descricao).ToArray());
            listBoxProdutos.Sorted = true;
        }

        private async Task IncluirNovosRegistros()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var dados = Produtos.ObterProdutosDeExcel().ToList();
                listBoxProdutos.Items.Clear();

                Produtos produtos = new Produtos();
                _produtos = await produtos.GetAll();

                foreach (var i in dados)
                {
                    Produtos produto = new Produtos
                    {
                        IDSistema = i.IDSistema,
                        Descricao = i.Descricao,
                        EstoqueMinimo = i.EstoqueMinimo ?? null
                    };

                    if (_produtos.Any(p => p.IDSistema == i.IDSistema))
                    {
                        produto.Update();
                    }
                    else
                    {
                        produto.Add();
                    }
                }

                _produtos = await produtos.GetAll();
                listBoxProdutos.Items.AddRange(_produtos.Select(p => p.Descricao).ToArray());
                listBoxProdutos.Sorted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir ou atualizar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default; // Restaura o cursor original
            }
        }

        private async Task AtualizarListaDeProdutos(Func<Task<IEnumerable<Produtos>>> obterProdutos)
        {
            _produtos = await obterProdutos();

            listBoxProdutos.Items.Clear();
            listBoxProdutos.Items.AddRange(_produtos.Select(p => p.Descricao).ToArray());
            listBoxProdutos.Sorted = true;
        }

        #endregion
        private void txtEstoqueMin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtEstoqueMin.ReadOnly && !string.IsNullOrEmpty(txtID.Text))
            {
                txtEstoqueMin.ReadOnly = false;
            }
        }

        private void txtEstoqueMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtEstoqueMin.ReadOnly)
                {
                    Produtos produtos = new Produtos();
                    produtos.IDSistema = int.Parse(txtID.Text);
                    produtos.Descricao = txtDescricao.Text;
                    produtos.EstoqueMinimo = int.TryParse(txtEstoqueMin.Text, out int valor) ? valor : null;
                    produtos.Update();
                    txtEstoqueMin.ReadOnly = true;

                }
            }
        }

        private void btnBuscarMovimentacoes_Click(object sender, EventArgs e)
        {

        }

        private void listBoxProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                IncluirNovosRegistros();
            }
            else if (e.KeyCode == Keys.F5)
            {
                AtualizarProdutos();
            }
        }

        private void txtEstoqueMin_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 08 ? true : false;
        }

        private void ckbVerificarEstoqueMin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                Frm_Configuracoes frm = new Frm_Configuracoes();
                frm.ShowDialog();
            }
        }

        private async void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescricao.Clear();
                txtEstoqueAtual.Clear();
                txtEstoqueMin.Clear();
                txtID.Clear();
                rbAcrescentar.Checked = false;
                rbRemover.Checked = false;
                dtpData.Value = DateTime.Now;
                dtpDataUltimaAlteracao.Value = DateTime.Now;
                numQuantidade.Value = 0;
                var descricao = listBoxProdutos.SelectedItem;

                Produtos produtos = new Produtos();
                var retorno = await produtos.GetForName(descricao.ToString());
                Movimentacoes mov = new Movimentacoes();
                var retornoMov = await mov.GetForIDSistema(retorno.IDSistema);
                if (retornoMov != null)
                {
                    txtEstoqueAtual.Text = retornoMov.Quantidade.ToString();
                    dtpDataUltimaAlteracao.Value = retornoMov.Data;
                }
                txtDescricao.Text = retorno.Descricao;
                txtID.Text = retorno.IDSistema.ToString();
                txtEstoqueMin.Text = retorno.EstoqueMinimo.ToString();

                if (!ckbBuscarPorPeriodo.Checked)
                {
                    var dados = await mov.GetListForID(retorno.IDSistema);
                    dgvMovimentacoes.DataSource = dados;
                }
                else
                {
                    var movim = await mov.GetListForDate(dtpDe.Value, dtpPara.Value);
                    dgvMovimentacoes.DataSource = movim;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAcrescentar.Checked || rbRemover.Checked)
                {
                    Movimentacoes mov = new Movimentacoes();
                    mov.IDSistema = int.Parse(txtID.Text);
                    mov.Data = DateTime.Parse(dtpData.Value.ToString()).ToUniversalTime();
                    int estoqueAtual = int.TryParse(txtEstoqueAtual.Text, out int result) ? result : 0;
                    int estoque = int.Parse(numQuantidade.Value.ToString());
                    int valor = 0;
                    if (estoqueAtual > 0)
                    {
                        if (rbAcrescentar.Checked)
                        {
                            valor = estoqueAtual + estoque;
                        }
                        else if (rbRemover.Checked)
                        {
                            valor = estoqueAtual - estoque;
                        }
                    }
                    else
                    {
                        valor = estoque;
                    }
                    if (valor.Equals(0))
                    {
                        MessageBox.Show("Ocorreu um erro ao incluir a movimentacao", "Erro ao incluir movimentacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    mov.Quantidade = valor;
                    mov.Add();
                    MessageBox.Show("Movimentação incluida Com Sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEstoqueAtual.Text = valor.ToString();
                    dtpDataUltimaAlteracao.Value = DateTime.Parse(dtpData.Value.ToString()).ToUniversalTime();
                }
                else
                {
                    MessageBox.Show("Atenção Selecione uma opção para remover ou acrescentar o estoque", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ckbVerificarEstoqueMin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerificarEstoqueMin.Checked)
            {
                RetornaRegistrosComEstoqueMinimo();
            }
            else
            {
                AtualizarProdutos();
            }

        }

        private async void btnBuscarMovimentacoes_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvMovimentacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Delete)
            {
                if (dgvMovimentacoes.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvMovimentacoes.SelectedRows[0];
                    var cellValue = selectedRow.Cells["ID"].Value.ToString();

                    DialogResult msg = MessageBox.Show("Atenção!\nDeseja Deletar o registro informado? \nEssa ação é irreversível!", "Deletar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg is DialogResult.Yes)
                    {
                        Movimentacoes mov = new Movimentacoes();
                        mov.ID = int.Parse(cellValue);
                        mov.Delete();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.ToLower();
            var filtro = _produtos.Where(p => p.Descricao.ToLower().Contains(search)).ToArray();

            listBoxProdutos.Items.Clear();
            listBoxProdutos.Items.AddRange(filtro.Select(p => p.Descricao).ToArray());
        }

        private void listBoxProdutos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(99, 194, 157)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            }


            e.Graphics.DrawString(listBoxProdutos.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);


            e.DrawFocusRectangle();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = @"https://github.com/murillohms",
                    UseShellExecute = true // Abre o link no navegador padrão
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = @"https://proautokimium.com.br/",
                    UseShellExecute = true // Abre o link no navegador padrão
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
            }
        }
    }
}
