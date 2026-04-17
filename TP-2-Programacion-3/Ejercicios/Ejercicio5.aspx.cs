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
            decimal totalAccesorios = 0;

            foreach (ListItem item in checkBoxAccesorios.Items)
            {
                if (item.Selected)
                {
                    totalAccesorios += decimal.Parse(item.Value);
                }
            }

            decimal total = costoMemoria + totalAccesorios;
            lblCosto.Text = "El precio final es de: $" + total.ToString();
        }
    }
}