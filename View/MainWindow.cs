using ControleDeEstoqueProauto.Models;
using System.Data.SqlClient;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Model.Services;
using ControleDeEstoqueProauto.Data;
using ControleDeEstoqueProauto.Model.Repository;


namespace ControleDeEstoqueProauto
{
    public partial class MainWindow : Form, IMainWindow
    {
        private readonly AppDbContext _context = new AppDbContext();
        private IEnumerable<Produtos> _produtos;

        private System.Windows.Forms.Timer timer;

        public IList<Produtos> listaDeProdutos 
        {
            get { return (IList<Produtos>)this.listBoxProdutos.DataSource; }
            set 
            { 
                this.listBoxProdutos.DataSource = value;
                this.listBoxProdutos.DisplayMember = "Descricao";
            }
        }

        public string ProdutoSelecionado 
        {
            get => (listBoxProdutos.SelectedItem as Produtos)?.Descricao ?? string.Empty;
            set
            {
                foreach (Produtos produto in listBoxProdutos.Items)
                {
                    if (produto.Descricao == value)
                    {
                        listBoxProdutos.SelectedItem = produto;
                        break;
                    }
                }
            }
        }
        public int IdSistema 
        {
            get { return int.Parse(this.txtID.Text); }
            set { this.txtID.Text = value.ToString(); }
        }

