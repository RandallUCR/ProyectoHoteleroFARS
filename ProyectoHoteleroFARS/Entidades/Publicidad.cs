using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Publicidad
    {
        public int TN_Id { set; get; }
        public string TC_Link { set; get; }
        public Galeria galeria { set; get; }
    }
}
