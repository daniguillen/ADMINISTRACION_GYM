﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Dominio
{
    public class Usuario
    {
        public string Mail
        {
            get; set;
        }

        public int IDUsuario
        {
            get; set;
        }

        public System.Web.Configuration.FormsAuthPasswordFormat Password
        {
            get; set;
        }

        public int IDNivel
        {
            get; set;
        }
    }
}