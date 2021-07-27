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
    public class AdministradorSugerenciasController : Controller{

        public IActionResult AdministrarSugerencias() {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null){ //este if debe aparecer en todas las acciones del administrador
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                ViewBag.Sugerencias = new SugerenciaRN().getSugerenciasRN();
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;
                return View("AdministrarSugerencias");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }

        public int eliminarSugerencia(int id){
            Sugerencia sug = new Sugerencia();
            sug.TN_Id = id;
            return new SugerenciaRN().eliminarSugerenciaRN(sug);
        }

        public JsonResult actualizarTablaSugerencias() {
            SugerenciaRN srn = new SugerenciaRN();
            string lista = JsonConvert.SerializeObject(srn.getSugerenciasRN());
            return Json(new { resultado = lista });
        }

        public IActionResult AdministrarSugerenciasFiltro(string rangofechasNo)
        {
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            { //este if debe aparecer en todas las acciones del administrador

                string fechaUno = rangofechasNo.Substring(0, 10);
                string fechaDos = rangofechasNo.Substring(13);

                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                ViewBag.Sugerencias = new SugerenciaRN().getSugerenciasFiltro(fechaUno,fechaDos);
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;
                return View("AdministrarSugerencias");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }
    }
}
