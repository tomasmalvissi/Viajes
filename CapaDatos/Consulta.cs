using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Consulta
    {
        private ConecDB conexion = new ConecDB();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select *from Viajes";
            tabla.Load(leer);
            conexion.CerrarConex();
            return tabla;
        }
    }
}
