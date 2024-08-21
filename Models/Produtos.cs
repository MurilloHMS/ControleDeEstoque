using ClosedXML.Excel;

namespace ControleDeEstoqueProauto.Models
{
    public class Produtos
    {
        public int IDSistema { get; set; }
        public string Descricao { get; set; }
        public int EstoqueMinimo { get; set; }


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
