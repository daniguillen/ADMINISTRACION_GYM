using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Dominio
{
    public class Plan
    {

        public int Tipos_Planes
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }

        public int Pagos
        {
            get => default;
            set
            {
            }
        }
    }
}