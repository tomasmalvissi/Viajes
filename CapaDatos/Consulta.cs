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
        public bool ActTarifas(double KMg1CBA, double KMg1INT, double KMg2CBA, double KMg2INT, double KMg3, double KMg4, double KMg11, double Horag1CBA, double Horag1INT, double Horag2CBA, double Horag2INT, double Horag3, double Horag4, double Horag11)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Insert into dbo.Var (KMg1CBA, KMg1INT, KMg2CBA,KMg2INT, KMg3, KMg4, KMg11, Horag1CBA, Horag1INT, Horag2CBA, Horag2INT, Horag3, Horag4, Horag11) " +
                    "values (@KMg1CBA, @KMg1INT, @KMg2CBA, @KMg2INT, @KMg3, @KMg4, @KMg11, @Horag1CBA, @Horag1INT, @Horag2CBA, @Horag2INT, @Horag3, @Horag4, @Horag11)";
                comando.Parameters.AddWithValue("@KMg1CBA", KMg1CBA);
                comando.Parameters.AddWithValue("@KMg1INT", KMg1INT);
                comando.Parameters.AddWithValue("@KMg2CBA", KMg2CBA);
                comando.Parameters.AddWithValue("@KMg2INT", KMg2INT);
                comando.Parameters.AddWithValue("@KMg3", KMg3);
                comando.Parameters.AddWithValue("@KMg4", KMg4);
                comando.Parameters.AddWithValue("@KMg11", KMg11);
                comando.Parameters.AddWithValue("@Horag1CBA", Horag1CBA);
                comando.Parameters.AddWithValue("@Horag1INT", Horag1INT);
                comando.Parameters.AddWithValue("@Horag2CBA", Horag2CBA);
                comando.Parameters.AddWithValue("@Horag2INT", Horag2INT);
                comando.Parameters.AddWithValue("@Horag3", Horag3);
                comando.Parameters.AddWithValue("@Horag4", Horag4);
                comando.Parameters.AddWithValue("@Horag11", Horag11);
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
