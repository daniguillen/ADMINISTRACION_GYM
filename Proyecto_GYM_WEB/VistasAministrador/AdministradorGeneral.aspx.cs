﻿using ACCIONES;
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
        //sera 1 al entrar es usuario, si esta en tabla entrenador 2 y si no es rutina 3
        public List<Rutina> ListarRutina = new List<Rutina>();
        //este id es el que tomare en el modal para modificarlo
        public int ModificarId;
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
                        Session["Nivel"] = 1;
                        ModificarId = -1;
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
        private void filtrarPorNivel()
        {

            ListaUsuarios = dato.listar_Clientes();
            List<Usuario> AuxListaUsuarios = new List<Usuario>();

            if (Session["Nivel"] != null && Convert.ToInt32(Session["Nivel"]) == 1)
            {
                foreach (var i in ListaUsuarios)
                {
                    if (i.nivel.ID == 1)
                    {
                        AuxListaUsuarios.Add(i);
                    }
                }
                LiteralUsuarios.Text = "<h1> Usuarios </h1>";
            }
            else if (Session["Nivel"] != null && Convert.ToInt32(Session["Nivel"]) == 2)
            {
                foreach (var i in ListaUsuarios)
                {
                    if (i.nivel.ID == 2)
                    {
                        AuxListaUsuarios.Add(i);
                    }
                }
                LiteralUsuarios.Text = "<h1> Entrenadores </h1>";
            }

            ListaUsuarios = AuxListaUsuarios;
            BindRepeater();

        }
        protected void Buscar(object sender, EventArgs e)
        {

            Usuario aux;
            void buscar()
            {
                List<Usuario> usuario = new List<Usuario>();
                Label1.Text = TxtBusquedad.Text;
                if (!TxtBusquedad.Text.Equals(""))
                {

                    if (aux != null)
                    {
                        usuario.Add(aux);
                        ListaUsuarios = usuario;
                    }
                    else
                    {
                        Resultado.Text = "Sin Resultado";
                        Resultado.Visible = true;
                    }
                }
                else
                {
                    Resultado.Text = "Sin Resultado";
                    Resultado.Visible = true;
                }
            }
            //no hay filtro (Persona y entrenadores)
            if (DropDownList1.SelectedValue.Equals(""))
            {
                aux = dato.BuscarAllCliente(TxtBusquedad.Text);
                buscar();
            }
            //filtrar por usuario
            if (DropDownList1.SelectedValue.Equals("1"))
            {
                aux = dato.BuscarOneCliente(TxtBusquedad.Text);
                buscar();
            }
            //filtrar por Entranadores
            if (DropDownList1.SelectedValue.Equals("2"))
            {
                aux = dato.BuscarOneEntrenador(TxtBusquedad.Text);
                buscar();
            }
            //filtrar Rutinas no esta hecha
            if (DropDownList1.SelectedValue.Equals("3"))
            {

            }

            BindRepeater();
        }
        protected void Entrenadores(object sender, EventArgs e)
        {
            Session["Nivel"] = 2;
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
            Resultado.Visible = false;
            Resultado.Text = "";
            BindRepeater();
        }
        protected void Usuarios(object sender, EventArgs e)
        {
            Session["Nivel"] = 1;
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
            Resultado.Visible = false;
            Resultado.Text = "";
            BindRepeater();
        }
        protected void Rutinas(object sender, EventArgs e)
        {
            Session["Nivel"] = 3;
            LiteralUsuarios.Text = "<h1> Rutina </h1>";
            Resultado.Visible = false;
            Resultado.Text = "";
            //   ListarRutina = dato.ListarRutinas();
            //BindRepeater().c;

        }
        protected void MensajeAUsuarioYEntrenadores(object sender, EventArgs e)
        {
            TextBox2.Text = "Mensaje enviado: " + TextBox1.Text;
            TextBox1.Text = "";
            Resultado.Visible = false;
            Resultado.Text = "";
        }

        protected void BtnEliminar_Persona_Command(object sender, CommandEventArgs e)
        {
            int userId;
            if (int.TryParse(e.CommandArgument.ToString(), out userId))
            {
                Label1.Text = "ID del usuario: " + userId.ToString();
                dato.Eliminar_Persona_x_ID(userId);
                filtrarPorNivel();
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
                filtrarPorNivel();
            }

        }
        protected void Modificar(object sender, CommandEventArgs e)
        {
            string[] valores = e.CommandArgument.ToString().Split(',');

            HfModificarId.Value = valores[0];
            TxtDNI.Text = valores[1];
            TxtNombre.Text = valores[2];
            TxtApellido.Text = valores[3];
            TxtCel.Text = valores[5];
            TxtTelEmerg.Text = valores[6];
            TxtMail.Text = valores[7];
            TxtPassword.Text = valores[8];

            string sexo = valores[9];
            if (!string.IsNullOrEmpty(sexo) && (sexo == "1" || sexo == "2" || sexo == "3" || sexo == "4"))
            {
                DdlSexo.SelectedValue = sexo;
            }
            else
            {
                DdlSexo.SelectedIndex = 0;
            }

            string estado = valores[10];
            if (!string.IsNullOrEmpty(estado) && (estado == "1" || estado == "0"))
            {
                DdlEstado.SelectedValue = estado;
            }
            else
            {
                DdlEstado.SelectedIndex = 0;
            }

            string plan = valores[4];
            if (!string.IsNullOrEmpty(plan) && (plan == "1" || plan == "2" || plan == "3" || plan == "4"))
            {
                DdlPlan.SelectedValue = plan;
            }
            else
            {
                DdlPlan.SelectedIndex = 0;
            }

            // Establecer plan.ID y sexo.id en los HiddenField
        //    HfPlanId.Value = valores[11];
        //    HfSexoId.Value = valores[12];

            ScriptManager.RegisterStartupScript(this, this.GetType(), "MostrarModal", "$('#exampleModal').modal('show');", true);
        }
        protected void BtnGuardarCambios_Click(object sender, EventArgs e)
        {



            Usuario usuario = new Usuario();
            string valor = HfModificarId.Value;
            usuario.ID = int.Parse(HfModificarId.Value);
            usuario.DNI = TxtDNI.Text;
            usuario.Nombre = TxtNombre.Text;
            usuario.Apellido = TxtApellido.Text;
        
            if (int.TryParse(DdlPlan.SelectedValue, out int planId))
            {
                usuario.plan.ID = planId;
            }
            usuario.Tel_Emergencia = TxtTelEmerg.Text;
            usuario.Cel = TxtCel.Text;
            usuario.Mail = TxtMail.Text;
            usuario.Password = TxtPassword.Text;
            // Para el DropDownList DdlSexo
            if (int.TryParse(DdlSexo.SelectedValue, out int sexoId))
            {
                usuario.sexo.ID = sexoId;
            }


            // Para el DropDownList DdlEstado
            if (int.TryParse(DdlEstado.SelectedValue, out int estadoId))
            {
                usuario.Estado = estadoId != 0; 
            }

           // dato.ModificarUsuarioEntrenador(usuario);

            ModificarId = -1;

            


            ScriptManager.RegisterStartupScript(this, this.GetType(), "CerrarModal", "$('#exampleModal').modal('hide');", true);
            Response.Redirect(Request.RawUrl);
        }

    }

}