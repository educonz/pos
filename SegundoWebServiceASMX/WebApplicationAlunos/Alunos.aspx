<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="WebApplicationAlunos.Alunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="txtCarregar" runat="server" Text="Carregar Alunos" OnClick="txtCarregar_Click" />
            <br />
            <br />
            <asp:GridView ID="grvAluno" runat="server"></asp:GridView>
            <asp:Label ID="lblRetornoTexto" runat="server" Text="Retorno"></asp:Label>
            <asp:Label ID="lblRetorno" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
