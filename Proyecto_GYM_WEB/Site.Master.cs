using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Prueba para sacar navbarMaster en otras paginas
            // string NavbarOcultoParaPaginas= System.IO.Path.GetFileName(Request.Url.AbsolutePath);
            //   if(NavbarOcultoParaPaginas == "VistaUsuarioCliente.aspx")
            //  {
            //      NavbarPanel.Visible = false;
            //  }
        }
    }
}