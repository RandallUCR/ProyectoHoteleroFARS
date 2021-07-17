using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministradorCaracteristicasController : Controller
    {
        public JsonResult Index(int id)
        {
            HttpContext.Session.SetInt32("TipoActualCaractId", id);
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualCaractId");
            return Json(new { url = Url.Action("Vista", "AdministradorCaracteristicas", new { id = tipo }) });

        }

        public IActionResult Vista(int id)
        {
            ViewBag.Layout = new LayoutController().getHotel();
            ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

            ViewBag.List = new CaracteristicaAdminRN().getTiposHabitacionCaract(id);
            return View("Index", id);
        }

        public JsonResult Insertar(string desc)
        {
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualCaractId");
            int result = new CaracteristicaAdminRN().insertarCaracteristica(desc, tipo);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Vista", "AdministradorCaracteristicas", new { id = tipo }) });
            }
            else
            {
                return Json(new { success = false, inserted = false });
            }

        }

        public JsonResult Modificar(int idCaract, string desce)
        {
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualCaractId");
            int result = new CaracteristicaAdminRN().modificarCaracteristica(idCaract, desce);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Vista", "AdministradorCaracteristicas", new { id = tipo }) });
            }
            else
            {
                return Json(new { success = false, inserted = false });
            }

        }

        public JsonResult Eliminar(int id)
        {
            int tipo = (int)HttpContext.Session.GetInt32("TipoActualCaractId");
            int result = new CaracteristicaAdminRN().eliminarCaracteristica(id);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Vista", "AdministradorCaracteristicas", new { id = tipo }) });
            }
            else
            {
                return Json(new { success = false, inserted = false });
            }

        }
    }
}
