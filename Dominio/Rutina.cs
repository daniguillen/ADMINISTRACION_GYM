using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Dominio
{
    public class Rutina
    {
        public int ID {get; set;}

        public int ID_Ejercicio {get; set;}

        public DateTime Dia {get; set;}

        public int ID_Persona {get; set;}
    }
}