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
        .auto-style3 {
            height: 23px;
            width: 90px;
        }
        .auto-style4 {
            width: 90px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Usuario: </td>
                    <td class="auto-style2">
                        <input id="usuarioInput" runat="server" type="text" /><asp:Label ID="LabelMensajeUsuario" style="color: red" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Contraseña : </td>
                    <td>
                        <input id="passwordInput" runat="server" type="password" /><asp:Label ID="LabelMensajePassword" style="color: red" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:Button ID="ButtonRegistrarse" runat="server" OnClick="ButtonRegistrarse_Click" Text="Registrarse" />
        </div>
        <asp:Label ID="LabelRegistroExitoso" style="color: green; display: block; margin-top: 30px" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ButtonVolver" runat="server" OnClick="ButtonVolver_Click" Visible="false" Text="Volver" />
        </p>
    </form>
</body>
</html>
