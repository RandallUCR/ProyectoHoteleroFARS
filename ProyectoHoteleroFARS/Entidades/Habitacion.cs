using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Habitacion
    {
        public int TN_Id { get; set; }
        public int TN_Numero { get; set; }
        public bool TB_Estado { get; set; }

        public TipoHabitacion tipo { get; set; }

    }
}
