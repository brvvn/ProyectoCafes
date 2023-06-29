using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCafes.Models
{
    public class Venta
    {
        public string IdVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public int CantidadProducto { get; set; }
        public string FechaVenta { get; set; }
    }
}