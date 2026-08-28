using ERSistemas.Infrastructure;
using ERSistemas.Infrastructure.Database;

namespace ERSistemas.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string server = "localhost";
            string database = "ERSistemas";
            string user = "sa";
            string pass = "J300916e&1";

            string connectionString =
                $"Server={server};" +
                $"Database={database};" +
                $"User Id={user};" +
                $"Password={pass};" +
                $"TrustServerCertificate=True;";

            ConexaoBanco conexaoBanco = new ConexaoBanco(connectionString);

            MigradorBanco migradorBanco = new MigradorBanco(conexaoBanco);

            InicializadorBanco inicializadorBanco = new InicializadorBanco(migradorBanco);

            InicializadorSistema inicializadorSistema = new InicializadorSistema(inicializadorBanco);

            FrmSplash splash = new FrmSplash(inicializadorSistema);
            splash.ShowDialog();
            if (splash.InicializacaoConcluida)
            {
                System.Windows.Forms.Application.Run(new frmPessoa());
            }
        }
    }
}