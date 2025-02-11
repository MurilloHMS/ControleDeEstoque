using ClosedXML.Excel;
using ControleDeEstoqueProauto.Interface;
using System.Diagnostics;


namespace ControleDeEstoqueProauto.Presenter
{
    public class DownloadEstoquePresenter
    {
        private readonly IDownloadEstoqueView _view;
        private readonly IMovimentacoesRepository _movimentacoesRepository;
        private readonly IProdutosRepository _produtosRepository;

        public DownloadEstoquePresenter(IDownloadEstoqueView view, IMovimentacoesRepository movimentacoesRepository, IProdutosRepository produtosRepository)
        {
            _view = view;
            _movimentacoesRepository = movimentacoesRepository;
            _produtosRepository = produtosRepository;
        }

        public async Task ExtrairEstoque()
        {
            try
            {
                var DataBusca = _view.DataSelecionada;
                var movimentacoes = await _movimentacoesRepository.GetAll();

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

                var produtos = await _produtosRepository.GetAll();
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Movimentacoes");

                    worksheet.Cell(1, 1).Value = "Id Sistema";
                    worksheet.Cell(1, 2).Value = "Descrição";
                    worksheet.Cell(1, 3).Value = "Data Do ultimo estoque";
                    worksheet.Cell(1, 4).Value = "Quantidade";

                    for (int i = 0; i < estoqueDoDia.Count; i++)
                    {
                        var movimentacao = estoqueDoDia[i];
                        var produto = produtos.FirstOrDefault(m => m.IDSistema == movimentacao.IDSistema);
                        worksheet.Cell(i + 2, 1).Value = movimentacao.IDSistema;
                        worksheet.Cell(i + 2, 2).Value = produto.Descricao;
                        worksheet.Cell(i + 2, 3).Value = movimentacao.Data.ToString("dd/MM/yyyy");
                        worksheet.Cell(i + 2, 4).Value = movimentacao.Quantidade;
                    }

                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "movimentacoes.xlsx");

                    workbook.SaveAs(filePath);

                    DialogResult msg = MessageBox.Show($"Planilha de estoque gerada com sucesso em: {filePath} \n Deseja abrir o arquivo?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
