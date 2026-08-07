using Aula01.Console;
using System.Runtime.CompilerServices;

Pessoa pessoa = new Pessoa();

Console.WriteLine("**** Dados cadastrais ****");
Console.WriteLine("___________________________________");
Console.WriteLine("Qual é seu nome?:");
pessoa.Nome = Console.ReadLine();

Console.WriteLine("Qual curso quer aprender?:");
pessoa.Curso = Console.ReadLine();

Console.WriteLine("Tem algum conhecimento na área?:");
if (Console.ReadLine().ToLower() == "sim")
{
    Console.WriteLine("Qual conhecimento você tem?:");
    pessoa.Origem = Console.ReadLine();
}
else
{
    pessoa.Origem = "Não tenho conhecimento na área.";
}
Console.WriteLine("Qual é sua data de nascimento (dd/mm/aaaa):");
pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

/*IMPRESSÃO DOS DADOS CADASTRAIS*/
Console.WriteLine("___________________________________");
Console.WriteLine("Nome: " + pessoa.Nome + ".");
Console.WriteLine("Quero estudar: " + pessoa.Curso);
Console.WriteLine("Experiência: " + pessoa.Origem);
Console.WriteLine("Idade: " + (DateTime.Now.Year - pessoa.DataNascimento.Year) + " anos.");
Console.WriteLine("___________________________________");
