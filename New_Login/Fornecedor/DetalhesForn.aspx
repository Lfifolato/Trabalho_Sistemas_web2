<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetalhesForn.aspx.cs" Inherits="New_Login.Fornecedor.DetalhesForn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="text-center text-primary">
            <h2>Cadastro de Fornecedor</h2>
        </div>

        <div class="row" style="margin-top: 15px">

            <div class="col-md-1">
                <label>ID:</label>           
                <asp:TextBox ID="txtId" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-7">
                <label>Razão Social:</label>           
                <asp:TextBox ID="txtRazao" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <label>CNPJ:</label>             
                <asp:TextBox ID="txtCnpj" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
        </div>

        <div class="row" style="margin-top: 15px">
            <div class="col-md-8">
                <label>Nome Do Responsavel:</label>               
                <asp:TextBox ID="txtRespon" runat="server"  CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>

            <div class="col-md-4">
                <label>Telefone:</label>                
                <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control" Enabled="false" ></asp:TextBox>
            </div>

        </div>

        <div class="row" style="margin-top: 15px">


            <div class="col-md-5">
                <label>Cep:</label>                
                <asp:TextBox ID="txtCep" runat="server"  CssClass="form-control" Enabled="false" ></asp:TextBox>
            </div>


            <div class="col-md-4"> 
                <label>Centro De Custo:</label>
                <asp:TextBox ID="txtCusto"  runat="server" CssClass="form-control" Enabled="false" ></asp:TextBox>
            </div>


            <div class="col-md-3"> 
                <label>Status:</label>
                <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
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
