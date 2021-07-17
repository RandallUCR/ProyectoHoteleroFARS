using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class CaracteristicaAdminRN
    {
        public List<Caracteristica> getTiposHabitacionCaract(int id)
        {
            CaracteristicaAdminAD tad = new CaracteristicaAdminAD();
            string respuesta = null;
            List<Caracteristica> c = new List<Caracteristica>();
            try
            {
                respuesta = tad.getTipoHabitacionCaract(id);
                if (respuesta != null)
                {
                    c = JsonConvert.DeserializeObject<List<Caracteristica>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return c;

        }

        public int insertarCaracteristica(string desc, int tipo)
        {
            CaracteristicaAdminAD rad = new CaracteristicaAdminAD();
            int result = 2;
            try
            {
                result = rad.insertarCaracteristica(new Caracteristica() { TC_Descripcion = desc, TN_Id_Tipo = tipo});

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 2;
            }

            return result;
        }

        public int modificarCaracteristica(int id, string desc)
        {
            CaracteristicaAdminAD rad = new CaracteristicaAdminAD();
            int result = 2;
            try
            {
                result = rad.modificarCaracteristica(new Caracteristica() { TN_Id = id, TC_Descripcion = desc});

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 2;
            }

            return result;
        }

        public int eliminarCaracteristica(int id)
        {
            CaracteristicaAdminAD rad = new CaracteristicaAdminAD();
            int result = 2;
            try
            {
                result = rad.eliminarCaracteristica(id);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 2;
            }

            return result;
        }
    }
}
