using ERSistemas.Console.Enums;

namespace ERSistemas.Console.Models;

internal class Endereco
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TipoEndereco TipoEndereco { get; set; } = new TipoEndereco();
    public string Nome { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty; 
    public string Complemento { get; set;} = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
}
