using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACCIONES;
namespace Proyecto_GYM_WEB.VistaEntrenador
{
    public partial class PantallaPrincipal : System.Web.UI.Page
    {
        Controller objController = new Controller();
        public int[] horario_rutinas = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
        public List<GrupoMuscular> ListagrupoMusculares = new List<GrupoMuscular>();
        public List<Ejercicio> ListaEjercicios
        {
            get
            {
                return (List<Ejercicio>)Session["ListaEjercicios"];
            }
            set { Session["ListaEjercicios"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {

                    if (Session["Entrenador"] != null)
                    {
                        Usuario usuario = (Usuario)Session["Entrenador"];
                    }
                    else
                    {
                        Response.Redirect("Login.aspx", false);
                    }

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

                    List<Ejercicio> listaEjercicio = objController.ListarEjercicios();
                    //lbxEjercicio.DataSource = listaEjercicio;
                    //lbxEjercicio.DataValueField = "ID";
                    //lbxEjercicio.DataTextField = "Nombre";
                    //lbxEjercicio.DataBind();


                    List<Dias> listaDias = objController.ListarDias();
                    //ddlDia.DataSource = listaDias;
                    //ddlDia.DataValueField = "ID";
                    //ddlDia.DataTextField = "dia";
                    //ddlDia.DataBind();

                    List<Rutina> listaRutina = objController.ListarRutinaParaAgregarEjercicio();
                    //ddlIDRutina.DataSource = listaRutina;
                    //ddlIDRutina.DataValueField = "ID";
                    //ddlIDRutina.DataTextField = "Nombre";
                    //ddlIDRutina.DataBind();

                    //foreach (int hora in horario_rutinas)
                    //{
                    //    ddlHorario.Items.Add(new ListItem(hora.ToString(), hora.ToString()));
                    //}
                    //ddlHorario.DataBind();


                    Session["ListaEjercicios"] = listaEjercicio;
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




        protected void ddlModificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalirX1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaPrincipalEntrenador.aspx", false);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {


                Ejercicio nuevoEjercicio = new Ejercicio();

                nuevoEjercicio.Nombre = txtNombre.Text;
                nuevoEjercicio.Descripcion = txtDescripcionEj.Text;
                nuevoEjercicio.Repeticiones = int.Parse(txtRepeticiones.Text);
                nuevoEjercicio.Tipo_Dificultad = new Dificultad();
                nuevoEjercicio.Tipo_Dificultad.ID = int.Parse(ddlDificultad.SelectedValue);
                nuevoEjercicio.Video = txtVideo.Text;
                nuevoEjercicio.Tipo_Ejercicio = new TipoEjercicio();
                nuevoEjercicio.Tipo_Ejercicio.ID = int.Parse(ddlTipo.SelectedValue);

                nuevoEjercicio.Grupo_Muscular = new GrupoMuscular();
                nuevoEjercicio.Grupo_Muscular.ID = int.Parse(ddlGrupoMuscu.SelectedValue);

                objController.AgregarEjercicio(nuevoEjercicio);
                ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "closeModal();", true);
                Response.Redirect("PantallaPrincipalEntrenador.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
        protected void btnSalirX2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PantallaPrincipalEntrenador.aspx", false);
        }

        protected void btnAgregarRutina_Click1(object sender, EventArgs e)
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
                objController.AgregarRutina(nuevarutina);
                Response.Redirect("PantallaPrincipalEntrenador.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //redirigir a pantalla error.
            }

        }

        protected void btnRutina_Click(object sender, EventArgs e)
        {
            Response.Redirect("../VistaEntrenador/vistaListarRutinas.aspx");
        }

        protected void btnListadoEjercicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("../VistaEntrenador/VistaEntrenador-EntrenamientosABM.aspx", false);
        }

        protected void btnRutinaAlta_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal2();", true);

        }

        protected void btnAltaEjercicio_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal();", true);
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {

            Response.Redirect("VistaPerfil-Entrenador.aspx", false);
        }
    }
}