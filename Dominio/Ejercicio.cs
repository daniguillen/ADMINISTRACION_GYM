using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Dominio
{
    public class Ejercicio
    {
        public int ID {get; set;}

        public string Descripcion {get; set;}

        public string Nombre {get; set;}

        public int Repeticiones {get; set;}

        public TipoEjercicio Tipo_Ejercicio {get; set;}

        public Dificultad Tipo_Dificultad {get; set;}

        public string Video {get; set;}

        public GrupoMuscular Grupo_Muscular {get; set;}


    }
}