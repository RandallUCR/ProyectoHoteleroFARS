using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReglasNegocio;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministradorClienteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Layout = new LayoutController().getHotel();

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

                ViewBag.List = new ClienteAdminRN().lista_clientes("");
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;

                return View("Index");
            }              
            return View("Login", -2);
        }

        public IActionResult Filtrar(string busqueda)
        {
            ViewBag.Layout = new LayoutController().getHotel();

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

                ViewBag.List = new ClienteAdminRN().lista_clientes(busqueda);
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;

                return View("Index");
            }
            return View("Login", -2);
        }

        public JsonResult Insertar(string cedula, string nombre, string apellidos, string email)
        {

            int result = new ClienteAdminRN().insertarCliente(cedula, nombre, apellidos, email);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministradorCliente") });
            }
            else
            {
                if (result == 2)
                {
                    return Json(new { success = true, inserted = false });
                }
                else
                {
                    return Json(new { success = false, inserted = false });

                }
            }

        }

        public JsonResult Modificar(int idCliente, string cedula, string nombre, string apellidos, string email)
        {

            int result = new ClienteAdminRN().modificarCliente(idCliente, cedula, nombre, apellidos, email);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministradorCliente") });
            }
            else
            {
                if (result == 2)
                {
                    return Json(new { success = true, inserted = false });
                }
                else
                {
                    return Json(new { success = false, inserted = false });

                }
            }

        }

        public JsonResult Eliminar(int id)
        {

            int result = new ClienteAdminRN().eliminarCliente(id);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministradorCliente") });
            }
            else
            {
                if (result == 2)
                {
                    return Json(new { success = true, inserted = false });
                }
                else
                {
                    return Json(new { success = false, inserted = false });

                }
            }

        }
    }
}
