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
        public int usuarios= 0 ;
        public int entrenadores = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Usuario> ListaUsuarios=new List<Usuario>();
            Controller dato= new Controller();
            ListaUsuarios = dato.Listar_Clientes();
            foreach (var item in ListaUsuarios)
            {
                if (item.nivel.ID == 1) {
                    usuarios++;
                }
                if (item.nivel.ID == 2)
                {
                    entrenadores++;
                }

            }

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

        protected void BtnCambiarPrecioPlanes(object sender, EventArgs e)
        {
            // Obtener valores
            string value = DdlPlan.SelectedIndex.ToString();
            string text = TxtNuevoPrecio.Text;
            Controller controller = new Controller();
            bool estado=false;
            estado = controller.ActualizacionDePrecio(int.Parse(text), int.Parse(value));
            if (estado)
            {
                CambioPrecio.Text = "Se cambio Correctamente a  " + text;
            }
            else { CambioPrecio.Text = "Ocurrio un error contacte a soporte"; }
            TxtNuevoPrecio.Text = "";
            DdlPlan.SelectedIndex = -1;
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
                //  Response.Redirect("Historial.aspx");
                Response.Redirect("AprobarAptoFisico.aspx");
            }
        }
        protected void Pagar(object sender, EventArgs e) {

         //   TxtDniUsuarioPagar

            Controller controller1 = new Controller();  
            Usuario usuario = new Usuario();
           
                usuario = controller1.BuscarOneClientePorDNI(int.Parse(TxtDniUsuarioPagar.Text));
            if (usuario.DNI != null)
            {

                NoseEncuentraUsuario.Text = "Usuario Encontrado" + usuario.Nombre + " " + usuario.Apellido + " " + usuario.DNI;
            }
            else { 
                NoseEncuentraUsuario.Text = "No se encontro el Usuario";
            
            }

                NoseEncuentraUsuario.Visible = true;
        }
    }
}