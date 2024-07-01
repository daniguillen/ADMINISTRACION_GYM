using ACCIONES;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistasAministrador
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                    if (!IsPostBack)
                    {
                        if (Session["Nivel"] == null)
                        {
                            Session["Nivel"] = 1;
                           
                        }
                        else
                        {
                            
                        }
                    }
    

        }
        protected void IrAUsuario(object sender, EventArgs e)
        {
            Response.Redirect("AdministradorGeneral.aspx");
        }

        protected void IrARegistro(object sender, EventArgs e)
        {
            Response.Redirect("../registroPersona.aspx");
        }


        protected void IrAModificarRutina(object sender, EventArgs e)
        {
            Response.Redirect("../VistaEntrenador/vistaListarRutinas.aspx");
        }
        protected void IrAHistorial(object sender, EventArgs e)
        {
            Response.Redirect("AdministradorEditarUsuario.aspx");
        }
        protected void Mensaje(object sender, EventArgs e)
        {
            bool estado;
            Controller mensaje = new Controller();
            estado = mensaje.enviarMensaje(TextMensaje.Text);
            if (estado)
            {

                LblMensaje.Text = "Mensaje enviado: " + TextMensaje.Text;
                LblMensaje.Visible = true;
                TextMensaje.Text = "";
            }
            else
            {

                LblMensaje.Text = "No se envio el mensaje";

            }


        }


        protected void BtnModificarPrecio_Click(object sender, EventArgs e)
        {
           
            ScriptManager.RegisterStartupScript(this, this.GetType(), "MostrarModal", "showModal()", true);
        }



        protected void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Ocultar el modal


        
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CerrarModal", "$('#exampleModal').modal('hide');", true);

            // Eliminar la clase modal-backdrop
            ScriptManager.RegisterStartupScript(this, this.GetType(), "EliminarBackDrop", "$('.modal-backdrop').remove();", true);
        }
        protected void Cerrar(object sender, EventArgs e)
        {
            //BORRA EL MODAL
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CerrarModal", "$('#exampleModal').modal('hide');", true);

            //BORRA EL FONDO DEL MODAL
            ScriptManager.RegisterStartupScript(this, this.GetType(), "EliminarBackDrop", "$('.modal-backdrop').remove();", true);

        }
      
    }
}