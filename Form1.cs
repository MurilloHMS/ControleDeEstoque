using ControleDeEstoqueProauto.Models;

namespace ControleDeEstoqueProauto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEstoqueMin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtEstoqueMin.ReadOnly)
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
                    MessageBox.Show("Estoque Minimo Atualizado com sucesso!");
                    txtEstoqueMin.ReadOnly = true;
                }
            }
        }

        private void btnBuscarMovimentacoes_Click(object sender, EventArgs e)
        {

        }

        private void listBoxProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                var dados = Produtos.ObterProdutosDeExcel().ToList();
                listBoxProdutos.Items.Clear();

                foreach (var i in dados)
                {
                    listBoxProdutos.Items.Add(i);
                }
                listBoxProdutos.Sorted = true;
            }
        }

        private void txtEstoqueMin_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 08 ? true : false;
        }
    }
}
