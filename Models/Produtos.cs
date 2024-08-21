using ClosedXML.Excel;
using ControleDeEstoqueProauto.Migrations;
using SQLitePCL;
using System.ComponentModel.DataAnnotations;

namespace ControleDeEstoqueProauto.Models
{
    public class Produtos
    {
        [Required]
        public int IDSistema { get; set; }
        [Required]
        public string Descricao { get; set; }
        public int ? EstoqueMinimo { get; set; }

        private readonly DAL<Produtos> _dal = new DAL<Produtos>();
        private readonly DAL<Movimentacoes> _dalM = new DAL<Movimentacoes>();

        #region Crud
        public async Task Add()
        {
            await _dal.AddAsync(this);
        }

        public async Task Update()
        {
            await _dal.UpdateAsync(this);
        }

        public async Task Delete()
        {
            await _dal.DeleteAsync(this);
        }

        public async Task<IEnumerable<Produtos>> GetAll() 
        { 
            return await _dal.GetAllAsync(); 
        }
        
        public async Task<Produtos> GetForID(int id)
        {
            return await _dal.GetForAsync(x => x.IDSistema.Equals(id));
        }

        public async Task<Produtos> GetForName(string name)
        {
            return await _dal.GetForAsync(x => x.Descricao.Equals(name));
        }


        public async Task<IEnumerable<Produtos>> GetProductLowStorage()
        {
            var produtos = await _dal.GetAllAsync();
            var movimentacoes = await _dalM.GetAllAsync();

            var produtosComEstoqueBaixo = produtos
                .Select(produto => new
                {
                    Produto = produto,
                    QuantidadeTotal = movimentacoes
                        .Where(m => m.IDSistema == produto.IDSistema)
                        .Sum(m => m.Quantidade)
                })
                .Where(p => p.Produto.EstoqueMinimo.HasValue && p.QuantidadeTotal <= p.Produto.EstoqueMinimo.Value)
                .Select(p => p.Produto)
                .ToList();

            return produtosComEstoqueBaixo;
        }


        #endregion
        public static IEnumerable<Produtos> ObterProdutosDeExcel()
        {
            string arquivo = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {
                if(DialogResult.OK == ofd.ShowDialog())
                {
                    arquivo = ofd.FileName;
                }
            }

            IEnumerable<Produtos> produtos;

            using (XLWorkbook workbook = new XLWorkbook(arquivo))
            {
                var planilha = workbook.Worksheet(1);
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

        public override string ToString()
        {
            return Descricao;
        }

    }
    
}
