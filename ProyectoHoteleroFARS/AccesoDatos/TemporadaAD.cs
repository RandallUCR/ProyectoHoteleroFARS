using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class TemporadaAD : ConexionAD
    {
        public string lista_temporadas()
        {
            List<Temporada> lista = new List<Temporada>();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_temps");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Temporada t = new Temporada();

                        t.TN_Id = int.Parse(dr[0].ToString());

                        int aux = dr[1].ToString().IndexOf(" ");
                        String aux2 = dr[1].ToString().Substring(0, aux);
                        t.TF_Inicio = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        aux = dr[2].ToString().IndexOf(" ");
                        aux2 = dr[2].ToString().Substring(0, aux);
                        t.TF_Final = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        t.TN_Porcentaje = int.Parse(dr[3].ToString());

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

        public int insertarTemporada(Temporada t)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_temp '{t.TF_Inicio}', '{t.TF_Final}',{t.TN_Porcentaje}");
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

        public int modificarTemporada(Temporada t)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_edit_temp '{t.TF_Inicio}', '{t.TF_Final}',{t.TN_Porcentaje},{t.TN_Id}");
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

        public int eliminarTemporada(int id)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_temp {id}");
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
