using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3.Ejercicios
{
    public partial class Ejercicio2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender ,EventArgs e)
        {

        }

        protected void ButtonResumen_Click(object sender ,EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            Response.Redirect("Ejercicio2b.aspx?nombre=" + nombre + "&apellido=" + apellido);
        }
    }
}