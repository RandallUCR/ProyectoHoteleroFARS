using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;

namespace ReglasNegocio
{
    public class HotelRN
    {
        public Hotel getHotel()
        {
            HotelAD had = new HotelAD();
            string respuesta = null;
            Hotel h = new Hotel();
            try
            {
                respuesta = had.getHotel();
                if (respuesta != null)
                {
                    h = JsonConvert.DeserializeObject<Hotel>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return h;
        }

        public int modificarSobreNosotrosRN(Hotel hotel) {
            return new HotelAD().modificarSobreNosotrosAD(hotel);
        }

        public int modificarHomeDescripcionRN(Hotel hotel)
        {
            return new HotelAD().modificarHomeDescripcionAD(hotel);
        }
       
        public int modificarComoLLegarRN(Hotel hotel)
        {
            return new HotelAD().modificarComoLLegarAD(hotel);
        }
        public int modificarFotoRN(Hotel hotel)
        {
            return new HotelAD().modificarFotoAD(hotel);
        }
    }
}
