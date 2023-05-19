using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var loginlk = (LinkButton)this.Master.FindControl("login");
        var homelk = (LinkButton)this.Master.FindControl("home");
        var cadastrarlk = (LinkButton)this.Master.FindControl("Cadastrar");
        var voltarlk = (LinkButton)this.Master.FindControl("Voltar");
        var sairlk = (LinkButton)this.Master.FindControl("Sair");
        loginlk.Visible = false;
        homelk.Visible = false;
        voltarlk.Visible = true;
        cadastrarlk.Visible = false;
        sairlk.Visible = true;
        
    }
    protected void btn_Cadastrar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtDataNascimento.Text) || string.IsNullOrEmpty(txtDataVestibular.Text))
        {
            msgErro.Text = "Preencha todos os campos!";
            msgErro.Visible = true;
        }
        else
        {
            Pessoa pessoa = new Pessoa();
            Usuario usuario = new Usuario();
            Aluno aluno = new Aluno();

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                string nome = null;
                pessoa.Nome = nome;
            }
            else
            {
                string nome = Convert.ToString(txtNome.Text);
                pessoa.Nome = nome;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                string email = null;
                usuario.Email = email;
            }
            else
            {
                string email = Convert.ToString(txtEmail.Text);
                usuario.Email = email;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                string senha = null;
                usuario.Senha = senha;
            }
            else
            {
                string senha = Convert.ToString(txtSenha.Text);
                string senhaCriptografada = Funcoes.BaseCodifica(senha);
                usuario.Senha = senhaCriptografada;
            }
            if (string.IsNullOrEmpty(txtRA.Text))
            {
                string ra = null;
                aluno.Ra = ra;
            }
            else
            {
                string ra = Convert.ToString(txtRA.Text);
                aluno.Ra = ra;
            }
            var cultureInfo = new CultureInfo("en-US");
            DateTime valorDataVest = Convert.ToDateTime(txtDataVestibular.Text);
            aluno.Data_Vestibular = valorDataVest.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime valorDataNasc = Convert.ToDateTime(txtDataNascimento.Text);
            pessoa.Data_nascimento = (valorDataNasc).ToString("yyyy-MM-dd HH:mm:ss");
            
            string query = "call inserir_valores('" + pessoa.Nome + "','"+pessoa.Data_nascimento+"','" + usuario.Email + "','" + usuario.Senha + "','" + aluno.Ra + "','"+aluno.Data_Vestibular+"');";
            IDbConnection con = MapeamentoBD.Conexao();
            IDbCommand cmd = MapeamentoBD.ComandoSQL(query, con);
            cmd.CommandTimeout = 200;
                
            var process = cmd.ExecuteScalar();
            int result = Convert.ToInt32(process);

            if (result < 0)
            {
                msgErro.Text = "Preencha todos os campos!";
                msgErro.Visible = true;

            }
            else
            {
                msgErro.Text = "Usuário adicionado com sucesso!";

                txtEmail.Text = null;
                txtDataNascimento.Text = null;
                txtDataVestibular.Text = null;
                txtNome.Text = null;
                txtRA.Text = null;
                txtSenha.Text  = null;

                msgErro.Visible = true;
            }
        }
    }
}