using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class VistaUsuarioCliente : System.Web.UI.Page
    {

        public Rutina rutinas_usuario = new Rutina();
        public Usuario Perfil = new Usuario();
        public Plan Plan = new Plan();
        public string na = "u";

        public Rutina_ejercicio RutinaCliente = new Rutina_ejercicio();
        public List<Dias> dia_semana = new List<Dias>();


        protected void Page_Load(object sender, EventArgs e)

        {
            Session["navbar"] = na;
            if (!IsPostBack)
            {
                Controller controller = new Controller();
                dia_semana = controller.ListarDias();
                dia_semana = dia_semana.OrderBy(d => d.id).ToList();
                Perfil = controller.Cliente(1);
                Plan.ID = Perfil.plan.ID;
                Plan = controller.ListarPLan().Find(x => x.ID == Plan.ID);
                rutinas_usuario = controller.Rutinas_id(Perfil.ID_rutina);
                Session["PerfilUsuario"] = Perfil;
                RepeaterUsuario.DataSource = dia_semana;
                RepeaterUsuario.DataBind();



            }




        }




    }
}