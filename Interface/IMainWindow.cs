using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEstoqueProauto.Models;

namespace ControleDeEstoqueProauto.Interface
{
    public interface IMainWindow
    {
        IList<Produtos> listaDeProdutos { get; set; }
        string ProdutoSelecionado { get; set; }
        int IdSistema {  get; set; }
        string Nome {  get; set; }
        int EstoqueAtual {  get; set; }
        DateTime DataUltimaAlteracao { get; set; }
        int? EstoqueMinimo { get; set; }
        DateTime DataAtual { get; set; }
        int Quantidade { get; set; }
        IList<Movimentacoes> MovimentacaoDoProduto { get; set; }
        DateTime DataDe { get; set; }
        DateTime DataPara { get; set; }
        bool Acrescentar {  get; set; }
        bool Remover { get; set; }
        string Filtro { get; set; }

        Presenter.MainWindowPresenter Presenter { get; set; }
        
    }
}
