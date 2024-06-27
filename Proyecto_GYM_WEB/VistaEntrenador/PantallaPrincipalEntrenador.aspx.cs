﻿using Dominio;
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
           

            if (Session["Entrenador"] != null)
            {
                Usuario usuario = (Usuario)Session["Entrenador"];
                lblBienvenida.Text = "BIENVENIDO ENTRENADOR " + usuario.Nombre + " QUE DESEA HACER HOY";
            }
            else
            {
                Response.Redirect("Login.aspx",false);
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


            //List<Dias> listaDias = objController.ListarDias();
            //ddlDia.DataSource = listaDias;
            //ddlDia.DataValueField = "ID";
            //ddlDia.DataTextField = "dia";
            //ddlDia.DataBind();

            //List<Rutina> listaRutina = objController.ListarRutinaParaAgregarEjercicio();
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
        private void CargaListaEjercicios()
        {
            ListaEjercicios = objController.ListarEjercicios();

        }
        private void CargaGruposMusculares()
        {
            ListagrupoMusculares = objController.ListarGrupoMuscular();
        }
        protected void ddlListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlListar.SelectedValue == "1") 
            {
                Response.Redirect("VistaEntrenador-EntrenamientosABM", false);
            }
            if(ddlListar.SelectedValue == "2")
            {
                Response.Redirect("vistaListarRutinas.aspx",false);
            }
        }

        protected void ddlAltas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlAltas.SelectedValue == "1")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal();", true);
            }
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
    }
}