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
    public class AdministradorHabitacionesController : Controller
    {
        public IActionResult AdministrarHabitacion()
        {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            { //este if debe aparecer en todas las acciones del administrador
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                return View("AdministrarHabitacion");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }
        public IActionResult CambiarDescripcion(int id)
        {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                TipoHabitacion th = new TipoHabitacionRN().getTipoHabitacionById(id);
                ViewBag.Nombre = th.TC_Nombre;
                ViewBag.Descripcion = th.TC_Descripcion;
                ViewBag.Precio = (int)th.TN_Precio;
                ViewBag.Formato = th.galeria.TC_Formato;
                ViewBag.Foto = th.galeria.TV_Archivo;

                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                return View("CambiarDescripcion");
            }
            return View("Login", -2);
        }
    }
}
