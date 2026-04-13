using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2_Programacion_3
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        private static readonly Random _random = new Random();

        protected void Page_Load(object sender ,EventArgs e)
        {

        }

        protected void LinkButtonColorTexto_Click(object sender ,EventArgs e)
        {
            int r = _random.Next(1, 256);
            int g = _random.Next(1, 256);
            int b = _random.Next(1, 256);

            lblResultado.ForeColor = Color.FromArgb(r, g, b);
        }

        protected void AplicarFormato_Click(object sender, EventArgs e)
        {
            //Con sender sabemos que boton se apreto
            LinkButton btn = (LinkButton)sender;

            switch (btn.ID)
            {
                case "Bold":
                    lblResultado.Font.Bold = !lblResultado.Font.Bold;
                    break;

                case "Italic":
                    lblResultado.Font.Italic = !lblResultado.Font.Italic;
                    break;

                case "Underline":
                    lblResultado.Font.Underline = !lblResultado.Font.Underline;
                    break;
            }
        }

        protected void colorRojo_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
        }

        protected void colorAzul_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.FromArgb(0, 0, 255);
        }

        protected void colorVerde_Click(object sender, EventArgs e)
        {
            lblResultado.ForeColor = Color.FromArgb(0, 255, 0);
        }
    }
}
