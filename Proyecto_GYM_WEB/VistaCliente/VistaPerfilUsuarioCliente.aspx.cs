using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        public Usuario usuario= new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["PerfilUsuario"];
            TxtDniEditar.Text = usuario.DNI;
        }
    }
}