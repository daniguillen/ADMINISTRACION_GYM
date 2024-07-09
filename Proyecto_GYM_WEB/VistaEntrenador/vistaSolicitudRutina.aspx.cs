using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using ACCIONES;
using System.Globalization;
namespace Proyecto_GYM_WEB.VistaEntrenador
{
    public partial class vistaSolicitudRutina : System.Web.UI.Page
    {
        Controller datos = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            dgvSolicitudes.DataSource = datos.Listar_Solicitudes();
            dgvSolicitudes.DataBind();

                

            }
        }
     

        protected void btnSalirAltaRutina_Click(object sender, EventArgs e)
        {
            Response.Redirect("vistaSolicitudRutina.aspx", false);
        }

        protected void btnAsignarRutina_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModalRutiAsignada();", true);
        }

        protected void btnAgregarRutinaSolicitada_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = txtNombreRutina.Text.Trim();
                string descripcion = txtDescripcionRutina.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Por favor, complete todos los campos.');", true);
                    return;
                }

                Rutina nuevarutina = new Rutina();

                nuevarutina.nombre = txtNombreRutina.Text;
                nuevarutina.descripcion = txtDescripcionRutina.Text;
                datos.AgregarRutina(nuevarutina);
                Response.Redirect("vistaSolicitudRutina", false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //redirigir a pantalla error.
            }
        }

        protected void btnvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaPrincipalEntrenador.aspx", false);
        }
    }
}