using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos 
{
    public class PublicidadAD : ConexionAD
    {

        public string getPublicidad()
        {
            List<Publicidad> data = new List<Publicidad>();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_Publicidad");
                if (dr != null)
                {
                    while (dr.Read()) {
                        Publicidad p = new Publicidad();
                        p.TN_Id = int.Parse(dr[0].ToString());
                        p.TC_Link = dr[1].ToString();

                        Galeria g = new Galeria();
                        g.TC_Formato = dr[2].ToString();
                        g.TV_Archivo = dr[3].ToString();

                        p.galeria = g;

                        data.Add(p);
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

    }
}
