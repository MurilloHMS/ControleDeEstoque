using System.Diagnostics;
using System.IO;
using ControleDeEstoqueProauto.Models;
using ClosedXML.Excel;

namespace ControleDeEstoqueProauto
{
    public partial class Frm_DownloadEstoque : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        
        public Frm_DownloadEstoque()
        {
            InitializeComponent();
        }

        public void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime DataBusca = dtpDataSelecionada.Value;
                var movimentacoes = _context.movimentacoes.ToList();

                // Realizando a operação UNION antes da projeção
                var estoqueDoDia = movimentacoes
                    .Where(m => m.Data == DataBusca) // Movimentações do dia selecionado
                    .Union(
                        movimentacoes
                            .Where(m => m.Data < DataBusca) // Movimentações anteriores
                            .GroupBy(m => m.IDSistema) // Agrupando por IDSistema
                            .Select(g => g.OrderByDescending(m => m.Data).First()) // Última movimentação anterior
                    )
                    .GroupBy(m => m.IDSistema) // Agrupando novamente para garantir unicidade
                    .Select(g => g.OrderByDescending(m => m.Data).First()) // Movimentação mais recente
                    .ToList(); // Execute a consulta aqui para trazer os dados
                
                var produtos = _context.produtos.ToList();
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Movimentacoes");
                    
                    worksheet.Cell(1,1).Value = "Id Sistema";
                    worksheet.Cell(1, 2).Value = "Descrição";
                    worksheet.Cell(1,3).Value = "Data Do ultimo estoque";
                    worksheet.Cell(1,4).Value = "Quantidade";

                    for (int i = 0; i < estoqueDoDia.Count; i++)
                    {
                        var movimentacao = estoqueDoDia[i];
                        var produto = produtos.Find(m => m.IDSistema == movimentacao.IDSistema);
                        worksheet.Cell(i + 2, 1).Value = movimentacao.IDSistema;
                        worksheet.Cell(i + 2, 2).Value = produto.Descricao;
                        worksheet.Cell(i + 2,3).Value = movimentacao.Data.ToString("dd/MM/yyyy");
                        worksheet.Cell(i + 2, 4).Value = movimentacao.Quantidade;
                    }

                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads","movimentacoes.xlsx");
                    
                    workbook.SaveAs(filePath);

                    DialogResult msg =  MessageBox.Show($"Planilha de estoque gerada com sucesso em: {filePath} \n Deseja abrir o arquivo?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (msg == DialogResult.Yes)
                    {
                        using (var process = new Process())
                        {
                            process.StartInfo.FileName = filePath;
                            process.StartInfo.UseShellExecute = true;
                            process.Start();
                        }
                    }
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro: {exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
