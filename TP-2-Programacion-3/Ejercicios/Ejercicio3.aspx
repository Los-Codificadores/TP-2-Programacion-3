<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 100px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButtonColorTexto" runat="server" OnClick="LinkButtonColorTexto_Click">Cambiar color del texto</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton3" runat="server">LinkButton</asp:LinkButton>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton4" runat="server">LinkButton</asp:LinkButton>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblResultado" runat="server" Text="Texto coloreado"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>    
                <td>
                    <asp:LinkButton ID="LinkButton5" runat="server">LinkButton</asp:LinkButton>
                    </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
