using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public class Upd002 : IAtualizacaoBanco
{
    public int Versao => 2;
    public string Descricao => "Criação da tabela Pessoa";
    public bool Validar(SqlConnection connection)
    {
        string sql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Pessoa'";
        using SqlCommand command = new SqlCommand(sql, connection);
        int count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }
    public string ObterScript() => """
        CREATE TABLE Pessoa
        (
            Id UNIQUEIDENTIFIER NOT NULL,
            TipoDocumento INT NOT NULL,
            Documento VARCHAR(20) NOT NULL,
            NomeRazaoSocial VARCHAR(200) NOT NULL,
            NomeFantasia VARCHAR(200) NULL,
            DataCadastro DATETIME2 NOT NULL,
            Ativo BIT NOT NULL,

            CONSTRAINT PK_Pessoa PRIMARY KEY (Id)
        );
        """;
}
