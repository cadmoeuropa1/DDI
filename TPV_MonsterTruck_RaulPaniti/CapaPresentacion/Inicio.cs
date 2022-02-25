using CapaEntidad;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        public static Interlocutor usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Interlocutor objUsuario)
        {
            InitializeComponent();
            usuarioActual = objUsuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = usuarioActual.Nombre;

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                iconmenu.Visible = true;
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuInterlocutor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmInterlocutores(usuarioActual.IdInterlocutor));
        }


        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAcercade_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAcercaDe());
        }

    }
}
