<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EditarForn.aspx.cs" Inherits="New_Login.Fornecedor.EditarForn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="text-center text-primary">
            <h2>Editar Dados de Fornecedor</h2>
        </div>


        <div class="row" style="margin-top: 15px">


            <div class="col-md-1">
                <label>ID:</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>


            <div class="col-md-7">
                <label>Razão Social:</label>
                <asp:TextBox ID="txtRazao" runat="server" MaxLength="100" CssClass="form-control" Enabled="true"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <label>CNPJ:</label>
                <asp:TextBox ID="txtCnpj" runat="server" MaxLength="14" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-8">
                <label>Nome Do Responsavel:</label>
                <asp:TextBox ID="txtRespon" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-4">
                <label>Telefone:</label>
                <asp:TextBox ID="txtTelefone" runat="server" AutoCompleteType="Cellular" MaxLength="11" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            </div>

        </div>

        <div class="row" style="margin-top: 15px">


            <div class="col-md-5">
                <label>Cep:</label>
                <asp:TextBox ID="txtCep" runat="server" MaxLength="9" CssClass="form-control"></asp:TextBox>
            </div>


            <div class="col-md-4">
                <label>Centro De Custo:</label>
                <asp:RequiredFieldValidator ID="rfvCusto" ControlToValidate="ddCusto"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:DropDownList ID="ddCusto" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Ti">TI</asp:ListItem>
                    <asp:ListItem Value="Operacional">Operacional</asp:ListItem>
                    <asp:ListItem Value="Administrativo">Administrativo</asp:ListItem>
                    <asp:ListItem Value="Comercial">Comercial</asp:ListItem>
                    <asp:ListItem Value="RH">RH</asp:ListItem>
                </asp:DropDownList>
            </div>


            <div class="col-md-3">
                <label>Status:</label>
                <asp:RequiredFieldValidator ID="rfvStatus" ControlToValidate="ddStatus"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:DropDownList ID="ddStatus" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Ativo">Ativo</asp:ListItem>
                    <asp:ListItem Value="Inativo">Inativo</asp:ListItem>
                </asp:DropDownList>
            </div>

        </div>

        <div class="row" style="margin-top: 15px">

            <div class="col-md-6 text-left ">
                <asp:HyperLink type="button" runat="server" class="btn btn-outline-primary" NavigateUrl="~/User/ListaUser.aspx">Voltar</asp:HyperLink>
            </div>

            <div class="col-md-6 text-right">
                <asp:Button ID="btnEditar" CssClass="btn btn-outline-warning" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            </div>

        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-12 text-right">
                <asp:Label ID="lblResultado" CssClass="text text-danger" runat="server"></asp:Label>
            </div>
        </div>
    </div>


</asp:Content>
