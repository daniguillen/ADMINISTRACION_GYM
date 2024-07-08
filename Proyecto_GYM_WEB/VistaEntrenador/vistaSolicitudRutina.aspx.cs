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
            dgvSolicitudes.DataSource = datos.Listar_Solicitudes();
            dgvSolicitudes.DataBind();
        }

        protected void btnVerDetalles_Click(object sender, EventArgs e)
        {

        }
    }
}