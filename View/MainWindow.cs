using ControleDeEstoqueProauto.Models;
using System.Data.SqlClient;
using System.Text;
using ControleDeEstoqueProauto.Model.Services;
using Microsoft.EntityFrameworkCore;
using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Model.Repository;
using ControleDeEstoqueProauto.Data;


namespace ControleDeEstoqueProauto
{
    public partial class MainWindow : Form, IMainWindow
    {

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
            set 
            {
                this.dtpDataUltimaAlteracao.Format = DateTimePickerFormat.Short;
                this.dtpDataUltimaAlteracao.Value = value;
           
            }
        }
        public int? EstoqueMinimo 
        {
            get { return int.Parse(this.txtEstoqueMin.Text); }
            set { this.txtEstoqueMin.Text = value.ToString(); }
        }
        public DateTime DataAtual 
        {
            get { return this.dtpData.Value; }
            set { this.dtpData.Value = value; }
        }
        public int Quantidade 
        {
            get { return int.Parse(this.numQuantidade.Value.ToString()); }
            set { this.numQuantidade.Value =  value; }
        }
        public IList<Movimentacoes> MovimentacaoDoProduto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataDe
        {
            get { return this.dtpDe.Value; }
            set { this.dtpDe.Value = value; }
        }
        public DateTime DataPara
        {
            get { return this.dtpPara.Value; }
            set { this.dtpPara.Value = value; }
        }

        public bool Acrescentar
        {
            get { return this.rbAcrescentar.Checked; }
            set { this.rbAcrescentar.Checked = value; }
        }

        public bool Remover
        {
            get { return this.rbRemover.Checked; }
            set { this.rbRemover.Checked = value; }
        }

        public string Filtro
        {
            get { return this.txtFiltro.Text.ToLower(); }
            set { this.txtFiltro.Text = value; }
        }

        public Presenter.MainWindowPresenter Presenter { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            var produtoRepository = new ProdutosRepository();
            var movimentacaoRepository = new MovimentacoesRepository();
            Presenter = new Presenter.MainWindowPresenter(this, produtoRepository, movimentacaoRepository);

            listBoxProdutos.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxProdutos.DrawItem += new DrawItemEventHandler(listBoxProdutos_DrawItem);

            AvisaProdutosComEstoqueMinimo();
        }
        #region Metodos 

        private async Task AvisaProdutosComEstoqueMinimo()
        {
            try
            {
                var produto = await new ProdutoService().ObterProdutosComEstoqueBaixo();
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
                MessageBox.Show("Ocorreu um erro ao verificar o estoque m�nimo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Presenter.AtualizarCadastroProduto();
                    txtEstoqueMin.ReadOnly = true;

                }
            }
        }
        private void listBoxProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                Presenter.IncluirNovosRegistros();
            }
            else if (e.KeyCode == Keys.F5)
            {
                Presenter.AtualizarListaDeProdutos();
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
                var descricao = listBoxProdutos.SelectedItem;

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

            Presenter.InserirMovimentação();
            
        }

        private void ckbVerificarEstoqueMin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerificarEstoqueMin.Checked)
            {
                Presenter.AtualizarListaDeProdutosComEstoqueMinimo();
            }
            else
            {
                Presenter.AtualizarListaDeProdutos();
            }

        }

        private void dgvMovimentacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Delete)
            {
                if (dgvMovimentacoes.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvMovimentacoes.SelectedRows[0];
                    var cellValue = selectedRow.Cells["ID"].Value.ToString();

                    DialogResult msg = MessageBox.Show("Atenção!\nDeseja Deletar o registro informado? \nEssa ação é irreversével!", "Deletar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msg is DialogResult.Yes)
                    {
                        Movimentacoes mov = new Movimentacoes();
                        mov.ID = int.Parse(cellValue);
                        //_context.movimentacoes.Remove(mov);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Presenter.FiltroDigitacao();
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
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
            }
        }

        private void incluirNovosRegistrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Presenter.IncluirNovosRegistros();
        }

        private void atualizarListaDeItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.AtualizarListaDeProdutos();
        }

        private void baixarMovimentaçõesPorDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_DownloadEstoque frm = new Frm_DownloadEstoque();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTimer.Text = DateTime.Now.ToString();
        }

        
    }
}
