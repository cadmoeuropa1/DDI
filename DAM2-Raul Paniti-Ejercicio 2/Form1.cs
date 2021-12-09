using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Raul_Paniti_Ejercicio_2
{
    public partial class Form1 : Form
    {
        String[] direcciones = { "Calle Madrid", "Calle Jaén", "Calle Madrid", "Calle Vitoria", "Av. Derechos Humanos", "Plaza España", "Av. del Cid", "Calle Santander", "Calle Tinte", "San Pedro y San Felices"
        , "Calle Alfareros", "Severo Ochoa", "Av. Castilla y León", "Calle Cantabria", "Calle Condesa Mencía"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbEstandar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVegano.Enabled == true)
            {
                chbVegano.Enabled = false;
            }
            else if (chbVegano.Enabled == false)
            {
                chbVegano.Enabled = true;
            }
        }
        private void chbVegano_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstandar.Enabled == true)
            {
                chbEstandar.Enabled = false;
            }
            else if (chbEstandar.Enabled == false)
            {
                chbEstandar.Enabled = true;
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            switch (validaciones()) {
                case 0:
                    errorProvider1.Clear();
                    break;
                case 1:
                    errorProvider1.SetError(pnlDatos, "Debe introducir un nombre y no debe contener números");
                    break;
                case 2:
                    errorProvider1.SetError(pnlDatos, "El numero de telefono es obligatorio y debe tener 9 digitos");
                    break;
                case 3:
                    errorProvider1.SetError(pnlDatos, "Debe elegir una dirección de las mostradas");
                    break;
                case 4:
                    errorProvider1.SetError(pnlMenu, "Debe seleccionar al menos un tipo de menú");
                    break;
                    }
        }


        private int validaciones()
        {
            if (txtNombre.Text == "" || txtNombre.Text.All(Char.IsLetter)==false)
            {
                return 1;
            }
            else if (txtTelefono.Text.Length < 9)
            {
                return 2;
            }
            else if (cmbDirecciones.SelectedIndex <= -1)
            {
                return 3;
            }else if (chbEstandar.Checked == false && chbVegano.Checked == false)
            {
                return 4;
            }
            else
                return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addDirecciones();
        }

        private void addDirecciones()
        {
            for (int i = 0; i<direcciones.Length; i++)
            {
                cmbDirecciones.Items.Add(direcciones[i]);
            }
        }
    }
}
