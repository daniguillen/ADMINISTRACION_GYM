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

            if (Session["navbar"].ToString() == "c") { 
            NavbarUsuarios.Controls.Add(LoadNavbarEntrenador());
            }
            else if(Session["navbar"].ToString() == "b")
            {

                NavbarUsuarios.Controls.Add(LoadNavbarUsuario());
            }
            else 
            {
                LoadNavbarEntrenador();
            }



        }
        private Control LoadNavbarUsuario()
        {
            return new LiteralControl("  " +
                "            <asp:ContentPlaceHolder ID=ContentPlaceHolder1 runat=server>" +
                "            <nav class=navbar navbar-expand-lg bg-body-tertiary navbar-dark bg-dark>   " +
                "      <div class=container-fluid>  <a class=navbar-brand href=#>NOMBREGYM</a>" +
                " <button class=navbar-toggler type=button data-bs-toggle=collapse data-bs-target=#navbarNavAltMarkup aria-controls=navbarNavAltMarkup aria-expanded=false aria-label=Toggle navigation>  " +
                "   <span class=navbar-toggler-icon></span>  </button> <div class=collapse navbar-collapse id=navbarNavAltMarkup2>       " +
                "   <div class=navbar-nav> <a class=nav-link active aria-current=page href=VistaPerfilUsuarioCliente.aspx>Mi perfil</a> " +
                "     <a class=nav-link active href=VistaMisEntrenamientos.aspx>Mis Entrenamientos</a> " +
                "        <a class=btn btn-danger href=Login.aspx>Cerrar Sesion usuario</a>  " +
                "        </div> </div> " +
                "    </div> </nav> </asp:ContentPlaceHolder>");
        }

        private Control LoadNavbarEntrenador()
        {
            return new LiteralControl("   <asp:ContentPlaceHolder ID=ContentPlaceHolder2 runat=server> " +
                "                   <nav class=navbar navbar-expand-lg bg-body-tertiary navbar-dark bg-dark>  " +
                "                      <div class=container-fluid>   " +
                "                         <a class=navbar-brand href=#>NOMBREGYM</a>  " +
                "                          <button class=navbar-toggler type=button data-bs-toggle=collapse data-bs-target=#navbarNavAltMarkup aria-controls=navbarNavAltMarkup aria-expanded=false aria-label=Toggle navigation>    " +
                "                            <span class=navbar-toggler-icon></span> </button>  <div class=collapse navbar-collapse id=navbarNavAltMarkup>  " +
                "                              <div class=navbar-nav> <a class=nav-link active aria-current=page href=VistaPerfilEntrenador.aspx>Mi perfil</a> " +
                "                                <a class=nav-link active href=VistaEntrenador-Usuarios.aspx>Usuarios</a> <a class=nav-link active href=VistaEntrenador-EntrenamientosABM.aspx>Entrenamientos</a>  " +
                "                                  <a class=nav-link active href=VistaEntrenador-Clases.aspx>Clases</a>                                 <a class=btn btn-danger href=Login.aspx>Cerrar Sesion</a>  " +
                "                              </div>       </div>   </div>     </nav>              </asp:ContentPlaceHolder> ");


        }
        private Control LoadNavbardefault()
        {
            return new LiteralControl("<nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark\">\r\n    " +
                "                <div class=\"container\">\r\n   " +
                "                     <a class=\"navbar-brand\" runat=\"server\" href=\"~/\">Nombre de la aplicación</a>\r\n   " +
                "                     <button type=\"button\" class=\"navbar-toggler\" data-bs-toggle=\"collapse\" data-bs-target=\".navbar-collapse\" title=\"Alternar navegación\" aria-controls=\"navbarSupportedContent\"\r\n   " +
                "                         aria-expanded=\"false\" aria-label=\"Toggle navigation\">\r\n                            <span class=\"navbar-toggler-icon\"></span>\r\n " +
                "                       </button>\r\n                        <div class=\"collapse navbar-collapse d-sm-inline-flex justify-content-between\">\r\n               " +
                "             <ul class=\"navbar-nav flex-grow-1\">\r\n                                <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"~/\">Inicio</a></li>\r\n      " +
                "                          <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"~/About\">Acerca de</a></li>\r\n                                <li class=\"nav-item\"><a class=\"nav-link\" runat=\"server\" href=\"~/Contact\">Contacto</a></li>\r\n      " +
                "                          <li class=\"nav-item\"><a href=\"Login.aspx?id\" class=\"btn btn-success me-2\">Login d</a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </nav>");


        }
    }
}