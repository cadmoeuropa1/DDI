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
    public partial class MenuEstandar : Form
    {
        String[] primeros = { "Macarrones", "Cocido Madrileño", "Callos", "Ensalada mediterránea", "Sopa de marisco" };
        String[] segundos = { "Filete de ternera a la plancha", "Entrecot", "Lubina asada", "Pollo al ajillo", "Dragón asado" };
        String[] postres = { "Flan de queso", "Helado", "Arroz con leche", "Tiramisú", "Pieza de fruta" };
        Bebida[] bebidas = { new Bebida("Café", 1.2f), new Bebida("Agua", 1f), new Bebida("Zumo/Refresco", 1.5f),
            new Bebida("Vino", 1.2f) };
        public MenuEstandar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuEstandar_Load(object sender, EventArgs e)
        {
            asignarPrimeros();
            asignarSegundos();
            AsignarPostres();
            asignarBebidas();
        }

        private void asignarBebidas()
        {
            cmbBebidas.Items.Add("No");
            for (int i = 0; i < bebidas.Length; i++)
            {
                cmbBebidas.Items.Add(bebidas[i]);

            }
        }

        private void AsignarPostres()
        {
            cmbPostres.Items.Add("No");
            for (int i = 0; i < postres.Length; i++)
            {
                cmbPostres.Items.Add(postres[i]);
            }
        }

        private void asignarSegundos()
        {
            for (int i = 0; i < segundos.Length; i++)
            {
                cmbSegundos.Items.Add(segundos[i]);
            }
        }

        private void asignarPrimeros()
        {
            for (int i = 0; i < primeros.Length; i++)
            {
                cmbPrimeros.Items.Add(primeros[i]);
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

            }
        }
        private int validar()
        {
            if (cmbPrimeros.SelectedIndex <= -1 || cmbSegundos.SelectedIndex <= -1)
            {
                return 1;
            }
            else
                return 0;
        }
    }

        partial class Bebida {
            String nombre;
            float precio;
            public Bebida(String nombre, float precio)
            {
                this.nombre = nombre;
                this.precio = precio;
            }
            public override string ToString()
            {
                String visualizar = nombre + "     " + precio + "€";
                return visualizar;
            }
        }
    } 

