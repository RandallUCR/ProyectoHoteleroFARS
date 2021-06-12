using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ConfirmacionReserva
    {
        public int TN_Id { set; get; }
        public string TC_Nombre { set; get; }
        public string TC_Apellidos { set; get; }
        public string TC_Correo { set; get; }
        public string TC_Id_Reserva { set; get; }
    }
}
