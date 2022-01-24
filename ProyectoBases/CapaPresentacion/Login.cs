using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Inicio form = new Inicio();
            form.Show();
                this.Hide();

            form.FormClosing += form_closing;
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
