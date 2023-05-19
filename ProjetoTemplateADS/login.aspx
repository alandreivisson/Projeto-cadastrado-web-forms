<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div class="login-box container pt-5">
            <!-- /.login-logo -->
            <div class="card card-outline card-warning ">
                <div class="card-header text-center">
                    <a href="#" class="h1"><b>COLETIVO</b>GO</a>
                </div>
                <div class="card-body">
                    <p class="login-box-msg">Entrar com um login:</p>
                    <div class="input-group mb-3">
                        <asp:TextBox name="txtEmail" CssClass="form-control" placeholder="E-mail" ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
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
                            <asp:Button OnClick="btnLogar_Click" ID="btnLogar" runat="server" CssClass="btn btn-success btn-block" Text=" Entrar "/>
                        </div>
                        <div class="col-4">
                        </div>
                        <!-- /.col -->
                        <div class="col-12" style="text-align:center;">
                            <asp:Literal ID="msgErro" runat="server"></asp:Literal>
                        </div>
                    </div>

                </div>



                    
                </div>
                <!-- /.card-body -->
            </div>
            <!-- /.card -->
        
        
        <!-- jQuery -->
        <script src="../../plugins/jquery/jquery.min.js"></script>
        <!-- Bootstrap 4 -->
        <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
        <!-- AdminLTE App -->
        <script src="../../dist/js/adminlte.min.js"></script>

</asp:Content>

