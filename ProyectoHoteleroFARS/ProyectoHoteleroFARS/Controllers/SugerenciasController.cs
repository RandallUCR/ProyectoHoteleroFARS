using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class SugerenciasController : Controller
    {
        public IActionResult Sugerencia()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            return View("Sugerencias");
        }

        public JsonResult RegistrarSugerencia(string sug)
        {
            int result = new SugerenciaRN().registrarSugerencia(sug);

            if (result == 1)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }

        }
    }
}
