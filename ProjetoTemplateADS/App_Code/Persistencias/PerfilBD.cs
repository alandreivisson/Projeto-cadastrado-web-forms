using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Perfil
/// </summary>
public class PerfilBD
{
    public static Perfil Buscar_Perfil(int id)
    {
        IDbConnection Conexao = MapeamentoBD.Conexao();
        string sql = "CALL BUSCAR_PERFIL(" + id + ");";
        IDbCommand Comando = MapeamentoBD.ComandoSQL(sql, Conexao);

        var reader = Comando.ExecuteReader();
        Perfil perfil = null;

        while (reader.Read())
        {
            perfil = new Perfil();
            perfil.Ra = Convert.ToInt32(reader["ALU_RA"]);
            perfil.Email = reader["USU_EMAIL"].ToString();
            perfil.Nome = reader["PES_NOME"].ToString();
        }

        return perfil;
    }
}