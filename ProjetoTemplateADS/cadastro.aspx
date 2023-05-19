<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="login-box container pt-5">
        <!-- /.login-logo -->
        <div class="card card-outline card-warning ">
            <div class="card-header text-center">
                <a href="#" class="h1"><b>COLETIVO</b>GO</a>
            </div>
            <div class="card-body">
                <p class="login-box-msg">Entrar com um Cadastro:</p>

                <div class="input-group mb-3">
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Nome"></asp:TextBox>
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-lock"></span>
                        </div>
                    </div>
                </div>

                <div class="input-group mb-3">
                    <asp:TextBox ID="txtDataNascimento" runat="server" CssClass="form-control" placeholder="Data de Nascimento"></asp:TextBox>
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-lock"></span>
                        </div>
                    </div>
                </div>

                <div class="input-group mb-3">
                    <asp:TextBox ID="txtRA" runat="server" CssClass="form-control" placeholder="RA" TextMode="Number"></asp:TextBox>
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-lock"></span>
                        </div>
                    </div>
                </div>

                <div class="input-group mb-3">
                    <asp:TextBox ID="txtDataVestibular" runat="server" CssClass="form-control" placeholder="Data de Vestibular"></asp:TextBox>
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-lock"></span>
                        </div>
                    </div>
                </div>

                <div class="input-group mb-3">
                    <asp:TextBox CssClass="form-control" placeholder="E-mail" ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-envelope"></span>
                        </div>
                    </div>
                </div>
                <div class="input-group mb-3">
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Senha" TextMode="Password"></asp:TextBox>
                    <div class="input-group-append">
                        <div class="input-group-text">
                            <span class="fas fa-lock"></span>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-4">
                    </div>
                    <!-- /.col -->
                    <div class="col-4">
                        <asp:Button OnClick="btn_Cadastrar_Click" ID="btn_Cadastrar" runat="server" CssClass="btn btn-success btn-block" Text=" Cadrastar " />
                    </div>
                    <div class="col-4">
                    </div>
                    <!-- /.col -->
                    <div class="col-12" style="text-align: center;">
                            <asp:Literal ID="msgErro" runat="server"></asp:Literal>
                    </div>    
                        <!-- /.col -->
                </div>
            </div>

        </div>
    </div>

</asp:Content>

