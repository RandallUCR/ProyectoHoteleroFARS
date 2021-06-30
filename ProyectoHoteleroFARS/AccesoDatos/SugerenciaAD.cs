using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class SugerenciaAD : ConexionAD
    {
        public int registrarSugerencia(string sug)
        {
            int result = 2;

            try
            {
                SqlDataReader dr = consultar($"EXEC sp_sugerencia '{sug}'");
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
