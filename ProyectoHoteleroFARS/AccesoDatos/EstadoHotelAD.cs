using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class EstadoHotelAD : ConexionAD{

        public List<Habitacion> getEstadoHotelHoyAD() {
            List<Habitacion> data = new List<Habitacion>();
            try
            {

                SqlDataReader dr = consultar($"EXEC sp_get_estado_habitaciones_hoy");
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        Habitacion habitacion = new Habitacion();
                        habitacion.tipo = new TipoHabitacion();

                        habitacion.TN_Id = int.Parse(dr[0].ToString());
                        habitacion.TN_Numero = int.Parse(dr[1].ToString());
                        habitacion.TB_Estado = true;
                        if (int.Parse(dr[2].ToString()) == 0) {
                            habitacion.TB_Estado = false;
                        }
                        habitacion.tipo.TC_Nombre = dr[3].ToString();
                        habitacion.TC_Estado = dr[4].ToString();

                        data.Add(habitacion);
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
            return data;
        }

    }
}
