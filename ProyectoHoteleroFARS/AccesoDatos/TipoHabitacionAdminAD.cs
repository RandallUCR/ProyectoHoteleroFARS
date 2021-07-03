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

        public int insertarTiposHabitaciones(TipoHabitacion t)
        {
            int result = -3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_tipo_habi '{t.TC_Nombre}','{t.TC_Descripcion}',{t.TN_Precio},'{t.galeria.TV_Archivo}','{t.galeria.TC_Formato}'");
                if (dr != null)
                {
                    dr.Read();
                    result = int.Parse(dr[0].ToString());
                }
            }
            catch (SqlException e) {
                result = -3;
            }

            return result;
        }

        public int eliminarTiposHabitaciones(int id)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_tipo_habi {id}");
                if (dr != null)
                {
                    dr.Read();
                    result = int.Parse(dr[0].ToString());
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }

            return result;
        }

    }
}
