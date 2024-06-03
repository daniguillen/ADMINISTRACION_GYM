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
    public partial class VistaEntrenador_EntrenamientosABM : System.Web.UI.Page
    {
        Controller objController = new Controller();
        public List<Ejercicio> ListaEjercicios = new List<Ejercicio>();
        public List<GrupoMuscular> ListagrupoMusculares = new List<GrupoMuscular>(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargaGruposMusculares();
                CargaListaEjercicios();
            }
        }

        private void CargaListaEjercicios()
        {
            ListaEjercicios = objController.ListarEjercicios();

        }
        private void CargaGruposMusculares()
        {
            ListagrupoMusculares = objController.ListarGrupoMuscular();

        }
    }
}