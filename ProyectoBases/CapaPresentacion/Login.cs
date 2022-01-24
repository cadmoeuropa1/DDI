using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Usuario> Usuarios = new CN_Usuario().Listar();
            Usuario OUsuario = new CN_Usuario().Listar().Where(u => u.Documento == txtUsuario.Text && u.Clave == txtContra.Text).FirstOrDefault();
            if (OUsuario != null) { 
            Inicio form = new Inicio();
            form.Show();
                this.Hide();

            form.FormClosing += form_closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
