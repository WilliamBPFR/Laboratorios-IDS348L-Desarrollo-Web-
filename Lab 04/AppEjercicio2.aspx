<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="AppEjercicio2.aspx.cs" Inherits="Lab_04.AppEjercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cedula:
            <asp:TextBox ID="txtPri3" runat="server" Width="45px"></asp:TextBox>
&nbsp;-
            <asp:TextBox ID="txtLargo" runat="server" Width="106px"></asp:TextBox>
&nbsp;-
            <asp:TextBox ID="txtVef" runat="server" Width="45px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelNoAdmitido" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnPadron" runat="server" OnClick="btnPadron_Click" Text="Consultar Padrón" />
            <br />
            <br />
            <br />
            <br />
            Nombres:&nbsp; <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellidos:&nbsp;
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <br />
            Telefono:&nbsp;
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            Fecha Nacimiento:
            <asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            Lugar Nacimiento:&nbsp;
            <asp:TextBox ID="txtLugNac" runat="server"></asp:TextBox>
            <br />
            <br />
            Edad:&nbsp;
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
