using System.Collections.Generic;

namespace Dominio
{
    public class Rutina_ejercicio
    {
        public Rutina_ejercicio()
        {
            ejercicio = new List<Ejercicio>();
        }
        public int ID { get; set; }
        public List<Ejercicio> ejercicio { get; set; }

        public int hora { get; set; }

        public Dias dia { get; set; }

    }
}