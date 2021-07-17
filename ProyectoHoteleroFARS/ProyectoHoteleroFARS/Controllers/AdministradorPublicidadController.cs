using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReglasNegocio;

namespace ProyectoHoteleroFARS.Controllers
{
    public class AdministradorPublicidadController : Controller
    {
        public IActionResult AdministrarPublicidad(){
            ViewBag.Layout = new LayoutController().getHotel(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
            if (HttpContext.Session.GetInt32("AdminActualId") != null)
            { //este if debe aparecer en todas las acciones del administrador
                ViewBag.Usuario = ((string)HttpContext.Session.GetString("AdminActualUsuario")).ToUpper(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL ADMIN******
                ViewBag.Publicidad = new PublicidadRN().getVallaPublicitaria();
                int rol = (int)HttpContext.Session.GetInt32("AdminActualRol");
                ViewBag.RolActual = rol;
                return View("AdministrarPublicidad");
            }
            return View("Login", -2); //este return debe aparecer en todas las acciones del administrador
        }

        public int guardarNuevaPublicidad(string base64, string formato, string linkP) {
            Publicidad pub = new Publicidad();
            pub.galeria = new Galeria();
            pub.TC_Link = linkP;
            pub.galeria.TV_Archivo = base64;
            pub.galeria.TC_Formato = formato;
            return new PublicidadRN().guardarNuevaPublicidadRN(pub);
        }

        public int eliminarPublicidad(int id) {
            return new PublicidadRN().eliminarPublicidadRN(new Publicidad { TN_Id = id });
        }

        public int editarLinkPublicidad(int id, string linkP) {
            return new PublicidadRN().editarLinkPublicidadRN(new Publicidad { TN_Id = id , TC_Link = linkP});
        }

        public JsonResult actualizarTablaPublicidad() {
            string lista = JsonConvert.SerializeObject(new PublicidadRN().getVallaPublicitaria());
            return Json(new { resultado = lista});
        }
    }
}
