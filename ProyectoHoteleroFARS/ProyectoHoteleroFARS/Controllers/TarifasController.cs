using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Xml;

namespace ProyectoHoteleroFARS.Controllers
{
    public class TarifasController : Controller
    {
        public IActionResult TarifasCliente()
        {
            ViewBag.Layout = new LayoutController().getLayout(); //NO BORRAR, AGREGAR ESTA LINEA PARA CADA VISTA DEL CLIENTE******
            ViewBag.TiposHabitacion = new TipoHabitacionRN().getTiposHabitacion(this.getCambioDolares());
            return View("TarifasCliente");
        }

        public decimal getCambioDolares()
        {
            string salida = "Nada";
            XmlDocument doc = new XmlDocument();
            doc.Load("https://gee.bccr.fi.cr/Indicadores/Suscripciones/WS/wsindicadoreseconomicos.asmx/ObtenerIndicadoresEconomicos?Indicador=318&FechaInicio="+ DateTime.Today.ToString("dd/MM/yyyy") + 
                "&FechaFinal=" + DateTime.Today.AddDays(1).ToString("dd/MM/yyyy") + "&Nombre=Randall&SubNiveles=N&CorreoElectronico=randallgears1998@gmail.com&Token=A90LC1E2RN");

            XmlNodeList elemList = doc.GetElementsByTagName("NUM_VALOR");
            for (int i = 0; i < elemList.Count; i++)
            {
                salida = elemList[i].InnerXml;
            }           
            return decimal.Parse(salida);
        }
    }
}
