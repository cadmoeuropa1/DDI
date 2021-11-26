using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_WindowsForms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnSolicitar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void controlBotones()
        {
            if(txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(Char.IsLetter))
            {
                btnSolicitar.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El nombre solo puede contener letras");

                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");
                }
                btnSolicitar.Enabled = false;
                txtNombre.Focus();
            }
        }
    }
}
