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
        public string Nombre
        {
            get; set;

        }

        public string Apellido
        {
            get; set;
        }

        public string Direccion
        {
            get; set;
        }

        public SqlDateTime Fecha_Nacimiento
        {
            get; set;
        }

        public char Sexo
        {
            get; set;
        }

        public string Foto
        {
            get; set;
        }

        public int DNI
        {
            get; set;
        }

        public string Apto_Fisico
        {
            get; set;
        }

        public int Tel_Emergencia
        {
            get; set;
        }

        public int Cel
        {
            get; set;
        }

        public SqlDateTime Fecha_ingreso
        {
            get; set;
        }

        public int IDPlanes
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }
    }
}