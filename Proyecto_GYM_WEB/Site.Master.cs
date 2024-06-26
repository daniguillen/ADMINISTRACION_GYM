using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["navbar"] == null){

             Session["navbar"]=""  ;
            }
            if (!IsPostBack)
            {

                if (Session["navbar"] != null)
                {
                    if (Session["navbar"].ToString() == "c")
                    {
                        NavbarEntrenador.Controls.Add(LoadNavbarEntrenador());
                    }
                    else if (Session["navbar"].ToString() == "u")
                    {
                        NavbarUsuarios.Controls.Add(LoadNavbarUsuario());
                    }
                }
            }


        }
        private Control LoadNavbarUsuario()
        {
            string aux = "<nav class=navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark>  <div class=container>" +
                "  <a class=navbar-brand runat=server href=~/>Nombre de la aplicación</a> " +
                "  <button type=buttonclass=navbar-togglerdata-bs-toggle=collapse data-bs-target=.navbar-collapse title=Alternar navegación aria-controls=navbarSupportedContent aria-expanded=false aria-label=Toggle navigation>" +
                " <span class=navbar-toggler-icon></span> </button><div class=collapse navbar-collapse d-sm-inline-flex justify-content-between><ul class=navbar-nav flex-grow-1> " +
                "  <li class=nav-item><a class=nav-linkrunat=serverhref=/Default>Regresar</a></li> " +
                "<li class=nav-item><a href=Login.aspx?id class=btn btn-success me-2>Login</a></li> </ul>  </div> </div> </nav>";
            return new LiteralControl(aux);
        }

        private Control LoadNavbarEntrenador()
        {


            string aux = "     <nav class=\"navbar  navbar-expand-sm navbar-toggleable-sm navbar-dark navPersonalizado mb-0\">\r\n" + "            <div class=\"container  justify-content-xl-between  \" id=\"containe\">\r\n                \r\n" +"            <a class=\"navbar-brand logo\" runat=\"server\" href=\"Default.aspx\">GYM</a>\r\n\r\n              \r\n" + "                \r\n\r\n                    " + "<button type=\"button\" class=\"navbar-toggler\" data-bs-toggle=\"collapse\" data-bs-target=\".navbar-collapse\" title=\"Alternar navegación\" aria-controls=\"navbarSupportedContent\"\r\n " + "                       aria-expanded=\"false\" aria-label=\"Toggle navigation\">\r\n                        <span class=\"navbar-toggler-icon\"></span>\r\n                    </button>\r\n " + "                   <div class=\"collapse  d-sm-inline-flex justify-content-between\">\r\n                        <ul class=\"navbar-nav flex-grow-1\">\r\n                            " + "<li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"VistaPerfil-Entrenador.aspx\">MI PERFIL</a></li>\r\n                            <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"VistaEntrenador-Usuarios.aspx\">USUARIOS</a></li>\r\n " + "                           <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"VistaEntrenador-EntrenamientosABM.aspx\">ENTRENAMIENTOS</a></li>\r\n                          " + "  <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"VistaEntrenador-Clases.aspx\">CLASES</a></li>\r\n                            <li class=\"nav-item\"><a href=\"Login.aspx?id\" class=\"btn btn-success me-2\">CERRAR SESION</a></li>\r\n    " + "                                               </ul>\r\n                    </div>\r\n                \r\n        " + "    </div>\r\n\r\n        </nav> ";
            return new LiteralControl(aux);


        }

    }
}