using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NegViajes
    {
       private Consulta ObjCons = new Consulta();

        public DataTable MostrarProd() 
        {
            DataTable tabla = new DataTable();
            tabla = ObjCons.Mostrar();
            return tabla;
        }
    }
}
