<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AdicionarForn.aspx.cs" Inherits="New_Login.Fornecedor.AdicionarForn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="text-center text-primary">
            <h2>Cadastro de Fornecedor</h2>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-8">
                <label>Razão Social:</label>
                <asp:RequiredFieldValidator ID="rfvRazao" ControlToValidate="txtRazao"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtRazao" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <label>CNPJ:</label>
                <asp:RequiredFieldValidator ID="rfvCnpj" ControlToValidate="txtCnpj"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtCnpj" runat="server" MaxLength="14" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-8">
                <label>Nome Do Responsavel:</label>
                <asp:RequiredFieldValidator ID="rfvResponsavel" ControlToValidate="txtRespon"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtRespon" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-4">
                <label>Telefone:</label>
                <asp:RequiredFieldValidator ID="rfvTelefone" ControlToValidate="txtTelefone"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtTelefone" runat="server" AutoCompleteType="Cellular" MaxLength="11" CssClass="form-control" TextMode="Phone"></asp:TextBox>
            </div>

        </div>

        <div class="row" style="margin-top: 15px">


            <div class="col-md-5">
                <label>Cep:</label>
                <asp:RequiredFieldValidator ID="rfvCep" ControlToValidate="txtCep"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtCep" runat="server" MaxLength="9" CssClass="form-control"></asp:TextBox>
            </div>

            
            <div class="col-md-4">
                <label>Centro De Custo:</label>
                <asp:RequiredFieldValidator ID="rfvCusto" ControlToValidate="ddCusto"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:DropDownList ID="ddCusto" runat="server" CssClass="form-control">
                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
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
                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
                    <asp:ListItem Value="Ativo">Ativo</asp:ListItem>
                    <asp:ListItem Value="Inativo">Inativo</asp:ListItem>
                </asp:DropDownList>
            </div>

        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-12 text-right">
                <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </div>

        <div class="form-inline my-2 my-lg-0" style="padding-top: 20px;">
            <asp:HyperLink type="button" runat="server" class="btn btn-outline-primary" NavigateUrl="/Fornecedor/ListaForn.aspx">Volar</asp:HyperLink>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-12 text-right">
                <asp:Label ID="lblResultado" CssClass="text text-danger" runat="server"></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>
