using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class ContactoRN
    {
        public List<Contactos> getContactosRN()
        {
            List<Contactos> contactosList = new List<Contactos>();
            ContactosAD conAD= new ContactosAD();
            string respuesta = null;
            try
            {

                respuesta = conAD.getContactos();
                if (respuesta != null)
                {
                    contactosList = JsonConvert.DeserializeObject<List<Contactos>>(respuesta);
                }

            }
            catch (Exception e)
            {

            }

            return contactosList;
        }

    }
}
