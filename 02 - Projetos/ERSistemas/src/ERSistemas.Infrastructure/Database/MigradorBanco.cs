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
        if (atualizacao.Versao <= versaoAtual)
        {
            return;
        }

        if (atualizacao.Validar(connection))
        {
            return;
        }
        
        using SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            string script = atualizacao.ObterScript();
            using SqlCommand command = new SqlCommand(script, connection, transaction);
            command.ExecuteNonQuery();
            RegistrarVersao(connection, transaction, atualizacao);
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
}
