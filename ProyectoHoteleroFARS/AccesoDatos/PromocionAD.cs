using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class PromocionAD : ConexionAD
    {
        public string lista_promociones()
        {
            List<TipoHabitacion> lista = new List<TipoHabitacion>();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_promos");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        TipoHabitacion t = new TipoHabitacion();

                        t.TN_Id = int.Parse(dr[4].ToString());
                        t.TC_Nombre = dr[5].ToString();

                        Promocion p = new Promocion();

                        p.TN_Id = int.Parse(dr[0].ToString());
                        p.TN_Porcentaje = int.Parse(dr[1].ToString());

                        int aux = dr[2].ToString().IndexOf(" ");
                        String aux2 = dr[2].ToString().Substring(0, aux);
                        p.TF_Inicio = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        aux = dr[3].ToString().IndexOf(" ");
                        aux2 = dr[3].ToString().Substring(0, aux);
                        p.TF_Final = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        t.promocion = p;
                        
                        lista.Add(t);
                    }

                }
                else
                {
                    lista = null;

                }
            }
            catch (SqlException e)
            {
                lista = null;
            }
            return JsonConvert.SerializeObject(lista);
        }

        public int insertarPromocion(TipoHabitacion p)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_promo '{p.promocion.TF_Inicio}', '{p.promocion.TF_Final}', {p.promocion.TN_Porcentaje}, {p.TN_Id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public int modificarPromocion(TipoHabitacion p)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_edit_promo '{p.promocion.TF_Inicio}', '{p.promocion.TF_Final}', {p.promocion.TN_Porcentaje}, {p.TN_Id},{p.promocion.TN_Id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public int eliminarPromocion(int id)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_promo {id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 2;
                }
            }
            catch (SqlException e)
            {
                result = 2;
            }
            return result;
        }
    }
}
