using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class ConexionAD
    {
        private string conexion;
        private SqlConnection con;
        public ConexionAD()
        {
            this.conexion = "Data Source=163.178.107.10;Initial Catalog=Proyecto_Hotelero_FARS;Persist Security Info=True;User ID=laboratorios;Password=KmZpo.2796";
        }

        public void conectar()
        {
            this.con = new SqlConnection(conexion);

            if (this.con != null)
            {
                Console.WriteLine("Conexion establecida");
            }
            else
            {
                Console.WriteLine("Conexion Erronea");
            }

        }

        public SqlDataReader consultar(string sentencia)
        {
            SqlDataReader dr = null;
            try
            {
                conectar();
                this.con.Open();
                SqlCommand cmd = new SqlCommand(sentencia, con);
                dr = cmd.ExecuteReader();
            }
            catch
            {
                this.con.Close();
                Console.WriteLine("Error en consultar");
            }

            return dr;
        }
    }
}
