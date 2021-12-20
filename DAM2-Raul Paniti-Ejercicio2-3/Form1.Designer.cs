
namespace DAM2_Raul_Paniti_Ejercicio2_3
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
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.cmbHoras = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgPista = new System.Windows.Forms.PictureBox();
            this.cmbPista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this.pnlCentral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCentral.Controls.Add(this.btnContinuar);
            this.pnlCentral.Controls.Add(this.rbNo);
            this.pnlCentral.Controls.Add(this.rbSi);
            this.pnlCentral.Controls.Add(this.cmbHoras);
            this.pnlCentral.Controls.Add(this.label5);
            this.pnlCentral.Controls.Add(this.label4);
            this.pnlCentral.Controls.Add(this.textBox1);
            this.pnlCentral.Controls.Add(this.label3);
            this.pnlCentral.Controls.Add(this.imgPista);
            this.pnlCentral.Controls.Add(this.cmbPista);
            this.pnlCentral.Controls.Add(this.label2);
            this.pnlCentral.Controls.Add(this.label1);
            this.pnlCentral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCentral.Location = new System.Drawing.Point(84, 43);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(641, 347);
            this.pnlCentral.TabIndex = 0;
            // 
            // btnContinuar
            // 
            this.btnContinuar.AutoSize = true;
            this.btnContinuar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinuar.Location = new System.Drawing.Point(262, 288);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(112, 33);
            this.btnContinuar.TabIndex = 11;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbNo.Location = new System.Drawing.Point(89, 233);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(45, 23);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = false;
            this.rbNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNo_MouseClick);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.BackColor = System.Drawing.Color.Transparent;
            this.rbSi.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbSi.Location = new System.Drawing.Point(170, 233);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(37, 23);
            this.rbSi.TabIndex = 9;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "SÍ";
            this.rbSi.UseVisualStyleBackColor = false;
            this.rbSi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSi_MouseClick);
            // 
            // cmbHoras
            // 
            this.cmbHoras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbHoras.FormattingEnabled = true;
            this.cmbHoras.Location = new System.Drawing.Point(417, 233);
            this.cmbHoras.Name = "cmbHoras";
            this.cmbHoras.Size = new System.Drawing.Size(121, 21);
            this.cmbHoras.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(328, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Escoja una hora para la fecha de hoy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(49, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿Se encuentra empadronado?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(298, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(100, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre completo:";
            // 
            // imgPista
            // 
            this.imgPista.BackColor = System.Drawing.Color.Transparent;
            this.imgPista.Location = new System.Drawing.Point(449, 59);
            this.imgPista.Name = "imgPista";
            this.imgPista.Size = new System.Drawing.Size(55, 53);
            this.imgPista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPista.TabIndex = 3;
            this.imgPista.TabStop = false;
            // 
            // cmbPista
            // 
            this.cmbPista.BackColor = System.Drawing.Color.White;
            this.cmbPista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPista.FormattingEnabled = true;
            this.cmbPista.ItemHeight = 16;
            this.cmbPista.Location = new System.Drawing.Point(298, 74);
            this.cmbPista.Name = "cmbPista";
            this.cmbPista.Size = new System.Drawing.Size(135, 24);
            this.cmbPista.TabIndex = 2;
            this.cmbPista.SelectedIndexChanged += new System.EventHandler(this.cmbPista_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija su pista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALQUILER DE PISTAS TOWN";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            this.error1.Icon = ((System.Drawing.Icon)(resources.GetObject("error1.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::DAM2_Raul_Paniti_Ejercicio2_3.Properties.Resources.si;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCentral);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alquiler de pistas Town";
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPista;
        private System.Windows.Forms.PictureBox imgPista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

