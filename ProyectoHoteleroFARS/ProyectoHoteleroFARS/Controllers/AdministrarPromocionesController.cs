using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministrarPromocionesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Layout = new LayoutController().getHotel();
            ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******

            ViewBag.Tipos = new TipoHabitacionRN().getTiposHabitacionTemp();
            ViewBag.List = new PromocionRN().lista_promociones();
            int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
            ViewBag.RolActual = rol;
            return View("Index");
        }

        public JsonResult Insertar(string rangofechas, int porcentaje, int tipo)
        {
            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            int result = new PromocionRN().insertarPromocion(fechaUno, fechaDos, porcentaje, tipo);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministrarPromociones") });
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

        public JsonResult Editar(string rangofechas, int porcentaje, int tipo, int idProm)
        {
            string fechaUno = rangofechas.Substring(0, 10);
            string fechaDos = rangofechas.Substring(13);

            int result = new PromocionRN().modificarPromocion(fechaUno, fechaDos, porcentaje, tipo, idProm);

            if (result == 1)
            {
                return Json(new { success = true, inserted = true, url = Url.Action("Index", "AdministrarPromociones") });
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
            int result = new PromocionRN().eliminarPromocion(id);

            if (result == 1)
            {
                return Json(new { success = true, url = Url.Action("Index", "AdministrarPromociones") });
            }
            else
            {
                return Json(new { success = false });
            }

        }
    }
}
