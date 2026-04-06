<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TP_2_Programacion_3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <link href="Ejercicio1StyleSheet.css" rel="stylesheet" />
        <title>Ejercicio 1</title>
        <style type="text/css">
            .auto-style6 {
                height: 39px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <div id="mensaje">
                <asp:Label ID="labelMensaje" runat="server" BackColor="Red" Font-Bold="False" ForeColor="White"></asp:Label>
            </div>

            <div class="input-producto">
                <asp:Label ID="labelNombre1" runat="server" Text="Ingrese el nombre del producto:"></asp:Label>
                <asp:TextBox ID="textBoxProducto1" runat="server"></asp:TextBox>
                <asp:Label ID="labelCantidad1" runat="server" Text="Cantidad:"></asp:Label>
                <asp:TextBox ID="textBoxCantidad1" runat="server"></asp:TextBox>
                <br />
                
            </div>
            <div class="input-producto">
                <asp:Label ID="LabelNombre2" runat="server" Text="Ingrese el nombre del producto:"></asp:Label>
                <asp:TextBox ID="TextBoxProducto2" runat="server"></asp:TextBox>
                <asp:Label ID="LabelCantidad2" runat="server" Text="Cantidad:"></asp:Label>
                <asp:TextBox ID="TextBoxCantidad2" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnGenerarTabla" runat="server" OnClick="btnGenerarTabla_Click" Text="Generar tabla" Height="27px" />
            </div>
            <div>
                <br />
                <table id="tableproduct" runat="server" border="1" class="tabla-ejercicio" visible ="false">
                    <tr>
                        <th class="col-prod">Producto</th>
                        <th class="col-cant">Cantidad</th>
                    </tr>
                    <tr>
                        <td id="tablaTextBoxProducto1" runat="server" accesskey="tablaTextBoxProducto1"></td>
                        <td id="tablaTextBoxCantidad1" runat="server"></td>
                    </tr>
                    <tr>
                        <td id="tablaTextBoxProducto2" runat="server"></td>
                        <td id="tablaTextBoxCantidad2" runat="server"></td>
                    </tr>
                    <tr>
                        <td id="tablaTextBoxTotal" runat="server"></td>
                        <td id="tablaTextBoxTotal2" runat="server"></td>
                    </tr>
                </table>
            </div>
        </form>
    </body>
</html>
