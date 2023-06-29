using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCafes.Models
{
    //Herencia
    public class Boleta : ProductoCafeteria
    {
        public string idBoleta { get; set; }

        //Composición (Se puede ocupar mas composición)
        public Venta claseVenta { get; set; }


    }
}