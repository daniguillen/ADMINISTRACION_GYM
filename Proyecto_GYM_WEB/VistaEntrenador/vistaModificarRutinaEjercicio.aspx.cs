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
    public partial class vistaModificarRutinaEjercicio : System.Web.UI.Page
    {
        Controller objController = new Controller();
        Rutina objRutina = new Rutina();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                List<Ejercicio> listaEjercicio = objController.ListarEjercicios();
                lbxEjercicio.DataSource = listaEjercicio;
                lbxEjercicio.DataValueField = "ID";
                lbxEjercicio.DataTextField = "Nombre";
                lbxEjercicio.DataBind();

                if (Request.QueryString["id"] != null)
                {
                    int ejercicioID = int.Parse(Request.QueryString["id"]);

                    int idRutina = int.Parse(Request.QueryString["editarRutina"]);
                    Session["idRutina"] = idRutina;
                    hfIdEjercicio.Value = ejercicioID.ToString();
                }




            }

        }

        protected void btnModificarRutinaEjercicio_Click(object sender, EventArgs e)
        {

            if (hfIdEjercicio.Value != null)
            {
                List<Ejercicio> EjerciciosDeLaRutinaQueYaHaySeleccionado = new List<Ejercicio>();
                foreach (ListItem item in lbxEjercicio.Items)
                {
                    if (item.Selected)
                    {
                        EjerciciosDeLaRutinaQueYaHaySeleccionado.Add(new Ejercicio { ID = int.Parse(item.Value) });

                    }
                }
                Rutina_ejercicio rutina_EjercicioModi = new Rutina_ejercicio
                {
                    ejercicio = EjerciciosDeLaRutinaQueYaHaySeleccionado,


                };
                var idEjercicioAnterior = int.Parse(Request.QueryString["id"]);
                objRutina.ID = int.Parse(Session["idRutina"].ToString());
                for (int i = 0; i < EjerciciosDeLaRutinaQueYaHaySeleccionado.Count(); i++)
                {
                    objController.datos = new AccesoDatos();
                    objController.ModificarEjercicioParaRutina_Ejercicio(rutina_EjercicioModi.ejercicio[i].ID, idEjercicioAnterior, objRutina);
                }

                Response.Redirect("vistaListarRutinas.aspx", false);

            }
        }
    }
}