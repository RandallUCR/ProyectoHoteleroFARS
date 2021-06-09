using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Administrador
    {
        public int TN_Id { set; get; }
        public string TC_Usuario { set; get; }
        public string TC_Contrasena { set; get; }
        public Rol rol { set; get; }
    }
}
