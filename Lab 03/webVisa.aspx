<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webVisa.aspx.cs" Inherits="Lab_03.webVisa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BIENVENIDO AL PORTAL DE VISAS DOMINICANAS</div>
        <p>
            INGRESE LAS INFORMACIONES SIGUIENTES:</p>
        <p>
            Tipo Documentos:
            <asp:TextBox ID="txtTipoDox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombres:
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellidos:
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha Nacimiento:
            <asp:Calendar ID="txtFechaNac" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sexo:
            <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ocupacion:
            <asp:TextBox ID="txtOcupacion" runat="server"></asp:TextBox>
        </p>
        <p>
            Salario:
            <asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Casa Propio:
            <asp:TextBox ID="txtCasaPropia" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vehículo:
            <asp:TextBox ID="txtVehiculo" runat="server"></asp:TextBox>
        </p>
        <p>
            Estado:
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lugar Trabajo:
            <asp:TextBox ID="txtLugarTrabajo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nivel Academico:
            <asp:TextBox ID="txtNivelAcademico" runat="server"></asp:TextBox>
        </p>
        <p>
            Foto:&nbsp; <asp:FileUpload ID="fileUpload" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="fotoPersona" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelImagenValida" runat="server"></asp:Label>
        </p>
        <div style="margin-left: 440px">
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar Informaciones" />
        </div>
    </form>
</body>
</html>
