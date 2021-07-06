using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class PublicidadRN
    {

        public List<Publicidad> getVallaPublicitaria()
        {
            PublicidadAD pad = new PublicidadAD();
            string respuesta = null;
            List<Publicidad> p = new List<Publicidad>();
            try
            {
                respuesta = pad.getPublicidad();
                if (respuesta != null)
                {
                    p = JsonConvert.DeserializeObject<List<Publicidad>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            /*if (p.Count > 1)
            {
                Random r = new Random();
                return p[r.Next(p.Count)];
            }
            else
            {
                if (p.Count == 1)
                {
                    return p[0];
                }
                else
                {
                    return null;
                }
            }*/
            return p;
        }

        public int guardarNuevaPublicidadRN(Publicidad pub) {
            return new PublicidadAD().guardarNuevaPublicidadAD(pub);
        }

        public int eliminarPublicidadRN(Publicidad pub) {
            return new PublicidadAD().eliminarPublicidadAD(pub);
        }

        public int editarLinkPublicidadRN(Publicidad pub) {
            return new PublicidadAD().editarLinkPublicidadAD(pub);
        }

    }
}
