﻿using ACCIONES;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    List<Dias> listaDias = objController.ListarDias();
                    ddlDia.DataSource = listaDias;
                    ddlDia.DataValueField = "ID";
                    ddlDia.DataTextField = "dia";
                    ddlDia.DataBind();


                    foreach (int hora in horario_rutinas)
                    {
                        ddlHorario.Items.Add(new ListItem(hora.ToString(), hora.ToString()));
                    }
                    ddlHorario.DataBind();


                    if (Request.QueryString["id"] != null)
                    {
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

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("vistaListarRutinas.aspx", false);
        }
    }
}