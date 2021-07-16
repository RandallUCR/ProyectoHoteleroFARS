using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class SugerenciaAD : ConexionAD
    {
        public int registrarSugerencia(string sug){
            int result = 2;
            try{
                SqlDataReader dr = consultar($"EXEC sp_sugerencia '{sug}'");
                if (dr != null){
                    dr.Read();

                    result = int.Parse(dr[0].ToString());

                }else{
                    result = 2;
                }
            }catch (SqlException e){
                result = 2;
            }
            return result;
        }

        public string getSugerenciasAD() {
            List<Sugerencia> data = new List<Sugerencia>();
            try{
                SqlDataReader dr = consultar($"EXEC sp_get_sugerencias");
                if (dr != null){
                    while (dr.Read()){
                        Sugerencia sugerencia = new Sugerencia();
                        sugerencia.TN_Id = int.Parse(dr[0].ToString());
                        sugerencia.TC_Sugerencia = dr[1].ToString();
                        sugerencia.TF_Fecha = dr[2].ToString();
                        data.Add(sugerencia);
                    }
                }else{
                    data.Add(null);
                }
            }catch (SqlException e){
                data.Add(null);
            }
            return JsonConvert.SerializeObject(data);
        }

        public int eliminarSugerenciaAD(Sugerencia sug) {
            int result = -2;
            try{
                SqlDataReader dr = consultar($"EXEC sp_delete_sugerencia {sug.TN_Id}");
                if (dr != null){
                    dr.Read();
                    result = int.Parse(dr[0].ToString());
                }else{
                    result = -3;
                }
            }catch (SqlException e){
                result = -4;
            }
            return result;
        }

        public string getSugerenciasFiltro(string fechai, string fechaf)
        {
            List<Sugerencia> data = new List<Sugerencia>();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_filtro_sugerencias'{fechai}','{fechaf}'");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Sugerencia sugerencia = new Sugerencia();
                        sugerencia.TN_Id = int.Parse(dr[0].ToString());
                        sugerencia.TC_Sugerencia = dr[1].ToString();
                        sugerencia.TF_Fecha = dr[2].ToString();
                        data.Add(sugerencia);
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
