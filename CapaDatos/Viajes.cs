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
        public string Origen { get; set; }
        public string Destino { get; set; }
        public float Importe { get; set; }
        public float Distancia { get; set; }
        public Personas Chofer { get; set; }
    }
}
