using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministradorTemporadasController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Layout = new LayoutController().getHotel();
            ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
            ViewBag.RolActual = rol;
            ViewBag.List = new TemporadaRN().lista_reservas();
            return View("Index");
        }

        public JsonResult Insertar(string rangofechas, int porcentaje)
        {
            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            int result = new TemporadaRN().insertarTemporada(fechaUno, fechaDos, porcentaje);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministradorTemporadas") });
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

        public JsonResult Editar(int idTemp, string rangofechas, int porcentaje)
        {
            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            int result = new TemporadaRN().modificarTemporada(fechaUno, fechaDos, porcentaje, idTemp);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministradorTemporadas") });
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
            int result = new TemporadaRN().eliminarTemporada(id);

            if (result == 1)
            {
                return Json(new { success = true, url = Url.Action("Index", "AdministradorTemporadas") });
            }
            else
            {                
                return Json(new { success = false});
            }

        }
    }
}
