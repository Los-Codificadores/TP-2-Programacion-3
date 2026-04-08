using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender ,EventArgs e)
        {

        }

        protected void LinkButtonEjercicio1_Click(object sender ,EventArgs e)
        {
            Response.Redirect("Ejercicio1.aspx");
        }

        protected void LinkButtonEjercicio2_Click(object sender ,EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }
    }
}