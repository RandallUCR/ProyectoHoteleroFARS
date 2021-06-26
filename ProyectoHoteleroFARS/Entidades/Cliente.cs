using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        public int TN_Id { set; get; }
        public string TC_Cedula { set; get; }
        public string TC_Nombre { set; get; }
        public string TC_Apellidos { set; get; }
        public string TC_Email { set; get; }
    }
}
