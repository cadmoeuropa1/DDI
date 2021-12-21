using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAUL_PANITI_1EVA
{
    public partial class Form1 : Form
    {
        String[] usuarios;
        String usuario, password, sala;
        Sala[] salas;
        Dictionary<String, String> ususLogin;
        Dictionary<String, float> bebidas;
        Dictionary<String, float> bocaditos;
        public Form1()
        {
            InitializeComponent();
            asignarComboBox();
            string listaUsuarios = Properties.Resources.credenciales.ToString();
            usuarios = listaUsuarios.Split(new[] { ";" },
                StringSplitOptions.RemoveEmptyEntries);
            salas = new Sala[] {new Sala("Sala 1", 8), new Sala("Sala 2", 10), new Sala("Sala 3/comedor", 20) };
            ususLogin = new Dictionary<string, string>();
            for (int i = 0; i<usuarios.Length; i+=2)
            {
                    ususLogin[usuarios[i]] = usuarios[i + 1];
            }
            bebidas = new Dictionary<string, float>();
            bebidas["Agua"] = 0.5f;
            bebidas["Café y leche"] = 1.0f;
            bebidas["Zumo naranja"] = 1.5f;
            bocaditos = new Dictionary<string, float>();
            bocaditos["Cruasán"]=1f;
            bocaditos["Jamón"] = 1.5f;
            bocaditos["Vegetal"] = 2f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtSala1.Text = salas[0].nombre + " (máx 8 personas)";
            rbtSala2.Text = salas[1].nombre + " (máx 10 personas)";
            rbtSala3.Text = salas[2].nombre + " (máx 20 personas)";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             usuario = txtUsuario.Text.ToString();
             password = txtContraseña.Text.ToString();
            switch (validaciones(usuario, password))
            {
                case 0:
                    errorProvider1.Clear();
                    MessageBox.Show("Usuario validado correctamente");
                    pnlReserva.Visible = true;
                    lblReserva.Visible = true;
                    pnlLogin.Visible = false;
                    lblLogin.Visible = false;
                    btnSalir.Enabled = false;
                    btnLogin.Visible = false;
                    break;
                case 1:
                    errorProvider1.SetError(pnlLogin, "El usuario y la contraseña no pueden estar vacíos");
                    break;
                case 2:
                    errorProvider1.SetError(pnlLogin, "El usuario y la contraseña no están validados");
                    break;
            }
            
        }

        private int validaciones(String usuario, String contra)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                return 1;
            }
            else if (contra != ususLogin[usuario])
            {
                return 2;
            }
            else return 0;
            
    }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlReserva.Visible = false;
            lblLogin.Visible = true;
            lblReserva.Visible = false;
            btnSalir.Enabled = true;
            btnLogin.Visible = true;
        }
        public void asignarComboBox()
        {
            cmbBebida.Text = "Seleccione su bebida";
            cmbBebida.Items.Add("Agua");
            cmbBebida.Items.Add("Café y leche");
            cmbBebida.Items.Add("Zumo naranja");

            cmbBocadito.Text = "Seleccione bocadito";
            cmbBocadito.Items.Add("Cruasán");
            cmbBocadito.Items.Add("Jamón");
            cmbBocadito.Items.Add("Vegetal");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (txtPersonas.Text != "")
            {
                int personas = int.Parse(txtPersonas.Text);
                switch (validarReserva(personas))
                {
                    case 0:
                        errorProvider1.Clear();
                        if (cmbBebida.SelectedIndex!= -1 || cmbBocadito.SelectedIndex != -1)
                        {
                            MessageBox.Show("Sala reservada correctaemente para " + usuario + "\nPara la " + sala
                            + " a las " + cmbHoras.SelectedItem + "\nRefrigerios: " + cmbBebida.SelectedItem + " " + cmbBocadito.SelectedItem);
                        }
                        else { 
                        MessageBox.Show("Sala reservada correctaemente para " + usuario + "\nPara la " + sala
                            + " a las " + cmbHoras.SelectedItem + "\n");
                        }
                        break;
                    case 1:
                        errorProvider1.SetError(pnlReserva, "Debe seleccionar al menos una sala");
                        break;
                    case 2:
                        errorProvider1.SetError(pnlReserva, "El numero de personas debe ser un dígito");
                        break;
                    case 3:
                        errorProvider1.SetError(pnlReserva, "Debe seleccionar una hora");
                        break;
                    case 4:
                        errorProvider1.SetError(pnlReserva, "Capacidad excedida");
                        break;
                }
            }
        }

        private void rbtSala1_Click(object sender, EventArgs e)
        {
            cmbHoras.Items.Clear();
            sala = "Sala 1";
            for (int i = 0; i<salas[0].horas.Length; i++)
            {
                cmbHoras.Items.Add(salas[0].horas[i] + "  Disponible");
            }
        }
        private void rbtSala2_Click(object sender, EventArgs e)
        {
            cmbHoras.Items.Clear();
            sala = "Sala 2";
            for (int i = 0; i < salas[1].horas.Length; i++)
            {
                cmbHoras.Items.Add(salas[1].horas[i] + "  Disponible");
            }
        }
        private void rbtSala3_Click(object sender, EventArgs e)
        {
            cmbHoras.Items.Clear();
            sala = "Sala 3/comedor";
            String horas3 = Properties.Resources.Horas3.ToString();
            String [] horas3A = horas3.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < horas3A.Length; i++)
            {
                cmbHoras.Items.Add(horas3A[i] + "  Disponible");
            }
        }

        private int validarReserva(int personas)
        {
            if (!rbtSala1.Checked && !rbtSala2.Checked && !rbtSala3.Checked)
            {
                return 1;
            }
            else if (!txtPersonas.Text.All(Char.IsDigit) || txtPersonas.Text=="")
            {
                return 2;
            }
            else if (cmbHoras.SelectedIndex == -1)
            {
                return 3;
            }
            else if((rbtSala1.Checked && personas > salas[0].capacidad) || (rbtSala2.Checked && personas > salas[1].capacidad) || (rbtSala3.Checked && personas > salas[2].capacidad))
            {
                return 4;
            }
            else
                return 0;
        }

        
    }
}
