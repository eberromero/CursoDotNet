using Microsoft.Data.SqlClient;
using ERSistemas.Domain.Models;

namespace ERSistemas.Infrastructure.Database;

public class CadastroAdmRepository
{
    private readonly ConexaoBanco _conexaoBanco;
    private readonly PessoaRepository _pessoaRepository;
    private readonly UsuarioRepository _usuarioRepository;

    public CadastroAdmRepository(ConexaoBanco conexaoBanco, PessoaRepository pessoaRepository, UsuarioRepository usuarioRepository)
    {
        _conexaoBanco = conexaoBanco;
        _pessoaRepository = pessoaRepository;
        _usuarioRepository = usuarioRepository;
    }

    public void Inserir(Pessoa pessoa, Usuario usuario)
    {
        using SqlConnection connection = _conexaoBanco.CriarConexao();

        connection.Open();

        using SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            _pessoaRepository.Inserir(pessoa, connection, transaction);
            _usuarioRepository.Inserir(usuario, connection, transaction);
            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
}