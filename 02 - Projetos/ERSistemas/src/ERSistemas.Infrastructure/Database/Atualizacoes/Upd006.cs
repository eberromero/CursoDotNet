using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public class Upd006 : IAtualizacaoBanco
{
    public int Versao => 6;
    public string Descricao => "Criação da tabela de usuarios do sistema";
    public bool Validar(SqlConnection connection)
    {
        string sql = """SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario'""";
        using SqlCommand command = new SqlCommand(sql, connection);
        int count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }
    public string ObterScript() => """
        CREATE TABLE Usuario
        (
            Id UNIQUEIDENTIFIER NOT NULL,
            PessoaId UNIQUEIDENTIFIER NOT NULL,
            Login VARCHAR(50) NOT NULL,
            SenhaHash VARCHAR(200) NOT NULL,
            Ativo BIT NOT NULL,
            DataCadastro DATETIME NOT NULL,
            CONSTRAINT PK_Usuario PRIMARY KEY (Id),
            CONSTRAINT FK_Usuario_Pessoa FOREIGN KEY (PessoaId) REFERENCES Pessoa (Id),
            CONSTRAINT UQ_Usuario_Login UNIQUE (Login)
        );
        """;
}
