using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3.Ejercicios
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender ,EventArgs e)
        {
            string nombre, apellido, ciudadElegida;
            List<string> temasSeleccionados = new List<string>();

            CheckBoxList checkBoxTemas = (CheckBoxList)PreviousPage.FindControl("checkBoxTemas");
            foreach (ListItem item in checkBoxTemas.Items)
            {
                if (item.Selected)
                {
                    temasSeleccionados.Add(item.Text);
                }
            }

            nombre = ((TextBox)PreviousPage.FindControl("txtNombre")).Text;
            apellido = ((TextBox)PreviousPage.FindControl("txtApellido")).Text;
            ciudadElegida = ((DropDownList)PreviousPage.FindControl("dropDownListCiudades")).SelectedItem.Text;

        }
    }
}