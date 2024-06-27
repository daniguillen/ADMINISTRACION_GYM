using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class VistaPerfil_Entrenador : System.Web.UI.Page
    {
        public Usuario usuario = new Usuario();
        public Controller objController = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            // usuario = (Usuario)Session[];

            ImagePerfil.ImageUrl = usuario.Foto;
            if (!IsPostBack)
            {
                
                usuario = (Usuario)Session["Entrenador"];
                    
                    ImagePerfil.ImageUrl = usuario.Foto;
                    TxtDniEditar.Text = usuario.DNI;
                    TxtNombreEditar.Text = usuario.Nombre;
                    TxtApellidoEditar.Text = usuario.Apellido;
                    TxtPlanEditar.Text = usuario.plan.Tipo_Plan;
                    TxtCelularEditar.Text = usuario.Cel;
                    TxtTelEmergenciaEditar.Text = usuario.Tel_Emergencia;
                    TxtEmailEditar.Text = usuario.Mail;
                    TxtPasswordEditar.Text = usuario.Password;

                    TxtFechaNacimientoEditar.Text = usuario.Fecha_Nacimiento.ToString("yyyy-MM-dd");
                    DdlSexo.SelectedItem.Text = usuario.sexo.Tipo;
                    TxtFechaIngresoEditar.Text = usuario.Fecha_ingreso.ToShortDateString();
                }

            }

        protected void BTN_Guardar_Click(object sender, EventArgs e)
        {
            try
            {

                usuario = (Usuario)Session["Entrenador"];
                usuario.DNI = TxtDniEditar.Text;
                usuario.Nombre = TxtNombreEditar.Text;
                usuario.Apellido = TxtApellidoEditar.Text;
                usuario.Cel = TxtCelularEditar.Text;
                usuario.Tel_Emergencia = TxtTelEmergenciaEditar.Text;
                usuario.Mail = TxtEmailEditar.Text;
                usuario.Password = TxtPasswordEditar.Text;
                usuario.Fecha_Nacimiento = DateTime.Parse(TxtFechaNacimientoEditar.Text);
                usuario.ID_rutina = 1;
                if (!string.IsNullOrEmpty(DdlSexo.SelectedValue))
                {

                    usuario.sexo.ID = int.Parse(DdlSexo.SelectedValue);
                    usuario.sexo.Tipo = DdlSexo.SelectedItem.Text;
                }

                if (!txtimagen.Value.Equals(""))
                {
                    string ruta = Server.MapPath(".././Assets/perfil/");
                    txtimagen.PostedFile.SaveAs(ruta + "perfil-" + usuario.ID + ".jpg");

                    usuario.Foto = "../Assets/perfil/perfil-" + usuario.ID + ".jpg";
                    ImagePerfil.ImageUrl = usuario.Foto;
                }
                else
                {

                    if (!usuario.Foto.Equals(""))
                    {
                        ImagePerfil.ImageUrl = usuario.Foto;

                    }

                }

                Controller datos = new Controller();
                datos.ModificarCliente(usuario);
                Session["Entrenador"] = usuario;

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }

    
}
