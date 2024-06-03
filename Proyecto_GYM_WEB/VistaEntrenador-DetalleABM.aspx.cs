using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class VistaEntrenador_Usuarios : System.Web.UI.Page
    {
        public GrupoMuscular grupoMus = new GrupoMuscular();
        public TipoEjercicio tipoEjercicio = new TipoEjercicio();
        public Ejercicio ejercicio = new Ejercicio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}