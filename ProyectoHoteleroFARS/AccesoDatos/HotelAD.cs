using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class HotelAD : ConexionAD
    {

        public string getHotel()
        {
            string data = "";

            try
            {
                SqlDataReader dr = consultar($"EXEC get_Hotel");
                if (dr != null)
                {
                   dr.Read();
                    data = JsonConvert.SerializeObject(new
                    {
                        TN_Id = int.Parse(dr[0].ToString()),
                        TC_Nombre = dr[1].ToString(),
                        TC_Descripcion = dr[2].ToString(),
                        TC_Sobre_Nostros = dr[3].ToString(),
                        TC_Ubicacion = dr[4].ToString(),
                        TC_Maps = dr[5].ToString(),
                        TN_Cod_Postal = int.Parse(dr[6].ToString()),
                        TC_Logo = dr[7].ToString(),
                        TC_Foto_Principal = dr[8].ToString()
                    });

                }
                else
                {
                    data = "Error";
                }
            }
            catch (SqlException e)
            {
                data = "Error " + e.Message;
            }
            return data;
        }

    }
}
