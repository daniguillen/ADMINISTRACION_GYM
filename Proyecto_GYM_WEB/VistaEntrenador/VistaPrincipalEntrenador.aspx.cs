using System;

namespace Proyecto_GYM_WEB
{
    public partial class VistaPrincipalEntrenador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "c";
            Session["navbar"] = a;
        }
    }
}