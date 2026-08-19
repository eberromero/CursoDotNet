using Microsoft.Data.SqlClient;
using ERSistemas.Infrastructure.Database.Atualizacoes;
using System.Reflection;

namespace ERSistemas.Infrastructure.Database;

public class MigradorBanco
{
    private readonly ConexaoBanco _conexaoBanco;
    public MigradorBanco(ConexaoBanco conexaoBanco)
    {
        _conexaoBanco = conexaoBanco;
    }

    public void Executar()
    {
        using SqlConnection connection = _conexaoBanco.CriarConexao();
        
        connection.Open();

        int versaoAtual = ObterVersaoAtual(connection);

        List<IAtualizacaoBanco> atualizacoes = ObterAtualizacoes();

        ValidarAtualizacoes(atualizacoes);

        foreach (IAtualizacaoBanco atualizacao in atualizacoes)
        {
            ExecutarAtualizacao(connection, atualizacao, versaoAtual);

            if (atualizacao.Versao > versaoAtual)
            {
                versaoAtual = atualizacao.Versao;
            }
        }
    }

    private List<IAtualizacaoBanco> ObterAtualizacoes()
    {
        Assembly assembly = typeof(IAtualizacaoBanco).Assembly;

        return assembly.GetTypes()
            .Where(tipo =>
                typeof(IAtualizacaoBanco).IsAssignableFrom(tipo) &&
                !tipo.IsInterface &&
                !tipo.IsAbstract)
            .Select(tipo => (IAtualizacaoBanco)Activator.CreateInstance(tipo)!)
            .OrderBy(atualizacao => atualizacao.Versao)
            .ToList();
    }
    private void ExecutarAtualizacao(SqlConnection connection, IAtualizacaoBanco atualizacao, int versaoAtual)
    {
        bool valido = atualizacao.Validar(connection);

        if (valido)
        {
            return;
        }
                
        using SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            string script = atualizacao.ObterScript();
            using SqlCommand command = new SqlCommand(script, connection, transaction);
            command.ExecuteNonQuery();
            
            if (atualizacao.Versao > versaoAtual)
            {
                RegistrarVersao(connection, transaction, atualizacao);
            }
            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    private void RegistrarVersao(SqlConnection connection, SqlTransaction transaction, IAtualizacaoBanco atualizacao)
    {
        string sql = """INSERT INTO VersaoBanco(Versao, Descricao, DataExecucao) VALUES (@Versao, @Descricao, GETDATE());""";

        using SqlCommand command = new SqlCommand(sql, connection, transaction);

        command.Parameters.AddWithValue("@Versao", atualizacao.Versao);
        command.Parameters.AddWithValue("@Descricao", atualizacao.Descricao);

        command.ExecuteNonQuery ();
    }

    private int ObterVersaoAtual(SqlConnection connection)
    {
        string sql = """SELECT ISNULL(MAX(Versao), 0) FROM VersaoBanco""";
        using SqlCommand command = new SqlCommand(sql, connection);
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public void ValidarAtualizacoes(List<IAtualizacaoBanco> atualizacoes)
    {
        HashSet<int> versoes = new HashSet<int>();

        foreach (IAtualizacaoBanco atualizacao in atualizacoes)
        {
            if (!versoes.Add(atualizacao.Versao))
            {
                throw new Exception($"A versão {atualizacao.Versao} está duplicada.");
            }
        }
        for (int i = 0; i < atualizacoes.Count; i++)
        {
            int versaoEsperada = i + 1;
            if (atualizacoes[i].Versao != versaoEsperada)
            {
                throw new Exception($"Atualização de versão {versaoEsperada} não encontrada.");
            }
        }
    }
}
