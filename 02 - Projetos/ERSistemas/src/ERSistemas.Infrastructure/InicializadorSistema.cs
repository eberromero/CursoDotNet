namespace ERSistemas.Infrastructure;

public class InicializadorSistema
{
    private readonly Database.InicializadorBanco _inicializadorBanco;
    public InicializadorSistema(Database.InicializadorBanco inicializadorBanco)
    {
        _inicializadorBanco = inicializadorBanco;
    }
    public void Inicializar(IProgress<ProgressoInicializacao>? progresso = null)
    {
        progresso?.Report(new ProgressoInicializacao(10, "Inicializando o sistema..."));
        progresso?.Report(new ProgressoInicializacao(30, "Conectando ao banco de dados..."));

        _inicializadorBanco.Inicializar();

        progresso?.Report(new ProgressoInicializacao(30, "Finalizando inicialização..."));
        progresso?.Report(new ProgressoInicializacao(100, "Sistema pronto!..."));
    }
}
