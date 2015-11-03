namespace MySleepy
{
    partial class PedidosGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFiltroPedidos = new System.Windows.Forms.TextBox();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFiltrarID = new System.Windows.Forms.Label();
            this.chkMostrarEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltroPedidos
            // 
            this.txtFiltroPedidos.Location = new System.Drawing.Point(161, 46);
            this.txtFiltroPedidos.Name = "txtFiltroPedidos";
            this.txtFiltroPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroPedidos.TabIndex = 0;
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.AllowUserToAddRows = false;
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Location = new System.Drawing.Point(63, 85);
            this.dgvListaPedidos.MultiSelect = false;
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.ReadOnly = true;
            this.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPedidos.Size = new System.Drawing.Size(574, 216);
            this.dgvListaPedidos.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(674, 91);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Pedido";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(674, 164);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Pedido";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(674, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Pedido";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(729, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblFiltrarID
            // 
            this.lblFiltrarID.AutoSize = true;
            this.lblFiltrarID.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiltrarID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrarID.Location = new System.Drawing.Point(71, 46);
            this.lblFiltrarID.Name = "lblFiltrarID";
            this.lblFiltrarID.Size = new System.Drawing.Size(69, 13);
            this.lblFiltrarID.TabIndex = 6;
            this.lblFiltrarID.Text = "Filtrar por ID";
            // 
            // chkMostrarEliminados
            // 
            this.chkMostrarEliminados.AutoSize = true;
            this.chkMostrarEliminados.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrarEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMostrarEliminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkMostrarEliminados.Location = new System.Drawing.Point(524, 46);
            this.chkMostrarEliminados.Name = "chkMostrarEliminados";
            this.chkMostrarEliminados.Size = new System.Drawing.Size(118, 17);
            this.chkMostrarEliminados.TabIndex = 7;
            this.chkMostrarEliminados.Text = "Mostrar eliminados";
            this.chkMostrarEliminados.UseVisualStyleBackColor = false;
            // 
            // PedidosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySleepy.Properties.Resources.bgnuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 375);
            this.Controls.Add(this.chkMostrarEliminados);
            this.Controls.Add(this.lblFiltrarID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.txtFiltroPedidos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PedidosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltroPedidos;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFiltrarID;
        private System.Windows.Forms.CheckBox chkMostrarEliminados;
    }
}

