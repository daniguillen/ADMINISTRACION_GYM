using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using ACCIONES;
using Dominio;

namespace Proyecto_GYM_WEB
{
    public partial class VistaEntrenador_EntrenamientosABM : System.Web.UI.Page
    {
        Controller objController = new Controller();
        public List<Ejercicio> ListaEjercicios
        {
            get
            {
                return (List<Ejercicio>)Session["ListaEjercicios"];
            }
            set { Session["ListaEjercicios"] = value; }
        }
        public List<GrupoMuscular> ListagrupoMusculares = new List<GrupoMuscular>();
        public string[] dia_semana = { "LUNES", "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };

        protected void Page_Load(object sender, EventArgs e)
        {


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

                    List<Ejercicio> listaEjercicio = objController.ListarEjercicios();
                    lbxEjercicio.DataSource = listaEjercicio;       
                    lbxEjercicio.DataValueField = "ID";
                    lbxEjercicio.DataTextField = "Nombre";
                    lbxEjercicio.DataBind();

                    ddlDia.DataSource = dia_semana;
                    ddlDia.DataBind();

                    Session["ListaEjercicios"] = listaEjercicio;
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //Redireccion pantalla error
            }

            string tableClass = "table-class";  // Clase para la tabla
            string headerClass = "header-class";  // Clase para los encabezados
            string rowClass = "row-class";  // Clase para las filas
            string cellClass = "cell-class";  // Clase para las celdas
            string musculos = $"<tr class='{headerClass}'>";
            string ejercicio = "";

            for (int i = 0; i < ListagrupoMusculares.Count; i++)
            {
                musculos += $"<th class='{cellClass}'>" + ListagrupoMusculares[i].Descripcion + "</th>";
            }
            musculos += "</tr>";

            Dictionary<int, List<string>> ejerciciosPorGrupo = new Dictionary<int, List<string>>();


            for (int i = 0; i < ListagrupoMusculares.Count; i++)
            {
                if (!ejerciciosPorGrupo.ContainsKey(ListagrupoMusculares[i].ID))
                {
                    ejerciciosPorGrupo[ListagrupoMusculares[i].ID] = new List<string>();
                }
            }

            for (int j = 0; j < ListaEjercicios.Count; j++)
            {
                int grupoMuscularId = ListaEjercicios[j].Grupo_Muscular.ID;
                if (ejerciciosPorGrupo.ContainsKey(grupoMuscularId))
                {
                    ejerciciosPorGrupo[grupoMuscularId].Add(ListaEjercicios[j].Nombre);
                }
            }

            int maxEjercicios = ejerciciosPorGrupo.Values.Any() ? ejerciciosPorGrupo.Values.Max(ejercLista => ejercLista.Count) : 0;

            for (int i = 0; i < maxEjercicios; i++)
            {
                ejercicio += $"<tr class='{rowClass}'>";
                foreach (var grupo in ListagrupoMusculares)
                {
                    if (i < ejerciciosPorGrupo[grupo.ID].Count)
                    {
                        ejercicio += $"<td class='{cellClass}'>" + ejerciciosPorGrupo[grupo.ID][i] + "</td>";
                    }
                    else
                    {
                        ejercicio += $"<td class='{cellClass}'></td>";
                    }
                }
                ejercicio += "</tr>";
            }
            //string styloTabla= "class="
            string tablaCompleta = $"<table class='{tableClass}'>" + musculos + ejercicio + "</table>";

            myLiteralControl.Text = tablaCompleta;



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
                Ejercicio nuevoEjercicio = new Ejercicio();

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
                Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //redirigir a pantalla error.
            }

        }

        protected void btnAgregarRutina_Click(object sender, EventArgs e)
        {
            try
            {

                Rutina_ejercicio nuevaRutinaEjercicio = new Rutina_ejercicio();
                Rutina nuevarutina = new Rutina();
                nuevaRutinaEjercicio.ejercicio = new List<Ejercicio>();
                Dias diaNuevo = new Dias();

                nuevarutina.nombre = txtNombreRutina.Text;
                nuevarutina.descripcion = txtDescripcionRutina.Text;

                foreach (ListItem item in lbxEjercicio.Items)
                {


                    if (item.Selected)
                    {
                        int ejercicioID = int.Parse(item.Value);
                        Ejercicio ejer = ListaEjercicios.Find(y => y.ID == ejercicioID);

                        if (ejer != null)
                        {
                            nuevaRutinaEjercicio.ejercicio.Add(ejer);
                        }

                    }
                }

                diaNuevo.dia = ddlDia.Text;
                Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);

            }
            catch (Exception ex)
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

        protected void btnOpenModal2_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal2();", true);

        }

        protected void btnSalirX1_Click(object sender, EventArgs e)
        {
            Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
        }

        protected void btnSalirX2_Click(object sender, EventArgs e)
        {
            Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
        }
    }
}