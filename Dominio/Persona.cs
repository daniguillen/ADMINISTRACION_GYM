using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Collections.Generic;


namespace Dominio
{
    public class Persona
    {
        public Persona()
        {
            rutina=new List<Rutina>();
        }

        public int ID { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public DateTime Fecha_Nacimiento { get; set; }

        public int Sexo { get; set; }

        public string Foto { get; set; }

        public string DNI { get; set; }

        public string Apto_Fisico { get; set; }

        public string Tel_Emergencia { get; set; }

        public string Cel { get; set; }

        public DateTime Fecha_ingreso { get; set; }

        public int ID_Plan { get; set; }
              

        public int ID_Establecimiento { get; set; }

        public bool Estado { get; set; }

        public int ID_Nivel { get; set; }

        public List<Rutina> rutina { get; set; }
        
    }
}