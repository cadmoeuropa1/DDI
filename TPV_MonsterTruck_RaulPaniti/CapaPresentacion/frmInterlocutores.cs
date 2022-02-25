using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class frmInterlocutores : Form
    {
        public int idInterlocutor;
        public frmInterlocutores(int idInterlocutor)
        {
            InitializeComponent();
            this.idInterlocutor = idInterlocutor;
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            txtIdPersona.Text = idInterlocutor.ToString();
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                    new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText };
            }

            List<Rol> listaRoles = new CN_Rol().ListarComboBox();

            foreach (Rol item in listaRoles)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = -1;
            List<Interlocutor> listaInterlocutores = new CN_Interlocutor().ListarDataGrid();

            foreach (Interlocutor item in listaInterlocutores)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdInterlocutor,
                    item.Nombre,
                    item.Direccion,
                    item.oRol.Descripcion,
                    item.Telefono
                    });
            }
        }

       private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Interlocutor obj = new Interlocutor()
            {
                IdInterlocutor = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
            };

            if (obj.IdInterlocutor == 0)
            {
                int idgenerado = new CN_Interlocutor().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[]{
                        "",
                        idgenerado,
                        txtNombre.Text,
                        txtDireccion.Text,
                        ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                        txtTelefono.Text
                });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Interlocutor().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Direccion"].Value = txtDireccion.Text;
                    row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cboRol.SelectedIndex = -1;
            //para que situe el foco en el primer combobox de Producto   
            txtNombre.Select();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.ok.Width;
                var h = Properties.Resources.ok.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.ok, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtNombre.Text = dgvdata.Rows[indice].Cells["Nombre_I"].Value.ToString();
                    txtDireccion.Text = dgvdata.Rows[indice].Cells["Direccion"].Value.ToString();
                    txtTelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();

                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if (oc.Texto == dgvdata.Rows[indice].Cells["Rol"].Value.ToString())
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el interlocutor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Interlocutor obj = new Interlocutor()
                    {
                        IdInterlocutor = Convert.ToInt32(txtIndice.Text)
                    };


                    new CN_Interlocutor().Eliminar(obj);
                    dgvdata.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    Limpiar();

                }
            }
        }
    }
}
