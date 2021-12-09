using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_RaulPaniti_Ejercicio2_2
{
    public partial class Form1 : Form
    {
        String[] direcciones = { "Calle Madrid", "Calle Vitoria", "Derechos Humanos" };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (!chbEstandar.Checked  && !chbVegano.Checked)
            {
                errorProvider1.SetError(panel1, "Debe seleccionar al menos un tipo de menú");
            }else if (chbEstandar.Checked || chbVegano.Checked)
            {
                errorProvider1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addDirecciones();
            if (chbEstandar.Checked)
            {
                chbVegano.Enabled = false;
            }else if (chbVegano.Checked)
            {
                chbEstandar.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private int validar()
        {
            if (txtNombre.Text=="" || (txtTelefono.Text.All(Char.IsDigit) || txtTelefono.Text.Length!=9) || cmbDireccion.SelectedIndex <= -1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            switch (validar())
            {
                case 0:
                    if (chbEstandar.Checked)
                    {

                    }else if (chbVegano.Checked)
                    {

                    }
                    break;
                case 1:
                    errorProvider1.SetError(panel2, "Debe completar todos los campos correctamente");
                    break;
            }
            
        }
        private void addDirecciones()
        {
            for (int i = 0; i<direcciones.Length; i++)
            {
                cmbDireccion.Items.Add(direcciones[i]);
            }
        }
    }
}
