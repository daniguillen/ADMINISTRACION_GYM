using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB.VistasAministrador
{
    public partial class Historiales : System.Web.UI.Page
    {
        public int IdUsuarioRecibido;
        public List<Historial>  HistorialUsuario= new List<Historial>();
        public Usuario elUsuarioEditar { get; set; } = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            
            
            

            //   ListUsuarios = (List<Usuario>)Session["ModificarCliente"];
            {
                HistorialUsuario= (List<Historial>)Session["Historial"];

                Session["Historial"] = null;
                RepeaterHistorial.DataSource = HistorialUsuario;
                RepeaterHistorial.DataBind();
            }
        }
       
            protected void Volver(object sender, EventArgs e)
        {




            Response.Redirect("./Administracion");
        }
    }
}