<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TP_2_Programacion_3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="IndexStyleSheet.css" rel="stylesheet" />
    <title>Ejercicios del TP 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="label-index">
            <asp:Label ID="LabelIndex" runat="server" Font-Bold="True" Text="Ejercicios del TP 2"></asp:Label>
        </div>
        <div id="links-ejercicios">
            <asp:LinkButton ID="LinkButtonEjercicio1" runat="server" OnClick="LinkButtonEjercicio1_Click">Ejercicio 1</asp:LinkButton>
            <asp:LinkButton ID="LinkButtonEjercicio2" runat="server" OnClick="LinkButtonEjercicio2_Click">Ejercicio 2</asp:LinkButton>
        </div>
    </form>
</body>
</html>
