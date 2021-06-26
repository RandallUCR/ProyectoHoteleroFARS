using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class GaleriaAD:ConexionAD
    {
        public string getGaleria()
        {
            List<Galeria> data = new List<Galeria>();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_Galeria");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Galeria p = new Galeria();
                        p.TN_Id = int.Parse(dr[0].ToString());
                        p.TC_Descripcion = dr[1].ToString();
                        p.TC_Formato = dr[2].ToString();
                        p.TV_Archivo = dr[3].ToString();

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

        public int guardarImagenGaleriaAD(Galeria galeria) {
            int respuesta = -1;
            try{
                SqlDataReader dr = consultar($"EXEC sp_add_img_galeria '{galeria.TC_Descripcion}', '{galeria.TV_Archivo}', '{galeria.TC_Formato}', {1}");
                if (dr != null){
                    dr.Read();
                    respuesta = int.Parse(dr[0].ToString());
                }else{
                    respuesta = -1;
                }
            }catch (SqlException e){
                respuesta = -2;
            }
            return respuesta;
        }

        public int eliminarImagenGaleriaAD(int id){
            int respuesta = -1;
            try{
                SqlDataReader dr = consultar($"EXEC sp_delete_img_galeria {id}");
                if (dr != null){
                    dr.Read();
                    respuesta = int.Parse(dr[0].ToString());
                }else{
                    respuesta = -1;
                }
            }catch (SqlException e){
                respuesta = -2;
            }
            return respuesta;
        }
    }
}
