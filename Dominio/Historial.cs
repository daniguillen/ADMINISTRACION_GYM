using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Historial
    {
        public int ID { get; set; } 

        public string NombrePersona { get; set; }

        public string Plan { get; set; }

        public SqlMoney Pago {  get; set; }
        
        public DateTime FechaPago { get; set; }

        public string DescripcionNota { get; set; }



    }
}

