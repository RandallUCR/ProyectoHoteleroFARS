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
            if (a.TN_Id < 0)
            {               
                return View("Login", a.TN_Id);
                
            }
            else
            {
                HttpContext.Session.SetInt32("AdminActualId", a.TN_Id);
                HttpContext.Session.SetString("AdminActualUsuario",a.TC_Usuario);
                HttpContext.Session.SetInt32("AdminActualRol", a.rol.TN_Id);

                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper();
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
            HttpContext.Session.SetInt32("AdminActualId", -1);
            HttpContext.Session.SetString("AdminActualUsuario", "");
            HttpContext.Session.SetInt32("AdminActualRol", -1);

            ViewBag.Layout = new LayoutController().getHotel();
            return View("Login");
        }
    }
}
