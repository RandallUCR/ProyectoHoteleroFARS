using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class HabitacionAdminAD : ConexionAD
    {
        public string getHabitacionesByTipo(int id)
        {
            List<Habitacion> list = new List<Habitacion>();
            
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_habitaciones {id}");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Habitacion h = new Habitacion();

                        h.TN_Id = int.Parse(dr[0].ToString());
                        h.TN_Numero = int.Parse(dr[1].ToString());
                        h.TB_Estado = int.Parse(dr[2].ToString());

                        list.Add(h);
                    }
                                       
                }
            }
            catch (SqlException e) {
                list = null;
            }

            return JsonConvert.SerializeObject(list);
        }
    }
}
