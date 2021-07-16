using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class TemporadaRN
    {
        public List<Temporada> lista_reservas()
        {
            TemporadaAD rad = new TemporadaAD();
            List<Temporada> lista = new List<Temporada>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_temporadas();
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<Temporada>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lista;
        }

        public int insertarTemporada(string fechai, string fechaf, int porcentaje)
        {
            TemporadaAD rad = new TemporadaAD();
            int result = 3;
            try
            {
                result = rad.insertarTemporada(new Temporada() { TF_Inicio = fechai, TF_Final = fechaf, TN_Porcentaje = porcentaje});

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int modificarTemporada(string fechai, string fechaf, int porcentaje, int idTemp)
        {
            TemporadaAD rad = new TemporadaAD();
            int result = 3;
            try
            {
                result = rad.modificarTemporada(new Temporada() { TN_Id = idTemp ,TF_Inicio = fechai, TF_Final = fechaf, TN_Porcentaje = porcentaje });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int eliminarTemporada(int id)
        {
            TemporadaAD rad = new TemporadaAD();
            int result = 2;
            try
            {
                result = rad.eliminarTemporada(id);

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
