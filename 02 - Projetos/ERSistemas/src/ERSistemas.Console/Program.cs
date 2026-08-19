using ERSistemas.Application.Services;
using ERSistemas.Domain.Enums;
using ERSistemas.Domain.Models;
using ERSistemas.Infrastructure.Database;
using ERSistemas.Infrastructure.Database.Atualizacoes;

string server = "localhost";
string database = "ERSistemas"; 
string user = "sa";
string pass = "J300916e&1";

string connectionString = 
    $"Server={server};" +
    $"Database={database};" +
    $"User Id={user};" +
    $"Password={pass};" +
    $"TrustServerCertificate=True;";

ConexaoBanco conexaoBanco = new ConexaoBanco(connectionString);

Upd001 atualizacao = new Upd001();

MigradorBanco migrador = new MigradorBanco(conexaoBanco);

migrador.Executar();

Console.WriteLine("Banco atualizado com sucesso.");