using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCafes.Models
{
    public class ProductoCafeteria
    {
        public string IdProducto { get; set; }
        public string NombreCafe { get; set; }
        public string TipoCafe { get; set; }
        public int Precio { get; set; }
    }
}