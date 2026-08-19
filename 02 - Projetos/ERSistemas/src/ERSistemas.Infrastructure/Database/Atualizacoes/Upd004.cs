using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public class Upd004 : IAtualizacaoBanco
{
    public int Versao => 4;
    public string Descricao => "Criação da tabela Endereco";

    public bool Validar(SqlConnection connection)
    {
        string sql = """SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Endereco'""";
        using SqlCommand command = new SqlCommand(sql, connection);
        int count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }

    public string ObterScript() => """
        CREATE TABLE Endereco (
             Id UNIQUEIDENTIFIER NOT NULL,
             PessoaId UNIQUEIDENTIFIER NOT NULL,
             TipoEndereco INT NOT NULL,
             Nome VARCHAR(100) NOT NULL,
             CEP VARCHAR(10) NOT NULL,
             Logradouro VARCHAR(200) NOT NULL,
             Numero VARCHAR(20) NOT NULL,
             Complemento VARCHAR(100) NULL,
             Bairro VARCHAR(100) NOT NULL,
             Cidade VARCHAR(100) NOT NULL,
             Estado VARCHAR(2) NOT NULL,

             CONSTRAINT PK_Endereco PRIMARY KEY (Id),
             CONSTRAINT FK_Endereco_Pessoa FOREIGN KEY (PessoaId) REFERENCES Pessoa(Id)
        );
        """;
}
