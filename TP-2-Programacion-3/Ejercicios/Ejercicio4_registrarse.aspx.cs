using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3.Ejercicios
{
    public partial class Ejercicio4_registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender ,EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Datos.AgregarUsuario(usuarioInput.Value, passwordInput.Value);



        }
    }
}