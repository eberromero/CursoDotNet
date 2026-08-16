using ERSistemas.Domain.Models;
using ERSistemas.Domain.Enums;

namespace ERSistemas.Application.Services;

public class PessoaService
{
    public Pessoa Criar()
    {
        return new Pessoa();
    }

    public Pessoa Cadastrar(
        string nomeRazaoSocial, 
        string documento, 
        TipoDocumento tipoDocumento)
    {
        if (string.IsNullOrWhiteSpace(nomeRazaoSocial)) 
            throw new InvalidOperationException(
                "O nome/razão social da pessoa é obrigatório.");

        if (string.IsNullOrWhiteSpace(documento))
            throw new InvalidOperationException(
                "O documento da pessoa é obrigatório.");

        Pessoa pessoa = new Pessoa();

        pessoa.NomeRazaoSocial = nomeRazaoSocial;
        pessoa.Documento = documento;
        pessoa.TipoDocumento = tipoDocumento;

        return pessoa;
    }
    
}