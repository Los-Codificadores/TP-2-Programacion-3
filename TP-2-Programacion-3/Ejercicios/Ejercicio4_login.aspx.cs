using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3.Ejercicios
{
    public partial class Ejercicio4_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Datos.AgregarUsuario("Claudio Default", "12345");
            Datos.AgregarUsuario("claudio", "casas");
            CampoErrores.InnerText = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4_registrarse.aspx");

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4_login.aspx");
        }

        protected void ButtonLogin_Click1(object sender, EventArgs e)
        {
            //Validamos si los campos no estan vacios:
            if (InputNombre.Value == "" || InputPass.Value == "") { 
                CampoErrores.InnerText = "Debe completar ambos campos";
                return;
            }

            //Validamos si el usuario existe
            foreach (var usuario in Datos.GetUsuarios())
            {
                if (usuario.getNombre() == InputNombre.Value && usuario.getContraseña() == InputPass.Value)
                {
                    Ejercicio4_valido.NombreUsuarioValido = usuario.getNombre();
                    CampoErrores.InnerText = "";
                    Response.Redirect("Ejercicio4_valido.aspx");
                    return;

                }
                CampoErrores.InnerText = "Usuario o contraseña invalidos";
            }
            return;
        }
    }
}