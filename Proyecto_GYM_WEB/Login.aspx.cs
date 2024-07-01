using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
using System.EnterpriseServices.CompensatingResourceManager;
using Proyecto_GYM_WEB.VistasAministrador;
namespace Proyecto_GYM_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        public Usuario usuario { get; set; } = new Usuario();
        public Usuario aux { get; set; } = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nuevoUsuario"]!=null)
            {
                if (Session["nuevoUsuario"].Equals("activo"))
                    
                {
                    lblNuevoUsuario.Text = "<div class=\"alert alert-info\" role=\"alert\">Usuario creado con Exito!!</div>";
                    lblNuevoUsuario.Visible = true;

                }
            }
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
                    if(aux.nivel.ID == 1)
                    {
                        Session["PerfilUsuario"] = aux;
                        Session["navbar"] = "u";
                        Response.Redirect("VistaCliente/VistaUsuarioCliente.aspx", false);
                    }
                    if (aux.nivel.ID == 2)
                    {

                        Session["Entrenador"] = aux;
                        Session["navbar"] = "c";
                        Response.Redirect("VistaEntrenador/PantallaPrincipalEntrenador.aspx", false);
                    }
                    if (aux.nivel.ID == 3)
                    {

                       
                        Response.Redirect("VistasAdministrador/Administracion.aspx", false);
                    }
                }
                else
                {
                    lblError.Text = "<div class=\"alert alert-danger\" role=\"alert\">Usuario o Clave no Válida!!</div>";
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}