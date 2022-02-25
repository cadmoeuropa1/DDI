using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

            Interlocutor ousuario = new CN_Interlocutor().Listar().Where(p => p.Login == txtLogin.Text && p.Clave == txtPassword.Text && (p.oRol.IdRol==1 || p.oRol.IdRol==2)).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
                //borrar contenido textbox usuario y clave
                txtLogin.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario erróneo, no existente o sin permiso para acceder", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

       
    }
}
