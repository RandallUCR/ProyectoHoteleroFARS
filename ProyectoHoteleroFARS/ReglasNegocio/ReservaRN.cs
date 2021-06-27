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
    }
}
