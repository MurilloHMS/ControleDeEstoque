using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Presenter
{
    public class MainWindowPresenter
    {
        private readonly IMainWindow _view;
        private readonly IProdutosRepository _produtosRepository;
        private readonly IMovimentacoesRepository _movimentacoesRepository;

        public MainWindowPresenter(IMainWindow view, IProdutosRepository produtosRepository, IMovimentacoesRepository movimentacoesRepository)
        {
            _view = view;
            _view.Presenter = this;
            _produtosRepository = produtosRepository;
            _movimentacoesRepository = movimentacoesRepository;

            AtualizarListaDeProdutos();
        }

        public async void AtualizarListaDeProdutos()
        {
            var produto = await _produtosRepository.GetAll(); 
            _view.listaDeProdutos = produto.ToList();
            var produtoSelecionado = _view.ProdutoSelecionado == null ? _view.ProdutoSelecionado : string.Empty;
            _view.ProdutoSelecionado = produtoSelecionado;
        }

        public async Task AtualizarDadosProdutosView(string p)
        {
            var prod = await _produtosRepository.GetByName(p);
            var mov = _movimentacoesRepository.GetById(prod.IDSistema);
            if (mov != null)
            {
                _view.IdSistema = mov.IDSistema;
                _view.Nome = prod.Descricao;
                _view.EstoqueAtual = mov.Quantidade;
                _view.Quantidade = mov.Quantidade;
                _view.DataUltimaAlteracao = mov.Data;
                _view.EstoqueMinimo = prod.EstoqueMinimo;
            }
        }
    }
}
