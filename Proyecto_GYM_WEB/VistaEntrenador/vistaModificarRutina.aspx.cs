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
        //Lista ejercicios por un lado de la base
        //por otro lado necesito la lista de ejercicios a modificar

        Controller objController = new Controller();
        public List<Ejercicio> listEjercicio = new List<Ejercicio>();
        public int[] horario_rutinas = { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
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


                    if (Request.QueryString["id"] != null)
                    {
                        int rutinaid = int.Parse(Request.QueryString["id"]);
                        hfRutinaID.Value = rutinaid.ToString();


                        Rutina objRuti = objController.RutinaIdParaModificarRutina(rutinaid);
                        txtNombreRutina.Text = objRuti.nombre;
                        txtDescripcionRutina.Text = objRuti.descripcion;




                        Rutina_ejercicio objRuti_Ejer = objController.Rutina_EjercicioIdParaModificarRutina(rutinaid);
                        ddlDia.SelectedValue = objRuti_Ejer.dia.id.ToString();
                        //lbxEjercicio.SelectedValue = objRuti_Ejer.ejercicio.ToString(); //Me trae los ejercicios que estan para modificar



                        foreach (ListItem item in lbxEjercicio.Items)
                        {
                            var desplegableEjercicioAux = new Ejercicio();
                            desplegableEjercicioAux.ID = int.Parse(item.Value);
                            if (objRuti_Ejer.ejercicio.Any(x => x.ID == desplegableEjercicioAux.ID))

                                item.Selected = true;
                        }
                    }

                    foreach (int hora in horario_rutinas)
                    {
                        ddlHorario.Items.Add(new ListItem(hora.ToString(), hora.ToString()));
                    }

                    // Establecer el DataValueField y enlazar los datos al control
                    //  ddlHorario.DataValueField = "Value";
                    //   ddlHorario.DataTextField = "Horario";
                    ddlHorario.DataBind();




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
                    int id = int.Parse(hfRutinaID.Value);
                    string nombre = txtNombreRutina.Text;
                    string descripcion = txtDescripcionRutina.Text;
                    int idDiaSeleccionado = int.Parse(ddlDia.SelectedValue);


                    List<Ejercicio> ejerciciosSeleccionados = new List<Ejercicio>();
                    foreach (ListItem item in lbxEjercicio.Items)
                    {
                        if (item.Selected)
                        {
                            ejerciciosSeleccionados.Add(new Ejercicio { ID = int.Parse(item.Value) });

                        }
                    }

                    Rutina rutinaModificar = new Rutina

                    {
                        ID = id,
                        nombre = nombre,
                        descripcion = descripcion,

                    };
                    Dias diasModif = new Dias
                    {

                        id = idDiaSeleccionado,
                    };
                    objController.ModificarRutina(rutinaModificar);

                    Rutina_ejercicio rutina_EjercicioModi = new Rutina_ejercicio
                    {
                        ejercicio = ejerciciosSeleccionados,
                    };
                    var idEjercicioAnterior = 0;
                    for (int i = 0; i < ejerciciosSeleccionados.Count(); i++)
                    {
                        //if (rutina_EjercicioModi.ejercicio[i].ID == )
                        objController.datos = new AccesoDatos();
                        objController.ModificarRutinaEjercicio(rutinaModificar, diasModif.id, rutina_EjercicioModi.ejercicio[i].ID, idEjercicioAnterior);


                    }

                    Response.Redirect("vistaListarRutinas.aspx", false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}