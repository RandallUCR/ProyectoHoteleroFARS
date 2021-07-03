using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class TipoHabitacionAdminRN
    {
        public int insertarTiposHabitaciones(string nombre, string desc, int precio, string base64, string formato)
        {
            TipoHabitacionAdminAD tad = new TipoHabitacionAdminAD();
            int result = -3;
            try
            {
                result = tad.insertarTiposHabitaciones(new TipoHabitacion() { TC_Nombre = nombre, TC_Descripcion = desc, TN_Precio = precio,
                galeria = new Galeria() { TV_Archivo = base64, TC_Formato = formato}
                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = -3;
            }

            return result;
        }

        public int eliminarTiposHabitaciones(int id)
        {
            TipoHabitacionAdminAD tad = new TipoHabitacionAdminAD();
            int result = 3;
            try
            {
                result = tad.eliminarTiposHabitaciones(id);

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
