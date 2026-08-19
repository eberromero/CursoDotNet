using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public class Upd005 : IAtualizacaoBanco
{
    public int Versao => 5;
    public string Descricao => "Criação da tabela Contato";
    public bool Validar(SqlConnection connection)
    {
        string sql = """SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contato'""";
        using SqlCommand command = new SqlCommand(sql, connection);
        int count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }
    public string ObterScript() => """
        CREATE TABLE Contato
        (
            Id UNIQUEIDENTIFIER NOT NULL,
            PessoaId UNIQUEIDENTIFIER NOT NULL,
            Nome VARCHAR(100) NOT NULL,
            TipoContato INT NOT NULL,
            Descricao VARCHAR(200) NOT NULL,
            Observacao VARCHAR(500) NULL,
            Principal BIT NOT NULL,

            CONSTRAINT PK_Contato PRIMARY KEY (Id),
            CONSTRAINT FK_Contato_Pessoa FOREIGN KEY (PessoaId) REFERENCES Pessoa (Id)
        );
        """;
}
