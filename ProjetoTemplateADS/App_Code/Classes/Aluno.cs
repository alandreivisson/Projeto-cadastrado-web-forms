using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Aluno
/// </summary>
public class Aluno
{
    private string _ra;
    private string _data_vestibular;

    public string Ra { get => _ra; set => _ra = value; }
    public string Data_Vestibular { get => _data_vestibular; set => _data_vestibular = value; }
}