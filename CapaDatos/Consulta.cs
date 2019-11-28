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
                //comando.CommandText = "Insert into dbo.Viajes (Fecha, NroViaje, Empresa, Origen, Destino, KM, Pasajero, MinEsp, PE, GNC, Importe, ImpEsp, Total, Nafta)" +
                //    " values (@Fecha, @NroViaje, @Empresa, @Origen, @Destino, @KM, @Pasajero, @MinEsp, @PE, @GNC, @Importe, @ImpEsp, @Total, @Nafta)";
                //comando.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = viaje.Fecha;
                //comando.Parameters.AddWithValue("@NroViaje", viaje.NroViaje);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Empresa);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Origen);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Destino);
                //comando.Parameters.AddWithValue("@Fecha", viaje.KM);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Pasajero);
                //comando.Parameters.AddWithValue("@Fecha", viaje.MinEsper);
                //comando.Parameters.AddWithValue("@Fecha", viaje.PeajeEst);
                //comando.Parameters.AddWithValue("@Fecha", viaje.GNC);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Importe);
                //comando.Parameters.AddWithValue("@Fecha", viaje.ImporteEsp);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Total);
                //comando.Parameters.AddWithValue("@Fecha", viaje.Nafta);

                comando.CommandText = "Insert into dbo.Viajes (Fecha, NroViaje, Empresa, Origen, Destino, KM, Pasajero, MinEsp, PE, GNC, Importe, ImpEsp, Total, Nafta) values " +
                  "(" + viaje.Fecha + "," + viaje.NroViaje + ",'" + viaje.Empresa + "','" + viaje.Origen + "',' " + viaje.Destino
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
