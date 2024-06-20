using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Web.UI;

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