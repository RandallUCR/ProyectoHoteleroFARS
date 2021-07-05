using Entidades;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class PublicidadAD : ConexionAD
    {

        public string getPublicidad(){
            List<Publicidad> data = new List<Publicidad>();
            try{
                SqlDataReader dr = consultar($"EXEC get_Publicidad");
                if (dr != null){
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
                }else{
                    data.Add(null);
                }
            }catch (SqlException e){
                data.Add(null);
            }
            return JsonConvert.SerializeObject(data);
        }

        //sp_create_publicidad
        public int guardarNuevaPublicidadAD(Publicidad pub) {
            int result = -2;
            try{
                SqlDataReader dr = consultar($"EXEC sp_create_publicidad '{pub.TC_Link}', '{pub.galeria.TV_Archivo}', '{pub.galeria.TC_Formato}'");
                if (dr != null){
                    dr.Read();
                    result = int.Parse(dr[0].ToString());
                }else{
                    return -3;
                }
            }catch (SqlException e){
                return -4;
            }
            return result;
        }

        public int eliminarPublicidadAD(Publicidad pub) {
            //sp_delete_publicidad
            int result = -2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_delete_publicidad {pub.TN_Id}");
                if (dr != null){
                    dr.Read();
                    result = int.Parse(dr[0].ToString());
                }else{
                    return -3;
                }
            }
            catch (SqlException e)
            {
                return -4;
            }
            return result;
        }

        public int editarLinkPublicidadAD(Publicidad pub) {
            //sp_update_link_publicidad
            int result = -2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_update_link_publicidad {pub.TN_Id}, '{pub.TC_Link}'");
                if (dr != null)
                {
                    dr.Read();
                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    return -3;
                }
            }
            catch (SqlException e)
            {
                return -4;
            }
            return result;
        }

    }
}
