using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var loginlk = (LinkButton)this.Master.FindControl("login");
        var homelk = (LinkButton)this.Master.FindControl("home");
        var cadastrarlk = (LinkButton)this.Master.FindControl("Cadastrar");
        var voltarlk = (LinkButton)this.Master.FindControl("Voltar");
        var sairlk = (LinkButton)this.Master.FindControl("Sair");
        loginlk.Visible = true;
        homelk.Visible = false;
        voltarlk.Visible = false;
        cadastrarlk.Visible = false;
        sairlk.Visible = false;
    }
}