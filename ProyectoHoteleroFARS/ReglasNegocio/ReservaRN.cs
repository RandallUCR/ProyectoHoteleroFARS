using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class ReservaRN
    {
        public TipoHabitacion verificar(string fechaUno, string fechaDos, int tipo, decimal dolar)
        {
            ReservaAD rad = new ReservaAD();
            TipoHabitacion t = new TipoHabitacion();

            string respuesta = null;
            try
            {
                respuesta = rad.verificar(fechaUno, fechaDos, tipo, dolar);
                if (respuesta != null)
                {
                    t = JsonConvert.DeserializeObject<TipoHabitacion>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return t;
        }

        public ConfirmacionReserva reservar(string cedula, string nombre, string apellidos, string correo, string tarjeta, string id_res, int trans, string fechaUno, string fechaDos, int id, string precio)
        {
            ReservaAD rad = new ReservaAD();
            ConfirmacionReserva c = new ConfirmacionReserva();

            string respuesta = null;
            try
            {
                respuesta = rad.reservar(cedula, nombre, apellidos, correo, tarjeta, id_res, trans, fechaUno, fechaDos, id, precio);
                if (respuesta != null)
                {
                    c = JsonConvert.DeserializeObject<ConfirmacionReserva>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return c;
        }

        public List<Reserva> lista_reservas()
        {
            ReservaAD rad = new ReservaAD();
            List<Reserva> lista = new List<Reserva>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_reservas();
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<Reserva>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lista;
        }

        public int modificarReserva(int id, int cedula, string nombre, string apellidos, string email, string tarjeta, string llegada, string salida, int tipo)
        {
            ReservaAD rad = new ReservaAD();
            int result = 3;

            try
            {
                result = rad.modificarReserva(id,cedula,nombre,apellidos,email,tarjeta,llegada,salida,tipo);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int eliminarReserva(int id)
        {
            ReservaAD rad = new ReservaAD();
            int result = 2;

            try
            {
                result = rad.eliminarReserva(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 2;
            }

            return result;
        }

        public int insertarReserva(int cedula, string nombre, string apellidos, string email, string tarjeta, string llegada, string salida, int tipo, decimal pago, string id_res, string trans)
        {
            ReservaAD rad = new ReservaAD();
            int result = 3;

            try
            {
                result = rad.insertarReserva(cedula, nombre, apellidos, email, tarjeta, llegada, salida, tipo, pago, id_res, trans);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public List<Reserva> lista_reservas_filtro(string fechaInicio, string fechaSalida)
        {
            ReservaAD rad = new ReservaAD();
            List<Reserva> lista = new List<Reserva>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_reservas_filtro(fechaInicio,fechaSalida);
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<Reserva>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lista;
        }
    }
}
