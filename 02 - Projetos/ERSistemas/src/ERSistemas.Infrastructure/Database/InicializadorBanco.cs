namespace ERSistemas.Infrastructure.Database;

public class InicializadorBanco
{
    private readonly MigradorBanco _migradorBanco;

    public InicializadorBanco(MigradorBanco migradorBanco)
    {
        _migradorBanco = migradorBanco;
    }
    public void Inicializar()
    {
        _migradorBanco.Executar();
    }
}
