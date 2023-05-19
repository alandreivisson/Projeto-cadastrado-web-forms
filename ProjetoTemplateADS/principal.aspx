<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="principal.aspx.cs" Inherits="principal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>

        <div class="row">
            
            <div class="col-2">
            </div>
            
            <div class="col-8" style="text-align:center; padding-top:5%">
                <asp:literal ID="nome" runat="server">Nome</asp:literal>
                <asp:TextBox ID="txtNomePerfil" runat="server" Enabled="false"></asp:TextBox>
                <asp:literal ID="ra" runat="server">Ra</asp:literal>
                <asp:TextBox ID="txtRa" runat="server" Enabled="false"></asp:TextBox>
                <asp:literal ID="email" runat="server">Email</asp:literal>
                <asp:TextBox ID="txtEmail" runat="server" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-2">
            </div>

            <div class="col-2">
            </div>
            <div class="col-8">
                <asp:Literal ID="lblAlunos" runat="server"></asp:Literal>
                <br />
                <br />
                <br />
                <div style="text-align:center; font-style:italic; font-size:xx-large;">
                    <asp:Literal  ID="vazio" runat="server" Visible="false">Sem Usuários Cadastrados</asp:Literal>
                </div>
                <asp:GridView ID="gdvAlunos"  ClientIDMode="Static" runat="server" AutoGenerateColumns="false" OnRowCommand="gdvAlunos_RowCommand">
                    <Columns >
                        <asp:BoundField  HeaderText="NOME" DataField="PES_NOME" />
                        <asp:BoundField  HeaderText="RA" DataField="ALU_RA" />
                        <asp:BoundField  HeaderText="DATA VESTIBULAR" DataField="ALU_DATA_VESTIBULAR" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField  HeaderText="EMAIL" DataField="USU_EMAIL" />
                        <asp:ButtonField ControlStyle-CssClass="btn-outline-dark; border-bottom-500" HeaderText="Excluir" CommandName="excluir" 
                            visible="true" ButtonType="Button" Text="Excluir"/>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-2">
            </div>
        </div>


    </div>
</asp:Content>



