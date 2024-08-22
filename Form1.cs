using ControleDeEstoqueProauto.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Text;

namespace ControleDeEstoqueProauto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarProdutos();
            AvisaProdutosComEstoqueMinimo();
        }
        #region Metodos 
        private async Task AtualizarProdutos()
        {
            Produtos produtos = new Produtos();
            var retorno = await produtos.GetAll();

            listBoxProdutos.Items.Clear();
            foreach (var i in retorno)
            {
                listBoxProdutos.Items.Add(i.ToString());
            }
            listBoxProdutos.Sorted = true;
        }
        private async Task AvisaProdutosComEstoqueMinimo()
        {
            Produtos produtos = new Produtos();
            var retorno = await produtos.GetProductLowStorage();
            if (retorno.Count() < 1) { return; }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Atenção os itens Abaixo estão com o estoque abaixo do Mínimo");
            sb.AppendLine();
            foreach (var i in retorno)
            {
                sb.AppendLine(i.ToString());
            }
            MessageBox.Show(sb.ToString(), "Itens Com estoque baixo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private async Task RetornaRegistrosComEstoqueMinimo()
        {
            Produtos produtos = new Produtos();
            var retorno = await produtos.GetProductLowStorage();
            listBoxProdutos.Items.Clear();
            foreach (var i in retorno)
            {
                listBoxProdutos.Items.Add(i.ToString());
            }
            listBoxProdutos.Sorted = true;
        }

        private async Task IncluirNovosRegistros()
        {
            var dados = Produtos.ObterProdutosDeExcel().ToList();
            listBoxProdutos.Items.Clear();
            Produtos retornos = new Produtos();
            var dadoss = await retornos.GetAll();
            if (dadoss.Count() < 1)
            {
                foreach (var i in dados)
                {
                    Produtos produto = new Produtos();
                    produto.IDSistema = i.IDSistema;
                    produto.Descricao = i.Descricao;
                    produto.EstoqueMinimo = i.EstoqueMinimo ?? null;
                    produto.Add();
                }
            }
            else
            {
                foreach (var i in dados)
                {
                    Produtos produto = new Produtos();
                    produto.IDSistema = i.IDSistema;
                    produto.Descricao = i.Descricao;
                    produto.EstoqueMinimo = i.EstoqueMinimo ?? null;
                    produto.Update();
                }
            }

            Produtos produtos = new Produtos();
            var retorno = await produtos.GetAll();
            foreach (var i in retorno)
            {
                Produtos p = new Produtos();
                p.IDSistema = i.IDSistema;
                p.Descricao = i.Descricao;
                p.EstoqueMinimo = i.EstoqueMinimo ?? null;
                listBoxProdutos.Items.Add(p);
            }
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
    }
}
