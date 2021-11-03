<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mascotas.aspx.cs" Inherits="Veterinaria.Mascotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 466px;
        }
        .auto-style4 {
            width: 466px;
            text-align: center;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style6 {
            width: 393px;
        }
        .auto-style7 {
            width: 390px;
        }
        .auto-style8 {
            width: 390px;
            text-align: center;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            width: 393px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <div class="auto-style1">
            <strong><span class="auto-style1">
            <br />
             <span class="auto-style5">INGRESO DE MASCOTAS</span></span></strong><br />
            <br />
        </div>
    
    <table class="auto-style2">
        <tr>
            <td class="auto-style6">Identificación de la mascota</td>
            <td class="auto-style8">
                <asp:TextBox ID="TxtCodMascota" runat="server" Width="266px" MaxLength="15"></asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:Button ID="BtnConsultarMascota" runat="server" OnClick="BtnConsultarMascota_Click" Text="Consultar Mascota" Width="224px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Label ID="LblCodigoPaciente" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Nombre de la mascota</td>
            <td class="auto-style8">
                <asp:TextBox ID="TxtNombreMascota" runat="server" Width="266px" MaxLength="50"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">Nombre del propietario</td>
            <td class="auto-style8">
                <asp:TextBox ID="TxtNombrePropietario" runat="server" Width="266px" MaxLength="50"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">Fecha de nacimiento de la mascota</td>
            <td class="auto-style8">
                <asp:TextBox ID="TxtFecha" runat="server"  Width="266px" ></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Label ID="LblMensaje" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Button ID="BtnGuardarMascota" runat="server" OnClick="BtnGuardarMascota_Click" Text="Guardar Mascota" Width="224px" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="BtnAnularMascota" runat="server" OnClick="BtnAnularMascota_Click" Text="Anular Mascota" Width="224px" />
            </td>
            <td class="auto-style1">
                <asp:Button ID="BtnLimpiarCampos" runat="server" OnClick="BtnLimpiarCampos_Click" Text="Limpiar Campos" Width="224px" />
            </td>
        </tr>
    
  </form>
</body>
</html>
