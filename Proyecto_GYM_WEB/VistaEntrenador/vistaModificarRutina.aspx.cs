using ACCIONES;
using Dominio;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
              
                    Rutina objRuti = objController.RutinaIdParaModificar(int.Parse(Request.QueryString["id"]));
                    txtNombreRutina.Text = objRuti.nombre;
                    txtDescripcionRutina.Text = objRuti.descripcion;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}