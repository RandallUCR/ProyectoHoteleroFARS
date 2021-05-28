using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class TipoHabitacionRN
    {

        public List<TipoHabitacion> getTiposHabitacionTemp()
        {
            TipoHabitacionAD tad = new TipoHabitacionAD();
            string respuesta = null;
            List<TipoHabitacion> t = new List<TipoHabitacion>();
            try
            {
                respuesta = tad.getTiposHabitacionTemp();
                if (respuesta != null)
                {
                    t = JsonConvert.DeserializeObject<List<TipoHabitacion>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return t;

        }

        public List<Caracteristica> getTiposHabitacionCaract(int id)
        {
            TipoHabitacionAD tad = new TipoHabitacionAD();
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

        public Promocion getTiposHabitacionPromo(int id)
        {
            TipoHabitacionAD tad = new TipoHabitacionAD();
            string respuesta = null;
            Promocion p = new Promocion();
            try
            {
                respuesta = tad.getTipoHabitacionPromo(id);
                if (respuesta != null)
                {
                    p = JsonConvert.DeserializeObject<Promocion>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return p;

        }

        public Galeria getGaleriaTiposHabitacion(int id)
        {
            TipoHabitacionAD tad = new TipoHabitacionAD();
            string respuesta = null;
            Galeria g = new Galeria();
            try
            {
                respuesta = tad.getGaleriaTipoHabitacion(id);
                if (respuesta != null)
                {
                    g = JsonConvert.DeserializeObject<Galeria>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return g;

        }

        public List<TipoHabitacion> getTiposHabitacion(decimal dolar)
        {
            List<TipoHabitacion> t = new List<TipoHabitacion>();
            try
            {
                t = this.getTiposHabitacionTemp();
                foreach (TipoHabitacion tipo in t)
                {
                    tipo.caracteristicas = this.getTiposHabitacionCaract(tipo.TN_Id);
                    tipo.promocion = this.getTiposHabitacionPromo(tipo.TN_Id);
                    tipo.galeria = this.getGaleriaTiposHabitacion(tipo.TN_Id);

                    if (tipo.promocion.TN_Id > -1)
                    {
                        decimal aux = Decimal.Divide(tipo.promocion.TN_Porcentaje, 100);
                        decimal aux2 = tipo.TN_Precio; 
                        decimal aux3 = tipo.TN_Precio * aux;
                        tipo.TN_Precio = decimal.Round((aux2 - aux3),1);
                    }
                    tipo.TN_Precio_Dolares = decimal.Round(Decimal.Divide(tipo.TN_Precio, dolar),1);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return t;

        }

    }
}
