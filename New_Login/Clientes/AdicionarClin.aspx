<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AdicionarClin.aspx.cs" Inherits="New_Login.Clientes.AdicionarClin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="text-center text-primary">
            <h2>Cadastro de Clientes</h2>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-9">
                <label>Nome:</label>
                <asp:RequiredFieldValidator ID="rfvNome" ControlToValidate="txtNome"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtNome" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label>Cpf:</label>
                <asp:RequiredFieldValidator ID="rfvcpf" ControlToValidate="txtCpf"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtCpf" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-3">
                <label>DDD:</label>
                <asp:RequiredFieldValidator ID="rfvDdd" ControlToValidate="txtDdd"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtDdd" runat="server" MaxLength="3" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-4">
                <label>Telefone:</label>
                <asp:RequiredFieldValidator ID="rfvtelefone" ControlToValidate="txtTelefone"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtTelefone" runat="server" MaxLength="8"  CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-5">
                <label>Celular:</label>
                <asp:RequiredFieldValidator ID="rfvCelular" ControlToValidate="txtCelular"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtCelular" runat="server" MaxLength="11"  CssClass="form-control"></asp:TextBox>
            </div>


        </div>

        <div class="row" style="padding-top:15px" >

            <div class="col-md-6">
                <label>E-mail:</label>
                <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="txtEmail"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="45"  CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-3">
                <label>Curva de Atendimento:</label>
                <asp:RequiredFieldValidator ID="rfvCurva" ControlToValidate="ddlCurva"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:DropDownList ID="ddlCurva" runat="server" CssClass="form-control">
                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
                    <asp:ListItem Value="D">D</asp:ListItem>
                    <asp:ListItem Value="C">C</asp:ListItem>
                    <asp:ListItem Value="B">B</asp:ListItem>
                    <asp:ListItem Value="A">A</asp:ListItem>
                    <asp:ListItem Value="AA">AA</asp:ListItem>
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

        <div class="row" style="margin-top: 15px">
            <div class="col-md-12 text-right">
                <asp:Label ID="lblResultado" CssClass="text text-danger" runat="server"></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>
