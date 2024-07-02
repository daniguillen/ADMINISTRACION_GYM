using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class VistaUsuarioCliente : System.Web.UI.Page
    {

        public Rutina rutinas_usuario = new Rutina();
        public Usuario Perfil = new Usuario();
        public Plan Plan = new Plan();


        public Controller controller = new Controller();
        public Rutina_ejercicio RutinaCliente = new Rutina_ejercicio();
        public List<Dias> dia_semana = new List<Dias>();

        public string mensaje = "";
        protected void Page_Load(object sender, EventArgs e)

        {

                mensaje =controller.MensajeDeAdministrador();
                LblInformacion.Text = mensaje;
                dia_semana = controller.ListarDias();
                dia_semana = dia_semana.OrderBy(d => d.id).ToList();
             
                Perfil = (Usuario)Session["PerfilUsuario"];
                Perfil.Foto = ".././" + Perfil.Foto;
                string ruta = Perfil.Foto.ToString();

              

                RepeaterUsuario.DataSource = dia_semana;
                RepeaterUsuario.DataBind();
            
        }

        public void DdlrutinaCLiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRutina = int.Parse(DdlrutinaCLiente.SelectedValue);
                if (idRutina == 1) {
                    rutinas_usuario = controller.Rutinas_id(1);
                }
                else if (idRutina == 2) {
                    rutinas_usuario = controller.Rutinas_id(2);
                }
                else if (idRutina == 3)
                {
                    rutinas_usuario = controller.Rutinas_id(3);
                }
                else if (idRutina == 4)
                {
                    rutinas_usuario = controller.Rutinas_id(Perfil.ID_rutina);
                }
                RepeaterUsuario.DataSource = rutinas_usuario.rutina_Ejercicios;
           
                 RepeaterUsuario.DataBind();


            
        }
      
    }
}