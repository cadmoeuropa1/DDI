
namespace DAM2_Raul_Paniti_Ejercicio_2
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cmbDirecciones = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.chbVegano = new System.Windows.Forms.CheckBox();
            this.chbEstandar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPedir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNDireccion = new System.Windows.Forms.TextBox();
            this.pnlDatos.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.txtNDireccion);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.cmbDirecciones);
            this.pnlDatos.Controls.Add(this.txtTelefono);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Location = new System.Drawing.Point(163, 148);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(209, 192);
            this.pnlDatos.TabIndex = 0;
            // 
            // cmbDirecciones
            // 
            this.cmbDirecciones.FormattingEnabled = true;
            this.cmbDirecciones.Location = new System.Drawing.Point(77, 101);
            this.cmbDirecciones.Name = "cmbDirecciones";
            this.cmbDirecciones.Size = new System.Drawing.Size(100, 21);
            this.cmbDirecciones.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 61);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.chbVegano);
            this.pnlMenu.Controls.Add(this.chbEstandar);
            this.pnlMenu.Location = new System.Drawing.Point(496, 148);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(137, 92);
            this.pnlMenu.TabIndex = 0;
            // 
            // chbVegano
            // 
            this.chbVegano.AutoSize = true;
            this.chbVegano.Location = new System.Drawing.Point(21, 53);
            this.chbVegano.Name = "chbVegano";
            this.chbVegano.Size = new System.Drawing.Size(92, 17);
            this.chbVegano.TabIndex = 1;
            this.chbVegano.Text = "Menú vegano";
            this.chbVegano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbVegano.UseVisualStyleBackColor = true;
            this.chbVegano.CheckedChanged += new System.EventHandler(this.chbVegano_CheckedChanged);
            // 
            // chbEstandar
            // 
            this.chbEstandar.AutoSize = true;
            this.chbEstandar.Location = new System.Drawing.Point(21, 18);
            this.chbEstandar.Name = "chbEstandar";
            this.chbEstandar.Size = new System.Drawing.Size(97, 17);
            this.chbEstandar.TabIndex = 0;
            this.chbEstandar.Text = "Menú estándar";
            this.chbEstandar.UseVisualStyleBackColor = true;
            this.chbEstandar.CheckedChanged += new System.EventHandler(this.chbEstandar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "SERVICIO DE COMIDA A DOMICILIO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPedir
            // 
            this.btnPedir.AutoSize = true;
            this.btnPedir.BackColor = System.Drawing.Color.IndianRed;
            this.btnPedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedir.Location = new System.Drawing.Point(286, 373);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(210, 41);
            this.btnPedir.TabIndex = 2;
            this.btnPedir.Text = "REALIZAR PEDIDO";
            this.btnPedir.UseVisualStyleBackColor = false;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(691, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datos personales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo de menú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nº";
            // 
            // txtNDireccion
            // 
            this.txtNDireccion.Location = new System.Drawing.Point(76, 136);
            this.txtNDireccion.Name = "txtNDireccion";
            this.txtNDireccion.Size = new System.Drawing.Size(32, 20);
            this.txtNDireccion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDatos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Servicio a Domicilio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.ComboBox cmbDirecciones;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.CheckBox chbVegano;
        private System.Windows.Forms.CheckBox chbEstandar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNDireccion;
        private System.Windows.Forms.Label label7;
    }
}

