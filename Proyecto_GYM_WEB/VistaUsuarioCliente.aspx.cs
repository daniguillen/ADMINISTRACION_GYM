using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class VistaUsuarioCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "b";
            Session["navbar"] = a;
            //Capturo el valor: "PRUEBA"
            // string user = Request.QueryString["txtNombre_Ingreso"].ToString();
            //  lblSaludoUser.Text = user + "Tu ingreso fue existoso";
        }
    }
}