using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        public int TN_Id { set; get; }
        public string TF_Fecha { set; get; }
        public string TC_Id_Reserva { set; get; }
        public string TN_Tarjeta { set; get; }
        public string TN_Transaccion { set; get; }
        public string TF_Llegada { set; get; }
        public string TF_Salida { set; get; }
        public Cliente cliente { set; get; }
        public TipoHabitacion tipo { set; get; }
    }
}
