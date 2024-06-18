using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["PerfilUsuario"];
            TxtDniEditar.Text = usuario.DNI;
            TxtNombreEditar.Text = usuario.Nombre;
            TxtApellidoEditar.Text = usuario.Apellido;
            TxtPlanEditar.Text = usuario.plan.Tipo_Plan;
            TxtCelularEditar.Text = usuario.Cel;
            TxtTelEmergenciaEditar.Text = usuario.Tel_Emergencia;
            TxtEmailEditar.Text = usuario.Mail;
            TxtPasswordEditar.Text = usuario.Password;

            TxtFechaNacimientoEditar.Text = usuario.Fecha_Nacimiento.ToString("yyyy-MM-dd");
            TxtSexoEditar.Text = usuario.sexo.Tipo;
            TxtFechaIngresoEditar.Text = usuario.Fecha_ingreso.ToShortDateString();



        }

        protected void BTN_Guardar_Click(object sender, EventArgs e)
        {
            usuario.DNI=TxtDniEditar.Text;
            usuario.Nombre=TxtNombreEditar.Text;
            usuario.Apellido=TxtApellidoEditar.Text;
            usuario.Cel=TxtCelularEditar.Text;
            usuario.Tel_Emergencia = TxtTelEmergenciaEditar.Text;
            usuario.Mail = TxtEmailEditar.Text;
            usuario.Password = TxtPasswordEditar.Text;
            usuario.Fecha_Nacimiento = DateTime.Parse(TxtFechaNacimientoEditar.Text);
            usuario.sexo.Tipo=TxtSexoEditar.Text;


            Controller datos= new Controller();
           

        }
    }
}