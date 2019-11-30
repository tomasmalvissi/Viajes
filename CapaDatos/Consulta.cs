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
                comando.CommandText = "Insert into dbo.Viajes (Fecha, Numero Viaje, Empresa, Origen, Destino, KM, Pasajero, Minuto Espera, Peaje / Estacionamiento, GNC, Importe, Importe Espera, Total, Nafta)" +
                    " values (@Fecha, @Numero Viaje, @Empresa, @Origen, @Destino, @KM, @Pasajero, @Minuto Espera, @Peaje / Estacionamiento, @GNC, @Importe, @Importe Espera, @Total, @Nafta)";
                comando.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = viaje.Fecha;
                comando.Parameters.AddWithValue("@Numero Viaje", viaje.NroViaje);
                comando.Parameters.AddWithValue("@Empresa", viaje.Empresa);
                comando.Parameters.AddWithValue("@Origen", viaje.Origen);
                comando.Parameters.AddWithValue("@Destino", viaje.Destino);
                comando.Parameters.AddWithValue("@KM", viaje.KM);
                comando.Parameters.AddWithValue("@Pasajero", viaje.Pasajero);
                comando.Parameters.AddWithValue("@Minuto Espera", viaje.MinEsper);
                comando.Parameters.AddWithValue("@Peaje / Estacionamiento", viaje.PeajeEst);
                comando.Parameters.AddWithValue("@GNC", viaje.GNC);
                comando.Parameters.AddWithValue("@Importe", viaje.Importe);
                comando.Parameters.AddWithValue("@Importe Espera", viaje.ImporteEsp);
                comando.Parameters.AddWithValue("@Total", viaje.Total);
                comando.Parameters.AddWithValue("@Nafta", viaje.Nafta);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            conexion.CerrarConex();
            return true;

        }
        //public bool Borrar(Viajes viaje) 
        //{

        //}

        public bool Editar(Viajes viaje)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Update dbo.Viajes set Fecha, Numero Viaje, Empresa, Origen, Destino, KM, Pasajero, Minuto Espera, Peaje / Estacionamiento, GNC, Importe, Importe Espera, Total, Nafta";
                comando.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = viaje.Fecha;
                comando.Parameters.AddWithValue("@Numero Viaje", viaje.NroViaje);
                comando.Parameters.AddWithValue("@Empresa", viaje.Empresa);
                comando.Parameters.AddWithValue("@Origen", viaje.Origen);
                comando.Parameters.AddWithValue("@Destino", viaje.Destino);
                comando.Parameters.AddWithValue("@KM", viaje.KM);
                comando.Parameters.AddWithValue("@Pasajero", viaje.Pasajero);
                comando.Parameters.AddWithValue("@Minuto Espera", viaje.MinEsper);
                comando.Parameters.AddWithValue("@Peaje / Estacionamiento", viaje.PeajeEst);
                comando.Parameters.AddWithValue("@GNC", viaje.GNC);
                comando.Parameters.AddWithValue("@Importe", viaje.Importe);
                comando.Parameters.AddWithValue("@Importe Espera", viaje.ImporteEsp);
                comando.Parameters.AddWithValue("@Total", viaje.Total);
                comando.Parameters.AddWithValue("@Nafta", viaje.Nafta);

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
