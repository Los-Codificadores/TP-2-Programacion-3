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
        .auto-style2 {
            width: 220px;
            height: 30px;
        }
        .auto-style3 {
            width: 220px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:39%; height: 342px;">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="labelConfiguracion" runat="server" Text="Elija su configuracion:"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Seleccione cantidad de memoria:</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:DropDownList ID="DropDownList1" AutoPostBack="false" runat="server">
                    <asp:ListItem Value="Memoria2GB">2GB</asp:ListItem>
                    <asp:ListItem Value="Memoria4GB">4GB</asp:ListItem>
                    <asp:ListItem Value="Memoria6GB">6GB</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:Label ID="labelAccesorios" runat="server" Text="Seleccione Accesorios:"></asp:Label>
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:CheckBoxList ID="checkBoxAccesorios" runat="server">
                    <asp:ListItem Value="2000,50">MonitorLCD</asp:ListItem>
                    <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
                    <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
                </asp:CheckBoxList>
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style3">Metodo de pago:&nbsp; <asp:DropDownList ID="DropDownListMetodo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListMetodo_SelectedIndexChanged">
                    <asp:ListItem>Transferencia</asp:ListItem>
                    <asp:ListItem>Credito</asp:ListItem>
                </asp:DropDownList>
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:Label ID="LabelCantidadCuotas" runat="server" Text="Cuotas"></asp:Label>
                <asp:DropDownList ID="DropDownListCuotas" runat="server">
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                    <asp:ListItem Value="6">6</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                </asp:DropDownList>
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:Button ID="botonCalcularPrecio" runat="server" CssClass="auto-style1" OnClick="botonCalcularPrecio_Click" Text="Calcular Precio Final" />
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:Label ID="LabelMensajeMetodoPago" runat="server"></asp:Label>
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:Label ID="LabelMensajeCuotas" visible="false" runat="server"></asp:Label>
                    </td>
        </tr>
                <tr>
            <td class="auto-style3">
                <asp:Label ID="lblCosto" runat="server" Text="El precio final es de:"></asp:Label>
                    </td>
        </tr>
    </table>
    </form>
</body>
</html>
