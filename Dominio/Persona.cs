using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Persona
    {
        public string Nombre { get; set;}

        public string Apellido { get; set;}

        public string Direccion { get; set;}

        public SqlDateTime Fecha_Nacimiento { get; set;}

        public int Sexo { get; set;}

        public string Foto { get; set;}

        public string DNI {get; set;}

        public string Apto_Fisico { get; set;}

        public string Tel_Emergencia { get; set; }

        public string Cel { get; set; }

        public SqlDateTime Fecha_ingreso { get; set; }

        public int ID_Planes { get; set;}

        public int ID { get; set;}

        public int ID_Usuario { get; set;}

        public int ID_Establecimiento{ get; set;}

        public int ID_Estado { get; set;}

        public int ID_Nivel { get; set;}
    }
}