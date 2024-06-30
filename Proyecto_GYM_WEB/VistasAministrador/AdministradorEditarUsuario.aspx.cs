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
    public partial class AdministradorEditarUsuario : System.Web.UI.Page
    {
        public int IdUsuarioRecibido;
        public List<Usuario> ListUsuarios = new List<Usuario>();
        public Usuario elUsuarioEditar { get; set; } = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            

            //   ListUsuarios = (List<Usuario>)Session["ModificarCliente"];
            if (!IsPostBack)
            {


            }
        }
       
            protected void Volver(object sender, EventArgs e)
        {




            Response.Redirect("./Administracion");
        }
    }
}