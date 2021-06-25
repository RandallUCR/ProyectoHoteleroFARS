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

        public int registrarSugerencia(string sug)
        {
            HotelAD had = new HotelAD();
            int result = 2;

            try
            {
                result = had.registrarSugerencia(sug);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 2;
            }

            return result;
        }


    }
}
