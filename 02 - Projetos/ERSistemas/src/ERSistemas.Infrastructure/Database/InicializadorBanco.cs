namespace ERSistemas.Infrastructure.Database;

public class InicializadorBanco
{
    private readonly MigradorBanco _migradorBanco;

    public InicializadorBanco(MigradorBanco migradorBanco)
    {
        _migradorBanco = migradorBanco;
    }
    public void Inicializar(IProgress<ProgressoInicializacao>? progresso = null)
    {
        progresso?.Report(new ProgressoInicializacao(40, "Verificando banco de dados..."));
        _migradorBanco.Executar();
        progresso?.Report(new ProgressoInicializacao(50, "Verificando banco de dados..."));
    }
}
