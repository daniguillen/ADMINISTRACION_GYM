using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistaEntrenador
{
    public partial class ModificarEjercicio : System.Web.UI.Page
    {
        Controller objController = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDropDownList();

                int ejercicioIdSeleccionado;
                if (int.TryParse(Request.QueryString["id"], out ejercicioIdSeleccionado))
                {


                    Ejercicio objEjercicio = objController.BuscarEjercicioPorID(ejercicioIdSeleccionado);
                    txtNombreEjercicio.Text = objEjercicio.Nombre;
                    txtDescripcion.Text = objEjercicio.Descripcion;
                    txtRepeticiones.Text = objEjercicio.Repeticiones.ToString();
                    txtVideo.Text = objEjercicio.Video;
                    ddlDificultad.SelectedValue = objEjercicio.Tipo_Dificultad.ID.ToString();
                    ddlGrupoMuscu.SelectedValue = objEjercicio.Grupo_Muscular.ID.ToString();
                    ddlTipo.SelectedValue = objEjercicio.Tipo_Ejercicio.ID.ToString();
                }
                //Validar else
            }
        }

        protected void btnGuardarCambiosEjercicio_Click(object sender, EventArgs e)
        {
            try
            {

                Ejercicio modificarEjercicio = new Ejercicio()
                {
                    ID = int.Parse(Request.QueryString["id"]),
                    Nombre = txtNombreEjercicio.Text,
                    Descripcion = txtDescripcion.Text,
                    Repeticiones = int.Parse(txtRepeticiones.Text),
                    Video = txtVideo.Text,
                    Grupo_Muscular = new GrupoMuscular { ID = int.Parse(ddlGrupoMuscu.SelectedValue) },
                    Tipo_Ejercicio = new TipoEjercicio { ID = int.Parse(ddlTipo.SelectedValue) },
                    Tipo_Dificultad = new Dificultad { ID = int.Parse(ddlDificultad.SelectedValue) },

                };
                GrupoMuscular muscular = new GrupoMuscular { ID = int.Parse(ddlGrupoMuscu.SelectedValue) };
                TipoEjercicio tipo = new TipoEjercicio { ID = int.Parse(ddlTipo.SelectedValue) };
                Dificultad dificultad = new Dificultad { ID = int.Parse(ddlDificultad.SelectedValue) };

                objController.ModificarEjercicioCompleto(modificarEjercicio, muscular, tipo, dificultad);
                Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarDropDownList()
        {
            List<GrupoMuscular> listaGrupo = objController.ListarGrupoMuscular();
            ddlGrupoMuscu.DataSource = listaGrupo;
            ddlGrupoMuscu.DataValueField = "ID";
            ddlGrupoMuscu.DataTextField = "Descripcion";
            ddlGrupoMuscu.DataBind();

            List<Dificultad> listaDificultad = objController.ListadoDeDificultad();
            ddlDificultad.DataSource = listaDificultad;
            ddlDificultad.DataValueField = "ID";
            ddlDificultad.DataTextField = "Descripcion";
            ddlDificultad.DataBind();

            List<TipoEjercicio> listaTipoEj = objController.ListadoTipoEjercicio();
            ddlTipo.DataSource = listaTipoEj;
            ddlTipo.DataValueField = "ID";
            ddlTipo.DataTextField = "Descripcion";
            ddlTipo.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
        }
    }
}