using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Activities;
using System.Web;

/// <summary>
/// Descrição resumida de PessoasBD
/// </summary>
public static class AlunosBD
{
 
    public static DataSet SelecionarTodosAlunos()
    {
        DataSet ds = new DataSet();
        IDbConnection Conexao = MapeamentoBD.Conexao();
        IDbCommand Comando;
        IDataAdapter Adapter;
        string sql = "CALL BUSCAR_ALUNOS();";
        Comando = MapeamentoBD.ComandoSQL(sql, Conexao);
        Adapter = MapeamentoBD.Adapter(Comando);
        Adapter.Fill(ds);
        return ds;
    }

    public static void ExcluirAluno(int ra) 
    {
        IDbConnection Conexao = MapeamentoBD.Conexao();
        string sql = "CALL EXCLUIR(" + ra + ");";
        IDbCommand Comando = MapeamentoBD.ComandoSQL(sql, Conexao);
        Comando.CommandTimeout = 200;
        Comando.ExecuteNonQuery();
    }
}