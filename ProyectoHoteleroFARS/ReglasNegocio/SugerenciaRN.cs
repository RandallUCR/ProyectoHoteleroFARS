using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReglasNegocio
{
    public class SugerenciaRN
    {
        public int registrarSugerencia(string sug)
        {
            SugerenciaAD sad = new SugerenciaAD();
            int result = 2;

            try
            {
                result = sad.registrarSugerencia(sug);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = 2;
            }

            return result;
        }
    }
}
