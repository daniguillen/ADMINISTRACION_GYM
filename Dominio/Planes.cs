using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace Dominio
{
    public class Plan
    {

        public string Tipo_Plan {get; set;}

        public int ID {get; set;}

        public SqlMoney Cuotas {get; set;}

        public string Descripcion { get; set;}  

    }
}