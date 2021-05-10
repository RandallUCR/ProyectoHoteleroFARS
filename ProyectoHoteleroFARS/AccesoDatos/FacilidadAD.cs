using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class FacilidadAD : ConexionAD{

        public string getFacilidadAD() {
            List<Facilidad> data = new List<Facilidad>();
            try{

                SqlDataReader dr = consultar($"EXEC sp_get_facilidad");
                if (dr != null){

                    while (dr.Read()){

                        Facilidad facilidad = new Facilidad();
                        facilidad.TN_Id = int.Parse(dr[0].ToString());
                        facilidad.TC_Descripcion = dr[1].ToString();
                        facilidad.TN_Id_Hotel = int.Parse(dr[2].ToString());
                        facilidad.galeria.TC_Descripcion = dr[3].ToString();
                        facilidad.galeria.TC_Formato = dr[4].ToString();
                        facilidad.galeria.TV_Archivo = dr[5].ToString();

                        data.Add(facilidad);
                    }
                }else{
                    data.Add(null);
                }
            }catch (SqlException e){
                data.Add(null);
            }
            return JsonConvert.SerializeObject(data);
        }

    }
}
