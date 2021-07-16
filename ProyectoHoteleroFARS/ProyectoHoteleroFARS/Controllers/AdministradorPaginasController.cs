using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministradorPaginasController : Controller
    {
        public IActionResult AdministrarPaginas()
        {
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

                ViewBag.Hotel = h;
                //cargar el texto de como llegar
                return View("ModificarPaginas");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }

        public int modificarSobreNosotros(string sobreNosotros)
        {
            return new HotelRN().modificarSobreNosotrosRN(new Hotel { TC_Sobre_Nosotros = sobreNosotros });
        }
        public int modificarHomeDescripcion(string descripcion)
        {
            return new HotelRN().modificarHomeDescripcionRN(new Hotel { TC_Descripcion = descripcion });
        }
        public int modificarComoLlegar(string maps, string ubicacion)
        {
            return new HotelRN().modificarComoLLegarRN(new Hotel { TC_Maps=maps, TC_Ubicacion = ubicacion});
        }

        public int guardarImagenGaleria(string base64, string formato)
        {
            return new GaleriaRN().guardarImagenGaleriaRN(new Galeria { TC_Descripcion = "desc", TV_Archivo = base64, TC_Formato = formato });
        }

        public int eliminarImagenGaleria(int idImg)
        {
            return new GaleriaRN().eliminarImagenGaleriaRN(idImg);
        }

        public int guardarNuevaFacilidad(string base64, string formato, string descF)
        {

            Facilidad facilidad = new Facilidad();
            facilidad.TC_Descripcion = descF;
            facilidad.galeria = new Galeria();
            facilidad.galeria.TC_Formato = formato;
            facilidad.galeria.TV_Archivo = base64;

            return new FacilidadRN().guardarNuevaFacilidadRN(facilidad);
        }

        public int editarFacilidad(int idFac, string descripcion)
        {
            Facilidad facilidad = new Facilidad();
            facilidad.TN_Id = idFac;
            facilidad.TC_Descripcion = descripcion;
            return new FacilidadRN().editarFacilidadRN(facilidad);
        }

        public int eliminarFacilidad(int idFac)
        {
            Facilidad facilidad = new Facilidad();
            facilidad.TN_Id = idFac;
            return new FacilidadRN().eliminarFacilidadRN(facilidad);
        }

        public JsonResult actualizarTablaFacilidades() {
            FacilidadRN frn = new FacilidadRN();
            string lista = JsonConvert.SerializeObject(frn.getFacilidadRN());
            return Json(new { resultado = lista });
        }

        public JsonResult actualizarTablaGaleria() {
            GaleriaRN grn = new GaleriaRN();
            string lista = JsonConvert.SerializeObject(grn.getGaleria());
            return Json(new { resultado = lista });
        }
    }
}
