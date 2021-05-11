using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoHabitacion
    {
        public int TN_Id { set; get; }
        public string TC_Nombre { set; get; }
        public string TC_Descripcion { set; get; }
        public decimal TN_Precio { set; get; }
        public List<Caracteristica> caracteristicas {set; get;}
        public Promocion promocion { set; get; }
        public decimal TN_Precio_Dolares { set; get; }
        public Galeria galeria { set; get; }
    }
}
