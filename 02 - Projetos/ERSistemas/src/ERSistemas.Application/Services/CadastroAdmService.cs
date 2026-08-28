using ERSistemas.Domain.Enums;
using ERSistemas.Domain.Models;
using ERSistemas.Infrastructure.Database;

namespace ERSistemas.Application.Services;

public class CadastroAdmService
{
    private readonly CadastroAdmRepository _cadastroAdmRepository;
    private readonly PasswordHasher _passwordHasher;

    public CadastroAdmService(CadastroAdmRepository cadastroAdmRepository, PasswordHasher passwordHasher)
    {
        _cadastroAdmRepository = cadastroAdmRepository;
        _passwordHasher = passwordHasher;
    }

    public void CriarAdministrador(string nome, string login, string senha)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome do administrador é obrigatório.");

        if (string.IsNullOrWhiteSpace(login))
            throw new ArgumentException("O login é obrigatório.");

        if (string.IsNullOrWhiteSpace(senha))
            throw new ArgumentException("A senha é obrigatória.");

        Pessoa pessoa = new Pessoa
        {
            TipoDocumento = TipoDocumento.CPF,
            NomeRazaoSocial = nome,
            Ativo = true
        };

        Usuario usuario = new Usuario
        {
            PessoaId = pessoa.Id,
            Login = login.Trim(),
            SenhaHash = _passwordHasher.Hash(senha),
            Ativo = true
        };

        _cadastroAdmRepository.Inserir(pessoa, usuario);
    }
}