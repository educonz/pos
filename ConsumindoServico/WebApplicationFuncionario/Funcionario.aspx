<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="WebApplicationFuncionario.Funcionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="idFuncionario"></asp:TextBox>
        <asp:Button runat="server" OnClick="Unnamed_Click" Text="Search"></asp:Button>

        <asp:GridView runat="server" ID="dgFuncionario" style="margin-top:20px !important"></asp:GridView>
    </div>
        
    </form>
</body>
</html>
