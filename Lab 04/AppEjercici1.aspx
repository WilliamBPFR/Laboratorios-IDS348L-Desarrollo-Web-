<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="AppEjercici1.aspx.cs" Inherits="Lab_04.AppEjercici1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cargar Foto de Cedula:
            <asp:FileUpload ID="fuImagen" runat="server" />
            <br />
            <br />
            <asp:Image ID="imagen" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <span class="auto-style1"><strong>Nombre de la Persona:</strong></span>&nbsp; <span class="auto-style1"><strong>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </strong></span>
        </div>
    </form>
</body>
</html>
