using ERSistemas.Application.Services;
using ERSistemas.Domain.Enums;
using ERSistemas.Domain.Models;
using ERSistemas.Infrastructure.Database;
using ERSistemas.Infrastructure.Database.Atualizacoes;

string user = "sa";
string pass = "J300916e&1";

string connectionString = 
    $"Server=localhost;Database=ERSistemas;User Id={user};Password={pass};TrustServerCertificate=True;";

ConexaoBanco conexaoBanco = 
    new ConexaoBanco(connectionString);

Upd001 atualizacao = new Upd001();

MigradorBanco migrador = new MigradorBanco(conexaoBanco);

migrador.Executar(atualizacao);

Console.WriteLine("Atualização Processada.");


ValidadorBanco databaseValidator = new ValidadorBanco(conexaoBanco);

using var connection = conexaoBanco.CriarConexao();

connection.Open();

Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");

bool exists = databaseValidator.DatabaseVersionExists();

Console.WriteLine($"VersaoBanco existe: {exists}");





//string caminhoScript =
//    Path.Combine(
//        AppContext.BaseDirectory,
//        "Database",
//        "Scripts",
//        "001_CriarVersaoBanco.sql");

//MigradorBanco databaseMigrator =
//    new MigradorBanco(databaseConnection);

//databaseMigrator.ExecutarScript(caminhoScript);


//Console.WriteLine("Script executado com sucesso!");

/*
PessoaService pessoaService = new PessoaService();

Pessoa pessoa = pessoaService.Cadastrar(
    "Empresa de Teste", 
    "12.345.678/0001-99", 
    TipoDocumento.CNPJ);

Console.WriteLine("Cadastro de endereços");

Endereco endereco = new Endereco();
endereco.TipoEndereco = TipoEndereco.Comercial;
endereco.Nome = "Trabalho";
endereco.Logradouro = "Rua Vitor Marcelo de Castro";
endereco.Numero = "600";
endereco.Bairro = "Parque Cidade Jardim 2";
endereco.Cidade = "Jundiai";
endereco.CEP = "13203-542";
endereco.Estado = "SP";
pessoa.AdicionarEndereco(endereco);

Contato contato = new Contato();
contato.Nome = "Comercial";
contato.TipoContato = TipoContato.WhatsApp;
contato.Descricao = "(11) 99999-9999";
contato.Observacao = "WhatsApp da empresa";
contato.Principal = true;
pessoa.AdicionarContato(contato);
*/

/* ==== CADASTRAR PESSOA ==== */

/*
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
*/