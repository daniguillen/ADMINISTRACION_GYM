using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Proyecto_GYM_WEB.VistasAministrador
{
    public partial class AdministradorGeneral : System.Web.UI.Page
    {
        public Controller dato = new Controller();

        // Cambié el almacenamiento de ListaUsuarios para usar Session
        public List<Usuario> ListaUsuarios
        {
            get { return (List<Usuario>)Session["ModificarCliente"]; }
            set { Session["ModificarCliente"] = value; }
        }

        public Usuario UsuarioEditar { get; set; } = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["TOKEN"] = "ENTRO";
            if (Session["TOKEN"] != null)
            {
                if (Session["TOKEN"].ToString() != "ENTRO")
                {
                    Response.Redirect("/");
                    return;
                }
                else
                {
                    if (!IsPostBack)
                    {
                        ListaUsuarios = dato.listar_Clientes();
                    }
                }
            }
            else
            {
                Response.Redirect("/");
            }
        }

        protected void Buscar(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Instructores();
        }
        protected void Entrenadores(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Instructores();
            LiteralUsuarios.Text = "<h1>Entrenadores</h1>";
        }
        protected void Usuarios(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Clientes();
            LiteralUsuarios.Text = "<h1>Clientes</h1>";
        }
    }
}