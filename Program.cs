using ControleDeEstoqueProauto.Data;

namespace ControleDeEstoqueProauto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();

            Iniciar();
        }

        private static bool VerificaBanco()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    return context.Database.CanConnect() && context.produtos.Any();
                }
            }catch
            {
                return false;
            }
        }

        private static void Iniciar()
        {
            if (!VerificaBanco())
            {
                MessageBox.Show("Banco de dados n�o configurado. Abrindo configura��es...", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Run(new Frm_Configuracoes());
            }
            else
            {
                Application.Run(new MainWindow()); 
            }
        }
    }
}