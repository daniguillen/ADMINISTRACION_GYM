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

        public int ID_Tipo {get; set;}

        public int ID_Dificultad {get; set;}

        public string Video {get; set;}

        public int ID_Grupo_Muscular {get; set;}


    }
}