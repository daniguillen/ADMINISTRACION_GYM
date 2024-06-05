using ACCIONES;
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
        Controller objController = new Controller();
        public List<Ejercicio> ListaEjercicios = new List<Ejercicio>();
        public List<GrupoMuscular> ListagrupoMusculares = new List<GrupoMuscular>();
        protected void Page_Load(object sender, EventArgs e)
        {
           // txtId.Enabled = false;
           // txtIDEjercicio.Enabled = false;

            try
            {
                if (!IsPostBack)
                {
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoMuscular nuevoGrupo = new GrupoMuscular();

                AccesoDatos datos = new AccesoDatos();


                // nuevoGrupo.ID = int.Parse(txtId.Text);
                nuevoGrupo.Descripcion = txtDescripcion.Text;

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

                objController.agregarGrupoMusucular(nuevoGrupo);
                objController.agregarEjercicio(nuevoEjercicio);
                Response.Redirect("VistaPrincipalEntrenador.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //redirigir a pantalla error.
            }
        }
    }
}