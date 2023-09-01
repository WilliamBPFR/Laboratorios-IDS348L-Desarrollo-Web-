<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webClasificacion.aspx.cs" Inherits="Lab_03.webClasificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CLASIFICACION DE IAMGENES<br />
            <br />
            SUBE TU IMAGEN:<br />
            <br />
            <asp:FileUpload ID="fuImagen" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnVerificar" runat="server" OnClick="btnVerificar_Click" Text="VERIFICAR MODERACION" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelModeracion" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Image ID="imagen" runat="server" />
        </div>
    </form>
</body>
</html>
