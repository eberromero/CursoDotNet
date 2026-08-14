using ERSistemas.Domain.Enums;

namespace ERSistemas.Domain.Models;

public class Endereco
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TipoEndereco TipoEndereco { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty; 
    public string Complemento { get; set;} = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
}
