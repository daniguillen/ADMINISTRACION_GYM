using ACCIONES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class vistaListarRutinas : Page
    {
        Controller objController = new Controller();
        public List<AuxTablaRutina> ListaTablaRuti
        {
            get
            {
                return (List<AuxTablaRutina>)Session["ModifListaRutina"];
            }
            set { Session["ModifListaRutina"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<AuxTablaRutina> tablaRutina = new List<AuxTablaRutina>();

            if (!IsPostBack)
            {
                tablaRutina = objController.ListarTablaRutinas();
                Session["ModifListaRutina"] = tablaRutina;
            }
        }
    }
}