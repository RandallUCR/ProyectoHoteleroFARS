using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class HabitacionAdminRN
    {
        public List<Habitacion> getHabitacionesByTipo(int id)
        {
            List<Habitacion> list = new List<Habitacion>();
            HabitacionAdminAD ad = new HabitacionAdminAD();

            string respuesta = null;

            try
            {
                respuesta = ad.getHabitacionesByTipo(id);               
                if (respuesta != null)
                {
                    list = JsonConvert.DeserializeObject<List<Habitacion>>(respuesta);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("RN");
            }

            return list;
        }

        public int insertarHabitacion(int num, bool estado, int tipo)
        {
            HabitacionAdminAD rad = new HabitacionAdminAD();
            int result = 3;
            try
            {
                result = rad.insertarHabitacion(new Habitacion() { TN_Numero = num, TB_Estado = estado, tipo = new TipoHabitacion() { TN_Id = tipo} });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int modificarHabitacion(int num, bool estado, int id)
        {
            HabitacionAdminAD rad = new HabitacionAdminAD();
            int result = 3;
            try
            {
                result = rad.modificarHabitacion(new Habitacion() { TN_Id = id, TN_Numero = num, TB_Estado = estado});

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int eliminarHabitacion(int id)
        {
            HabitacionAdminAD rad = new HabitacionAdminAD();
            int result = 3;
            try
            {
                result = rad.eliminarHabitacion(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }
    }
}
