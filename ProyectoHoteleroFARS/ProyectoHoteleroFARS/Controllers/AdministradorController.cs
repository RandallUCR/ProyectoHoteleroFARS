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

        public IActionResult AdministrarHabitacion() {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null) { //este if debe aparecer en todas las acciones del administrador
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                return View("AdministrarHabitacion");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }

        public IActionResult AdministrarPaginas() {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            { //este if debe aparecer en todas las acciones del administrador
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                //cargar el texto de home
                //cargar el texto de sobre nosotros
                Hotel h = new HotelRN().getHotel();
                ViewBag.SobreNosotros = h.TC_Sobre_Nosotros;
                //cargar las fotos de la galería
                ViewBag.Galeria = new GaleriaRN().getGaleria();
                //cargar el texto de facilidades
                ViewBag.Facilidad = new FacilidadRN().getFacilidadRN();
                //cargar el texto de como llegar
                return View("ModificarPaginas");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }

        public int modificarSobreNosotros(string sobreNosotros) {
            return new HotelRN().modificarSobreNosotrosRN(new Hotel { TC_Sobre_Nosotros = sobreNosotros});
        }

        public int guardarImagenGaleria(string base64, string formato) {
            return new GaleriaRN().guardarImagenGaleriaRN(new Galeria { TC_Descripcion = "desc", TV_Archivo = base64, TC_Formato = formato });
        }

        public int eliminarImagenGaleria(int idImg) {
            return new GaleriaRN().eliminarImagenGaleriaRN(idImg);
        }

        public IActionResult CambiarDescripcion(int id) {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

            if (HttpContext.Session.GetInt32("AdminActualId") != null){
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
    }
}
