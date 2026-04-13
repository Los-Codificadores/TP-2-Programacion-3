<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 25px;
        }

        .auto-style3 {
            height: 100px;
        }
        .auto-style4 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButtonColorTexto" runat="server" OnClick="LinkButtonColorTexto_Click">Color de texto aleatorio</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="labelColor" runat="server" Text="Color del texto: "></asp:Label>
                        <asp:LinkButton ID="colorRojo" runat="server" OnClick="colorRojo_Click" Font-Underline="True" Style="font-size: 20px;
                            text-decoration: none; border: 1px solid #ccc; padding: 2px 10px; margin-left: 5px" BackColor="Red" Font-Bold="False" Font-Overline="False" Font-Strikeout="False" ForeColor="Red">R</asp:LinkButton>
                        <asp:LinkButton ID="colorAzul" runat="server" OnClick="colorAzul_Click" Font-Underline="True" Style="font-size: 20px;
                            text-decoration: none; border: 1px solid #ccc; padding: 2px 10px; margin-left: 5px" BackColor="Blue" Font-Bold="False" Font-Overline="False" Font-Strikeout="False" ForeColor="Blue">B</asp:LinkButton>
                        <asp:LinkButton ID="colorVerde" runat="server" OnClick="colorVerde_Click" Font-Underline="True" Style="font-size: 20px;
                            text-decoration: none; border: 1px solid #ccc; padding: 2px 10px; margin-left: 5px" BackColor="Lime" Font-Bold="False" Font-Overline="False" Font-Strikeout="False" ForeColor="Lime">G</asp:LinkButton>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
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
                <tr style="padding-top: 20px">
                    <td colspan="3" class="auto-style4">
                        <asp:LinkButton ID="Bold" runat="server" OnClick="AplicarFormato_Click" Font-Bold="True" Style="font-size: 20px;
                            text-decoration: none; border: 1px solid #ccc; padding: 2px 10px;">B</asp:LinkButton>
                        <asp:LinkButton ID="Italic" runat="server" OnClick="AplicarFormato_Click" Font-Italic="True" Style="font-size: 20px;
                            text-decoration: none; border: 1px solid #ccc; padding: 2px 10px; margin-left: 5px">I</asp:LinkButton>
                        <asp:LinkButton ID="Underline" runat="server" OnClick="AplicarFormato_Click" Font-Underline="True" Style="font-size: 20px;
                            text-decoration: none; border: 1px solid #ccc; padding: 2px 10px; margin-left: 5px" Font-Bold="False" Font-Overline="False" Font-Strikeout="False">U</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style3">
                        <asp:Label ID="lblResultado" runat="server" Text="Texto coloreado"></asp:Label>
                    </td>
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
