using ACCIONES;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_GYM_WEB
{
    public partial class Vista_Detalle_Ejericios_Clientes : System.Web.UI.Page
    {
       public Usuario usuario = new Usuario();
        public Rutina rutina_usuario = new Rutina();
        public Dias dia_rutina;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                string a = "b";
                Session["navbar"] = a;
                usuario = (Usuario)Session["PerfilUsuario"];
                Controller datos = new Controller();
                rutina_usuario = datos.Rutinas_id(usuario.ID_rutina);
                dia_rutina = datos.ListarDias().Find(x=> x.dia== Request.QueryString["id"]);

            }
        }
    }
}