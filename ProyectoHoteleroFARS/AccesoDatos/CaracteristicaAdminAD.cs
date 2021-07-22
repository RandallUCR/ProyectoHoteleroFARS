using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class CaracteristicaAdminAD: ConexionAD
    {

        public string getTipoHabitacionCaract(int id)
        {
            List<Caracteristica> data = new List<Caracteristica>();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_CaractTipo {id}");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Caracteristica c = new Caracteristica();
                        c.TN_Id = int.Parse(dr[0].ToString());
                        c.TC_Descripcion = dr[1].ToString();



                        data.Add(c);
                    }
                }
                else
                {
                    data.Add(null);
                }
            }
            catch (SqlException e)
            {
                data.Add(null);
            }
            return JsonConvert.SerializeObject(data);
        }

        public int insertarCaracteristica(Caracteristica c)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_caract '{c.TC_Descripcion}',{c.TN_Id_Tipo}");
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

        public int modificarCaracteristica(Caracteristica c)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_edit_caract {c.TN_Id},'{c.TC_Descripcion}'");
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

        public int eliminarCaracteristica(int id)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_caract {id}");
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
