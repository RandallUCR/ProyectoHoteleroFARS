using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class EstadoHotelRN{

        public List<Habitacion> getEstadoHotelHoyRN() {
            return new EstadoHotelAD().getEstadoHotelHoyAD();
        }

    }
}
