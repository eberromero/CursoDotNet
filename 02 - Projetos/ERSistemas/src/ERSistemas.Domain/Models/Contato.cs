using ERSistemas.Domain.Enums;

namespace ERSistemas.Domain.Models;

public class Contato
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public TipoContato TipoContato { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Observacao { get; set; } = string.Empty;
    public bool Principal { get; set; }
}
