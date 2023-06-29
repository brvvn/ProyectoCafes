using Newtonsoft.Json.Linq;
using ProyectoCafes.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices1
{
    
    public partial class Formulario : System.Web.UI.Page
    {
        //Lista de datos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Obtener los datos en formato JSON
                CafesController cafesController = new CafesController();
                var cafesJson = cafesController.ObtenerCafeJson();

                //Deserializar la cadena JSON en una lista de objetos
                var cafes = JArray.Parse(cafesJson);

                //Ordenar los cafés por el nombre
                var cafesOrdenadas = cafes.OrderBy(p => (string)p["NombreCafe"]).ToList();

                //Enlazar los datos de la GRIDVIEW para mostrarlos en la tabla
                GridView1.DataSource = cafesOrdenadas;
                GridView1 .DataBind();
            }

        }

        //Evento boton
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Obtener el ID de la venta ingresado en el TextBox
            string idBoleta = txtBuscarId.Text;

            //Obtener los datos en formato JSON
            CafesController cafesController = new CafesController();
            var cafesJson = cafesController.ObtenerCafeJson();

            //Deserializar la cadena JSON en una lista de objetos
            var cafes = JArray.Parse(cafesJson);

            //Filtrar los cafes por ID de boleta
            var cafesFiltrados = cafes.Where(p => (string)p["idBoleta"] == idBoleta).ToList();
            //Enlazar los datos filtrados a la GRIDVIEW
            GridView1.DataSource= cafesFiltrados;
            GridView1 .DataBind();
        }

    }
}