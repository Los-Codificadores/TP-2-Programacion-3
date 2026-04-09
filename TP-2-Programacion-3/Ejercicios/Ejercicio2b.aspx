<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2b.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicios.Ejercicio2b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 2b</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 119px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="padding-left: 60px">
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="48px" Text="Resumen" Height="90px"></asp:Label>
        <br />
        <br />
        <table class="auto-style1" runat="server" style="font-size: 18px;">
            <tr>
                <td class="auto-style2">Nombre:</td>
                <td id="tablaNombre" style="font-weight: bold">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Apellido:</td>
                <td id="tablaApellido" style="font-weight: bold">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Zona:</td>
                <td id="tablaZona" style="font-weight: bold">&nbsp;</td>
            </tr>
        </table>
        <div style="height: 20px">
        </div>
        <asp:Label ID="label4" runat="server" Text="Los temas elegidos son:" Font-Size="18px"></asp:Label>
        <br />
        <asp:Label ID="labelTemas" runat="server" Font-Bold="True" Text="Label" style="display: block; padding-left: 80px" Font-Size="18px" ></asp:Label>
    </form>
</body>
</html>
