using Dominio;
using System;

namespace Proyecto_GYM_WEB
{
    public partial class VistaPerfil_Entrenador : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            // usuario = (Usuario)Session[];
        }
    }
}