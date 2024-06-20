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
        public Controller datos = new Controller();
        public string nivel="";
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagePerfil.ImageUrl = usuario.Foto;
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == "2")
                {
                    nivel = "2";
                    usuario = datos.Cliente(18);
                    ImagePerfil.ImageUrl = usuario.Foto;
                    TxtDniEditar.Visible=false;
                    TxtNombreEditar.Text = usuario.Nombre;
                    TxtNombreEditar.Enabled=false;
                    TxtApellidoEditar.Text = usuario.Apellido;
                    TxtApellidoEditar.Enabled = false;
                    TxtPlanEditar.Visible = false;
                    TxtCelularEditar.Visible = false;
                    TxtTelEmergenciaEditar.Visible = false;
                    TxtEmailEditar.Text = usuario.Mail;
                    TxtEmailEditar.Enabled = false;
                    TxtPasswordEditar.Visible = false;

                    TxtFechaNacimientoEditar.Visible = false;
                    DdlSexo.Visible = false;
                    TxtFechaIngresoEditar.Visible = false;

                }
                else
                {
                    usuario = (Usuario)Session["PerfilUsuario"];
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


        }

        protected void BTN_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                

                Usuario usuario = (Usuario)Session["PerfilUsuario"];
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

            
            }
            catch (Exception ex)
            {
               Session.Add("error", ex.ToString()); 
            }
           

        }
    }
}