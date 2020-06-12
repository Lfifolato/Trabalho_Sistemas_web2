<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="New_Login.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ADL </title>
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Css/Login.css" rel="stylesheet" />
</head>
<body>
   <div class="wrapper fadeInDown">
        <div id="formContent">

            <div class="fadeIn first">

                <img src="img/adssoftware.png" />

            </div>

            <form runat="server">
                <asp:TextBox ID="txtUser" runat="server" class="fadeIn second" name="login" placeholder="Usuário"></asp:TextBox>
                <asp:TextBox ID="txtSenha" runat="server" class="fadeIn thir" name="login" placeholder="Senha"  TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" class="fadeIn fourth" Text="Logar" OnClick="btnLogin_Click"  />
            </form>

            <div id="formFooter">
                <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
            </div>

        </div>
    </div>
</body>
</html>
