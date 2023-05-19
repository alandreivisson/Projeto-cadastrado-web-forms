using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarAlunosComGrid();
        var loginlk = (LinkButton)this.Master.FindControl("login");
        var homelk = (LinkButton)this.Master.FindControl("home");
        var cadastrarlk = (LinkButton)this.Master.FindControl("Cadastrar");
        var voltarlk = (LinkButton)this.Master.FindControl("Voltar");
        var sairlk = (LinkButton)this.Master.FindControl("Sair");
        loginlk.Visible = false;
        homelk.Visible = false;
        voltarlk.Visible = false;
        cadastrarlk.Visible = true;
        sairlk.Visible = true;

        Usuario user = (Usuario)Session["USUARIO"];
        string id_str = user.Id.ToString();
        int id = Convert.ToInt32(id_str);
        Perfil perfil = PerfilBD.Buscar_Perfil(id);

        txtNomePerfil.Text = perfil.Nome;
        txtRa.Text = Convert.ToString(perfil.Ra);
        txtEmail.Text = perfil.Email;

        int linhas = gdvAlunos.Rows.Count;
        if (linhas == 0)
        {
            vazio.Visible = true;
        }
        else {
            for (int i=0; i<linhas; i++)
            { 
                string chavePrimaria = gdvAlunos.Rows[i].Cells[1].Text;
                int chave = Convert.ToInt32(chavePrimaria);
                

                if (chave ==  perfil.Ra) 
                {
                    gdvAlunos.Rows[i].Cells[4].Enabled = false;
                }
            }
        }
    }

    void CarregarAlunosComGrid()
    {
        DataSet dsAlunos = AlunosBD.SelecionarTodosAlunos();
        Funcoes.CarregarGridViewComDataSet(dsAlunos, gdvAlunos);
    }

    protected void gdvAlunos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "excluir") 
        {
            int index = int.Parse((string)e.CommandArgument);
            string chaveExcluir = gdvAlunos.Rows[index].Cells[1].Text;
            AlunosBD.ExcluirAluno(Convert.ToInt32(chaveExcluir));
        }
        Response.Redirect("principal.aspx");
    }
}