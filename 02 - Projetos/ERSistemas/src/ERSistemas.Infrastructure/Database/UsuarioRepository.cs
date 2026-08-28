using Microsoft.Data.SqlClient;
using ERSistemas.Domain.Models;

namespace ERSistemas.Infrastructure.Database;

public class UsuarioRepository
{
    private readonly ConexaoBanco _conexaoBanco;

    public UsuarioRepository(ConexaoBanco conexaoBanco)
    {
        _conexaoBanco = conexaoBanco;
    }

    public Usuario? ObterPorLogin(string login)
    {
        const string sql = """
            SELECT
                Id,
                PessoaId,
                Login,
                SenhaHash,
                DataCadastro,
                Ativo
            FROM Usuario
            WHERE Login = @Login
            """;

        using SqlConnection connection = _conexaoBanco.CriarConexao();

        using SqlCommand command =
            new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Login", login);

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        if (!reader.Read())
            return null;

        return new Usuario
        {
            Id = reader.GetGuid(reader.GetOrdinal("Id")),
            PessoaId = reader.GetGuid(reader.GetOrdinal("PessoaId")),
            Login = reader.GetString(reader.GetOrdinal("Login")),
            SenhaHash = reader.GetString(reader.GetOrdinal("SenhaHash")),
            DataCadastro = reader.GetDateTime(
                reader.GetOrdinal("DataCadastro")),
            Ativo = reader.GetBoolean(reader.GetOrdinal("Ativo"))
        };
    }
    public bool ExisteUsuario()
    {
        const string sql = """SELECT COUNT(*) FROM Usuario""";

        using SqlConnection connection = _conexaoBanco.CriarConexao();
        using SqlCommand command = new SqlCommand(sql, connection);
        connection.Open();
        int count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }
    public void Inserir(Usuario usuario, SqlConnection connection, SqlTransaction transaction)
    {
        const string sql = """
        INSERT INTO Usuario
        (
            Id,
            PessoaId,
            Login,
            SenhaHash,
            Ativo,
            DataCadastro
        )
        VALUES
        (
            @Id,
            @PessoaId,
            @Login,
            @SenhaHash,
            @Ativo,
            @DataCadastro
        )
        """;

        using SqlCommand command = new SqlCommand(sql, connection, transaction);

        command.Parameters.AddWithValue("@Id", usuario.Id);
        command.Parameters.AddWithValue("@PessoaId", usuario.PessoaId);
        command.Parameters.AddWithValue("@Login", usuario.Login);
        command.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
        command.Parameters.AddWithValue("@Ativo", usuario.Ativo);
        command.Parameters.AddWithValue("@DataCadastro", usuario.DataCadastro);

        command.ExecuteNonQuery();
    }

}