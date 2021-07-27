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
    public class AdministradorController : Controller
    {
        public IActionResult Login(string usuario, string contrasena)
        {
            Administrador a = new AdministradorRN().login(usuario,contrasena);
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (a.TN_Id < 0){               
                return View("Login", a.TN_Id);
            }else{
                HttpContext.Session.SetInt32("AdminActualId", a.TN_Id);
                HttpContext.Session.SetString("AdminActualUsuario",a.TC_Usuario);
                HttpContext.Session.SetInt32("AdminActualRol", a.rol.TN_Id);

                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                return View("HomeAdmin");
            }
        }

        public IActionResult Index()
        {
            ViewBag.Layout = new LayoutController().getHotel(); 
            return View("Login");
        }       

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            ViewBag.Layout = new LayoutController().getHotel();
            return View("Login");
        }

        public IActionResult Home()
        {
            ViewBag.Layout = new LayoutController().getHotel();
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                return View("HomeAdmin");
            }
            return View("Login", -2);
        }

        public IActionResult Admin()
        {
            ViewBag.Layout = new LayoutController().getHotel();
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;
                ViewBag.List = new AdministradorRN().lista_admins();

                return View("AdministrarAdmin");
            }
            return View("Login", -2);          
        }

        public JsonResult Insertar(string user, string pass, int rol)
        {

            int result = new AdministradorRN().insertarAdmin(user, pass, rol);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Admin", "Administrador") });
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

        public JsonResult Modificar(int idAdmin, string usere, string passe, int role)
        {

            int result = new AdministradorRN().modificarAdmin(idAdmin, usere, passe, role);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Admin", "Administrador") });
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

            int result = new AdministradorRN().eliminarAdmin(id);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Admin", "Administrador") });
            }
            else
            {
                return Json(new { success = false, inserted = false });
            }

        }

    }
}
