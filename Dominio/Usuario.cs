using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Dominio
{
    public class Usuario : Persona
    {

       public Usuario()
        {
            Persona Persona = new Persona();
        }
        public string Mail {get; set;}
               
        public System.Web.Configuration.FormsAuthPasswordFormat Password {get; set;}

        public Nivel nivel = new Nivel();

    }


}