﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace Dominio
{
    public class Rutina_ejercicio
    {
        public Rutina_ejercicio()
        {
            ejercicio= new List<Ejercicio>();
        }
        public int ID {get; set;}
        public List<Ejercicio> ejercicio {get; set;}

        public int hora { get; set;} 
      
        public Dias dia { get; set;} 

    }
}