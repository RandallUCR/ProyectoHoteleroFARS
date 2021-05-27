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
    }
}
