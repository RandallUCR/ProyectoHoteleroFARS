﻿using Entidades;
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

        public string lista_reservas()
        {
            List<Reserva> lista = new List<Reserva>();
            try
            {
                SqlDataReader dr = consultar($"EXEC get_reservar");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Reserva r = new Reserva();
                        r.TN_Id = int.Parse(dr[0].ToString());

                        int aux = dr[1].ToString().IndexOf(" ");
                        String aux2 = dr[1].ToString().Substring(0, aux);
                        r.TF_Fecha = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        r.TC_Id_Reserva = dr[2].ToString();
                        r.TN_Tarjeta = dr[3].ToString();
                        r.TN_Transaccion = dr[4].ToString();

                        aux = dr[5].ToString().IndexOf(" ");
                        aux2 = dr[5].ToString().Substring(0, aux);
                        r.TF_Llegada = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        aux = dr[6].ToString().IndexOf(" ");
                        aux2 = dr[6].ToString().Substring(0, aux);
                        r.TF_Salida = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        Cliente c = new Cliente();
                        c.TN_Id = int.Parse(dr[7].ToString());
                        c.TC_Cedula = dr[8].ToString();
                        c.TC_Nombre = dr[9].ToString();
                        c.TC_Apellidos = dr[10].ToString();
                        c.TC_Email = dr[11].ToString();

                        TipoHabitacion t = new TipoHabitacion();
                        t.TN_Id = int.Parse(dr[12].ToString());
                        t.TC_Nombre = dr[13].ToString();

                        r.cliente = c;
                        r.tipo = t;

                        lista.Add(r);
                    }
                  
                }
                else
                {
                    lista = null;
                    
                }
            }
            catch (SqlException e)
            {
                lista = null;
            }
            return JsonConvert.SerializeObject(lista);
        }

        public int modificarReserva(int id, int cedula, string nombre, string apellidos, string email, string tarjeta, string llegada, string salida, int tipo)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"exec sp_editar_reserva {id},{cedula},'{nombre}','{apellidos}','{email}',{tarjeta},'{llegada}','{salida}',{tipo}");
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

        public int eliminarReserva(int id)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"exec sp_eliminar_reserva {id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 2;
                }
            }
            catch (SqlException e)
            {
                result = 2;
            }
            return result;
        }

        public int insertarReserva(int cedula, string nombre, string apellidos, string email, string tarjeta, string llegada, string salida, int tipo, decimal pago, string id_res, string trans)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"exec sp_insertar_reserva {cedula},'{nombre}','{apellidos}','{email}',{tarjeta},'{llegada}','{salida}',{tipo},{pago},'{id_res}',{trans}");
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

        public string lista_reservas_filtro(string fechaInicio, string fechaFinal)
        {
            List<Reserva> lista = new List<Reserva>();
            try
            {
                SqlDataReader dr = consultar($"exec sp_filtrar_reservas '{fechaInicio}', '{fechaFinal}'");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Reserva r = new Reserva();
                        r.TN_Id = int.Parse(dr[0].ToString());

                        int aux = dr[1].ToString().IndexOf(" ");
                        String aux2 = dr[1].ToString().Substring(0, aux);
                        r.TF_Fecha = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        r.TC_Id_Reserva = dr[2].ToString();
                        r.TN_Tarjeta = dr[3].ToString();
                        r.TN_Transaccion = dr[4].ToString();

                        aux = dr[5].ToString().IndexOf(" ");
                        aux2 = dr[5].ToString().Substring(0, aux);
                        r.TF_Llegada = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        aux = dr[6].ToString().IndexOf(" ");
                        aux2 = dr[6].ToString().Substring(0, aux);
                        r.TF_Salida = DateTime.Parse(aux2).ToString("yyyy-MM-dd");

                        Cliente c = new Cliente();
                        c.TN_Id = int.Parse(dr[7].ToString());
                        c.TC_Cedula = dr[8].ToString();
                        c.TC_Nombre = dr[9].ToString();
                        c.TC_Apellidos = dr[10].ToString();
                        c.TC_Email = dr[11].ToString();

                        TipoHabitacion t = new TipoHabitacion();
                        t.TN_Id = int.Parse(dr[12].ToString());
                        t.TC_Nombre = dr[13].ToString();

                        r.cliente = c;
                        r.tipo = t;

                        lista.Add(r);
                    }

                }
                else
                {
                    lista = null;

                }
            }
            catch (SqlException e)
            {
                lista = null;
            }
            return JsonConvert.SerializeObject(lista);
        }
    }
}
