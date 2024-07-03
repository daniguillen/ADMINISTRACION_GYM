using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Script.Serialization;
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
        public int[] horario_rutinas = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };


        public List<Ejercicio> ListaEjercicios
        {
            get
            {
                return (List<Ejercicio>)Session["ListaEjercicios"];
            }
            set { Session["ListaEjercicios"] = value; }
        }
        public List<GrupoMuscular> ListagrupoMusculares = new List<GrupoMuscular>();


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    CargaGruposMusculares();
                    CargaListaEjercicios();
                    LLenarDropDownList();
                    List<Ejercicio> listaEjercicio = objController.ListarEjercicios();                    

                    foreach (int hora in horario_rutinas)
                    {
                        ddlHorario.Items.Add(new ListItem(hora.ToString(), hora.ToString()));
                    }
                    ddlHorario.DataBind();

                    List<GrupoMuscular> listaGrupoM = objController.ListarGrupoMuscular();
                    ddlGrupoMuscu.DataSource = listaGrupoM;
                    ddlGrupoMuscu.DataValueField = "ID";
                    ddlGrupoMuscu.DataTextField = "Descripcion";
                    ddlGrupoMuscu.DataBind();
                                                  
                    Session["ListaEjercicios"] = listaEjercicio;
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //Redireccion pantalla error
            }

            string tableClass = "table table-striped table-bordered table-dark";  // Clase para la tabla
            string headerClass = "header-class";  // Clase para los encabezados
            string rowClass = "row-class";  // Clase para las filas
            string cellClass = "cell-class";  // Clase para las celdas
            string linkClass = "custom-link"; // Clase para los enlaces
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
                    ejerciciosPorGrupo[grupoMuscularId].Add($"<a href='ModificarEjercicio.aspx?id={ListaEjercicios[j].ID}' class='{linkClass}'>{ListaEjercicios[j].Nombre}</a>");
                    //ejerciciosPorGrupo[grupoMuscularId].Add($"<a href='#' class='{linkClass}' data-id='{ListaEjercicios[j].ID}'>{ListaEjercicios[j].Nombre}</a>");
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
        private void LLenarDropDownList()
        {
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

            List<GrupoMuscular> listaGrupo = objController.ListarGrupoMuscular();
            ddlGrupoMuscular.DataSource = listaGrupo;
            ddlGrupoMuscular.DataValueField = "ID";
            ddlGrupoMuscular.DataTextField = "Descripcion";
            ddlGrupoMuscular.DataBind();

            List<Ejercicio> listaEjercicio = objController.ListarEjercicios();
            lbxEjercicio.DataSource = listaEjercicio;
            lbxEjercicio.DataValueField = "ID";
            lbxEjercicio.DataTextField = "Nombre";
            lbxEjercicio.DataBind();


            List<Dias> listaDias = objController.ListarDias();
            ddlDia.DataSource = listaDias;
            ddlDia.DataValueField = "ID";
            ddlDia.DataTextField = "dia";
            ddlDia.DataBind();

            List<Rutina> listaRutina = objController.ListarRutinaParaAgregarEjercicio();
            ddlIDRutina.DataSource = listaRutina;
            ddlIDRutina.DataValueField = "ID";
            ddlIDRutina.DataTextField = "Nombre";
            ddlIDRutina.DataBind();
        }
        protected void btnAgregarEjercicioARutina_Click(object sender, EventArgs e)
        {
            try
            {
                Rutina_ejercicio nuevaRutinaEjercicio = new Rutina_ejercicio();
                Dias diaNuevo = new Dias();
                foreach (ListItem item in lbxEjercicio.Items)
                {
                    if (item.Selected)
                    {
                        int ejercicioID = int.Parse(item.Value);
                        Ejercicio ejer = ListaEjercicios.Find(y => y.ID == ejercicioID);
                        nuevaRutinaEjercicio.ejercicio.Add(ejer);
                    }
                }
                var rutinaID = int.Parse(ddlIDRutina.SelectedValue);
                diaNuevo.id = int.Parse(ddlDia.SelectedValue);
                nuevaRutinaEjercicio.hora = int.Parse(ddlHorario.SelectedValue);
                //  nuevaRutinaEjercicio.hora= int.Parse(txtHora.Text);

                foreach (var item in nuevaRutinaEjercicio.ejercicio)
                {
                    objController.datos = new AccesoDatos();
                    objController.AgregarRutinaXEjercicio(rutinaID, item.ID, diaNuevo, nuevaRutinaEjercicio);
                }

                Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void btnOpenModal3_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal3();", true);
        }


        protected void btnbtnSalirX3_Click(object sender, EventArgs e)
        {
            Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaPrincipalEntrenador", false);
        }
        protected void ddlGrupoMuscular_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grupoMuscularID = int.Parse(ddlGrupoMuscular.SelectedValue);
            List<Ejercicio> listaEjercicios = objController.ListarEjerciciosXGrupoMuscular(grupoMuscularID);
            Ejercicio objEjer = new Ejercicio();
            lbxEjercicio.DataSource = listaEjercicios;
            lbxEjercicio.DataValueField = "ID";
            lbxEjercicio.DataTextField = "NOMBRE";
            lbxEjercicio.DataBind();
        }

        protected void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Ejercicio> listaEjercicio = (List<Ejercicio>)Session["ListaEjercicios"];
            List<Ejercicio> listaEjercicioFiltrada = listaEjercicio.FindAll(x => x.Nombre.ToUpper().Contains(TxtBusqueda.Text.ToUpper()));
            lbxEjercicio.DataSource = listaEjercicioFiltrada;
            lbxEjercicio.DataBind();
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VistaEntrenador-EntrenamientosABM.aspx", false);
        }

        protected void btnModificarEjercicio_Click(object sender, EventArgs e)
        {
        }

     
    }
}