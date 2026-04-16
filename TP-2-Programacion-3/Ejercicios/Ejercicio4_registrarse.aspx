<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4_registrarse.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicios.Ejercicio4_registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        #usuario {
            width: 208px;
        }
        #passwordInput {
            width: 208px;
        }
        #usuarioInput {
            width: 205px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Usuario: </td>
                    <td class="auto-style2">
                        <input id="usuarioInput" runat="server" type="text" /></td>
                </tr>
                <tr>
                    <td>Contraseña : </td>
                    <td>
                        <input id="passwordInput" runat="server" type="password" /></td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrarse" />
        </div>
    </form>
</body>
</html>
