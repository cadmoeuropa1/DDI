
namespace RAUL_PANITI_1EVA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.cmbBocadito = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHoras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtSala3 = new System.Windows.Forms.RadioButton();
            this.rbtSala2 = new System.Windows.Forms.RadioButton();
            this.rbtSala1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.txtContraseña);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(30, 192);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(210, 103);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(88, 62);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(88, 14);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // pnlReserva
            // 
            this.pnlReserva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReserva.Controls.Add(this.btnCerrarSesion);
            this.pnlReserva.Controls.Add(this.btnReserva);
            this.pnlReserva.Controls.Add(this.label10);
            this.pnlReserva.Controls.Add(this.label9);
            this.pnlReserva.Controls.Add(this.cmbBebida);
            this.pnlReserva.Controls.Add(this.cmbBocadito);
            this.pnlReserva.Controls.Add(this.label8);
            this.pnlReserva.Controls.Add(this.cmbHoras);
            this.pnlReserva.Controls.Add(this.label7);
            this.pnlReserva.Controls.Add(this.txtPersonas);
            this.pnlReserva.Controls.Add(this.label6);
            this.pnlReserva.Controls.Add(this.rbtSala3);
            this.pnlReserva.Controls.Add(this.rbtSala2);
            this.pnlReserva.Controls.Add(this.rbtSala1);
            this.pnlReserva.Controls.Add(this.label3);
            this.pnlReserva.Location = new System.Drawing.Point(330, 40);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(489, 423);
            this.pnlReserva.TabIndex = 1;
            this.pnlReserva.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Location = new System.Drawing.Point(404, 393);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(78, 23);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.AutoSize = true;
            this.btnReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnReserva.Location = new System.Drawing.Point(210, 375);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(98, 30);
            this.btnReserva.TabIndex = 13;
            this.btnReserva.Text = "RESERVA";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Bocadito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bebida:";
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Location = new System.Drawing.Point(104, 322);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(121, 21);
            this.cmbBebida.TabIndex = 10;
            // 
            // cmbBocadito
            // 
            this.cmbBocadito.FormattingEnabled = true;
            this.cmbBocadito.Location = new System.Drawing.Point(320, 322);
            this.cmbBocadito.Name = "cmbBocadito";
            this.cmbBocadito.Size = new System.Drawing.Size(96, 21);
            this.cmbBocadito.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(175, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Refrigerio (opcional)";
            // 
            // cmbHoras
            // 
            this.cmbHoras.FormattingEnabled = true;
            this.cmbHoras.Location = new System.Drawing.Point(228, 232);
            this.cmbHoras.Name = "cmbHoras";
            this.cmbHoras.Size = new System.Drawing.Size(147, 21);
            this.cmbHoras.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seleccione la hora de reserva";
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(281, 180);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(36, 20);
            this.txtPersonas.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Numero de personas:";
            // 
            // rbtSala3
            // 
            this.rbtSala3.AutoSize = true;
            this.rbtSala3.Location = new System.Drawing.Point(170, 129);
            this.rbtSala3.Name = "rbtSala3";
            this.rbtSala3.Size = new System.Drawing.Size(14, 13);
            this.rbtSala3.TabIndex = 3;
            this.rbtSala3.TabStop = true;
            this.rbtSala3.UseVisualStyleBackColor = true;
            this.rbtSala3.Click += new System.EventHandler(this.rbtSala3_Click);
            // 
            // rbtSala2
            // 
            this.rbtSala2.AutoSize = true;
            this.rbtSala2.Location = new System.Drawing.Point(170, 91);
            this.rbtSala2.Name = "rbtSala2";
            this.rbtSala2.Size = new System.Drawing.Size(14, 13);
            this.rbtSala2.TabIndex = 2;
            this.rbtSala2.TabStop = true;
            this.rbtSala2.UseVisualStyleBackColor = true;
            this.rbtSala2.Click += new System.EventHandler(this.rbtSala2_Click);
            // 
            // rbtSala1
            // 
            this.rbtSala1.AutoSize = true;
            this.rbtSala1.Location = new System.Drawing.Point(170, 52);
            this.rbtSala1.Name = "rbtSala1";
            this.rbtSala1.Size = new System.Drawing.Size(14, 13);
            this.rbtSala1.TabIndex = 1;
            this.rbtSala1.TabStop = true;
            this.rbtSala1.UseVisualStyleBackColor = true;
            this.rbtSala1.Click += new System.EventHandler(this.rbtSala1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(112, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Indique la sala que desea alquilar";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLogin.Location = new System.Drawing.Point(106, 171);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 18);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblReserva.Location = new System.Drawing.Point(542, 19);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(78, 18);
            this.lblReserva.TabIndex = 3;
            this.lblReserva.Text = "RESERVA";
            this.lblReserva.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Location = new System.Drawing.Point(266, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(35, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "==>";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalir.Location = new System.Drawing.Point(267, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 27);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 491);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlReserva);
            this.Controls.Add(this.pnlLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Resrva de Salas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtSala3;
        private System.Windows.Forms.RadioButton rbtSala2;
        private System.Windows.Forms.RadioButton rbtSala1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbHoras;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.ComboBox cmbBocadito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

