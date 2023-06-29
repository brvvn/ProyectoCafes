using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCafes
{
    public partial class FormularioCafes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarClick(object sender, EventArgs e)
        {
            //Defino variables
            string NombreVendedor = txtNombreV.Text;
            string NombreCafe = txtNombreC.Text;
            string Categoria = ddlCategoria.SelectedItem.Value;
            int Cantidad = Convert.ToInt32(txtCantidadC.Text);
            int Precio = Convert.ToInt32(txtPrecioC.Text);
            string Fecha = txtFecha.Text;


            int Total = Cantidad * Precio;
            double ValorConIva = (Total * 0.19);
            double totalConIva = Total + ValorConIva;

            lblResultado.Text = $"Nombre Vendedor: {NombreVendedor} <br/>" +
                                $"Nombre del Café: {NombreCafe} <br/>" +
                                $"Categoria: {Categoria} <br />" +
                                $"Cantidad: {Cantidad} <br/>" +
                                $"Precio: {Precio} <br/>" +
                                $"Total sin IVA: {Total} <br/>" +
                                $"Total del IVA: {ValorConIva} <br/>" +
                                $"Total con IVA: {totalConIva} <br/>" +
                                $"Fecha: {Fecha}";
        }
    }
}