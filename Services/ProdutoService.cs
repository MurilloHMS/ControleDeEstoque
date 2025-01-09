using ClosedXML.Excel;
using ControleDeEstoqueProauto.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoqueProauto.Services;

public class ProdutoService
{
    private readonly AppDbContext _context = new AppDbContext();
    
    public async Task<IEnumerable<Produtos>> ObterProdutosComEstoqueBaixo()
    {
        var produtos = await _context.produtos.ToListAsync();
        var movimentacoes = await _context.movimentacoes.ToListAsync();

        var produtosComEstoqueBaixo = produtos.Select(produto => new
            {
                Produto = produto,
                QuantidadeTotal = movimentacoes
                    .Where(m => m.IDSistema == produto.IDSistema)
                    .Sum(m => m.Quantidade)
            }).Where(p => p.Produto.EstoqueMinimo.HasValue && p.QuantidadeTotal <= p.Produto.EstoqueMinimo.Value)
            .Select(p => p.Produto).ToList();
        
        return produtosComEstoqueBaixo;
    }

    public static IEnumerable<Produtos> ObterProdutosDoExcel()
    {
        string arquivo = string.Empty;

        using OpenFileDialog ofd = new OpenFileDialog();
        if (DialogResult.OK == ofd.ShowDialog())
            arquivo = ofd.FileName;

        IEnumerable<Produtos> produtos;

        using (XLWorkbook workbook = new(arquivo))
        {
            var planilha = workbook.Worksheets.First();
            produtos = planilha.RowsUsed()
                .Skip(1)
                .Select(row => new Produtos
                {
                    IDSistema = row.Cell(1).GetValue<int>(),
                    Descricao = row.Cell(2).GetValue<string>()
                }).ToList();
        }
        return produtos;
    }
}