        public string Nome 
        {
            get { return this.txtDescricao.Text; }
            set { this.txtDescricao.Text = value; } 
        }
        public int EstoqueAtual 
        {
            get { return int.Parse(this.txtEstoqueAtual.Text); }
            set { this.txtEstoqueAtual.Text = value.ToString(); }
        }
        public DateTime DataUltimaAlteracao 
        {
            get { return this.dtpDataUltimaAlteracao.Value; }
            set { this.dtpDataUltimaAlteracao.Value = value; }
        }
        public int? EstoqueMinimo 
        {
            get { return int.Parse(this.txtEstoqueMin.Text); }
            set { this.txtEstoqueMin.Text = value.ToString(); }
        }
        public DateTime DataAtual { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<Movimentacoes> MovimentacaoDoProduto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataDe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataPara { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Presenter.MainWindowPresenter Presenter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //AvisaProdutosComEstoqueMinimo();

            var produtoRepository = new ProdutosRepository();
            var movimentacaoRepository = new MovimentacoesRepository();
            Presenter = new Presenter.MainWindowPresenter(this, produtoRepository, movimentacaoRepository);

            listBoxProdutos.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxProdutos.DrawItem += new DrawItemEventHandler(listBoxProdutos_DrawItem);
        }
        #region Metodos 

        //private async Task AvisaProdutosComEstoqueMinimo()
        //{
        //    try
        //    {
        //        var produto = await new ProdutoService().ObterProdutosComEstoqueBaixo();
        //        if (produto.Count() < 1) { return; }
        //        StringBuilder sb = new StringBuilder();
        //        sb.AppendLine("Atenção os itens abaixo estão com o estoque abaixo do mínimo:");
        //        sb.AppendLine();
        //        foreach (var i in produto)
        //        {
        //            sb.AppendLine(i.ToString());
        //        }
        //        MessageBox.Show(sb.ToString(), "Itens com estoque baixo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao verificar o estoque m�nimo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private async Task RetornaRegistrosComEstoqueMinimo()
        //{
        //    Produtos produtos = new Produtos();
        //    _produtos = await new ProdutoService().ObterProdutosComEstoqueBaixo();
        //    listBoxProdutos.Items.Clear();
        //    listBoxProdutos.Items.AddRange(_produtos.Select(p => p.Descricao).ToArray());
        //    listBoxProdutos.Sorted = true;
        //}

        //private async Task IncluirNovosRegistros()
        //{
        //    try
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        var dados = ProdutoService.ObterProdutosDoExcel();
        //        listBoxProdutos.Items.Clear();
        //        _produtos = await _context.produtos.ToListAsync();
        //        foreach (var i in dados)
        //        {
        //            Produtos produto = new Produtos
        //            {
        //                IDSistema = i.IDSistema,
        //                Descricao = i.Descricao,
        //                EstoqueMinimo = i.EstoqueMinimo ?? null
        //            };
        //            if (_produtos.Any(p => p.IDSistema == i.IDSistema))
        //            {
        //                _context.produtos.Update(produto);
        //            }
        //            else
        //            {
        //                _context.produtos.Add(produto);
        //            }

        //            _context.SaveChanges();
        //        }
        //        _produtos = await _context.produtos.ToListAsync();
        //        listBoxProdutos.Items.AddRange(_produtos.Select(p => p.Descricao).ToArray());
        //        listBoxProdutos.Sorted = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao incluir ou atualizar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.Cursor = Cursors.Default; // Restaura o cursor original
        //    }
        //}

        //private async Task AtualizarListaDeProdutos(IEnumerable<Produtos> obterProdutos)
        //{
        //    _produtos = obterProdutos;
        //    listBoxProdutos.Items.Clear();
        //    listBoxProdutos.Items.AddRange(_produtos.Select(p => p.Descricao).ToArray());
        //    listBoxProdutos.Sorted = true;
        //}
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
                    //Produtos produtos = new Produtos();
                    //produtos.IDSistema = int.Parse(txtID.Text);
                    //produtos.Descricao = txtDescricao.Text;
                    //produtos.EstoqueMinimo = int.TryParse(txtEstoqueMin.Text, out int valor) ? valor : null;
                    //_context.produtos.Update(produtos);
                    //_context.SaveChanges();
                    //txtEstoqueMin.ReadOnly = true;

                }
            }
        }
        private void listBoxProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                //IncluirNovosRegistros();
            }
            else if (e.KeyCode == Keys.F5)
            {
                //AtualizarProdutos();
            }
        }

        private void txtEstoqueMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 08 ? true : false;
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
                dtpDataUltimaAlteracao.Format = DateTimePickerFormat.Custom;
                dtpDataUltimaAlteracao.CustomFormat = " ";
                numQuantidade.Value = 0;

                Presenter.AtualizarDadosProdutosView(ProdutoSelecionado.ToString());

                //if (!ckbBuscarPorPeriodo.Checked)
                //{
                //    var data = _context.movimentacoes.Where(m => m.IDSistema == retorno.IDSistema).ToListAsync();
                //    dgvMovimentacoes.DataSource = data;
                //}
                //else
                //{
                //    var data = await _context.movimentacoes.Where(m => m.Data >= dtpDe.Value && m.Data <= dtpPara.Value).ToListAsync();
                //    dgvMovimentacoes.DataSource = data;
                //}
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (rbAcrescentar.Checked || rbRemover.Checked)
            //    {
            //        Movimentacoes mov = new Movimentacoes();
            //        mov.IDSistema = int.Parse(txtID.Text);
            //        mov.Data = DateTime.Parse(dtpData.Value.ToString()).ToUniversalTime();
            //        int estoqueAtual = int.TryParse(txtEstoqueAtual.Text, out int result) ? result : 0;
            //        int estoque = int.Parse(numQuantidade.Value.ToString());
            //        int valor = 0;
            //        if (estoqueAtual > 0)
            //        {
            //            if (rbAcrescentar.Checked)
            //            {
            //                valor = estoqueAtual + estoque;
            //            }
            //            else if (rbRemover.Checked)
            //            {
            //                valor = estoqueAtual - estoque;
            //            }
            //        }
            //        else
            //        {
            //            valor = estoque;
            //        }
            //        if (valor.Equals(0))
            //        {
            //            MessageBox.Show("Ocorreu um erro ao incluir a movimentacao", "Erro ao incluir movimentacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        mov.Quantidade = valor;
            //        _context.movimentacoes.Add(mov);
            //        _context.SaveChanges();
            //        MessageBox.Show("Movimentação incluida Com Sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtEstoqueAtual.Text = valor.ToString();
            //        dtpDataUltimaAlteracao.Value = DateTime.Parse(dtpData.Value.ToString()).ToUniversalTime();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Aten��o Selecione uma op��o para remover ou acrescentar o estoque", "Verifica��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
            //catch (SqlException)
            //{
            //    throw;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        private void ckbVerificarEstoqueMin_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbVerificarEstoqueMin.Checked)
            //{
            //    RetornaRegistrosComEstoqueMinimo();
            //}
            //else
            //{
            //    AtualizarProdutos();
            //}

        }

        private void dgvMovimentacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Delete)
            {
                if (dgvMovimentacoes.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvMovimentacoes.SelectedRows[0];
                    var cellValue = selectedRow.Cells["ID"].Value.ToString();

                    DialogResult msg = MessageBox.Show("Aten��o!\nDeseja Deletar o registro informado? \nEssa a��o � irrevers�vel!", "Deletar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg is DialogResult.Yes)
                    {
                        //Movimentacoes mov = new Movimentacoes();
                        //mov.ID = int.Parse(cellValue);
                        //_context.movimentacoes.Remove(mov);
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
                MessageBox.Show("N�o foi possível abrir o link. Erro: " + ex.Message);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = @"https://proautokimium.com.br/",
                    UseShellExecute = true
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
