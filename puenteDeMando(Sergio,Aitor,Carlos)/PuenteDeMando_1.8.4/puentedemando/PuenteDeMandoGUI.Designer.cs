namespace PuenteDeMando
{
    partial class PuenteDeMandoGUI
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuenteDeMandoGUI));
            this.prBejecucion = new System.Windows.Forms.ProgressBar();
            this.btComunicaciones = new System.Windows.Forms.Button();
            this.btAboutUs = new System.Windows.Forms.Button();
            this.btOficial = new System.Windows.Forms.Button();
            this.btEscudo = new System.Windows.Forms.Button();
            this.btFinalizarSim = new System.Windows.Forms.Button();
            this.gbOficial = new System.Windows.Forms.GroupBox();
            this.lbNombreSub = new System.Windows.Forms.Label();
            this.lbNombreOfi = new System.Windows.Forms.Label();
            this.prJubilacion = new System.Windows.Forms.ProgressBar();
            this.lbTiemJub = new System.Windows.Forms.Label();
            this.lbSubof = new System.Windows.Forms.Label();
            this.lbOficial = new System.Windows.Forms.Label();
            this.gbEscudo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prBproteccion = new System.Windows.Forms.ProgressBar();
            this.lbFechaEstelar = new System.Windows.Forms.Label();
            this.BWprJubilacion = new System.ComponentModel.BackgroundWorker();
            this.BWprMensaje = new System.ComponentModel.BackgroundWorker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.BWprSimulacion = new System.ComponentModel.BackgroundWorker();
            this.pbImgNave = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mItFinalizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mItSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.BWescudo = new System.ComponentModel.BackgroundWorker();
            this.BWeligeCasillas = new System.ComponentModel.BackgroundWorker();
            this.gbOficial.SuspendLayout();
            this.gbEscudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgNave)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prBejecucion
            // 
            this.prBejecucion.Location = new System.Drawing.Point(0, 524);
            this.prBejecucion.Maximum = 600;
            this.prBejecucion.Name = "prBejecucion";
            this.prBejecucion.Size = new System.Drawing.Size(851, 23);
            this.prBejecucion.TabIndex = 1;
            // 
            // btComunicaciones
            // 
            this.btComunicaciones.BackColor = System.Drawing.Color.Red;
            this.btComunicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btComunicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btComunicaciones.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComunicaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btComunicaciones.Location = new System.Drawing.Point(0, 488);
            this.btComunicaciones.Name = "btComunicaciones";
            this.btComunicaciones.Size = new System.Drawing.Size(124, 36);
            this.btComunicaciones.TabIndex = 2;
            this.btComunicaciones.Text = "Comunicaciones";
            this.btComunicaciones.UseVisualStyleBackColor = false;
            this.btComunicaciones.Click += new System.EventHandler(this.MostrarComunicaciones);
            // 
            // btAboutUs
            // 
            this.btAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAboutUs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAboutUs.ForeColor = System.Drawing.Color.LimeGreen;
            this.btAboutUs.Location = new System.Drawing.Point(121, 488);
            this.btAboutUs.Name = "btAboutUs";
            this.btAboutUs.Size = new System.Drawing.Size(124, 36);
            this.btAboutUs.TabIndex = 3;
            this.btAboutUs.Text = "About Us";
            this.btAboutUs.UseVisualStyleBackColor = true;
            this.btAboutUs.Click += new System.EventHandler(this.MostrarAboutUs);
            // 
            // btOficial
            // 
            this.btOficial.BackColor = System.Drawing.Color.RoyalBlue;
            this.btOficial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOficial.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOficial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btOficial.Location = new System.Drawing.Point(0, 459);
            this.btOficial.Name = "btOficial";
            this.btOficial.Size = new System.Drawing.Size(124, 32);
            this.btOficial.TabIndex = 4;
            this.btOficial.Text = "Oficial";
            this.btOficial.UseVisualStyleBackColor = false;
            this.btOficial.Click += new System.EventHandler(this.MostrarVentanaOficiales);
            // 
            // btEscudo
            // 
            this.btEscudo.BackColor = System.Drawing.Color.LimeGreen;
            this.btEscudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEscudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEscudo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEscudo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEscudo.Location = new System.Drawing.Point(121, 459);
            this.btEscudo.Name = "btEscudo";
            this.btEscudo.Size = new System.Drawing.Size(124, 32);
            this.btEscudo.TabIndex = 5;
            this.btEscudo.Text = "Escudo";
            this.btEscudo.UseVisualStyleBackColor = false;
            this.btEscudo.Click += new System.EventHandler(this.MostrarEscudo);
            // 
            // btFinalizarSim
            // 
            this.btFinalizarSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinalizarSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizarSim.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizarSim.ForeColor = System.Drawing.Color.Red;
            this.btFinalizarSim.Location = new System.Drawing.Point(29, 386);
            this.btFinalizarSim.Name = "btFinalizarSim";
            this.btFinalizarSim.Size = new System.Drawing.Size(184, 46);
            this.btFinalizarSim.TabIndex = 6;
            this.btFinalizarSim.Text = "Finalizar Simulación";
            this.btFinalizarSim.UseVisualStyleBackColor = true;
            this.btFinalizarSim.Click += new System.EventHandler(this.btFinalizarSim_Click);
            // 
            // gbOficial
            // 
            this.gbOficial.Controls.Add(this.lbNombreSub);
            this.gbOficial.Controls.Add(this.lbNombreOfi);
            this.gbOficial.Controls.Add(this.prJubilacion);
            this.gbOficial.Controls.Add(this.lbTiemJub);
            this.gbOficial.Controls.Add(this.lbSubof);
            this.gbOficial.Controls.Add(this.lbOficial);
            this.gbOficial.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOficial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOficial.Location = new System.Drawing.Point(0, 24);
            this.gbOficial.Name = "gbOficial";
            this.gbOficial.Size = new System.Drawing.Size(245, 253);
            this.gbOficial.TabIndex = 7;
            this.gbOficial.TabStop = false;
            this.gbOficial.Text = "Oficial";
            // 
            // lbNombreSub
            // 
            this.lbNombreSub.AutoSize = true;
            this.lbNombreSub.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreSub.Location = new System.Drawing.Point(55, 156);
            this.lbNombreSub.Name = "lbNombreSub";
            this.lbNombreSub.Size = new System.Drawing.Size(126, 15);
            this.lbNombreSub.TabIndex = 5;
            this.lbNombreSub.Text = "Nombre Suboficial";
            // 
            // lbNombreOfi
            // 
            this.lbNombreOfi.AutoSize = true;
            this.lbNombreOfi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreOfi.Location = new System.Drawing.Point(54, 79);
            this.lbNombreOfi.Name = "lbNombreOfi";
            this.lbNombreOfi.Size = new System.Drawing.Size(105, 15);
            this.lbNombreOfi.TabIndex = 4;
            this.lbNombreOfi.Text = "Nombre Oficial";
            // 
            // prJubilacion
            // 
            this.prJubilacion.Location = new System.Drawing.Point(10, 212);
            this.prJubilacion.Maximum = 60;
            this.prJubilacion.Name = "prJubilacion";
            this.prJubilacion.Size = new System.Drawing.Size(229, 23);
            this.prJubilacion.TabIndex = 3;
            this.prJubilacion.Value = 60;
            // 
            // lbTiemJub
            // 
            this.lbTiemJub.AutoSize = true;
            this.lbTiemJub.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiemJub.Location = new System.Drawing.Point(6, 189);
            this.lbTiemJub.Name = "lbTiemJub";
            this.lbTiemJub.Size = new System.Drawing.Size(175, 15);
            this.lbTiemJub.TabIndex = 2;
            this.lbTiemJub.Text = "Tiempo hasta jubilación:";
            // 
            // lbSubof
            // 
            this.lbSubof.AutoSize = true;
            this.lbSubof.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubof.Location = new System.Drawing.Point(7, 123);
            this.lbSubof.Name = "lbSubof";
            this.lbSubof.Size = new System.Drawing.Size(84, 15);
            this.lbSubof.TabIndex = 1;
            this.lbSubof.Text = "Suboficial:";
            // 
            // lbOficial
            // 
            this.lbOficial.AutoSize = true;
            this.lbOficial.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOficial.Location = new System.Drawing.Point(6, 32);
            this.lbOficial.Name = "lbOficial";
            this.lbOficial.Size = new System.Drawing.Size(119, 15);
            this.lbOficial.TabIndex = 0;
            this.lbOficial.Text = "Oficial a bordo:";
            // 
            // gbEscudo
            // 
            this.gbEscudo.Controls.Add(this.label1);
            this.gbEscudo.Controls.Add(this.prBproteccion);
            this.gbEscudo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEscudo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbEscudo.Location = new System.Drawing.Point(0, 283);
            this.gbEscudo.Name = "gbEscudo";
            this.gbEscudo.Size = new System.Drawing.Size(245, 80);
            this.gbEscudo.TabIndex = 8;
            this.gbEscudo.TabStop = false;
            this.gbEscudo.Text = "Escudo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nivel de protección:";
            // 
            // prBproteccion
            // 
            this.prBproteccion.Location = new System.Drawing.Point(8, 50);
            this.prBproteccion.Maximum = 64;
            this.prBproteccion.Name = "prBproteccion";
            this.prBproteccion.Size = new System.Drawing.Size(231, 23);
            this.prBproteccion.Step = 1;
            this.prBproteccion.TabIndex = 0;
            this.prBproteccion.Value = 64;
            // 
            // lbFechaEstelar
            // 
            this.lbFechaEstelar.AutoSize = true;
            this.lbFechaEstelar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaEstelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbFechaEstelar.Location = new System.Drawing.Point(261, 34);
            this.lbFechaEstelar.Name = "lbFechaEstelar";
            this.lbFechaEstelar.Size = new System.Drawing.Size(112, 15);
            this.lbFechaEstelar.TabIndex = 9;
            this.lbFechaEstelar.Text = "Fecha Estelar: ";
            // 
            // BWprJubilacion
            // 
            this.BWprJubilacion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWprJubilacion_DoWork);
            this.BWprJubilacion.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWprJubilacion_ProgressChanged);
            // 
            // BWprMensaje
            // 
            this.BWprMensaje.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWprMensaje_DoWork);
            this.BWprMensaje.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWprMensaje_ProgressChanged);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFecha.Location = new System.Drawing.Point(380, 34);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 13);
            this.lbFecha.TabIndex = 11;
            // 
            // BWprSimulacion
            // 
            this.BWprSimulacion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWprSimulacion_DoWork);
            this.BWprSimulacion.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWprSimulacion_ProgressChanged);
            this.BWprSimulacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWprSimulacion_RunWorkerCompleted);
            // 
            // pbImgNave
            // 
            this.pbImgNave.Image = global::PuenteDeMando.Properties.Resources.uss_enterprise_100_;
            this.pbImgNave.Location = new System.Drawing.Point(245, 24);
            this.pbImgNave.Name = "pbImgNave";
            this.pbImgNave.Size = new System.Drawing.Size(606, 507);
            this.pbImgNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgNave.TabIndex = 0;
            this.pbImgNave.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuText;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mMenu
            // 
            this.mMenu.BackColor = System.Drawing.SystemColors.MenuText;
            this.mMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItFinalizar,
            this.mItSalir});
            this.mMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(51, 20);
            this.mMenu.Text = "Menú";
            // 
            // mItFinalizar
            // 
            this.mItFinalizar.BackColor = System.Drawing.SystemColors.ControlText;
            this.mItFinalizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mItFinalizar.Name = "mItFinalizar";
            this.mItFinalizar.Size = new System.Drawing.Size(152, 22);
            this.mItFinalizar.Text = "Finalizar";
            this.mItFinalizar.Click += new System.EventHandler(this.mItFinalizar_Click);
            // 
            // mItSalir
            // 
            this.mItSalir.BackColor = System.Drawing.SystemColors.Desktop;
            this.mItSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mItSalir.Name = "mItSalir";
            this.mItSalir.Size = new System.Drawing.Size(152, 22);
            this.mItSalir.Text = "Salir";
            this.mItSalir.Click += new System.EventHandler(this.MenuSalir);
            // 
            // BWescudo
            // 
            this.BWescudo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWescudo_DoWork);
            this.BWescudo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWescudo_ProgressChanged);
            // 
            // BWeligeCasillas
            // 
            this.BWeligeCasillas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWeligeCasillas_DoWork);
            this.BWeligeCasillas.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWeligeCasillas_ProgressChanged);
            // 
            // PuenteDeMandoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(846, 546);
            this.ControlBox = false;
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbFechaEstelar);
            this.Controls.Add(this.gbEscudo);
            this.Controls.Add(this.gbOficial);
            this.Controls.Add(this.btFinalizarSim);
            this.Controls.Add(this.prBejecucion);
            this.Controls.Add(this.pbImgNave);
            this.Controls.Add(this.btEscudo);
            this.Controls.Add(this.btOficial);
            this.Controls.Add(this.btAboutUs);
            this.Controls.Add(this.btComunicaciones);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(862, 585);
            this.MinimumSize = new System.Drawing.Size(862, 585);
            this.Name = "PuenteDeMandoGUI";
            this.Text = "Puente_de_Mando";
            this.Load += new System.EventHandler(this.PuenteDeMandoGUI_Load);
            this.gbOficial.ResumeLayout(false);
            this.gbOficial.PerformLayout();
            this.gbEscudo.ResumeLayout(false);
            this.gbEscudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgNave)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImgNave;
        private System.Windows.Forms.ProgressBar prBejecucion;
        private System.Windows.Forms.Button btComunicaciones;
        private System.Windows.Forms.Button btAboutUs;
        private System.Windows.Forms.Button btOficial;
        private System.Windows.Forms.Button btEscudo;
        private System.Windows.Forms.Button btFinalizarSim;
        private System.Windows.Forms.GroupBox gbOficial;
        private System.Windows.Forms.ProgressBar prJubilacion;
        private System.Windows.Forms.Label lbTiemJub;
        private System.Windows.Forms.Label lbSubof;
        private System.Windows.Forms.Label lbOficial;
        private System.Windows.Forms.GroupBox gbEscudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prBproteccion;
        private System.Windows.Forms.Label lbNombreSub;
        private System.Windows.Forms.Label lbNombreOfi;
        private System.Windows.Forms.Label lbFechaEstelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mMenu;
        private System.Windows.Forms.ToolStripMenuItem mItFinalizar;
        private System.Windows.Forms.ToolStripMenuItem mItSalir;
        private System.ComponentModel.BackgroundWorker BWprJubilacion;
        private System.ComponentModel.BackgroundWorker BWprMensaje;
        private System.Windows.Forms.Label lbFecha;
        private System.ComponentModel.BackgroundWorker BWprSimulacion;
        private System.ComponentModel.BackgroundWorker BWescudo;
        private System.ComponentModel.BackgroundWorker BWeligeCasillas;
    }
}

