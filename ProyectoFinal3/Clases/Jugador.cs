using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal3.Clases
{
    using System;

    namespace TuProyecto.Models
    {
        public class Jugador
        {
            // Propiedades de la tabla Jugador
            public int ID { get; set; }
            public string NombreCompleto { get; set; }
            public string Nacionalidad { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Altura { get; set; }
            public string Peso { get; set; }
            public string Posicion { get; set; }
            public string Dorsal { get; set; }
            public string urlFotoCabeza {  get; set; }
            public string urlFotoCompleta { get; set; }
        }
    }

}
