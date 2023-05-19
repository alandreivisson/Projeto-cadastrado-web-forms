using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var loginlk = (LinkButton)this.Master.FindControl("login");
        var homelk = (LinkButton)this.Master.FindControl("home");
        var cadastrarlk = (LinkButton)this.Master.FindControl("Cadastrar");
        var voltarlk = (LinkButton)this.Master.FindControl("Voltar");
        var sairlk = (LinkButton)this.Master.FindControl("Sair");
        loginlk.Visible = false;
        homelk.Visible = true;
        voltarlk.Visible = false;
        cadastrarlk.Visible = false;
        sairlk.Visible = false;
    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        
        if (string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtSenha.Text)) {
            msgErro.Text = "Usuário e Senha não podem ser nulos!";
            msgErro.Visible = true;
        }else if (string.IsNullOrEmpty(txtSenha.Text))
        {
            msgErro.Text = "Senha não pode ser nula!";
            msgErro.Visible = true;
        }
        else if (string.IsNullOrEmpty(txtEmail.Text))
        {
            msgErro.Text = "Usuário não pode ser nulo!";
            msgErro.Visible = true;
        }
        else
        {
            string senha = Funcoes.BaseCodifica(txtSenha.Text);
            string query = "CALL PROCURAR_USUARIO('" + senha + "','" + txtEmail.Text + "');";
            IDbConnection con = MapeamentoBD.Conexao();
            IDbCommand cmd = MapeamentoBD.ComandoSQL(query, con);
            

            var reader = cmd.ExecuteReader();
            Usuario usuario = null;
            Aluno aluno = null;
            Pessoa pessoa = null;

            while (reader.Read())
            {
                usuario = new Usuario();
                aluno = new Aluno();
                pessoa = new Pessoa();
                usuario.Id = Convert.ToInt32(reader["USU_ID"]);
                usuario.Senha = reader["USU_SENHA"].ToString();
                usuario.Email = reader["USU_EMAIL"].ToString();
                aluno.Ra = reader["ALU_RA"].ToString();
                aluno.Data_Vestibular = reader["ALU_DATA_VESTIBULAR"].ToString();
                pessoa.Nome = reader["PES_NOME"].ToString();
                pessoa.Data_nascimento = reader["PES_DATA_NASCIMENTO"].ToString();
            }

            if (usuario != null)
            {
                Session["USUARIO"] = usuario;
                con.Close();
                Response.Redirect("principal.aspx?par=" + Funcoes.BaseCodifica(txtSenha.Text));
            }
            else
            {
                
                msgErro.Text = "Usuária ou senha incorretos";
                msgErro.Visible=true;
                txtEmail.Text = null;
                txtSenha.Text = null;
            }
        }
    }
}