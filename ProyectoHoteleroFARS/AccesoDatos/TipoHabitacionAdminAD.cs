using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class TipoHabitacionAdminAD : ConexionAD
    {
        public string getTiposHabitaciones()
        {
            TipoHabitacion th = new TipoHabitacion();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_tipos");
                if (dr != null)
                {
                    dr.Read();
                    th.TN_Id = int.Parse(dr[0].ToString());
                    th.TC_Nombre = dr[1].ToString();
                    th.TC_Descripcion = dr[2].ToString();
                }
            }
            catch (SqlException e) { }

            return JsonConvert.SerializeObject(th);
        }

        /*public string getHabitacionesByTipo(int id)
        {
            TipoHabitacion th = new TipoHabitacion();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_tipos");
                if (dr != null)
                {
                    dr.Read();
                    th.TN_Id = int.Parse(dr[0].ToString());
                    th.TC_Nombre = dr[1].ToString();
                    th.TC_Descripcion = dr[2].ToString();
                }
            }
            catch (SqlException e) { }

            return JsonConvert.SerializeObject(th);
        }*/
    }
}
