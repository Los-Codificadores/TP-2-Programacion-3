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
                    <td class="auto-style3">
                        <asp:Label ID="LabelErrorNombre" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="LabelApellido" runat="server" Text="Apellido:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LabelErrorApellido" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ciudad</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="dropDownListCiudades" runat="server">
                            <asp:ListItem Value="Zona Norte">Gral. Pacheco</asp:ListItem>
                            <asp:ListItem Value="Zona Oeste">San Miguel</asp:ListItem>
                            <asp:ListItem Value="Zona Sur">Boedo</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Temas:</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:CheckBoxList ID="checkBoxTemas" runat="server">
                            <asp:ListItem>Ciencias</asp:ListItem>
                            <asp:ListItem>Literatura</asp:ListItem>
                            <asp:ListItem>Historia</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LabelErrorTemas" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                    </td>
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
