using ControleDeEstoqueProauto.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Presenter
{
    public class ProdutosPresenter
    {
        private readonly IMainWindow _view;
        private readonly IProdutosRepository _repository;

        public ProdutosPresenter(IMainWindow view, IProdutosRepository repository)
        {
            _view = view;
            _view.Presenter = this;
            _repository = repository;

            AtualizarListaDeProdutos();
        }

        private async void AtualizarListaDeProdutos()
        {
            var produto = await _repository.GetAll(); 
            _view.listaDeProdutos = produto.ToList();
            
        }
    }
}
