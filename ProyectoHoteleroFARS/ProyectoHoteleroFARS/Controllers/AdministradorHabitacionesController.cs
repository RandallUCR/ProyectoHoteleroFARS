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
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            { //este if debe aparecer en todas las acciones del administrador
                ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

                List<TipoHabitacion> t = new TipoHabitacionRN().getTiposHabitacionTemp();
                ViewBag.Tipos = t;
                ViewBag.Habitaciones = new HabitacionAdminRN().getHabitacionesByTipo(t[0].TN_Id);
                if (t.Count()>0)
                {
                    HttpContext.Session.SetInt32("TipoActualId", t[0].TN_Id);
                    return View("AdministrarHabitacion", t[0].TC_Nombre);                 
                }
                else
                {
                    return View("AdministrarHabitacion", "Vacio");
                }
                
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }

        public IActionResult CambiarTipo(int tipoHabi)
        {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

            List<TipoHabitacion> t = new TipoHabitacionRN().getTiposHabitacionTemp();
            ViewBag.Tipos = t;
            List<Habitacion> h = new HabitacionAdminRN().getHabitacionesByTipo(tipoHabi);
            ViewBag.Habitaciones = h;
            ViewBag.Index = tipoHabi;
            HttpContext.Session.SetInt32("TipoActualId", tipoHabi);

            return View("AdministrarHabitacion", findTipo(t,tipoHabi));
        }

        public string findTipo(List<TipoHabitacion> list, int value)
        {
            int salida = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].TN_Id == value)
                {
                    salida = i;
                }
            }
            if (list.Count()>0)
            {
                return list[salida].TC_Nombre;
            }
            else
            {
                return "Vacio";
            }
            
        }

        public JsonResult irTipo(int id)
        {
            return Json(new { url = Url.Action("CambiarDescripcion", "AdministradorHabitaciones", new {id = id }) });
        }
        public IActionResult CambiarDescripcion(int id)
        {

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
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

        public JsonResult insertarHabitacion(int num, bool estado)
        {
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualId");
            int result = new HabitacionAdminRN().insertarHabitacion(num, estado, tipo);

            switch (result)
            {
                case 1:
                    return Json(new { success = true, inserted = true, url = Url.Action("CambiarTipo", "AdministradorHabitaciones", new { tipoHabi = tipo}) });
                    break;
                case 2:
                    return Json(new { success = true, inserted = false });
                    break;
                default:
                    return Json(new { success = false, inserted = false });
                    break;
            }
        }

        public JsonResult modificarHabitacion(int num, bool estado, int id)
        {
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualId");
            int result = new HabitacionAdminRN().modificarHabitacion(num, estado, id);

            switch (result)
            {
                case 1:
                    return Json(new { success = true, inserted = true, url = Url.Action("CambiarTipo", "AdministradorHabitaciones", new { tipoHabi = tipo }) });
                    break;
                case 2:
                    return Json(new { success = true, inserted = false });
                    break;
                default:
                    return Json(new { success = false, inserted = false });
                    break;
            }
        }

        public JsonResult eliminarHabitacion(int id)
        {
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualId");
            int result = new HabitacionAdminRN().eliminarHabitacion(id);

            switch (result)
            {
                case 1:
                    return Json(new { success = true, inserted = true, url = Url.Action("CambiarTipo", "AdministradorHabitaciones", new { tipoHabi = tipo }) });
                    break;
                case 2:
                    return Json(new { success = true, inserted = false });
                    break;
                default:
                    return Json(new { success = false, inserted = false });
                    break;
            }
        }

        public JsonResult insertarTipo(string nombre, string desc,int precio, string base64, string ext)
        {
            int result = new TipoHabitacionAdminRN().insertarTiposHabitaciones(nombre, desc, precio, base64, ext);

            switch (result)
            {
                case -3:
                    return Json(new { success = false, inserted = false });
                    break;
                case -2:
                    return Json(new { success = true, inserted = false });
                    break;
                default:
                    HttpContext.Session.SetInt32("TipoActualId", result);
                    return Json(new { success = true, inserted = true, url = Url.Action("CambiarTipo", "AdministradorHabitaciones", new { tipoHabi = result }) });
                    break;
            }
        }

        public JsonResult eliminarTipo(int id)
        {
            int result = new TipoHabitacionAdminRN().eliminarTiposHabitaciones(id);

            switch (result)
            {
                case 1:
                    return Json(new { success = true, inserted = true, url = Url.Action("AdministrarHabitacion", "AdministradorHabitaciones") });
                    break;
                case 2:
                    return Json(new { success = true, inserted = false });
                    break;
                default:
                    return Json(new { success = false, inserted = false });
                    break;
            }
        }
    }
}
