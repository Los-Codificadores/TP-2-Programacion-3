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
        string producto1;
        int cantidad1;

        protected void Page_Load(object sender ,EventArgs e)
        {
            
        }

        protected void btnGenerarTabla_Click(object sender ,EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProducto1.Text)|| string.IsNullOrWhiteSpace(textBoxCantidad1.Text))
            {
                labelMensaje.Text = "Ingrese un nombre de producto y cantidad para agregar a la lista.";

                return;
            }

            labelMensaje.Text = "";

            producto1 = textBoxProducto1.Text;
            // No chequea si el string es un int válido
            cantidad1 = int.Parse(textBoxCantidad1.Text);
        }
    }
}