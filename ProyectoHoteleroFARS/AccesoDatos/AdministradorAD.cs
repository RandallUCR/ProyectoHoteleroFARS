using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class AdministradorAD : ConexionAD
    {
        public string login(Administrador administrador)
        {
                Administrador data = new Administrador();

            try
            {
                SqlDataReader dr = consultar($"EXEC admin_login '{administrador.TC_Usuario}', '{administrador.TC_Contrasena}'");
                if (dr != null)
                {
                    dr.Read();

                    data.TN_Id = int.Parse(dr[0].ToString());
                    data.TC_Usuario = dr[1].ToString();
                    data.TC_Contrasena = dr[2].ToString();

                    Rol r = new Rol();
                    r.TN_Id = int.Parse(dr[3].ToString());
                    r.TC_Rol = dr[4].ToString();

                    data.rol = r;

                }
                else
                {
                    data = null;
                }
            }
            catch (SqlException e)
            {
                data = null;
            }
            return JsonConvert.SerializeObject(data);
        }

        public string lista_admins()
        {
            List<Administrador> lista = new List<Administrador>();
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_get_administradores");
                if (dr != null)
                {
                    while (dr.Read())
                    {

                        Administrador a = new Administrador();
                        a.TN_Id = int.Parse(dr[0].ToString());
                        a.TC_Usuario = dr[1].ToString();
                        a.TC_Contrasena = dr[2].ToString();

                        Rol r = new Rol();
                        r.TN_Id = int.Parse(dr[3].ToString());
                        r.TC_Rol = dr[4].ToString();

                        a.rol = r;

                        lista.Add(a);
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

        public int insertarAdmin(Administrador a)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_ins_admin '{a.TC_Usuario}','{a.TC_Contrasena}',{a.rol.TN_Id}");
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

        public int modificarAdmin(Administrador a)
        {
            int result = 3;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_edit_admin {a.TN_Id},'{a.TC_Usuario}','{a.TC_Contrasena}',{a.rol.TN_Id}");
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

        public int eliminarAdmin(int id)
        {
            int result = 2;
            try
            {
                SqlDataReader dr = consultar($"EXEC sp_del_admin {id}");
                if (dr != null)
                {
                    dr.Read();

                    result = int.Parse(dr[0].ToString());
                }
                else
                {
                    result = 2;
                }
            }
            catch (SqlException e)
            {
                result = 2;
            }
            return result;
        }
    }
}
