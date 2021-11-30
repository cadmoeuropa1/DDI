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
    public partial class SolicitudPrestamo : Form
    {
        string nombreCliente;
        string[] razas_disponibles = {"Balrog", "Drúedain", "Enano", "Elfo", "Ent", "Goblin", 
            "Hobbit", "Hombre", "Istari (Mago)", "Orco", "Troll", "Uruk-hai" };
        string[] lugares_disponibles;
        int[] cuotas = {12, 24, 36, 60, 120, 180, 240};

        public SolicitudPrestamo(string nombre)
        {
            InitializeComponent();
            nombreCliente = nombre;
            string listaLugares = Properties.Resources.lugares.ToString();
            lugares_disponibles = listaLugares.Split(new[] { "\n" }, 
                StringSplitOptions.RemoveEmptyEntries);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolicitudPrestamo_Load(object sender, EventArgs e)
        {
            label1.Text += nombreCliente;
            visualizarRazas();
            visualizarLugares();
            visualizarCuotas();
            btnSolicitar.Enabled = false;
        }

        private void visualizarRazas()
        {
            for(int i = 0; i<razas_disponibles.Length; i++)
            {
                cmbRaza.Items.Add(razas_disponibles[i]);
            }
        }

        private void visualizarLugares()
        {
            for(int i = 0; i<lugares_disponibles.Length; i++)
            {
                cmbOrigen.Items.Add(lugares_disponibles[i]);
            }
        }
        
        private void controlPaneles()
        {

        }
        private void visualizarCuotas()
        {
          for(int i = 0; i<cuotas.Length; i++)
            {
                cmbCuotas.Items.Add(cuotas[i]);
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

        }
    }
}
