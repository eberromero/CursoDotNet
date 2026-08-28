using ERSistemas.Domain.Models;
using ERSistemas.Infrastructure.Database;

namespace ERSistemas.Application.Services;

public class AutenticacaoService
{
    private readonly UsuarioRepository _usuarioRepository;
    private readonly PasswordHasher _passwordHasher;

    public AutenticacaoService(UsuarioRepository usuarioRepository, PasswordHasher passwordHasher)
    {
        _usuarioRepository = usuarioRepository;
        _passwordHasher = passwordHasher;
    }

    public Usuario? Autenticar(string login, string senha)
    {
        if (string.IsNullOrWhiteSpace(login))
            return null;

        if (string.IsNullOrWhiteSpace(senha))
            return null;

        Usuario? usuario = _usuarioRepository.ObterPorLogin(login);

        if (usuario == null)
            return null;

        if (!usuario.Ativo)
            return null;

        bool senhaValida = _passwordHasher.Verify(senha, usuario.SenhaHash);

        if (!senhaValida)
            return null;

        return usuario;
    }
}