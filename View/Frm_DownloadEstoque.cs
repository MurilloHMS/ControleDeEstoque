using System.Diagnostics;
using System.IO;
using ControleDeEstoqueProauto.Models;
using ClosedXML.Excel;
using ControleDeEstoqueProauto.Data;
using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Model.Repository;

namespace ControleDeEstoqueProauto
{
    public partial class Frm_DownloadEstoque : Form, IDownloadEstoqueView
    {

        public DateTime DataSelecionada
        {
            get { return this.dtpDataSelecionada.Value; }
            set { this.dtpDataSelecionada.Value = value; }
        }
        
        public Presenter.DownloadEstoquePresenter Presenter { get; set; }
        public Frm_DownloadEstoque()
        {
            InitializeComponent();

            var movimentacoesRepository = new MovimentacoesRepository();
            var produtosRepository = new ProdutosRepository();
            Presenter = new Presenter.DownloadEstoquePresenter(this, movimentacoesRepository, produtosRepository);

        }

        public void btnBaixar_Click(object sender, EventArgs e)
        {
            Presenter.ExtrairEstoque();
        }


    }
}
