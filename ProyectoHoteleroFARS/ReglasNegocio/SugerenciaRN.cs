using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class SugerenciaRN
    {
        public int registrarSugerencia(string sug) {
            SugerenciaAD sad = new SugerenciaAD();
            int result = 2;
            try {
                result = sad.registrarSugerencia(sug);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                result = 2;
            }
            return result;
        }

        public List<Sugerencia> getSugerenciasRN() {
            List<Sugerencia> lista = new List<Sugerencia>();
            SugerenciaAD sad = new SugerenciaAD();
            string respuesta = null;
            try {
                respuesta = sad.getSugerenciasAD();
                if (respuesta != null) {
                    lista = JsonConvert.DeserializeObject<List<Sugerencia>>(respuesta);
                }
            } catch (Exception e) {
            }
            return lista;
        }

        public int eliminarSugerenciaRN(Sugerencia sug){
            return new SugerenciaAD().eliminarSugerenciaAD(sug);
        }

        public List<Sugerencia> getSugerenciasFiltro(string fechai, string fechaf)
        {
            List<Sugerencia> lista = new List<Sugerencia>();
            SugerenciaAD sad = new SugerenciaAD();
            string respuesta = null;
            try
            {
                respuesta = sad.getSugerenciasFiltro(fechai, fechaf);
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<Sugerencia>>(respuesta);
                }
            }
            catch (Exception e)
            {
            }
            return lista;
        }

    }
}
