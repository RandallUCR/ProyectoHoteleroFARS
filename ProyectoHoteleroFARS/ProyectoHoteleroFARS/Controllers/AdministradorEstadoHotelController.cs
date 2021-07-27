using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministradorEstadoHotelController : Controller
    {
        public IActionResult Index(){
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null) { //este if debe aparecer en todas las acciones del administrador
                ViewBag.Habitaciones = new EstadoHotelRN().getEstadoHotelHoyRN();
                ViewBag.Fecha = DateTime.Now;
                return View("Index");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }
    }
}
