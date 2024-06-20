using Dominio;
using System;
using System.Collections.Generic;

namespace Proyecto_GYM_WEB.VistasAministrador
{
    public partial class AdministradorEditarUsuario : System.Web.UI.Page
    {
        public int IdUsuarioRecibido;
        public List<Usuario> ListUsuarios = new List<Usuario>();
        public Usuario elUsuarioEditar { get; set; } = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

            IdUsuarioRecibido = int.Parse(Request.QueryString["id"]);


            //   ListUsuarios = (List<Usuario>)Session["ModificarCliente"];
            if (!IsPostBack)
            {
                ListUsuarios = (List<Usuario>)Session["ModificarCliente"];

                elUsuarioEditar = ListUsuarios.Find(x => x.ID == IdUsuarioRecibido);

                TxtDniEditar.Text = elUsuarioEditar.DNI.ToString();
                TxtNombreEditar.Text = elUsuarioEditar.Nombre;
                TxtApellidoEditar.Text = elUsuarioEditar.Apellido;
                TxtPlanEditar.Text = elUsuarioEditar.plan.Tipo_Plan.ToString();
                TxtCelularEditar.Text = elUsuarioEditar.Cel;
                TxtTelEmergenciaEditar.Text = elUsuarioEditar.Tel_Emergencia;
                TxtEmailEditar.Text = elUsuarioEditar.Mail;
                TxtPasswordEditar.Text = elUsuarioEditar.Password;
                TxtFechaNacimientoEditar.Text = elUsuarioEditar.Fecha_Nacimiento.ToString("yyyy-MM-dd");
                TxtSexoEditar.Text = elUsuarioEditar.sexo.Tipo.ToString();
                TxtFechaIngresoEditar.Text = elUsuarioEditar.Fecha_ingreso.ToString("yyyy-MM-dd");
                TxtEstadoEditar.Text = elUsuarioEditar.Estado ? "Activo" : "Inactivo";
                TxtNivelEditar.Text = elUsuarioEditar.plan.ID.ToString();

            }
        }
    }
}