using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pessoa
/// </summary>
public class Pessoa
{
    private string _nome;
    private string _data_nascimento;

    public string Nome { get => _nome; set => _nome = value; }
    public string Data_nascimento { get => _data_nascimento; set => _data_nascimento = value; }
}