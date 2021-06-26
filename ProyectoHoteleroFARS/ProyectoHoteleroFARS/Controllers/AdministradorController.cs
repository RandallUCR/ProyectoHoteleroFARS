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

        public IActionResult Lista_Reservar()
        {
            ViewBag.Layout = new LayoutController().getHotel();

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                List<Reserva> r = new ReservaRN().lista_reservas();
                ViewBag.Reservas = r;
                ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();
                return View("ListaReservar");
            }

            return View("Login", -2);
        }

        public JsonResult ModificarReserva(int id, int cedula, string nombre, string apellidos, string email, string tarjeta, string rangofechas, int tipo)
        {
            /* ViewBag.Layout = new LayoutController().getHotel();
             ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
             List<Reserva> r = new ReservaRN().lista_reservas();
             ViewBag.Reservas = r;
             ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();*/

            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            int result = new ReservaRN().modificarReserva(id,cedula,nombre,apellidos,email,tarjeta,fechaUno,fechaDos,tipo);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Lista_Reservar", "Administrador") });
            }
            else
            {
                if (result == 2)
                {
                    return Json(new { success = true, inserted = false });
                }
                else
                {
                    if (result == 3)
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

        public JsonResult EliminarReserva(int id)
        {
            /* ViewBag.Layout = new LayoutController().getHotel();
             ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
             List<Reserva> r = new ReservaRN().lista_reservas();
             ViewBag.Reservas = r;
             ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();*/

            int result = new ReservaRN().eliminarReserva(id);

            if (result == 1)
            {
                return Json(new { success = true, url = Url.Action("Lista_Reservar", "Administrador") });
            }
            else
            {
                return Json(new { success = false });

            }

        }

        public JsonResult InsertarReserva(int cedula, string nombre, string apellidos, string email, string tarjeta, string rangofechas, int tipo, decimal pago)
        {
            /* ViewBag.Layout = new LayoutController().getHotel();
             ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
             List<Reserva> r = new ReservaRN().lista_reservas();
             ViewBag.Reservas = r;
             ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();*/

            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            Guid g = Guid.NewGuid();
            string aux = Guid.NewGuid() + "";
            string id_res = aux.Substring(0, 13);
            int trans = new Random().Next(10000, 99999);

            int result = new ReservaRN().insertarReserva(cedula, nombre, apellidos, email, tarjeta, fechaUno, fechaDos, tipo, pago,id_res,trans+"");

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Lista_Reservar", "Administrador") });
            }
            else
            {
                if (result == 2)
                {
                    return Json(new { success = true, inserted = false });
                }
                else
                {
                    if (result == 3)
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

        public IActionResult Lista_Reservar_Filtro(string rangofechasNo)
        {
            ViewBag.Layout = new LayoutController().getHotel();
            string fechaUno = rangofechasNo.Substring(0, 10);
            string fechaDos = rangofechasNo.Substring(13);

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                List<Reserva> r = new ReservaRN().lista_reservas_filtro(fechaUno, fechaDos);
                ViewBag.Reservas = r;
                ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();
                return View("ListaReservar");
            }

            return View("Login", -2);
        }
    }
}
