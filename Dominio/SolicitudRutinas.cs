using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class SolicitudRutinas
    {

        public int ID_SolicitudRutinas { get; set; }
        public Usuario usuario { get; set; }
        
        public Entrenador entrenador {  get; set; }    

        public string Mensaje { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public bool Estado { get; set; }

        public bool RutinaAsignada { get; set; }
    }
}