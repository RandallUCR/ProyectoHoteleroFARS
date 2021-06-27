using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class TipoHabitacionAD : ConexionAD
    {

        public string getTipoHabitacionById(int id) {
            TipoHabitacion th = new TipoHabitacion { galeria = new Galeria() };
            try {
                SqlDataReader dr = consultar($"EXEC get_tipo_habitacion_by_id {id}");
                if (dr != null) {
                    dr.Read();
                    th.TN_Id = int.Parse(dr[0].ToString());
                    th.TC_Nombre = dr[1].ToString();
                    th.TC_Descripcion = dr[2].ToString();
                    th.TN_Precio = decimal.Parse(dr[3].ToString());
                    th.galeria.TC_Formato = dr[4].ToString();
                    th.galeria.TV_Archivo = dr[5].ToString();
                }
            } catch (SqlException e) {}

            return JsonConvert.SerializeObject(th);
        }

        public string getTiposHabitacionTemp()
        {
            List<TipoHabitacion> data = new List<TipoHabitacion>();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_Tipos_Habitacion");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        TipoHabitacion t = new TipoHabitacion();
                        t.TN_Id = int.Parse(dr[0].ToString());
                        t.TC_Nombre = dr[1].ToString();
                        t.TC_Descripcion = dr[2].ToString();
                        t.TN_Precio = decimal.Parse(dr[3].ToString());



                        data.Add(t);
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

        public string getTipoHabitacionCaract(int id)
        {
            List<Caracteristica> data = new List<Caracteristica>();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_CaractTipo {id}");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Caracteristica c = new Caracteristica();
                        c.TN_Id = int.Parse(dr[0].ToString());
                        c.TC_Descripcion = dr[1].ToString();



                        data.Add(c);
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

        public string getTipoHabitacionPromo(int id)
        {
            Promocion data = new Promocion();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_PromoTipo {id}");
                if (dr != null)
                {
                    dr.Read();                                      
                        data.TN_Id = int.Parse(dr[0].ToString());
                        data.TN_Porcentaje = int.Parse(dr[1].ToString());
                }
            }
            catch (SqlException e)
            {
                
            }
            return JsonConvert.SerializeObject(data);
        }

        public string getGaleriaTipoHabitacion(int id)
        {
            Galeria data = new Galeria();

            try
            {
                SqlDataReader dr = consultar($"EXEC get_GaleriaTipoHabi {id}");
                if (dr != null)
                {
                    dr.Read();
                    data.TN_Id = int.Parse(dr[0].ToString());
                    data.TC_Descripcion = dr[1].ToString();
                    data.TC_Formato = dr[2].ToString();
                    data.TV_Archivo = dr[3].ToString();
                }
            }
            catch (SqlException e)
            {

            }
            return JsonConvert.SerializeObject(data);
        }

    }
}
