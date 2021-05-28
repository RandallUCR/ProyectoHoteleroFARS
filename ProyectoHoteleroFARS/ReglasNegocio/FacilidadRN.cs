using AccesoDatos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio{
    public class FacilidadRN {

        public List<Facilidad> getFacilidadRN() {
            List<Facilidad> facilidadList = new List<Facilidad>();
            FacilidadAD fad = new FacilidadAD();
            string respuesta = null;
            try {

                respuesta = fad.getFacilidadAD();
                if (respuesta != null){
                    facilidadList = JsonConvert.DeserializeObject<List<Facilidad>>(respuesta);
                }

            } catch (Exception e) {

            }

            return facilidadList;
        }

    }
}
