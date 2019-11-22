using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConecDB
    {
        private SqlConnection Conexion = new SqlConnection("Server=(local);DataBase= Viajes; Integrated Security=true");
        public SqlConnection AbrirConexion() 
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConex() 
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
