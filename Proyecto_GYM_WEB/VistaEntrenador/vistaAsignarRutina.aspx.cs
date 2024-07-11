using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistaEntrenador
{
    public partial class vistaAsignarRutina : System.Web.UI.Page
    {
        Controller datos = new Controller();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string usuarioID= Request.QueryString["userid"];
                string rutinaAsignadaID = Request.QueryString["id"];
                lblUsuarioID.Text = usuarioID;
                lblAsignarRutinaID.Text = rutinaAsignadaID;

                dgvRutinas.DataSource = datos.ListarSoloRutinas();
                dgvRutinas.DataBind();
            }
        }

        protected void btnvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaPrincipalEntrenador.aspx", false);
        }

        protected void btnAsignarRutina_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int rutinaId = int.Parse(button.CommandArgument);
            int usuarioID = int.Parse(lblUsuarioID.Text);
            int rutinaAsignadaID = int.Parse(lblAsignarRutinaID.Text);

            datos.AsignarRutinaAUsuario(rutinaId, usuarioID);
            datos.SolicitudYaAsignada(rutinaAsignadaID);

            Response.Redirect("PantallaPrincipalEntrenador.aspx", false);
        }

        protected void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Rutina> listaSolicitudesRutinas = datos.ListarSoloRutinas();
            List<Rutina> listaSolicitudesFiltrada = listaSolicitudesRutinas.FindAll(x => x.nombre.ToUpper().Contains(TxtBusqueda.Text.ToUpper()));
            dgvRutinas.DataSource = listaSolicitudesFiltrada;
            dgvRutinas.DataBind();
        }
    }
}