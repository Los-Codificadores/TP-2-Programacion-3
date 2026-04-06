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

        protected void btnReiniciarTabla_Click(object sender, EventArgs e)
        {
            tableproduct.Rows[1].Cells[0].InnerText = "";
            tableproduct.Rows[1].Cells[1].InnerText = "";

            tableproduct.Rows[2].Cells[0].InnerText = "";
            tableproduct.Rows[2].Cells[1].InnerText = "";

            tableproduct.Visible = true;
            tableproduct.Rows[3].Cells[0].InnerText = "Total: ";
            tableproduct.Rows[3].Cells[1].InnerText = "";

            tableproduct.Visible = false;
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

            // Se accede a la tabla como si fuese una matriz.
            tableproduct.Rows[1].Cells[0].InnerText = producto1;
            tableproduct.Rows[1].Cells[1].InnerText = cantidad1.ToString();


            // Producto 2
            producto2 = TextBoxProducto2.Text;
            cantidad2 = int.Parse(TextBoxCantidad2.Text);

            tableproduct.Rows[2].Cells[0].InnerText = producto2;
            tableproduct.Rows[2].Cells[1].InnerText = cantidad2.ToString();





            // Total
            tableproduct.Visible = true;
            tableproduct.Rows[3].Cells[0].InnerText = "Total: ";
            tableproduct.Rows[3].Cells[1].InnerText = (cantidad1 + cantidad2).ToString();


        }
    }
}