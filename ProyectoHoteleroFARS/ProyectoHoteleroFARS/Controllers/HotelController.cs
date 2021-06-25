using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoHoteleroFARS.Models;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class HotelController : Controller
    {
        private readonly ILogger<HotelController> _logger;
        public HotelController(ILogger<HotelController> logger)
        {
            _logger = logger;
        }

        public IActionResult HomeCliente()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            Hotel h = new HotelRN().getHotel();
            ViewBag.Nombre = h.TC_Nombre;
            ViewBag.Descripcion = h.TC_Descripcion;
            ViewBag.FotoPrincipal = h.TC_Foto_Principal;
            return View("HomeCliente");
        }

        public IActionResult SobreNosotrosCliente()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            Hotel h = new HotelRN().getHotel();
            ViewBag.SobreNosotros = h.TC_Sobre_Nosotros;
            GaleriaRN gal = new GaleriaRN();
            ViewBag.Galeria = gal.getGaleria();
            return View("SobreNosotros");
        }

        public IActionResult FacilidadesCliente() {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            ViewBag.Facilidades = new FacilidadRN().getFacilidadRN();
            return View("Facilidades");
        }
        public IActionResult Contactenos()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            ViewBag.Contactenos = new ContactoRN().getContactosRN();
            return View("Contactenos");
        }

        public IActionResult ComoLlegarCliente() {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            Hotel h = new HotelRN().getHotel();
            ViewBag.Ubicacion = h.TC_Ubicacion;
            ViewBag.Maps = h.TC_Maps;
            return View("ComoLlegar");
        }

        public IActionResult Sugerencias()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            return View("Sugerencias");
        }

        public JsonResult RegistrarSugerencia(string sug)
        {
            int result = new HotelRN().registrarSugerencia(sug);

            if (result == 1)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
            
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
