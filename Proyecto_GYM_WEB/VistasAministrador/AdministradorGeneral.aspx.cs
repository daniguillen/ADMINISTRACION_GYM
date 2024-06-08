using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

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
                        BindRepeater();
                    }
                }
            }
            else
            {
                Response.Redirect("/");
            }
        }

        private void BindRepeater()
        {
            RepeaterUsuarios.DataSource = ListaUsuarios;
            RepeaterUsuarios.DataBind();
        }

        protected void Buscar(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Instructores();
            BindRepeater();
        }

        protected void Entrenadores(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Instructores();
            LiteralUsuarios.Text = "<h1>Entrenadores</h1>";
            BindRepeater();
        }

        protected void Usuarios(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Clientes();
            LiteralUsuarios.Text = "<h1>Clientes</h1>";
            BindRepeater();
        }

        protected void BtnEliminar_Command(object sender, CommandEventArgs e)
        {
            int userId;
            if (int.TryParse(e.CommandArgument.ToString(), out userId))
            {
                Label1.Text = "ID del usuario: " + userId.ToString();
                
                ListaUsuarios = dato.listar_Clientes();
                BindRepeater(); 
            }
            else
            {
                Label1.Text = "No se pudo obtener el ID del usuario.";
            }
        }
    }
}