using Microsoft.Data.SqlClient;
using ERSistemas.Domain.Models;

namespace ERSistemas.Infrastructure.Database;

public class PessoaRepository
{
    private readonly ConexaoBanco _conexaoBanco;

    public PessoaRepository(ConexaoBanco conexaoBanco)
    {
        _conexaoBanco = conexaoBanco;
    }

    public void Inserir(Pessoa pessoa, SqlConnection connection, SqlTransaction transaction)
    {
        const string sql = """
            INSERT INTO Pessoa
            (
                Id,
                TipoDocumento,
                Documento,
                NomeRazaoSocial,
                NomeFantasia,
                DataCadastro,
                Ativo
            )
            VALUES
            (
                @Id,
                @TipoDocumento,
                @Documento,
                @NomeRazaoSocial,
                @NomeFantasia,
                @DataCadastro,
                @Ativo
            )
            """;

        using SqlCommand command = new SqlCommand(sql, connection, transaction);

        command.Parameters.AddWithValue("@Id", pessoa.Id);
        command.Parameters.AddWithValue("@TipoDocumento", (int)pessoa.TipoDocumento);
        command.Parameters.AddWithValue("@Documento", pessoa.Documento);
        command.Parameters.AddWithValue("@NomeRazaoSocial", pessoa.NomeRazaoSocial);
        command.Parameters.AddWithValue("@NomeFantasia", string.IsNullOrWhiteSpace(pessoa.NomeFantasia)? DBNull.Value: pessoa.NomeFantasia);
        command.Parameters.AddWithValue("@DataCadastro", pessoa.DataCadastro);
        command.Parameters.AddWithValue("@Ativo", pessoa.Ativo);

        command.ExecuteNonQuery();
    }
}