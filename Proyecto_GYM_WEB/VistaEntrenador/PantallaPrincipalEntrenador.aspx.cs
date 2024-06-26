using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistaEntrenador
{
    public partial class PantallaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (Session["Entrenador"] != null)
            {
                Usuario usuario = (Usuario)Session["Entrenador"];
                lblBienvenida.Text = "BIENVENIDO ENTRENADOR " + usuario.Nombre + " QUE DESEA HACER HOY";
            }
            else
            {
                Response.Redirect("Login.aspx",false);
            }
        }





    }
}