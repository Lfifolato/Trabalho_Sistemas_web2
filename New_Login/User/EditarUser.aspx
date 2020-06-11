<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EditarUser.aspx.cs" Inherits="New_Login.User.EditarUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="text-center text-primary">
            <h2>Editar Dados do Usuario</h2>
        </div>

        <div class="row" style="margin-top: 15px">

            <div class="col-md-2">
                <label>ID</label>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="false" ></asp:TextBox>
            </div>


            <div class="col-md-10">
                <label>Nome:</label>
                <asp:TextBox ID="txtNome" runat="server" MaxLength="50" CssClass="form-control"
                    Enabled="true">
                </asp:TextBox>
            </div>

        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-5">
                <label>E-mail:</label>
                <asp:TextBox ID="txtEmail" runat="server" MaxLength="100" CssClass="form-control"
                    Enabled="true">
                </asp:TextBox>
            </div>

            <div class="col-md-4">
                <label>Login:</label>
                <asp:TextBox ID="txtLogin" runat="server" MaxLength="100" CssClass="form-control"
                    Enabled="true">
                </asp:TextBox>
            </div>

            <div class="col-md-3">
                <label>Nivel De Acesso</label>
                <asp:RequiredFieldValidator ID="rfvNivel" ControlToValidate="txtNome"
                    ErrorMessage="*" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>
                <asp:DropDownList ID="txtNivel" runat="server" CssClass="form-control">
                    <asp:ListItem Selected="True" Value=""></asp:ListItem>
                    <asp:ListItem Value="A">Administrador</asp:ListItem>
                    <asp:ListItem Value="O">Operador</asp:ListItem>
                </asp:DropDownList>
            </div>

        </div>

        <div class="form-inline my-2 my-lg-0" style="padding-top: 20px;">
            <asp:HyperLink type="button" runat="server" class="btn btn-outline-primary" NavigateUrl="~/User/ListaUser.aspx">Voltar</asp:HyperLink>
        </div>

        <div class="form-inline my-2 my-lg-0" style="padding-top: 20px;">
            <asp:Button id="btnRemover" class="btn btn-outline-warning" runat="server"
                Text="Editar" OnClick="btnRemover_Click" />
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-12 text-right">
                <asp:Label ID="lblResultado" CssClass="text-success" runat="server"></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
