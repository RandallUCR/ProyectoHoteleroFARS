using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class ReservaAD : ConexionAD
    {
        public string verificar(string fechaUno, string fechaDos, int tipo, decimal dolar)
        {
            TipoHabitacion t = new TipoHabitacion();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_verificar_habitacion '{fechaUno}', '{fechaDos}', {tipo}");
                if (dr != null)
                {
                    dr.Read();

                    t.TN_Id = int.Parse(dr[0].ToString());
                    t.TC_Descripcion = dr[1].ToString();
                    t.TN_Precio = decimal.Parse(dr[4].ToString());

                    Galeria g = new Galeria();
                    g.TV_Archivo = dr[2].ToString();
                    g.TC_Formato = dr[3].ToString();

                    t.galeria = g;
                    t.TN_Precio_Dolares = decimal.Round(Decimal.Divide(t.TN_Precio, dolar), 1);
                }
                else
                {
                    t = null;
                }
            }
            catch (SqlException e)
            {
                t = null;
            }
            return JsonConvert.SerializeObject(t);
        }

        public string reservar(string cedula, string nombre, string apellidos, string correo, string tarjeta, string id_res, int trans, string fechaUno, string fechaDos, int id, string precio)
        {
            ConfirmacionReserva c = new ConfirmacionReserva();
            try
            {
                decimal aux = decimal.Parse(precio);
                SqlDataReader dr = consultar($"EXEC sp_reservar '{id_res}',{trans} , '{fechaUno}', '{fechaDos}', {id}, '{cedula}', '{nombre}', " +
                    $"'{apellidos}', '{correo}', {tarjeta},{aux}");
                if (dr != null)
                {
                    dr.Read();

                    c.TN_Id = int.Parse(dr[0].ToString());
                    c.TC_Nombre = dr[1].ToString();
                    c.TC_Apellidos = dr[2].ToString();
                    c.TC_Correo = dr[3].ToString();
                    c.TC_Id_Reserva = dr[4].ToString();
                }
                else
                {
                    c = null;
                }
            }
            catch (SqlException e)
            {
                c = null;
            }
            return JsonConvert.SerializeObject(c);
        }
    }
}
