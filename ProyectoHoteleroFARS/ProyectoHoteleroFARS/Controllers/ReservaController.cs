using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class ReservaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            ViewBag.TiposHabi = new TipoHabitacionRN().getTiposHabitacionTemp();

            return View("VerificarReservaCliente");
        }

        public IActionResult VerificarHabitacion(string rangofechas, int tiposh)
        {

            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******       
            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            TipoHabitacion t = new ReservaRN().verificar(fechaUno, fechaDos, tiposh, new TarifasController().getCambioDolares());
            
            if (t.TN_Id > 0)
            {
                HttpContext.Session.SetInt32("IdHabiSelec", t.TN_Id);
                HttpContext.Session.SetString("PrecioHabiSelec", t.TN_Precio+"");
                HttpContext.Session.SetString("Fecha1HabiSelec", fechaUno);
                HttpContext.Session.SetString("Fecha2HabiSelec", fechaDos);
                ViewBag.Habitacion = t;
                return View("Reservar");
            }
            else {
                ViewBag.TiposHabi = new TipoHabitacionRN().getTiposHabitacionTemp();
                if (t.TN_Id == -1)
                {
                    return View("VerificarReservaCliente", -1);
                }
                else
                {
                    return View("VerificarReservaCliente", -2);
                }

            }
            
        }

        public IActionResult Reservar(string cedula, string nombre, string apellidos, string correo, string tarjeta)
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******  
            Guid g = Guid.NewGuid();
            string aux = Guid.NewGuid()+"";
            string id_res = aux.Substring(0,13);
            int trans = new Random().Next(10000,99999);
            int id_habi = (int)HttpContext.Session.GetInt32("IdHabiSelec");
            string precio = HttpContext.Session.GetString("PrecioHabiSelec");
            string fechaUno = HttpContext.Session.GetString("Fecha1HabiSelec");
            string fechaDos = HttpContext.Session.GetString("Fecha2HabiSelec");

            ConfirmacionReserva c = new ReservaRN().reservar(cedula, nombre, apellidos, correo, tarjeta, id_res, trans, fechaUno, fechaDos, id_habi, precio);
            
            if (c.TN_Id > 0)
            {
                ViewBag.Confirmacion = c;
                return View("ConfirmacionReserva");
            }
            else
            {
                if (c.TN_Id == -1)
                {
                    return View("VerificarReservaCliente", -1);
                }
                else
                {
                    return View("VerificarReservaCliente", -2);
                }
            }      
        }
    }
}
