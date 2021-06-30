using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class ReservaAdminRN
    {
        public List<Reserva> lista_reservas()
        {
            ReservaAdminAD rad = new ReservaAdminAD();
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
            ReservaAdminAD rad = new ReservaAdminAD();
            int result = 3;

            try
            {
                result = rad.modificarReserva(id, cedula, nombre, apellidos, email, tarjeta, llegada, salida, tipo);

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
            ReservaAdminAD rad = new ReservaAdminAD();
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
            ReservaAdminAD rad = new ReservaAdminAD();
            int result = 3;
            Console.WriteLine("R");
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
            ReservaAdminAD rad = new ReservaAdminAD();
            List<Reserva> lista = new List<Reserva>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_reservas_filtro(fechaInicio, fechaSalida);
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
