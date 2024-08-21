using ControleDeEstoqueProauto.Models;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ControleDeEstoqueProauto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarProdutos();
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

        private async Task IncluirNovosRegistros()
        {
            var dados = Produtos.ObterProdutosDeExcel().ToList();
            listBoxProdutos.Items.Clear();

            foreach (var i in dados)
            {
                Produtos produto = new Produtos();
                produto.IDSistema = i.IDSistema;
                produto.Descricao = i.Descricao;
                produto.EstoqueMinimo = i.EstoqueMinimo ?? null;
                produto.Update();
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
                    produtos.EstoqueMinimo = int.Parse(txtEstoqueMin.Text);
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
            var descricao = listBoxProdutos.SelectedItem;

            Produtos produtos = new Produtos();
            var retorno = await produtos.GetForName(descricao.ToString());
            txtDescricao.Text = retorno.Descricao;
            txtID.Text = retorno.IDSistema.ToString();
            txtEstoqueMin.Text = retorno.EstoqueMinimo.ToString();


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
