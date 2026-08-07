using ERSistemas.Console.Models;

namespace ERSistemas.Console;

internal class Pessoa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TipoDocumento TipoDocumento { get; set; }
    public string Documento { get; set; } = string.Empty;
    public string NomeRazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public bool Ativo { get; set; } = true;

    public List<Endereco> Enderecos { get; set; } = new();
    public List<Contato> Contatos { get; set; } = new();
}
