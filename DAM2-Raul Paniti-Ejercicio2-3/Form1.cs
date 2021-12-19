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
        String[] pistas = { "Futbol", "Fut-Sala/Multiusos", "Baloncesto", "Padel" };
        public Form1()
        {
            InitializeComponent();
            configurarComboBox();
        }
        public void configurarComboBox()
        {
            for (int i = 0; i<pistas.Length; i++)
            {
                cmbPista.Items.Add(pistas[i]);
            }
        }

        private void cmbPista_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPista.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
            }
        }
    }
}
