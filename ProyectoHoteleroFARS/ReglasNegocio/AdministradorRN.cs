using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class AdministradorRN
    {
        public Administrador login(string usuario, string contrasena)
        {
            AdministradorAD aad = new AdministradorAD();
            string respuesta = null;
            Administrador a = new Administrador();
            a.TC_Usuario = usuario;
            a.TC_Contrasena = contrasena;
            try
            {
                respuesta = aad.login(a);
                if (respuesta != null)
                {
                    a = JsonConvert.DeserializeObject<Administrador>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return a;
        }

        public List<Administrador> lista_admins()
        {
            AdministradorAD rad = new AdministradorAD();
            List<Administrador> lista = new List<Administrador>();

            string respuesta = null;
            try
            {
                respuesta = rad.lista_admins();
                if (respuesta != null)
                {
                    lista = JsonConvert.DeserializeObject<List<Administrador>>(respuesta);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lista;
        }

        public int insertarAdmin(string usuario, string contrasena, int rol)
        {
            AdministradorAD rad = new AdministradorAD();
            int result = 3;
            try
            {
                result = rad.insertarAdmin(new Administrador() { TC_Usuario = usuario, TC_Contrasena = contrasena, rol = new Rol() { TN_Id = rol} });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int modificarAdmin(int id, string usuario, string contrasena, int rol)
        {
            AdministradorAD rad = new AdministradorAD();
            int result = 3;
            try
            {
                result = rad.modificarAdmin(new Administrador() { TN_Id = id, TC_Usuario = usuario, TC_Contrasena = contrasena, rol = new Rol() { TN_Id = rol } });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 3;
            }

            return result;
        }

        public int eliminarAdmin(int id)
        {
            AdministradorAD rad = new AdministradorAD();
            int result = 2;
            try
            {
                result = rad.eliminarAdmin(id);

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
