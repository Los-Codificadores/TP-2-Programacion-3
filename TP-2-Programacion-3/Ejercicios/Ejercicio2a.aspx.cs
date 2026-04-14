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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResumen_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            //Validacion de campos vacios
            bool validacionNombre = validarCampoDeTexto(nombre, LabelErrorNombre, "*El campo nombre no puede estar vacio");
            bool validacionApellido = validarCampoDeTexto(apellido, LabelErrorApellido, "*El campo apellido no puede estar vacio");
            bool validacionTemas = validarSeleccionCheckBoxList(checkBoxTemas, LabelErrorTemas, "*Debe seleccionar al menos un tema");


            if (!validacionNombre || !validacionApellido || !validacionTemas)
            {
                return;
            }

            Server.Transfer("Ejercicio2b.aspx");

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

        protected bool validarSeleccionCheckBoxList(CheckBoxList checkBoxList, Label labelError, string mensajeError)
        {
            if (checkBoxList.SelectedItem == null)
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
    }
}