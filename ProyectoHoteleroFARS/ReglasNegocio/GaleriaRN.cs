using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class GaleriaRN
    {
        public List<Galeria> getGaleria()
        {
            GaleriaAD pad = new GaleriaAD();
            string respuesta = null;
            List<Galeria> p = new List<Galeria>();
            try
            {
                respuesta = pad.getGaleria();
                if (respuesta != null)
                {
                    p = JsonConvert.DeserializeObject<List<Galeria>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return p;

        }
    }
}
