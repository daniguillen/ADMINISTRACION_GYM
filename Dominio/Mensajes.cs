using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Mensajes
    {
        public int ID {  get; set; }

        public string DescripcionNota { get; set; }

        public DateTime FechaMensaje { get; set; }
    }
}