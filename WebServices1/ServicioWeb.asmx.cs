using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoCafes.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices1
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string ObtenerCafeJson()
        {
            //Creo una instancia del controlador de los cafés
            CafesController cafesController = new CafesController();
            //Obtengo los datos en formato JSON del metodo ObtenerCafes del controlador
            var cafesJson = cafesController.ObtenerCafeJson();

            //Deserializar la cadena JSON en una lista de objetos
            var cafes = JArray.Parse(cafesJson);

            //Ordenar los cafés por el nombre
            var cafesOrdenadas = cafes.OrderBy(p => (string)p["NombreCafe"]).ToList();

            //Convertir la lista de objetos ordenados a una cadena Json
            var cafesOrdenadosJson = JsonConvert.SerializeObject(cafesOrdenadas);

            return cafesOrdenadosJson;
        }
    }
}
