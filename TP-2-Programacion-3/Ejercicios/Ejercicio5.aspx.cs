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
            CostoMemoria = (int)Enum.Parse(typeof(PrecioMemoria), DropDownList1.SelectedValue); 
            lblCosto.Text = "El precio final es de: $" + CostoMemoria.ToString();
        }
    }
}