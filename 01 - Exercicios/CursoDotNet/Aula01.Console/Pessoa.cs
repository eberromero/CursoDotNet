using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01.Console;

internal class Pessoa
{
    public string Nome { get; set; } = string.Empty;
    public string Curso { get; set; } = string.Empty;
    public string Origem { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public bool Ativo { get; set; }
    public Endereco Endereco { get; set; } = new Endereco();
}
