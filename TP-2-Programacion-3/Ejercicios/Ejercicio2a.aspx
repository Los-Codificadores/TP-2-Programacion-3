<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2a.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicios.Ejercicio2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 2a</title>
    <style type="text/css">
        .auto-style2 {
            width: 80px;
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
            width: 166px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div id="input-info-personal">

            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="LabelNombre" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 0px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="LabelApellido" runat="server" Text="Apellido:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style3"></td>
                </tr>
            </table>

        </div>

        <div id="input-temas">

        </div>

        <div id="button-resumen">
            <asp:Button ID="ButtonResumen" runat="server" OnClick="ButtonResumen_Click" style="height: 26px" Text="Ver resumen" />
        </div>

    </form>
</body>
</html>
