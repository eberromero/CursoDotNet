using ERSistemas.Domain.Enums;

namespace ERSistemas.Domain.Models;

public class Pessoa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TipoDocumento TipoDocumento { get; set; }
    public string Documento { get; set; } = string.Empty;
    public string NomeRazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public bool Ativo { get; set; } = true;

    private readonly List<Endereco> _enderecos = new();
    private readonly List<Contato> _contatos = new();

    public IReadOnlyList<Endereco> Enderecos => _enderecos;
    public IReadOnlyList<Contato> Contatos => _contatos;

    public void AdicionarEndereco(Endereco endereco)
    {
        if (endereco == null)
            throw new ArgumentNullException(nameof(endereco));

        if (_enderecos.Contains(endereco))
            throw new InvalidOperationException("Este endereço ja foi adicionado à pessoa.");
        
        
        _enderecos.Add(endereco);
    }
    public void AdicionarContato(Contato contato)
    {
        if (contato == null)
            throw new ArgumentNullException(nameof(contato));

        _contatos.Add(contato);
    }
}