using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Perfil
/// </summary>
public class Perfil
{
    private int _ra;
    private string _nome;
    private string _email;
    

    public int Ra { get => _ra; set => _ra = value; }
    public string Nome { get => _nome; set => _nome = value; }
    public string Email { get => _email; set => _email = value; }

}