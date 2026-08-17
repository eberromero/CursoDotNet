using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public class Upd001 : IAtualizacaoBanco
{
    public int Versao => 1;

    public string Descricao =>
        "Criação da tabela VersaoBanco";
    public bool Validar(SqlConnection connection)
    {
        string sql = """
            SELECT COUNT(*)
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_NAME = 'VersaoBanco'
            """;
        
        using SqlCommand command =
            new SqlCommand(sql, connection);

        int count = Convert.ToInt32(command.ExecuteScalar());

        return count > 0;
    }

    public string ObterScript() => """
        CREATE TABLE VersaoBanco
        (
            Id INT IDENTITY(1,1) NOT NULL,
            Versao INT NOT NULL,
            Descricao VARCHAR(200) NOT NULL,
            DataExecucao DATETIME2 NOT NULL,

            CONSTRAINT PK_VersaoBanco
                PRIMARY KEY (Id)
        );
        """;
}
