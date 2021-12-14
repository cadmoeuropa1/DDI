using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Raul_Paniti_Ejercicio2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1_Paint(panel1, null);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(panel1, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, panel1.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }
    }

}
