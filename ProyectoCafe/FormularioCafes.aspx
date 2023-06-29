<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioCafes.aspx.cs" Inherits="ProyectoCafes.FormularioCafes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Merley Caffee</h1>
    <h2>Formulario de Compras</h2>

    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <div class="container">
            <div class="form-group">
                <asp:Label ID="lblNombreV" runat="server" Text="Nombre Vendedor: "></asp:Label>
                <asp:TextBox ID="txtNombreV" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblFecha" runat="server" Text="Fecha de Venta: "></asp:Label>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblNombreC" runat="server" Text="Nombre del Cafe: "></asp:Label>
                <asp:TextBox ID="txtNombreC" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCategoria" runat="server" Text="Tipo de Cafe: "></asp:Label>
                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Latte" Value="Latte"></asp:ListItem>
                    <asp:ListItem Text="Cappuccino" Value="Cappuccino"></asp:ListItem>
                    <asp:ListItem Text="Mocaccino" Value="Mocaccino"></asp:ListItem>
                </asp:DropDownList>
            </div>
            
            <div class="form-group">
                <asp:Label ID="lblCantidadCJ" runat="server" Text="Cantidad: "></asp:Label>
                <asp:TextBox ID="txtCantidadC" runat="server" CssClass="form-control" type="number"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPrecioC" runat="server" Text="Precio del Café: "></asp:Label>
                <asp:TextBox ID="txtPrecioC" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

            <br />
           
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviarClick" CssClass="btn btn-primary" />
        
    </asp:PlaceHolder>

    <br />

    <div>
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </div>

</asp:Content>