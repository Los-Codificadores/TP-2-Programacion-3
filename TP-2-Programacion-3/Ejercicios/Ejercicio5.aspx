<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicios.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:39%; height: 342px;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Elija su configuracion:"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Seleccione cantidad de memoria:</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="Memoria2GB">2GB</asp:ListItem>
                    <asp:ListItem Value="Memoria4GB">4GB</asp:ListItem>
                    <asp:ListItem Value="Memoria6GB">6GB</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
                <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style1">
                <asp:Label ID="lblCosto" runat="server" Text="El precio final es de:"></asp:Label>
                    </td>
        </tr>
    </table>
    </form>
</body>
</html>
