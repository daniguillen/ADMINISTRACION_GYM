using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class VistaUsuarioCliente : System.Web.UI.Page
    {

        public Rutina rutinas_usuario;
        public Usuario Perfil = new Usuario();
        public Plan Plan = new Plan();
        public Controller controller = new Controller();
        

        public string mensaje = "";
        protected void Page_Load(object sender, EventArgs e)

        {
            rutinas_usuario = new Rutina();

            mensaje = controller.MensajeDeAdministrador();
                LblInformacion.Text = mensaje;
              

                Perfil = (Usuario)Session["PerfilUsuario"];
                Perfil.Foto = ".././" + Perfil.Foto;

             


        }

        public void DdlrutinaCLiente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int idRutina = int.Parse(DdlrutinaCLiente.SelectedValue);
                rutinas_usuario = controller.Rutinas_id(idRutina == 4 ? Perfil.ID_rutina : idRutina);

             
            
        }
      
    }
}