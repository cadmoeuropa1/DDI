
namespace CapaPresentacion
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuInterlocutor = new FontAwesome.Sharp.IconMenuItem();
            this.menuVehiculos = new FontAwesome.Sharp.IconMenuItem();
            this.menuRutas = new FontAwesome.Sharp.IconMenuItem();
            this.menuTaller = new FontAwesome.Sharp.IconMenuItem();
            this.menuAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.menuInformes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuSalir = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInterlocutor,
            this.menuVehiculos,
            this.menuRutas,
            this.menuTaller,
            this.menuAdmin,
            this.menuInformes,
            this.menuAcercade,
            this.menuSalir});
            this.menu.Location = new System.Drawing.Point(0, 47);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1042, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuInterlocutor
            // 
            this.menuInterlocutor.AutoSize = false;
            this.menuInterlocutor.BackColor = System.Drawing.Color.White;
            this.menuInterlocutor.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.menuInterlocutor.IconColor = System.Drawing.Color.Black;
            this.menuInterlocutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInterlocutor.IconSize = 50;
            this.menuInterlocutor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInterlocutor.Name = "menuInterlocutor";
            this.menuInterlocutor.Size = new System.Drawing.Size(122, 69);
            this.menuInterlocutor.Text = "Interlocutor";
            this.menuInterlocutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuInterlocutor.Click += new System.EventHandler(this.menuInterlocutor_Click);
            // 
            // menuVehiculos
            // 
            this.menuVehiculos.AutoSize = false;
            this.menuVehiculos.BackColor = System.Drawing.Color.White;
            this.menuVehiculos.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menuVehiculos.IconColor = System.Drawing.Color.Black;
            this.menuVehiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVehiculos.IconSize = 50;
            this.menuVehiculos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVehiculos.Name = "menuVehiculos";
            this.menuVehiculos.Size = new System.Drawing.Size(122, 69);
            this.menuVehiculos.Text = "Vehiculos";
            this.menuVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuRutas
            // 
            this.menuRutas.AutoSize = false;
            this.menuRutas.BackColor = System.Drawing.Color.White;
            this.menuRutas.IconChar = FontAwesome.Sharp.IconChar.Road;
            this.menuRutas.IconColor = System.Drawing.Color.Black;
            this.menuRutas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuRutas.IconSize = 50;
            this.menuRutas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRutas.Name = "menuRutas";
            this.menuRutas.Size = new System.Drawing.Size(122, 69);
            this.menuRutas.Text = "Rutas";
            this.menuRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTaller
            // 
            this.menuTaller.AutoSize = false;
            this.menuTaller.BackColor = System.Drawing.Color.White;
            this.menuTaller.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.menuTaller.IconColor = System.Drawing.Color.Black;
            this.menuTaller.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuTaller.IconSize = 50;
            this.menuTaller.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuTaller.Name = "menuTaller";
            this.menuTaller.Size = new System.Drawing.Size(122, 69);
            this.menuTaller.Text = "Taller";
            this.menuTaller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuAdmin
            // 
            this.menuAdmin.AutoSize = false;
            this.menuAdmin.BackColor = System.Drawing.Color.White;
            this.menuAdmin.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuAdmin.IconColor = System.Drawing.Color.Black;
            this.menuAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAdmin.IconSize = 50;
            this.menuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(122, 69);
            this.menuAdmin.Text = "Admin";
            this.menuAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuInformes
            // 
            this.menuInformes.AutoSize = false;
            this.menuInformes.BackColor = System.Drawing.Color.White;
            this.menuInformes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menuInformes.IconColor = System.Drawing.Color.Black;
            this.menuInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInformes.IconSize = 50;
            this.menuInformes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Size = new System.Drawing.Size(122, 69);
            this.menuInformes.Text = "Informes";
            this.menuInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuAcercade
            // 
            this.menuAcercade.AutoSize = false;
            this.menuAcercade.BackColor = System.Drawing.Color.White;
            this.menuAcercade.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menuAcercade.IconColor = System.Drawing.Color.Black;
            this.menuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercade.IconSize = 50;
            this.menuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercade.Name = "menuAcercade";
            this.menuAcercade.Size = new System.Drawing.Size(122, 69);
            this.menuAcercade.Text = "Acerca de ";
            this.menuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAcercade.Click += new System.EventHandler(this.menuAcercade_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.AutoSize = false;
            this.menuSalir.BackColor = System.Drawing.Color.White;
            this.menuSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.menuSalir.IconColor = System.Drawing.Color.Black;
            this.menuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSalir.IconSize = 50;
            this.menuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(122, 69);
            this.menuSalir.Text = "Salir";
            this.menuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1042, 47);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "Sistema de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGÍSTICA MONSTER TRUCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(663, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(709, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 4;
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 120);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1042, 499);
            this.contenedor.TabIndex = 5;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(709, 24);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 13);
            this.labelUsuario.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 619);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuInterlocutor;
        private FontAwesome.Sharp.IconMenuItem menuVehiculos;
        private FontAwesome.Sharp.IconMenuItem menuRutas;
        private FontAwesome.Sharp.IconMenuItem menuTaller;
        private FontAwesome.Sharp.IconMenuItem menuAdmin;
        private FontAwesome.Sharp.IconMenuItem menuInformes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem menuAcercade;
        private FontAwesome.Sharp.IconMenuItem menuSalir;
        private System.Windows.Forms.Label labelUsuario;
    }
}