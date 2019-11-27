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
            comando.CommandText = "Select * from dbo.Viajes";
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
                comando.CommandText = "Insert into dbo.Viajes (NroViaje, Empresa, Origen, Destino, KM, Pasajero, MinEsp, PE, GNC, Importe, ImpEsp, Total, Nafta) values " +
                  "("+ viaje.NroViaje + ",'" + viaje.Empresa + "','" + viaje.Origen + "',' " + viaje.Destino
                    + "'," + viaje.KM + ",'" + viaje.Pasajero + "'," + viaje.MinEsper + "," + viaje.PeajeEst + "," + viaje.GNC
                    + "," + viaje.Importe + "," + viaje.ImporteEsp + "," + viaje.Total + "," + viaje.Nafta + ");";
                comando.ExecuteNonQuery();

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
