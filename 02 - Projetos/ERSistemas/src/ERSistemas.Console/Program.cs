using ERSistemas.Domain.Models;
using ERSistemas.Domain.Enums;

Pessoa pessoa = new Pessoa();

Console.WriteLine("Cadastro de endereços");

Endereco endereco = new Endereco();
endereco.TipoEndereco = TipoEndereco.Comercial;
endereco.Nome = "Trabalho";
endereco.Logradouro = "Rua Vitor Marcelo de Castro";
endereco.Numero = "600";
endereco.Cidade = "Jundiai";
endereco.CEP = "13203-542";
endereco.Estado = "SP";
pessoa.Enderecos.Add(endereco);

Contato contato = new Contato();
contato.Nome = "Comercial";
contato.TipoContato = TipoContato.WhatsApp;
contato.Descricao = "(11) 99999-9999";
contato.Observacao = "WhatsApp da empresa";
contato.Principal = true;
pessoa.Contatos.Add(contato);

pessoa.NomeRazaoSocial = "Empresa de Teste";
pessoa.Documento = "12.345.678/0001-99";
pessoa.TipoDocumento = TipoDocumento.CNPJ;


Console.WriteLine();
Console.WriteLine("===== DADOS DA PESSOA =====");

Console.WriteLine("Nome/Razão Social: " + pessoa.NomeRazaoSocial);
Console.WriteLine("Documento: " + pessoa.Documento);
Console.WriteLine("Tipo: " + pessoa.TipoDocumento);

Console.WriteLine("==== ENDEREÇOS ====");

foreach (Endereco item in pessoa.Enderecos) 
{ 
    Console.WriteLine("Tipo: " + item.TipoEndereco);
    Console.WriteLine("Nome: " + item.Nome);
    Console.WriteLine("CEP: " + item.CEP);
    Console.WriteLine("Logradouro: " + item.Logradouro);
    Console.WriteLine("Número: " + item.Numero);
    Console.WriteLine("Bairro: " + item.Bairro);
    Console.WriteLine("Cidade: " + item.Cidade);
    Console.WriteLine("Estado: " + item.Estado);
}

Console.WriteLine("==== CONTATOS ====");
foreach (Contato item in pessoa.Contatos)
{
    Console.WriteLine("Nome: " + item.Nome);
    Console.WriteLine("Tipo: " + item.TipoContato);
    Console.WriteLine("Descrição: " + item.Descricao);
    Console.WriteLine("Observação: " + item.Observacao);
    Console.WriteLine("Principal: " + item.Principal);
}