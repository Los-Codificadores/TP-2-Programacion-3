<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4_login.aspx.cs" Inherits="TP_2_Programacion_3.Ejercicios.Ejercicio4_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 27%;
            margin-right: 0px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style4 {
            width: 146px;
        }
        #Text1 {
            width: 191px;
        }
        #Password1 {
            width: 192px;
        }
        .auto-style5 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2" dir="ltr" style="font-weight: bold; vertical-align: middle; text-align: center;">Iniciar Sesion</td>
                </tr>
                <tr>
                    <td class="auto-style5">Nombre de usuario:</td>
                    <td class="auto-style4">
                        <input id="InputNombre" type="text" /></td>
                </tr>
                <tr>
                    <td class="auto-style5">Contraseña:</td>
                    <td class="auto-style4">
                        <input id="InputPass" type="password" /></td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2" style="vertical-align: middle; text-align: center">
                        <asp:Button ID="ButtonLogin" runat="server" Text="Login" Width="82px" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registro" />
    </form>
</body>
</html>
