using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public class Upd003 : IAtualizacaoBanco
{
    public int Versao => 3;

    public string Descricao =>
        "Adição do campo Observacao na tabela Pessoa";

    public bool Validar(SqlConnection connection)
    {
        string sql = """SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Pessoa' AND COLUMN_NAME = 'Observacao'""";
        using SqlCommand command = new SqlCommand(sql, connection);
        int count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }

    public string ObterScript() => """ALTER TABLE Pessoa ADD Observacao VARCHAR(500) NULL;""";
}