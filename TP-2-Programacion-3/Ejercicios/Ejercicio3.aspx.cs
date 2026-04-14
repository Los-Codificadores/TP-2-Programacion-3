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
            //Tuve que refinir la fuente en la carga, por que si no al modificar
            //La fuente en el boton, se inicializa con basura.
            if (!IsPostBack)
            {
                lblResultado.Font.Size = FontUnit.Point(16);
            }

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

        protected void buttonPlus_Click(object sender, EventArgs e)
        {
            // Es algo confuso, pero necesite convertirlo a int, por que el retorno del font unit es
            // un float, y el metodo point requiere un int.

            if (lblResultado.Font.Size.Unit.Value < 64)
            {
                lblResultado.Font.Size = FontUnit.Point((int)lblResultado.Font.Size.Unit.Value + 2);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (lblResultado.Font.Size.Unit.Value > 10)
            {
                lblResultado.Font.Size = FontUnit.Point((int)lblResultado.Font.Size.Unit.Value - 2);
            }
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            lblResultado.ControlStyle.Reset(); //Con esto reseteo el estilo del control, esto no afecta el tamanio de la fuente
            lblResultado.Font.Size = FontUnit.Point(16);
        }

        protected void LinkButtonReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Index.aspx");
        }

        protected void LinkButtonFondoAleatorio_Click(object sender, EventArgs e)
        {
            int r = _random.Next(1, 256);
            int g = _random.Next(1, 256);
            int b = _random.Next(1, 256);

            lblResultado.BackColor = Color.FromArgb(r, g, b);
        }

        protected void ddlBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Value = ddlBorderStyle.SelectedValue;
            lblResultado.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), Value);
        }
    }
}
