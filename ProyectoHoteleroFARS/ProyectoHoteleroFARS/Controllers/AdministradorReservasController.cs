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
    public class AdministradorReservasController : Controller
    {
        public IActionResult Lista_Reservar()
        {
            ViewBag.Layout = new LayoutController().getHotel();

            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            {
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                List<Reserva> r = new ReservaAdminRN().lista_reservas();
                ViewBag.Reservas = r;
                ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;
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

            int result = new ReservaAdminRN().modificarReserva(id, cedula, nombre, apellidos, email, tarjeta, fechaUno, fechaDos, tipo);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Lista_Reservar", "AdministradorReservas") });
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

            int result = new ReservaAdminRN().eliminarReserva(id);

            if (result == 1)
            {
                return Json(new { success = true, url = Url.Action("Lista_Reservar", "AdministradorReservas") });
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
            Console.WriteLine("c");
            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            Guid g = Guid.NewGuid();
            string aux = Guid.NewGuid() + "";
            string id_res = aux.Substring(0, 13);
            int trans = new Random().Next(10000, 99999);

            int result = new ReservaAdminRN().insertarReserva(cedula, nombre, apellidos, email, tarjeta, fechaUno, fechaDos, tipo, pago, id_res, trans + "");

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Lista_Reservar", "AdministradorReservas") });
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
                List<Reserva> r = new ReservaAdminRN().lista_reservas_filtro(fechaUno, fechaDos);
                ViewBag.Reservas = r;
                ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;
                return View("ListaReservar");
            }

            return View("Login", -2);
        }
    }
}
