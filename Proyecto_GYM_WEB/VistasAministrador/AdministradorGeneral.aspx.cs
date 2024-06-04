using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistasAministrador
{
    public partial class AdministradorGeneral : System.Web.UI.Page
    {
        public Controller dato= new Controller();
       public List<Usuario> ListaUsuarios = new List<Usuario>();
        


        protected void Page_Load(object sender, EventArgs e)
        {
            Session["TOKEN"] = "ENTRO";
            Session["navBar"] = "a";
            if (Session["TOKEN"].ToString() != "ENTRO") {

                Response.Redirect("~/Default");
            }else { 
            
            
                
            
            }

            if (!IsPostBack)
            {



                //esto hay q cambiarlo y borrarlo
                ListaUsuarios = dato.listar_Clientes();
            }

            


        }
    }
}