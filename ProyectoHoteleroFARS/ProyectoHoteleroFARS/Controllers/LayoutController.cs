using Entidades;
using Microsoft.AspNetCore.Mvc;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHoteleroFARS.Controllers
{
    public class LayoutController : Controller
    {

        public Hotel getHotel()
        {
            HotelRN hrn = new HotelRN();
            return hrn.getHotel();
        }

        public Publicidad getPublicidad()
        {
            PublicidadRN prn = new PublicidadRN();
            return prn.getVallaPublicitaria();
        }

        public Layout getLayout()
        {
            Layout l = new Layout();
            l.hotel = getHotel();
            l.publicidad = getPublicidad();

            return l;
        }
        
    }
}
