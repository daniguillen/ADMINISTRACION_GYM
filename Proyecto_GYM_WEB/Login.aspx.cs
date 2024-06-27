using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
namespace Proyecto_GYM_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        public Usuario usuario { get; set; } = new Usuario();
        public Usuario aux { get; set; } = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresoSesion_Click(object sender, EventArgs e)
        {

            Controller objController = new Controller();
            try
            {
                usuario.Mail = txtMail.Text;
                usuario.Password = txtContraseña.Text;
                aux = objController.IngresoConLogin(usuario.Mail, usuario.Password);

                if (aux.ID != 0)
                {
                    if (aux.nivel.ID == 2)
                    {

                        Session["Entrenador"] = aux;
                        Session["navbar"] = "c";
                        Response.Redirect("VistaEntrenador/PantallaPrincipalEntrenador.aspx", false);
                    }
                }
                else
                {
                    Response.Redirect("error.aspx",false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}