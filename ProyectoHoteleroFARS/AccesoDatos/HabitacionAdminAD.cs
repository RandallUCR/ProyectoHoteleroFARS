using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class HabitacionAdminAD : ConexionAD
    {
        public string getHabitacionesByTipo(int id)
        {
            List<Habitacion> list = new List<Habitacion>();
            
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_habitaciones {id}");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Habitacion h = new Habitacion();

                        h.TN_Id = int.Parse(dr[0].ToString());
                        h.TN_Numero = int.Parse(dr[1].ToString());
                        h.TB_Estado = bool.Parse(dr[2].ToString());

                        TipoHabitacion t = new TipoHabitacion();
                        t.TN_Id = int.Parse(dr[3].ToString());
                        t.TC_Nombre = dr[4].ToString();

                        h.tipo = t;

                        list.Add(h);
                    }


                }
            }
            catch (SqlException e) {
                //list = null;               
            }
            return JsonConvert.SerializeObject(list);
        }

        public int insertarHabitacion(Habitacion h)
        {
            int result = 3;
            int aux = 0;
            if (h.TB_Estado)
            {
                aux = 1;
            }

            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_habitacion {h.TN_Numero}, {aux}, {h.tipo.TN_Id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public int modificarHabitacion(Habitacion h)
        {
            int result = 3;
            int aux = 0;
            if (h.TB_Estado)
            {
                aux = 1;
            }

            try
            {
                SqlDataReader dr = consultar($"EXEC sp_edit_habitacion {h.TN_Numero}, {aux}, {h.TN_Id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public int eliminarHabitacion(int id)
        {
            int result = 3;

            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_habitacion {id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public string getDisponibilidad(string fechai, string fechaf, int tipo)
        {
            List<Habitacion> list = new List<Habitacion>();

            try
            {
                SqlDataReader dr = consultar($"exec sp_get_disponibilidad_habitaciones_by_fechas '{fechai}','{fechaf}',{tipo}");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Habitacion h = new Habitacion();
                        h.TN_Numero = int.Parse(dr[0].ToString());
                        h.TC_Estado = dr[3].ToString();

                        TipoHabitacion t = new TipoHabitacion();
                        t.TC_Nombre = dr[1].ToString();
                        t.TN_Precio = decimal.Parse(dr[2].ToString());

                        h.tipo = t;

                        list.Add(h);
                    }


                }
            }
            catch (SqlException e)
            {
                //list = null;               
            }
            return JsonConvert.SerializeObject(list);
        }
    }
}
