using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class PromocionRN
    {
        public List<TipoHabitacion> lista_promociones()
        {
            PromocionAD rad = new PromocionAD();
            List<TipoHabitacion> lista = new List<TipoHabitacion>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_promociones();
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<TipoHabitacion>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lista;
        }

        public int insertarPromocion(string fechai, string fechaf, int porcentaje, int tipo)
        {
            PromocionAD rad = new PromocionAD();
            int result = 3;
            try
            {
                result = rad.insertarPromocion(new TipoHabitacion() { TN_Id = tipo, promocion = new Promocion() { TF_Inicio = fechai, TF_Final = fechaf, TN_Porcentaje = porcentaje} });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int modificarPromocion(string fechai, string fechaf, int porcentaje, int tipo, int idPromo)
        {
            PromocionAD rad = new PromocionAD();
            int result = 3;
            try
            {
                result = rad.modificarPromocion(new TipoHabitacion() { TN_Id = tipo, promocion = new Promocion() { TN_Id = idPromo, TF_Inicio = fechai, TF_Final = fechaf, TN_Porcentaje = porcentaje } });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int eliminarPromocion(int id)
        {
            PromocionAD rad = new PromocionAD();
            int result = 2;
            try
            {
                result = rad.eliminarPromocion(id);

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
