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

        public DataTable TFiltro(DateTime fechavalue, DateTime fechafin)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from dbo.Viajes where Fecha BETWEEN @fechavalue AND @fechafin";
            comando.Parameters.Add(new SqlParameter("@fechavalue", SqlDbType.DateTime)).Value = fechavalue;
            comando.Parameters.Add(new SqlParameter("@fechafin", SqlDbType.DateTime)).Value = fechafin;
            comando.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            conexion.CerrarConex();
            return tabla;
        }
        public bool Grabar(Viajes viaje)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Insert into dbo.Viajes (Fecha, NViaje, Empresa, Origen, Destino, KM, Pasajero, MinEspera, PeajeEst, GNC, Nafta, Importe, ImporteEsp, Total)" +
                    " values (@Fecha, @NViaje, @Empresa, @Origen, @Destino, @KM, @Pasajero, @MinEspera, @PeajeEst, @GNC, @Nafta, @Importe, @ImporteEsp, @Total)";
                comando.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = viaje.Fecha;
                comando.Parameters.AddWithValue("@NViaje", viaje.NroViaje);
                comando.Parameters.AddWithValue("@Empresa", viaje.Empresa);
                comando.Parameters.AddWithValue("@Origen", viaje.Origen);
                comando.Parameters.AddWithValue("@Destino", viaje.Destino);
                comando.Parameters.AddWithValue("@KM", viaje.KM);
                comando.Parameters.AddWithValue("@Pasajero", viaje.Pasajero);
                comando.Parameters.AddWithValue("@MinEspera", viaje.MinEsper);
                comando.Parameters.AddWithValue("@PeajeEst", viaje.PeajeEst);
                comando.Parameters.AddWithValue("@GNC", viaje.GNC);
                comando.Parameters.AddWithValue("@Nafta", viaje.Nafta);
                comando.Parameters.AddWithValue("@Importe", viaje.Importe);
                comando.Parameters.AddWithValue("@ImporteEsp", viaje.ImporteEsp);
                comando.Parameters.AddWithValue("@Total", viaje.Total);


                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

                throw;
            }
            conexion.CerrarConex();
            return true;

        }
        public bool Borrar(string idvalue)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Delete from dbo.Viajes where Id=" + @idvalue;

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception)
            {

                throw;
            }
            conexion.CerrarConex();
            return true;
        }

        public bool Editar(Viajes viaje, string idvalue)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Update dbo.Viajes set Fecha=@Fecha, NViaje = @NViaje, Empresa = @Empresa, Origen=@Origen, Destino=@Destino, KM = @KM, Pasajero=@Pasajero, MinEspera=@MinEspera, PeajeEst=@PeajeEst, GNC=@GNC, Nafta=@Nafta, Importe=@Importe, ImporteEsp=@ImporteEsp, Total=@Total WHERE Id = @idvalue";
                comando.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = viaje.Fecha;
                comando.Parameters.AddWithValue("@NViaje", viaje.NroViaje);
                comando.Parameters.AddWithValue("@Empresa", viaje.Empresa);
                comando.Parameters.AddWithValue("@Origen", viaje.Origen);
                comando.Parameters.AddWithValue("@Destino", viaje.Destino);
                comando.Parameters.AddWithValue("@KM", viaje.KM);
                comando.Parameters.AddWithValue("@Pasajero", viaje.Pasajero);
                comando.Parameters.AddWithValue("@MinEspera", viaje.MinEsper);
                comando.Parameters.AddWithValue("@PeajeEst", viaje.PeajeEst);
                comando.Parameters.AddWithValue("@GNC", viaje.GNC);
                comando.Parameters.AddWithValue("@Nafta", viaje.Nafta);
                comando.Parameters.AddWithValue("@Importe", viaje.Importe);
                comando.Parameters.AddWithValue("@ImporteEsp", viaje.ImporteEsp);
                comando.Parameters.AddWithValue("@Total", viaje.Total);
                comando.Parameters.AddWithValue("@idvalue", idvalue);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
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
