using Microsoft.Data.SqlClient;
using ERSistemas.Infrastructure.Database.Atualizacoes;

namespace ERSistemas.Infrastructure.Database;

public class MigradorBanco
{
    private readonly ConexaoBanco _conexaoBanco;
    public MigradorBanco(ConexaoBanco conexaoBanco)
    {
        _conexaoBanco = conexaoBanco;
    }
    public void Executar(IAtualizacaoBanco atualizacao)
    {
        using SqlConnection connection = _conexaoBanco.CriarConexao();
        
        connection.Open();
        
        if (atualizacao.Validar(connection))
        {
            return;
        }

        using SqlTransaction transaction =
            connection.BeginTransaction();
        try
        {
            string script = atualizacao.ObterScript();

            using SqlCommand command = new SqlCommand(script, connection, transaction);

            command.ExecuteNonQuery();

            RegistrarVersao(connection, atualizacao);

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
        
    }

    private void RegistrarVersao(
        SqlConnection connection,
        IAtualizacaoBanco atualizacao)
    {
        string sql = """
            INSERT INTO VersaoBanco
            (
                Versao,
                Descricao,
                DataExecucao
            ) VALUES 
            (
                @Versao,
                @Descricao,
                GETDATE()
            );
            """;

        using SqlCommand command = 
            new SqlCommand( sql, connection );

        command.Parameters.AddWithValue(
            "@Versao",
            atualizacao.Versao);
        command.Parameters.AddWithValue(
            "@Descricao",
            atualizacao.Descricao);

        command.ExecuteNonQuery ();
    }
}
