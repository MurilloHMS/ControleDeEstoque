using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Model.Services;
using ControleDeEstoqueProauto.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public async void AtualizarListaDeProdutosComEstoqueMinimo()
        {
            var produto = await _produtosRepository.GetAll();
            var movimentacoes = await _movimentacoesRepository.GetAll();

            var produtosComEstoqueBaixo = produto.Select(produto => new
            {
                Produto = produto,
                QuantidadeTotal = movimentacoes.Where(m => m.IDSistema == produto.IDSistema).Sum(m => m.Quantidade)
            }).Where(p => p.Produto.EstoqueMinimo.HasValue && p.QuantidadeTotal <= p.Produto.EstoqueMinimo.Value).Select(p => p.Produto).ToList();

            _view.listaDeProdutos = produtosComEstoqueBaixo;
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
                _view.DataUltimaAlteracao = mov.Data;
                _view.EstoqueMinimo = prod.EstoqueMinimo;
            }
        }

        public async Task InserirMovimentação()
        {
            try
            {
                if (_view.Acrescentar || _view.Remover)
                {
                    Movimentacoes mov = new Movimentacoes();
                    mov.IDSistema = _view.IdSistema;
                    mov.Data = DateTime.Parse(_view.DataAtual.ToString()).ToUniversalTime();
                    int estoqueAtual = _view.EstoqueAtual;
                    int estoque = _view.Quantidade;
                    int valor = 0;
                    if (estoqueAtual > 0)
                    {
                        if (_view.Acrescentar)
                        {
                            valor = estoqueAtual + estoque;
                        }
                        else if (_view.Remover)
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
                    _movimentacoesRepository.Save(mov);
                    MessageBox.Show("Movimentação incluida Com Sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _view.EstoqueAtual = valor;
                    _view.DataUltimaAlteracao = DateTime.Parse(_view.DataAtual.ToString()).ToUniversalTime();
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

        public async Task FiltroDigitacao()
        {
            string search = _view.Filtro;
            var filtro = await _produtosRepository.GetListByFilter(search);

            _view.listaDeProdutos.Clear();
            _view.listaDeProdutos = (IList<Models.Produtos>)filtro;
        }

        public async Task AtualizarCadastroProduto()
        {

            try
            {
                Produtos produto = _produtosRepository.GetById(_view.IdSistema);
                produto.EstoqueMinimo = _view.EstoqueMinimo;
                _produtosRepository.SaveProduct(produto);
            }
            catch (Exception ex)
            {
                throw;
            }
            
            
        }

        public async Task IncluirNovosRegistros()
        {
            try
            {
                var dados = ProdutoService.ObterProdutosDoExcel();
                _view.listaDeProdutos.Clear();
                var produtos = await _produtosRepository.GetAll();
                foreach (var i in dados)
                {
                    Produtos produto = new Produtos
                    {
                        IDSistema = i.IDSistema,
                        Descricao = i.Descricao,
                        EstoqueMinimo = i.EstoqueMinimo ?? null
                    };
                    if (produtos.Any(p => p.IDSistema == i.IDSistema))
                    {
                        _produtosRepository.SaveProduct(produto);
                    }
                    else
                    {
                        _produtosRepository.SaveNewProduct(produto);
                    }
                }
                AtualizarListaDeProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir ou atualizar registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
