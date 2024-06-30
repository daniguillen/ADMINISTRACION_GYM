using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class RegistroPersona : System.Web.UI.Page
    {
        public Usuario usuario= new Usuario();
        public Controller datos = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Ingreso(object sender, EventArgs e)
        {   
            usuario.Mail = txtMail.Text;
            usuario.Password=txtContraseña.Text;
            usuario.Nombre= txtNombre_Ingreso.Text;
            usuario.Apellido=txtApellido_Ingreso.Text;
            usuario.DNI = txtDNI.Text;
            if (DropDownList1.SelectedValue == "")
            {
                usuario.sexo.ID = 4;
            }
            else
            {
                usuario.sexo.ID = int.Parse(DropDownList1.SelectedValue);
            }
            usuario.Fecha_Nacimiento =Convert.ToDateTime(txtFechaNac.Text);
            usuario.Cel=txtCelular.Text;
            usuario.Tel_Emergencia = txtTelEmergencia.Text;
            usuario.Direccion=txtDireccion.Text;
            usuario.plan.ID = int.Parse(ddlplanes.SelectedValue);

        

            if (txtBoxArchivoAptoFisico!=null)
            {
                string ruta = Server.MapPath("~/Assets/Aptos/");
                txtBoxArchivoAptoFisico.PostedFile.SaveAs(ruta + "Apto_Fisico" + usuario.DNI + ".jpg");

                usuario.Apto_Fisico = "~/Assets/Aptos/Apto_Fisico" + usuario.DNI + ".jpg";
               
            }
            if (txtFoto != null)
            {
                string ruta = Server.MapPath("~/Assets/perfil/");
                txtFoto.PostedFile.SaveAs(ruta + "Perfil-" + usuario.DNI + ".jpg");

                usuario.Foto = "/Assets/perfil/Perfil-" + usuario.DNI + ".jpg";

            }
            datos.AltaCliente(usuario);
            Response.Redirect("Login.aspx", false);

            Session["nuevoUsuario"] = "activo";

        }
    }
}