using Newtonsoft.Json;
using ProyectoCafes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCafes.Controllers
{
    public class CafesController : Controller
    {
        // GET: Cafes
        public ActionResult Index()
        {
            return View();
        }

        //Declaro el arreglo
        private Boleta[] cafes;

        public CafesController() 
        {
            cafes = new Boleta[]
            {
                new Boleta{idBoleta = "1000",
                        claseVenta = new Venta{NombreVendedor = "Pedro Aguilera", FechaVenta = "15/06/2023",CantidadProducto = 3},
                        NombreCafe = "Café Caramelo Latte", 
                        TipoCafe = "Latte",
                        Precio = 8000, 
                        },
                new Boleta{idBoleta = "1001",
                        claseVenta = new Venta{NombreVendedor = "Jose Prieto", FechaVenta = "16/06/2023",CantidadProducto = 5},
                        NombreCafe = "Café Cappuccino Clasico",
                        TipoCafe = "Cappuccino",
                        Precio = 8500,
                        },
                new Boleta{idBoleta = "1002",
                        claseVenta = new Venta{NombreVendedor = "Manuel Rodriguez", FechaVenta = "17/06/2023",CantidadProducto = 1},
                        NombreCafe = "Café Cappuccino Vainilla",
                        TipoCafe = "Cappuccino",
                        Precio = 6000,
                        },
                new Boleta{idBoleta = "1003",
                        claseVenta = new Venta{NombreVendedor = "Pedro Aguilera", FechaVenta = "18/06/2023",CantidadProducto = 2},
                        NombreCafe = "Café Mocaccino",
                        TipoCafe = "Mocaccino",
                        Precio = 7500,
                        },
            };
        }
        public string ObtenerCafeJson()
        {
            return JsonConvert.SerializeObject(cafes);
        }
    }
}