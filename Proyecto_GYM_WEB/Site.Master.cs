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
            if (!IsPostBack)
            {
                if (Session["navbar"].ToString() == "c")
                {
                    NavbarUsuarios.Controls.Add(LoadNavbarEntrenador());
                }
                else if (Session["navbar"].ToString() == "b")
                {

                    NavbarUsuarios.Controls.Add(LoadNavbarUsuario());
                }
            }



        }
        private Control LoadNavbarUsuario()
        {
            string aux = "<nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark\">\r\n            <div class=\"container\">\r\n                <a class=\"navbar-brand\" runat=\"server\" href=\"~/\">Nombre de la aplicación</a>\r\n                <button type=\"button\" class=\"navbar-toggler\" data-bs-toggle=\"collapse\" data-bs-target=\".navbar-collapse\" title=\"Alternar navegación\" aria-controls=\"navbarSupportedContent\"\r\n                    aria-expanded=\"false\" aria-label=\"Toggle navigation\">\r\n                    <span class=\"navbar-toggler-icon\"></span>\r\n                </button>\r\n                <div class=\"collapse navbar-collapse d-sm-inline-flex justify-content-between\">\r\n                    <ul class=\"navbar-nav flex-grow-1\">\r\n                        <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"/Default\">Regresar</a></li>\r\n                        <li class=\"nav-item\"><a href=\"Login.aspx?id\" class=\"btn btn-success me-2\">Login</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>";
                return new LiteralControl(aux);
        }

        private Control LoadNavbarEntrenador()
        {


            string aux = "        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark\">\r\n            <div class=\"container\">\r\n                <a class=\"navbar-brand\" runat=\"server\" href=\"~/\">Bienvenido Entrenador</a>\r\n                <button type=\"button\" class=\"navbar-toggler\" data-bs-toggle=\"collapse\" data-bs-target=\".navbar-collapse\" title=\"Alternar navegación\" aria-controls=\"navbarSupportedContent\"\r\n                    aria-expanded=\"false\" aria-label=\"Toggle navigation\">\r\n                    <span class=\"navbar-toggler-icon\"></span>\r\n                </button>\r\n                <div class=\"collapse navbar-collapse d-sm-inline-flex justify-content-between\">\r\n                    <ul class=\"navbar-nav flex-grow-1\">\r\n                        <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"~/\">Inicio</a></li>\r\n                        <li class=\"nav-item\"><a href=\"Login.aspx?id\" class=\"btn btn-success me-2\">Salir</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>";
            return new LiteralControl(aux);


        }
       
    }
}