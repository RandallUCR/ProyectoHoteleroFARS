using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class ClienteAdminAD : ConexionAD
    {
        public string lista_clientes(string busqueda)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_clientes '%{busqueda}%'");
                if (dr != null)
                {
                    while (dr.Read())
                    {

                        Cliente c = new Cliente();
                        c.TN_Id = int.Parse(dr[0].ToString());
                        c.TC_Cedula = dr[1].ToString();
                        c.TC_Nombre = dr[2].ToString();
                        c.TC_Apellidos = dr[3].ToString();
                        c.TC_Email = dr[4].ToString();

                        lista.Add(c);
                    }

                }
                else
                {
                    lista = null;

                }
            }
            catch (SqlException e)
            {
                lista = null;
            }
            return JsonConvert.SerializeObject(lista);
        }

        public int insertarCliente(Cliente c)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_cliente {c.TC_Cedula}, '{c.TC_Nombre}', '{c.TC_Apellidos}', '{c.TC_Email}'");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public int modificarCliente(Cliente c)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_edit_cliente {c.TN_Id}, {c.TC_Cedula}, '{c.TC_Nombre}', '{c.TC_Apellidos}', '{c.TC_Email}'");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }

        public int eliminarCliente(int id)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_cliente {id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 3;
                }
            }
            catch (SqlException e)
            {
                result = 3;
            }
            return result;
        }
    }
}
