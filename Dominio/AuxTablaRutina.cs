using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class AuxTablaRutina
    {
        public int ID_Rutina{get; set;}
        public string NombreRutina { get; set;}
        public string DescripcionRutina { get; set;}
        public string DiaNombre {  get; set;}
        public string NombreEjercicio {  get; set;}
        public int Repeticiones {  get; set;}

        public int Horario {  get; set;}

        public int ID_Ejercicio { get; set;}

    }
}