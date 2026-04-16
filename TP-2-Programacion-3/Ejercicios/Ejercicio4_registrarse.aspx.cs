using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        protected bool validarCampoDeTexto(string campo, Label labelError, string mensajeError)
        {
            //le quito todos los espacios en blanco
            string campoSinEspacios = campo.Trim();

            if (string.IsNullOrEmpty(campoSinEspacios))
            {
                labelError.Text = mensajeError;
                return false;
            }
            else
            {
                labelError.Text = "";
                return true;
            }
        }

        protected void ButtonRegistrarse_Click(object sender, EventArgs e)
        {   
            bool esUsuarioValido = validarCampoDeTexto(usuarioInput.Value, LabelMensajeUsuario, "* El nombre de usuario no puede estar vacío.");
            bool esPasswordValido = validarCampoDeTexto(passwordInput.Value, LabelMensajePassword, "* La contraseña no puede estar vacía.");
            string patronRegex = @"^(?=.*[a-zA-Z])(?=.*[A-Z])(?=.*\d)\S{8,}$";

            if (!esUsuarioValido || !esPasswordValido)
            {
                return;
            }

            if (!Regex.IsMatch(passwordInput.Value, patronRegex))
            {
                LabelMensajePassword.Text = "* La contraseña debe tener al menos 8 caracteres, una letra mayúscula, una letra minúscula y un número.";
                return;
            }

            Datos.AgregarUsuario(usuarioInput.Value, passwordInput.Value);
            usuarioInput.Value = string.Empty;
            passwordInput.Value = string.Empty;

            LabelRegistroExitoso.Text = "Se ha registrado correctamente";
            ButtonVolver.Visible = true;

        }
      
        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4_login.aspx");
        }
    }
}