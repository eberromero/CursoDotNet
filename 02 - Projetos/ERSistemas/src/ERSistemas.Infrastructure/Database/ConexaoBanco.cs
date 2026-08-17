using Microsoft.Data.SqlClient;
using ERSistemas.Infrastructure.Database;

namespace ERSistemas.Infrastructure.Database;

public class ConexaoBanco
{
    private readonly string _connectionString;
    public ConexaoBanco(string connectionString)
    {
        _connectionString = connectionString;
    }

    public SqlConnection CriarConexao()
    {
        return new SqlConnection(_connectionString);
    }
}
