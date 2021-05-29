using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace AccesoDatos
{
    public class ContactosAD : ConexionAD
    {
        public string getContactos()
        {
            List<Contactos> data = new List<Contactos>();

            try
            {
                SqlDataReader dr = consultar($"EXEC  sp_get_Contactos");
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Contactos contactos = new Contactos();
                        contactos.TN_Id = int.Parse(dr[0].ToString());
                        contactos.TC_Tipo= dr[1].ToString();
                        contactos.TN_Contacto = dr[2].ToString();
                        contactos.TN_Id_Hotel = int.Parse(dr[3].ToString());
                        data.Add(contactos);
    }
                }
                else
                {
                    data.Add(null);
                }
            }
            catch (SqlException e)
            {
                data.Add(null);
            }
            return JsonConvert.SerializeObject(data);
        }

    }
}
