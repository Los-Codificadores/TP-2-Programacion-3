using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3.Ejercicios
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public enum PrecioMemoria 
        { 
            Memoria2GB = 200,
            Memoria4GB = 375,
            Memoria6GB = 500
        }

        int CostoMemoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Solo se ejecuta la primera vez que se carga la página
            {
                DropDownListCuotas.Visible = false;
                LabelCantidadCuotas.Visible = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void botonCalcularPrecio_Click(object sender, EventArgs e)
        {
            int costoMemoria = (int)Enum.Parse(typeof(PrecioMemoria), DropDownList1.SelectedValue);
            float totalAccesorios = 0;

            foreach (ListItem item in checkBoxAccesorios.Items)
            {
                if (item.Selected)
                {
                    totalAccesorios += float.Parse(item.Value);
                }
            }

            float total = costoMemoria + totalAccesorios;
            float[] intereses = {0.0f,0.15f,0.30f,0.45f};
            float interesSeleccionado = intereses[DropDownListCuotas.SelectedIndex];
            
            float efectoMetodoPago = 0;
            switch (DropDownListMetodo.SelectedValue)
            {
                case "Transferencia":
                    efectoMetodoPago = -0.1f; //Descuento del 10% para pago al contado
                    interesSeleccionado = 0.0f; //Sin interes para pago al contado
                    break;
                case "Credito":
                    if (DropDownListCuotas.SelectedValue == "1") efectoMetodoPago = 0.0f; //Sin interes para pago al contado
                    else efectoMetodoPago = 0.15f; //Interes del 15% para pagos a credito
                    break;
            }
            
            float totalConInteres = total + (total * interesSeleccionado) + (total * efectoMetodoPago);
            int cantidadCuotas = int.Parse(DropDownListCuotas.SelectedValue);
            float cuota = totalConInteres / cantidadCuotas;

            LabelMensajeMetodoPago.Text = "Ajuste por metodo de pago: " + (efectoMetodoPago >= 0 ? (efectoMetodoPago * 100).ToString() + "% de interes." : (-efectoMetodoPago * 100).ToString() + "% de descuento.");
            lblCosto.Text = "El precio final es de: $" + totalConInteres.ToString();

            if (cantidadCuotas != 1 && DropDownListMetodo.SelectedValue == "Credito")
            {
                LabelMensajeCuotas.Visible = true;
                LabelMensajeCuotas.Text = cantidadCuotas + " cuotas de $" + cuota.ToString("F2");
            }
            else
            {   
                LabelMensajeCuotas.Visible = false;
            }
        }

        protected void DropDownListMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quito la posibilidad de seleccionar cuotas si el metodo de pago no es credito
            if (DropDownListMetodo.SelectedValue == "Credito")
            {
                DropDownListCuotas.Visible = true;
                LabelCantidadCuotas.Visible = true;
            }
            else
            {
                DropDownListCuotas.Visible = false;
                LabelCantidadCuotas.Visible = false;
            }
        }
    }
}