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
    public partial class frmNombre : Form
    {
        public frmNombre()
        {
            InitializeComponent();
        }

        private void frmNombre_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Raúl-Denis Paniti Paniti", "Raúl-Denis Paniti Paniti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
