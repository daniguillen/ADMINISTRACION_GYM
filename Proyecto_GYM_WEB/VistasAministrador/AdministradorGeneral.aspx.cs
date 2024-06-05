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
    public partial class AdministradorGeneral : System.Web.UI.Page
    {
        public Controller dato= new Controller();
        public List<Usuario> ListaUsuarios = new List<Usuario>();

        public Usuario UsuarioEditar { get; set; } = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["TOKEN"] = "ENTRO";
            Session["navBar"] = "a";
            Session["ModificarCliente"]="";
            if (Session["TOKEN"] != null)
            {
                // TOKEN no es nulo, verifica su valor
                if (Session["TOKEN"].ToString() != "ENTRO")
                {
                    Response.Redirect("/");
                    return;
                }
                else
                {
                    if (!IsPostBack)
                    {



                        //esto hay q cambiarlo y borrarlo
                        ListaUsuarios = dato.listar_Clientes();
                        Session["ModificarCliente"] = ListaUsuarios;

                    }

                }
            }
            else
            {
                // La sesión no existe, redirigir
                Response.Redirect("/");
            }


            
            


        }
    }
}