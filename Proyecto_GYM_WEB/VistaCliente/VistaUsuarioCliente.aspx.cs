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

            if (!IsPostBack)
            {
                mensaje =controller.MensajeDeAdministrador();
                LblInformacion.Text = mensaje;
                dia_semana = controller.ListarDias();
                dia_semana = dia_semana.OrderBy(d => d.id).ToList();
                //      string[] prueba = (String[])Session["PerfilUsuario"];
                Perfil = (Usuario)Session["PerfilUsuario"];
                Perfil.Foto = ".././" + Perfil.Foto;
                string ruta = Perfil.Foto.ToString();
                // Plan.ID = Perfil.plan.ID;
                // Plan = controller.ListarPLan().Find(x => x.ID == Plan.ID);
                rutinas_usuario = controller.Rutinas_id(1);
                Session["PerfilUsuario"] = Perfil;
                RepeaterUsuario.DataSource = dia_semana;
                RepeaterUsuario.DataBind();



            }




        }




    }
}