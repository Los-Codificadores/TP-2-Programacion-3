using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3.Ejercicios
{
    public partial class Ejercicio4_valido : System.Web.UI.Page
    {
        public static string NombreUsuarioValido = "";
        protected void Page_Load(object sender ,EventArgs e)
        {
            labelNombreUsuario.Text = NombreUsuarioValido;

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4_login.aspx");
        }
    }
}