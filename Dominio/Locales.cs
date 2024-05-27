using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Dominio
{
    public class Establecimiento
    {
        public string Direccion {get; set;}

        public string Nombre {get; set;}


        public int Cuit {get; set;}

        public string Descripcion {get; set;}

        public int ID {get; set;}
    }
}