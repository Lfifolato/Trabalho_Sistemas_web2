<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RemoverClin.aspx.cs" Inherits="New_Login.Clientes.RemoverClin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="text-center text-primary">
            <h2>Cadastro de Clientes</h2>
        </div>

        <div class="row" style="margin-top: 15px">

            <div class="col-md-2">
                <label>ID:</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-7">
                <label>Nome:</label>
                <asp:TextBox ID="txtNome" runat="server" MaxLength="50" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label>Cpf:</label>
                <asp:TextBox ID="txtCpf" runat="server" MaxLength="50" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-3">
                <label>DDD:</label>
                <asp:TextBox ID="txtDdd" runat="server" MaxLength="3" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-4">
                <label>Telefone:</label>
                <asp:TextBox ID="txtTelefone" runat="server" MaxLength="8" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-5">
                <label>Celular:</label>
                <asp:TextBox ID="txtCelular" runat="server" MaxLength="11" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>


        </div>

        <div class="row" style="padding-top: 15px">

            <div class="col-md-6">
                <label>E-mail:</label>
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="45" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-3">
                <label>Curva de Atendimento:</label>
                <asp:TextBox ID="txtCurva" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-3">
                <label>Status:</label>
                <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

        </div>

        <div class="row" style="padding-top: 20px;">

            <div class="form-inline my-2 my-lg-0">
                <asp:HyperLink type="button" runat="server" class="btn btn-outline-primary" NavigateUrl="/Clientes/ListaClin.aspx">Volar</asp:HyperLink>
            </div>

            <div class="col-md-6 ">
                <asp:Button ID="btnEditar" CssClass="btn btn-outline-danger" runat="server" Text="Deletar" OnClick="btnEditar_Click" />
            </div>

        </div>



       

        <div class="row" style="margin-top: 15px">
            <div class="col-md-12 text-right">
                <asp:Label ID="lblResultado" CssClass="text text-danger" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
