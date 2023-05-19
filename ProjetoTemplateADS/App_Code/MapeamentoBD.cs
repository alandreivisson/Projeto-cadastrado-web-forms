using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Descrição resumida de MapeamentoBD
/// </summary>
public class MapeamentoBD
{
    // 1 metodo: conexão com o bd;
    public static IDbConnection Conexao()
    {
        MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["stringConexaoBD"]);
        objConexao.Open();
        return objConexao;
    }

    // 2 metodo: executar comando sql;
    public static IDbCommand ComandoSQL(string sql, IDbConnection Conexao)
    {
        IDbCommand Comando = Conexao.CreateCommand();
        Comando.CommandText = sql;
        return Comando;
    }

    // 3 metodo: container de dados;
    public static IDataAdapter Adapter(IDbCommand Comando)
    {
        IDbDataAdapter Adapter = new MySqlDataAdapter();
        Adapter.SelectCommand = Comando;
        return Adapter;
    }

    // 4 metodo: parametrização;
    // C# Data: SQL Injection / XCS => Cross Script
    public static IDbDataParameter ValidarParametros(string nomeParametro, object Valor)
    {
        return new MySqlParameter(nomeParametro, Valor);
    }

}