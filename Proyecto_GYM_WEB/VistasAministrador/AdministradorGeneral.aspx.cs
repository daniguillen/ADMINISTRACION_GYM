using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Web.UI;
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
            TextBox2.Text = "Mensaje enviado: " + TextBox1.Text;
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

        protected void Modificar(object sender, CommandEventArgs e)
        {
            string[] valores = e.CommandArgument.ToString().Split(',');

            // Asigna valores a los TextBox
            TxtDNI.Text = valores[1];
            TxtNombre.Text = valores[2];
            TxtApellido.Text = valores[3];
            TxtPlan.Text = valores[4];
            TxtTelEmerg.Text = valores[5];
            TxtMail.Text = valores[6];
            TxtSexo.Text = valores[8];
            TxtEstado.Text = valores[9];

            // Actualiza los labels con JavaScript
            ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateLabels",
                $"document.getElementById('{TxtDNI.ClientID}').value = '{valores[1]}';" +
                $"document.getElementById('{TxtNombre.ClientID}').value = '{valores[2]}';" +
                $"document.getElementById('{TxtApellido.ClientID}').value = '{valores[3]}';" +
                $"document.getElementById('{TxtPlan.ClientID}').value = '{valores[4]}';" +
                $"document.getElementById('{TxtTelEmerg.ClientID}').value = '{valores[5]}';" +
                $"document.getElementById('{TxtMail.ClientID}').value = '{valores[6]}';" +
                $"document.getElementById('{TxtSexo.ClientID}').value = '{valores[8]}';" +
                $"document.getElementById('{TxtEstado.ClientID}').value = '{valores[9]}';",
                true);

            // Abre el modal
            ScriptManager.RegisterStartupScript(this, this.GetType(), "MostrarModal", "$('#exampleModal').modal('show');", true);
        }

        protected void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los TextBox
            int id = int.Parse(TxtDNI.Text);
            string nombre = TxtNombre.Text;
            // ... obtener otros valores de los TextBox

            // Actualiza el usuario en la base de datos
            Usuario usuario = new Usuario();
            usuario.ID = id;
            usuario.Nombre = nombre;
            // ... asignar otros valores al objeto usuario

            // Llama al método para actualizar el usuario en el Controller
            //   dato.ActualizarUsuario(usuario);

            // Cierra el modal
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CerrarModal", "$('#exampleModal').modal('hide');", true);

            // Recarga la página para actualizar la lista de usuarios
            Response.Redirect(Request.RawUrl);
        }







    }


}