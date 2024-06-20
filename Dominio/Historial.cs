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

        public int ID_Persona { get; set; }

        public int ID_Planes { get; set; }

        public SqlMoney Pago {  get; set; }
        
        public DateTime FechaPago { get; set; }

        public string DescripcionNota { get; set; }



    }
}

