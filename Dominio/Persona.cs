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
            plan= new Plan();
            sexo = new Sexo();
           
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Apto_Fisico { get; set; }
        public string Cel { get; set; }
        public string Direccion { get; set; }
        public string DNI { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_baja { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Foto { get; set; }
        public Plan plan { get; set; }
        public Sexo sexo { get; set; }
        public string Tel_Emergencia { get; set; }

        public int ID_Establecimiento { get; set; }

        public bool Estado { get; set; }
        public int ID_rutina { get; set; }
        
    }
}