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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == "2")
                {
                    usuario = datos.Cliente(18);
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
                else
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
                if (!string.IsNullOrEmpty(DdlSexo.SelectedValue))
                {

                    usuario.sexo.ID = int.Parse(DdlSexo.SelectedValue);
                    usuario.sexo.Tipo = DdlSexo.SelectedItem.Text;
                }
                string ruta = Server.MapPath(".././Assets/perfil/");
                txtimagen.PostedFile.SaveAs(ruta+"perfil-"+usuario.ID+".jpg");

                usuario.Foto = "~/Assets/perfil-" + usuario.ID + ".jpg";


                Controller datos = new Controller();
                datos.ModificarCliente(usuario);

                Master.FindControl("img");
                //leer
                Image img =(Image)Master.FindControl("imgAvatar");
                img.ImageUrl = usuario.Foto;
                Session["PerfilUsuario"] = usuario.Foto;
            }
            catch (Exception ex)
            {
               Session.Add("error", ex.ToString()); 
            }
           

        }
    }
}