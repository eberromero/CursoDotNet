using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database;

public class ValidadorBanco
{
    private readonly ConexaoBanco _databaseConnection;
    public ValidadorBanco(ConexaoBanco databaseConnection)
    {  
        _databaseConnection = databaseConnection; 
    }

    public bool DatabaseVersionExists()
    {
        using SqlConnection connection = _databaseConnection.CriarConexao();

        connection.Open();

        string sql = @"
            SELECT COUNT(*)
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_NAME = 'VersaoBanco'";

        using SqlCommand command = new SqlCommand(sql, connection);

        int count = (int)command.ExecuteScalar();

        return count > 0;   
    }
}
