using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void login_Click(object sender, EventArgs e)
    {
        Session["USUARIO"] = null;
        Response.Redirect("login.aspx");
    }

    protected void home_Click(object sender, EventArgs e)
    {
        Session["USUARIO"] = null;
        Response.Redirect("home.aspx");
    }

    protected void Cadastrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("cadastro.aspx");
    }

    protected void Voltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("principal.aspx");
    }

    protected void Sair_Click(object sender, EventArgs e)
    {
        Session["USUARIO"] = null;
        Response.Redirect("home.aspx");
    }
}
