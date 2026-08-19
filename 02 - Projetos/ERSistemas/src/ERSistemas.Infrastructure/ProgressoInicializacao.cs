namespace ERSistemas.Infrastructure;

public class ProgressoInicializacao
{
    public int Percentual { get; }
    public string Mensagem { get; }

    public ProgressoInicializacao(int percentual, string mensagem)
    {
        Percentual = percentual;
        Mensagem = mensagem;
    }
}
