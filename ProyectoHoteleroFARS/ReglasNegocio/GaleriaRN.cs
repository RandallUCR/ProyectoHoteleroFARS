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

        public int guardarImagenGaleriaRN(Galeria galeria) {
            return new GaleriaAD().guardarImagenGaleriaAD(galeria);
        }

        public int eliminarImagenGaleriaRN(int id) {
            return new GaleriaAD().eliminarImagenGaleriaAD(id);
        }
    }
}
