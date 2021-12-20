using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_Raul_Paniti_Ejercicio2_3
{
    public partial class Form1 : Form
    {
        String[] pistas = { "Futbol", "Fut-Sala/Multiusos", "Baloncesto", "Padel" };
        Hora[] horas = { new Hora("08:00", false), new Hora("09:00", false), new Hora("10:00", false), new Hora("11:00", false), new Hora("12:00", false), new Hora("13:00", false), new Hora("14:00", false), new Hora("15:00", false), new Hora("16:00", false), new Hora("17:00", false), new Hora("18:00", false), new Hora("19:00", false), new Hora("20:00", false), new Hora("21:00", false) };
        Dictionary<string, int> diccionario = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            configurarComboBox();
            agregarHoras();
            diccionario.Add("precioEmpadronado", 8);
            diccionario.Add("precioNoEmpadronado", 18);
        }
        public void configurarComboBox()
        {
            for (int i = 0; i<pistas.Length; i++)
            {
                cmbPista.Items.Add(pistas[i]);
            }
        }

        private void cmbPista_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPista.SelectedIndex)
            {
                case 0:
                    imgPista.Image = DAM2_Raul_Paniti_Ejercicio2_3.Properties.Resources.Soccer_Ball_icon_icons_com_76265;
                    break;
                case 1:
                    imgPista.Image = DAM2_Raul_Paniti_Ejercicio2_3.Properties.Resources.soccer_field_icon_137175;
                    break;
                case 2:
                    imgPista.Image = DAM2_Raul_Paniti_Ejercicio2_3.Properties.Resources._1490886333_37_basketball_82467;
                    break;
                case 3:
                    imgPista.Image = DAM2_Raul_Paniti_Ejercicio2_3.Properties.Resources.ball_tennis_padel_sport_icon_141847;
                    break;
            }
        }
        private void agregarHoras()
        {
            for (int i = 0; i<horas.Length; i++)
            {
                cmbHoras.Items.Add(horas[i]);
            }
        }

        private void rbNo_MouseClick(object sender, MouseEventArgs e)
        {
            rbNo.Checked = true;
            rbSi.Checked = false;
        }
        private void rbSi_MouseClick(object sender, MouseEventArgs e)
        {
            rbSi.Checked = true;
            rbNo.Checked = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Hora hora = horas[cmbHoras.SelectedIndex];

            switch (validaciones())
            {
                case 0:
                    horas[cmbHoras.SelectedIndex].reservado = true;
                    if (rbSi.Checked)
                    {
                        MessageBox.Show("RESERVA COMPLETADA PARA FECHA " + System.DateTime.Today + hora.hora + "\n"
                            + textBox1.Text + ", sí empadronado \n" + "Por un valor de " + diccionario["precioEmpadronado"] + "€");
                    }
                    break;
                case 1:
                    error1.SetError(btnContinuar, "Debe seleccionar una pista.");
                    break;
                case 2:
                    error1.SetError(btnContinuar, "El nombre no puede estar vacío ni contener números.");
                    break;
                case 3:
                    error1.SetError(btnContinuar, "Debe seleccionar una hora disponible");
                    break;
                case 4:
                    error1.SetError(btnContinuar, "Debe indicar si está empadronado o no");
                    break;
            }
        }

        private int validaciones()
        {
            if (cmbPista.SelectedIndex == -1)
            {
                return 1;
            }
            else if (textBox1.Text == "" || textBox1.Text.All(Char.IsLetter) == false)
            {
                return 2;
            }
            else if (validarHora() == 1 || validarHora() == 3)
            {
                return 3;
            }
            else if (!rbSi.Checked && !rbNo.Checked)
            {
                return 4;
            }
            else
                return 0;
        }

        private int validarHora()
        {
            if (cmbHoras.SelectedIndex != -1)
            {
                Hora horaSel = horas[cmbHoras.SelectedIndex];
                if (horaSel.reservado)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 2;
            }
        }
    }
}
