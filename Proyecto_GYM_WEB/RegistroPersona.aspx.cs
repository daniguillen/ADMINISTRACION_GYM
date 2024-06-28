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
            usuario.sexo.ID = int.Parse(DropDownList1.SelectedValue);
            usuario.Fecha_Nacimiento =Convert.ToDateTime(txtFechaNac.Text);
            usuario.Cel=txtCelular.Text;
            usuario.Tel_Emergencia = txtTelEmergencia.Text;
            usuario.Direccion=txtDireccion.Text;
            usuario.plan.ID = int.Parse(ddlplanes.SelectedValue);
           
            datos.AltaCliente(usuario,txtBoxArchivoAptoFisico,txtFoto);

        }
    }
}