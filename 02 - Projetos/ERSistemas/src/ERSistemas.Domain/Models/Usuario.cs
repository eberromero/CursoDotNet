namespace ERSistemas.Domain.Models;

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid PessoaId { get; set; }

    public string Login { get; set; } = string.Empty;

    public string SenhaHash { get; set; } = string.Empty;

    public bool Ativo { get; set; } = true;

    public DateTime DataCadastro { get; set; } = DateTime.Now;
}