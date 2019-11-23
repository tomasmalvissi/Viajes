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
            comando.CommandText = "Select * from dbo.Pets";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConex();
            return tabla;
        }

        public bool Grabar(Viajes viaje)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Insert into Viajes (id, fecha, origen, destino) values " + viaje.Fecha + ", " + viaje.Origen + ", " + viaje.Destino;
                

            }
            catch (Exception)
            {

                throw;
            }
            conexion.CerrarConex();
            return true;

        }
    }
}
