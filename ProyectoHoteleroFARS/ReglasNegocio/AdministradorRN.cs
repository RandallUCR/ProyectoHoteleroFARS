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
    }
}
