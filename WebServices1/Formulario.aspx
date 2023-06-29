<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="WebServices1.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- Librería de Bootstrap-->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <!-- Caja de texto -->
        <asp:TextBox ID="txtBuscarId" runat="server" />
        <!-- Boton de busqueda -->
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

        <br />

        <!-- Tabla de datos -->
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" class="table table-striped">
            <Columns>
                <asp:BoundField DataField="idBoleta" HeaderText="ID Boleta" ItemStyle-CssClass="col-md-2" />
                <asp:BoundField DataField="claseVenta.NombreVendedor" HeaderText="Nombre Vendedor" ItemStyle-CssClass="col-md-2" />
                <asp:BoundField DataField="claseVenta.FechaVenta" HeaderText="Fecha de Venta" ItemStyle-CssClass="col-md-2" />
                <asp:BoundField DataField="NombreCafe" HeaderText="Nombre del Café" ItemStyle-CssClass="col-md-2" />
                <asp:BoundField DataField="TipoCafe" HeaderText="Tipo de Café" ItemStyle-CssClass="col-md-2" />
                <asp:BoundField DataField="claseVenta.CantidadProducto" HeaderText="Cantidad de Productos" ItemStyle-CssClass="col-md-2" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" ItemStyle-CssClass="col-md-2" />
            </Columns>
        </asp:GridView>

        <asp:Label ID="lblMensaje" runat="server"></asp:Label>

    </form>
</body>
</html>
