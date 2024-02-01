using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal3.Clases
{
    internal class Temporada
    {
        // Propiedades de la tabla EstadisticasPorTemporadaJugador
        public int EstadisticasID { get; set; }
        public string season { get; set; }
        public int PJ { get; set; }
        public double PPP { get; set; }
        public int TC { get; set; }
        public int TL { get; set; }
        public double RPP { get; set; }
        public double APP { get; set; }
        public double STL { get; set; }
        public double BLK { get; set; }
        public double _3PM { get; set; }
        public double _3PERC { get; set; }
    }
}
