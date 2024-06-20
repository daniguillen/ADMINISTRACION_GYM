using System;

namespace Proyecto_GYM_WEB
{
    public partial class RegistroPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Ingreso(object sender, EventArgs e)
        {
            Response.Redirect("VistaCliente/VistaUsuarioCliente");
        }
    }
}