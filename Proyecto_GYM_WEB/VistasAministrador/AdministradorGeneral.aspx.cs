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
                Label1.Text = TxtBusquedad.Text;
        }

        protected void Entrenadores(object sender, EventArgs e)
        {

            ListaUsuarios = dato.listar_Clientes();
            List<Usuario> AuxListaUsuarios = new List<Usuario>();
            foreach (var i in ListaUsuarios)
            {
                if (i.nivel.ID == 2)
                {
                    AuxListaUsuarios.Add(i);
                }

            }
            LiteralUsuarios.Text = "<h1> Entrenadores </h1>";
            ListaUsuarios = AuxListaUsuarios;
            BindRepeater();
        }

        protected void Usuarios(object sender, EventArgs e)
        {
            ListaUsuarios = dato.listar_Clientes();
            List<Usuario> AuxListaUsuarios = new List<Usuario>();
            foreach (var i in ListaUsuarios)
            {
                if (i.nivel.ID == 1)
                {
                    AuxListaUsuarios.Add(i);
                }

            }
            LiteralUsuarios.Text = "<h1> Usuarios </h1>";
            ListaUsuarios = AuxListaUsuarios;
            BindRepeater();
        }
        protected void Rutinas(object sender, EventArgs e)
        {
            LiteralUsuarios.Text = "<h1> Rutina </h1>";
            
            
        }
            protected void MensajeAUsuarioYEntrenadores(object sender, EventArgs e)
        {
            TextBox2.Text ="Mensaje enviado: "+ TextBox1.Text;
            TextBox1.Text = "";
        }

        protected void BtnEliminar_Persona_Command(object sender, CommandEventArgs e)
        {
            int userId;
            if (int.TryParse(e.CommandArgument.ToString(), out userId))
            {
                Label1.Text = "ID del usuario: " + userId.ToString();
                dato.Eliminar_Persona_x_ID(userId);
                ListaUsuarios = dato.listar_Clientes();
                BindRepeater();
            }
            else
            {
                Label1.Text = "No se pudo obtener el ID del usuario.";
            }
        }



        protected void BtnActivar(object sender, CommandEventArgs e)
        {
            int userId;
            if (int.TryParse(e.CommandArgument.ToString(), out userId))
            {

                dato.Activar_Cliente_PorID(userId);
                ListaUsuarios = dato.listar_Clientes();
                BindRepeater();
            }

        }

    }

}