using ACCIONES;
using Dominio;
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

            /*
             
             
            if (Session["Nivel"] == null ||  !Session["Nivel"].Equals("3")){


                Response.Redirect("/");
            }
             


            */

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




        protected void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Obtener valores
            string value = DdlPlan.SelectedIndex.ToString();
            string text = TxtNuevoPrecio.Text;
            Controller controller = new Controller();
                 CambioPrecio.Text = "Se cambio Correctamente a  "+text;
            

    
        }
        protected void BuscarHistorial(object sender, EventArgs e)
        {
            // Obtener valores
           // TxtDNI
            Controller controller = new Controller();

            

            List<Historial> list = new List<Historial>();
            list= controller.historiaPorDNI(int.Parse(TxtDNI.Text));
            if (list.Count > 0) {
                Session["Historial"] = list;
                Response.Redirect("Historial.aspx");
            }
        }
    }
}