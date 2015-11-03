namespace MySleepy
{
    partial class IFClientesGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IFClientesGUI));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAnadirCliente = new System.Windows.Forms.Button();
            this.btnElimCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnCerrarClientes = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cbCamposClientes = new System.Windows.Forms.ComboBox();
            this.lbltipobuscar = new System.Windows.Forms.Label();
            this.chkClientesEliminados = new System.Windows.Forms.CheckBox();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(14, 78);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(780, 449);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnAnadirCliente
            // 
            this.btnAnadirCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnAnadirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirCliente.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCliente.Location = new System.Drawing.Point(818, 134);
            this.btnAnadirCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnadirCliente.Name = "btnAnadirCliente";
            this.btnAnadirCliente.Size = new System.Drawing.Size(203, 33);
            this.btnAnadirCliente.TabIndex = 1;
            this.btnAnadirCliente.Text = "Añadir Cliente";
            this.btnAnadirCliente.UseVisualStyleBackColor = false;
            this.btnAnadirCliente.Click += new System.EventHandler(this.btnAnadirCliente_Click);
            // 
            // btnElimCliente
            // 
            this.btnElimCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnElimCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimCliente.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimCliente.Location = new System.Drawing.Point(818, 291);
            this.btnElimCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnElimCliente.Name = "btnElimCliente";
            this.btnElimCliente.Size = new System.Drawing.Size(203, 33);
            this.btnElimCliente.TabIndex = 2;
            this.btnElimCliente.Text = "Eliminar Cliente";
            this.btnElimCliente.UseVisualStyleBackColor = false;
            this.btnElimCliente.Click += new System.EventHandler(this.btnElimCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(818, 213);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(203, 33);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnCerrarClientes
            // 
            this.btnCerrarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarClientes.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarClientes.Location = new System.Drawing.Point(818, 493);
            this.btnCerrarClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrarClientes.Name = "btnCerrarClientes";
            this.btnCerrarClientes.Size = new System.Drawing.Size(203, 34);
            this.btnCerrarClientes.TabIndex = 4;
            this.btnCerrarClientes.Text = "Cerrar Gestión de Clientes";
            this.btnCerrarClientes.UseVisualStyleBackColor = false;
            this.btnCerrarClientes.Click += new System.EventHandler(this.btnCerrarClientes_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(396, 23);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(179, 23);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // cbCamposClientes
            // 
            this.cbCamposClientes.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbCamposClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamposClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.cbCamposClientes.FormattingEnabled = true;
            this.cbCamposClientes.Items.AddRange(new object[] {
            "--Selecciona un campo--",
            "NOMBRE",
            "APELLIDO 1",
            "APELLIDO 2",
            "DIRECCION",
            "CÓDIGO POSTAL",
            "COMUNIDAD",
            "PROVINCIA",
            "POBLACIÓN",
            "TELÉFONO 1",
            "TELÉFONO 2",
            "EMAIL"});
            this.cbCamposClientes.Location = new System.Drawing.Point(168, 22);
            this.cbCamposClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCamposClientes.Name = "cbCamposClientes";
            this.cbCamposClientes.Size = new System.Drawing.Size(174, 23);
            this.cbCamposClientes.TabIndex = 8;
            // 
            // lbltipobuscar
            // 
            this.lbltipobuscar.AutoSize = true;
            this.lbltipobuscar.BackColor = System.Drawing.Color.Transparent;
            this.lbltipobuscar.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipobuscar.Location = new System.Drawing.Point(41, 26);
            this.lbltipobuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipobuscar.Name = "lbltipobuscar";
            this.lbltipobuscar.Size = new System.Drawing.Size(113, 15);
            this.lbltipobuscar.TabIndex = 9;
            this.lbltipobuscar.Text = "Campo a buscar:";
            // 
            // chkClientesEliminados
            // 
            this.chkClientesEliminados.AutoSize = true;
            this.chkClientesEliminados.BackColor = System.Drawing.Color.Transparent;
            this.chkClientesEliminados.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClientesEliminados.Location = new System.Drawing.Point(652, 25);
            this.chkClientesEliminados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClientesEliminados.Name = "chkClientesEliminados";
            this.chkClientesEliminados.Size = new System.Drawing.Size(152, 19);
            this.chkClientesEliminados.TabIndex = 10;
            this.chkClientesEliminados.Text = "Mostrar Eliminados";
            this.chkClientesEliminados.UseVisualStyleBackColor = false;
            this.chkClientesEliminados.CheckedChanged += new System.EventHandler(this.chkClientesEliminados_CheckedChanged);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCliente.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(818, 80);
            this.btnCargarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(203, 33);
            this.btnCargarCliente.TabIndex = 11;
            this.btnCargarCliente.Text = "CARGAR CLIENTE";
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            this.btnCargarCliente.Visible = false;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // IFClientesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MySleepy.Properties.Resources.bgnuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 591);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.chkClientesEliminados);
            this.Controls.Add(this.lbltipobuscar);
            this.Controls.Add(this.cbCamposClientes);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnCerrarClientes);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnElimCliente);
            this.Controls.Add(this.btnAnadirCliente);
            this.Controls.Add(this.dgvClientes);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IFClientesGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAnadirCliente;
        private System.Windows.Forms.Button btnElimCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnCerrarClientes;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cbCamposClientes;
        private System.Windows.Forms.Label lbltipobuscar;
        private System.Windows.Forms.CheckBox chkClientesEliminados;
        public System.Windows.Forms.Button btnCargarCliente;
    }
}

