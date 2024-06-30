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
    public partial class _Default : Page
    {
        public List<Plan> plancito=new List<Plan>();
        public Controller datos=new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "";
            Session["navbar"] = a;
            plancito = datos.ListarPLan();
        }
    }
}