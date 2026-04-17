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
            float totalConInteres = total + (total * interesSeleccionado);
            int cantidadCuotas = int.Parse(DropDownListCuotas.SelectedValue);
            float cuota = total / cantidadCuotas;

            lblCosto.Text = "El precio final es de: $" + totalConInteres.ToString();

            if (cantidadCuotas != 1)
            {
                LabelMensajeCuotas.Visible = true;
                LabelMensajeCuotas.Text = cantidadCuotas + " cuotas de $" + cuota.ToString("F2");
            }
            else
            {   
                LabelMensajeCuotas.Visible = false;
            }
        }
    }
}