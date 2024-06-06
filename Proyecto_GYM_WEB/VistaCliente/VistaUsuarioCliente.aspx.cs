﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class VistaUsuarioCliente : System.Web.UI.Page
    {
       

        public Usuario Perfil=new Usuario();
        public Plan Plan=new Plan();
        public string na = "u";
        public Rutina RutinaCliente = new Rutina();
       

        protected void Page_Load(object sender, EventArgs e)

        {
            Session["navbar"] = na;
            if (!IsPostBack)
            {

                Controller controller = new Controller();
                Perfil = controller.Cliente(1);
                Plan.ID = Perfil.ID_Plan;
                Plan = controller.ListarPLan().Find(x => x.ID == Plan.ID);
                RutinaCliente.ID = Perfil.ID_rutina;
                RutinaCliente = controller.ListarRutinas().Find(x=>x.ID==RutinaCliente.ID);
                
                
                
            }

           
        }



        
    }
}