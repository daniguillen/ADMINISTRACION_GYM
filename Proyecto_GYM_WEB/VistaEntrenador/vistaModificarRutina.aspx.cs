using ACCIONES;
using Dominio;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistaEntrenador
{
    public partial class vistaModificarRutina : System.Web.UI.Page
    {
        Controller objController = new Controller();
        public int[] horario_rutinas = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
        public bool FiltroAvanzado { get; set; }
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
            try
            {
                FiltroAvanzado = chkAFiltroAvanzado.Checked;
                if (!IsPostBack)
                {

                    List<Dias> listaDias = objController.ListarDias();
                    ddlDia.DataSource = listaDias;
                    ddlDia.DataValueField = "ID";
                    ddlDia.DataTextField = "dia";   
                    ddlDia.DataBind();

                    Session["listaGrupoMuscular"] = objController.ListarGrupoMuscular();
                    ddlGrupoMuscular.DataSource = Session["listaGrupoMuscular"];
                    ddlGrupoMuscular.DataValueField = "ID";
                    ddlGrupoMuscular.DataTextField = "DESCRIPCION";
                    ddlGrupoMuscular.DataBind();

                    foreach (int hora in horario_rutinas)
                    {
                        ddlHorario.Items.Add(new ListItem(hora.ToString(), hora.ToString()));
                    }
                    ddlHorario.DataBind();


                    if (Request.QueryString["id"] != null)
                    {   //Modifico la rutina 
                        int rutinaid = int.Parse(Request.QueryString["id"]);
                        hfRutinaID.Value = rutinaid.ToString();


                        Rutina objRuti = objController.RutinaIdParaModificarRutina(rutinaid);
                        txtNombreRutina.Text = objRuti.nombre;
                        txtDescripcionRutina.Text = objRuti.descripcion;

                        Rutina_ejercicio objRuti_Ejer = objController.Rutina_EjercicioIdParaModificarRutina(rutinaid);
                        ddlDia.SelectedValue = objRuti_Ejer.dia.id.ToString();
                        ddlHorario.SelectedValue = objRuti_Ejer.hora.ToString();

                    }

                }
                else
                {
                    // Mantén el estado del checkbox durante el postback
                    FiltroAvanzado = chkAFiltroAvanzado.Checked;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void btnModificarRutina_Click(object sender, EventArgs e)
        {
            try
            {
                if (hfRutinaID.Value != null)
                {
                    int idRuti = int.Parse(hfRutinaID.Value);
                    string nombre = txtNombreRutina.Text;
                    string descripcion = txtDescripcionRutina.Text;
                    int idDiaSeleccionado = int.Parse(ddlDia.SelectedValue);
                    int horarioSeleccionado = int.Parse(ddlHorario.SelectedValue);

                    Rutina rutinaModificar = new Rutina

                    {
                        ID = idRuti,
                        nombre = nombre,
                        descripcion = descripcion,

                    };
                    objController.ModificarRutina(rutinaModificar);
                    Dias diasModif = new Dias
                    {

                        id = idDiaSeleccionado,
                    };

                    Rutina_ejercicio rutina_HoraModi = new Rutina_ejercicio
                    {
                        hora = horarioSeleccionado
                    };

                    objController.ModificarRutinaEjerciDiaHora(diasModif, rutina_HoraModi, rutinaModificar);
                    Response.Redirect("vistaListarRutinas.aspx", false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                int rutinaid = int.Parse(hfRutinaID.Value);
                int ejercicioNuevo = 0;
                int IDejercicioQueMeTraigoDelFront = int.Parse(hfEjercicioID.Value); //Este ejercicio me trae el modal

                foreach (ListItem item in ddlEjercicios.Items)
                {
                    if (item.Selected)
                    {
                        ejercicioNuevo = int.Parse(item.Value);

                    }
                }

                objController.ModificarEjercicio(rutinaid, IDejercicioQueMeTraigoDelFront, ejercicioNuevo);
                ListaTablaRuti = objController.ListarTablaRutinas();

                ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "closeModal();", true);
                Response.Redirect("vistaModificarRutina.aspx?id=" + hfRutinaID.Value, false);

                UpdatePanel1.Update();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        protected void ddlGrupoMuscular_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grupoMuscularID = int.Parse(ddlGrupoMuscular.SelectedValue);
            List<Ejercicio> listaEjercicios = objController.ListarEjerciciosXGrupoMuscular(grupoMuscularID);
            Ejercicio objEjer = new Ejercicio();
            ddlEjercicios.DataSource = listaEjercicios;
            ddlEjercicios.DataValueField = "ID";
            ddlEjercicios.DataTextField = "NOMBRE";
            ddlEjercicios.DataBind();

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int rutinaid = int.Parse(hfRutinaID.Value);
            int ejercicioSeleccionado = int.Parse(hfEjercicioID.Value);
            objController.eliminarEjercicio(rutinaid, ejercicioSeleccionado);
            ListaTablaRuti = objController.ListarTablaRutinas();

            Response.Redirect("vistaModificarRutina.aspx?id=" + hfRutinaID.Value, false);
            UpdatePanelTabla.Update();
        }

        protected void ddlEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ejercicioID = int.Parse(ddlEjercicios.SelectedValue);
            Ejercicio objEjercicioID = objController.BuscarEjercicioPorID(ejercicioID);
            txtRepeticiones.Text = objEjercicioID.Repeticiones.ToString();
        }

        protected void btnOpenModal_Click(object sender, EventArgs e)
        {
            Session["NombreRutina"] = txtNombreRutina.Text;
            Session["DescripcionRutina"] = txtDescripcionRutina.Text;
            Session["Horario"] = ddlHorario.SelectedValue;
            Session["Dia"] = ddlDia.SelectedValue;
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModalScript", "openModal();", true);
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("vistaListarRutinas.aspx", false);
        }
        protected void btnSalirX1_Click(object sender, EventArgs e)
        {
            Response.Redirect("vistaModificarRutina.aspx?id=" + hfRutinaID.Value, false);
        }
        protected void chkAFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado = chkAFiltroAvanzado.Checked;
        }

    }
}