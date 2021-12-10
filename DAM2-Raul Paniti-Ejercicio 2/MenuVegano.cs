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
    public partial class MenuVegano : Form
    {
        String nombre_cliente;
        Bebida[] bebidas = { new Bebida("Café", 1.2f), new Bebida("Agua", 1f), new Bebida("Zumo/Refresco", 1.5f),
            new Bebida("Vino", 1.2f) };
        String[] primeros;
        String[] segundos;
        String[] postres;
        Dictionary<String, float> precios;
        public MenuVegano(String nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;
            lblBienvenida.Text += nombre;
            precios = new Dictionary<string, float>();
            precios["precioPrimero"] = 4.4f * 1.2f;
            precios["precioSegundo"] = 5.5f * 1.2f;
            precios["precioPostre"] = 3.0f;
            precios["precioPan"] = 0.8f;
            instanciarCombos();
        }

        private void instanciarCombos()
        {
            String primerosVeganos = Properties.Resources.PrimerosVeganos.ToString();
            String segundosVeganos = Properties.Resources.SegundosVeganos.ToString();
            String postresVeganos = Properties.Resources.PostresVeganos.ToString();
            primeros = primerosVeganos.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            segundos = segundosVeganos.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            postres = postresVeganos.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            cmbBebidas.Items.Add("No");
            cmbPostres.Items.Add("No");
            for (int i = 0; i < primeros.Length; i++)
            {
                cmbPrimeros.Items.Add(primeros[i]);
            }
            for (int i = 0; i < segundos.Length; i++)
            {
                cmbSegundos.Items.Add(segundos[i]);
            }
            for (int i = 0; i < postres.Length; i++)
            {
                cmbPostres.Items.Add(postres[i]);
            }
            for (int i = 0; i < bebidas.Length; i++)
            {
                cmbBebidas.Items.Add(bebidas[i]);
            }

        }
        private void chbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNo.Enabled == true)
            {
                chbNo.Enabled = false;
            }
            else if (chbNo.Enabled == false)
            {
                chbNo.Enabled = true;
            }
        }

        private void chbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSi.Enabled == true)
            {
                chbSi.Enabled = false;
            }
            else if (chbSi.Enabled == false)
            {
                chbSi.Enabled = true;
            }
        }


        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            switch (validar())
            {
                case 0:
                    visualizarPedido();
                    errorProvider1.Clear();
                    break;
                case 1:
                    errorProvider1.SetError(pnlDetalles, "Debe seleccionar al menos un primer plato y un segundo plato");
                    break;
                case 2:
                    errorProvider1.SetError(pnlDetalles, "Si no desea postre ni bebida indiquelo con la opción 'No'");
                    break;
                case 3:
                    errorProvider1.SetError(pnlDetalles, "Debe indicar si quiere o no pan");
                    break;

            }
        }
        private void visualizarPedido()
        {
            String mensaje = "";
            float precioFinal = precios["precioPrimero"] + precios["precioSegundo"];
            if (cmbBebidas.SelectedIndex == 0 && cmbPostres.SelectedIndex == 0)
            {
            }
            else if (cmbBebidas.SelectedIndex > 0 && cmbPostres.SelectedIndex > 0)
            {
                precioFinal += precios["precioPostre"] + bebidas[cmbBebidas.SelectedIndex - 1].getPrecio();
            }
            else if (cmbPostres.SelectedIndex > 0 && cmbBebidas.SelectedIndex == 0)
            {
                precioFinal += precios["precioPostre"];
            }
            else if (cmbBebidas.SelectedIndex > 0 && cmbPostres.SelectedIndex == 0)
            {
                precioFinal += bebidas[cmbBebidas.SelectedIndex - 1].getPrecio();
            }
            if (chbSi.Checked)
            {
                precioFinal += precios["precioPan"];
            }
            mensaje = "El precio final del pedido es de " + precioFinal + "€";
            lblFinal.Text = mensaje;
        }
        private int validar()
        {
            if (cmbPrimeros.SelectedIndex <= -1 || cmbSegundos.SelectedIndex <= -1)
            {
                return 1;
            }
            else if (cmbBebidas.SelectedIndex <= -1 || cmbPostres.SelectedIndex <= -1)
            {
                return 2;
            }
            else if (!chbNo.Checked && !chbSi.Checked)
            {
                return 3;
            }
            else
                return 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
