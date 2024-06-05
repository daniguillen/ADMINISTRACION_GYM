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
           // txtId.Enabled = false;
          //  txtIDEjercicio.Enabled = false;
            try
            {
                if (!IsPostBack)
                {

                    CargaGruposMusculares();
                    CargaListaEjercicios();

                    List<Dificultad> lista = objController.ListadoDeDificultad();
                    ddlDificultad.DataSource = lista;
                    ddlDificultad.DataValueField = "ID";
                    ddlDificultad.DataTextField = "Descripcion";
                    ddlDificultad.DataBind();

                    List<TipoEjercicio> listaTipoEj = objController.ListadoTipoEjercicio();
                    ddlTipo.DataSource = listaTipoEj;
                    ddlTipo.DataValueField = "ID";
                    ddlTipo.DataTextField = "Descripcion";
                    ddlTipo.DataBind();

                    List<GrupoMuscular> listaGrupo = objController.ListarGrupoMuscular();
                    ddlGrupoMuscu.DataSource = listaGrupo;
                    ddlGrupoMuscu.DataValueField = "ID";
                    ddlGrupoMuscu.DataTextField = "Descripcion";
                    ddlGrupoMuscu.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //Redireccion pantalla error
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                GrupoMuscular nuevoGrupo = new GrupoMuscular();

                AccesoDatos datos = new AccesoDatos();


                // nuevoGrupo.ID = int.Parse(txtId.Text);
                if(nuevoGrupo.Descripcion != "")
                {

                Ejercicio nuevoEjercicio = new Ejercicio();

                //nuevoEjercicio.ID = int.Parse(txtIDEjercicio.Text);
                nuevoEjercicio.Descripcion = txtDescripcionEj.Text;
                nuevoEjercicio.Nombre = txtNombre.Text;
                nuevoEjercicio.Repeticiones = int.Parse(txtRepeticiones.Text);
                nuevoEjercicio.Tipo_Dificultad = new Dificultad();
                nuevoEjercicio.Tipo_Dificultad.ID = int.Parse(ddlDificultad.SelectedValue);
                nuevoEjercicio.Video = txtVideo.Text;
                nuevoEjercicio.Tipo_Ejercicio = new TipoEjercicio();
                nuevoEjercicio.Tipo_Ejercicio.ID = int.Parse(ddlTipo.SelectedValue);
                nuevoEjercicio.Grupo_Muscular = new GrupoMuscular();
                nuevoEjercicio.Grupo_Muscular.ID = int.Parse(ddlGrupoMuscu.SelectedValue);

                objController.agregarEjercicio(nuevoEjercicio);
                ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "closeModal();", true);
                Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx",false);
                }
                else
                {
                nuevoGrupo.Descripcion = txtDescripcion.Text;
                objController.agregarGrupoMusucular(nuevoGrupo);

                }

            }
            catch(Exception ex) 
            {
                Session.Add("error", ex);
                throw;
                //redirigir a pantalla error.
            }

        }

        protected void btnOpenModal_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal();", true);
        }

    }
}