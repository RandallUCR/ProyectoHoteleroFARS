using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class ClienteAdminRN
    {
        public List<Cliente> lista_clientes(string busqueda)
        {
            ClienteAdminAD rad = new ClienteAdminAD();
            List <Cliente> lista = new List<Cliente>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_clientes(busqueda);
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lista;
        }

        public int insertarCliente(string cedula, string nombre, string apellidos, string email)
        {
            ClienteAdminAD rad = new ClienteAdminAD();
            int result = 3;
            try
            {
                result = rad.insertarCliente(new Cliente() { TC_Cedula = cedula, TC_Nombre = nombre, TC_Apellidos = apellidos, TC_Email = email});

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int modificarCliente(int id, string cedula, string nombre, string apellidos, string email)
        {
            ClienteAdminAD rad = new ClienteAdminAD();
            int result = 3;
            try
            {
                result = rad.modificarCliente(new Cliente() { TN_Id = id, TC_Cedula = cedula, TC_Nombre = nombre, TC_Apellidos = apellidos, TC_Email = email });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int eliminarCliente(int id)
        {
            ClienteAdminAD rad = new ClienteAdminAD();
            int result = 3;
            try
            {
                result = rad.eliminarCliente(id);

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
