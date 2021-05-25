using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades{
    public class Facilidad{
        public int TN_Id { set; get; }
        public string TC_Descripcion { set; get; }
        public int TN_Id_Hotel { set; get; }
        public Galeria galeria { set; get; }
    }
}
