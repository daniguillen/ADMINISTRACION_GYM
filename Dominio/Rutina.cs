using System.Collections.Generic;

namespace Dominio
{
    public class Rutina
    {
        public Rutina()
        {
            rutina_Ejercicios = new List<Rutina_ejercicio>();

        }
        public int ID { get; set; }
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public bool estado { get; set; }
        public bool personal { get; set; }

        public List<Rutina_ejercicio> rutina_Ejercicios { get; set; }

    }
}