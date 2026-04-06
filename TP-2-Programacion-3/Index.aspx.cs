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
        string producto1, producto2;
        int cantidad1, cantidad2;

        protected void Page_Load(object sender ,EventArgs e)
        {
            
        }

        private bool VerificarCamposVacios (string mensaje, Label labelmensaje, TextBox textProducto, TextBox textCantidad)
        {
            if (string.IsNullOrWhiteSpace(textProducto.Text) || string.IsNullOrWhiteSpace(textCantidad.Text))
            {
                labelmensaje.Text = mensaje;
                return true;
            }
            return false;
        }

        protected void btnGenerarTabla_Click(object sender ,EventArgs e)
        {
            bool producto1Incompleto = VerificarCamposVacios("[ERROR] Producto N°1 incompleto: Ingrese un nombre de producto y cantidad para agregar a la lista.", labelMensaje, textBoxProducto1, textBoxCantidad1);
            bool producto2Incompleto = VerificarCamposVacios("[ERROR] Producto N°2 incompleto: Ingrese un nombre de producto y cantidad para agregar a la lista.", labelMensaje, TextBoxProducto2, TextBoxCantidad2);

            if (producto1Incompleto || producto2Incompleto)
            {
                tableproduct.Visible = false;
                return;
            }

            labelMensaje.Text = "";

            producto1 = textBoxProducto1.Text;
            // No chequea si el string es un int válido
            cantidad1 = int.Parse(textBoxCantidad1.Text);

            producto2 = TextBoxProducto2.Text;

            cantidad2 = int.Parse(TextBoxCantidad2.Text);

            tableproduct.Visible = true;

        }
    }
}