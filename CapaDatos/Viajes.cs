using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
    public class Viajes
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NroViaje { get; set; }
        public string Empresa { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public float KM { get; set; }
        public string Pasajero { get; set; }
        public float MinEsper { get; set; }
        public float PeajeEst { get; set; }
        public float GNC { get; set; }
        public float Importe { get; set; }
        public float ImporteEsp { get; set; }
        public float Total { get; set; }
        public float Nafta { get; set; }
        public string idvalue {get; set;}
    }
}
