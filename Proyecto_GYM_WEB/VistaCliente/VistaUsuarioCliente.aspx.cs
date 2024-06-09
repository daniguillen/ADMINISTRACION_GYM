using System;
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


        public Usuario Perfil = new Usuario();
        public Plan Plan = new Plan();
        public string na = "u";
      //  public Rutina_ejercicio RutinaCliente = new Rutina_ejercicio();
        public string[] dia_semana={"LUNES", "MARTES","MIERCOLES","JUEVES","VIERNES","SABADO","DOMINGO"};

        protected void Page_Load(object sender, EventArgs e)

        {
            Session["navbar"] = na;
            if (!IsPostBack)
            {

                Controller controller = new Controller();
                Perfil = controller.Cliente(1);
                Plan.ID = Perfil.plan.ID;
                Plan = controller.ListarPLan().Find(x => x.ID == Plan.ID);
              //  RutinaCliente.ID = Perfil.ID_rutina;
               // RutinaCliente = controller.ListarRutinas().Find(x=>x.ID==RutinaCliente.ID);
                
                
                
            }

           
        }



        
    }
}