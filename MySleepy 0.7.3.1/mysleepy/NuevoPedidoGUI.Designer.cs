namespace MySleepy
{
    partial class NuevoPedidoGUI
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
            this.dgvNuevoPedido = new System.Windows.Forms.DataGridView();
            this.ColRefArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtRefCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calendarFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExplorarClientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnAddArticulo = new System.Windows.Forms.Button();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNuevoPedido
            // 
            this.dgvNuevoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRefArticulo,
            this.ColNombre,
            this.ColCantidad,
            this.ColPrecioUnitario,
            this.ColPrecioTotal});
            this.dgvNuevoPedido.Location = new System.Drawing.Point(30, 156);
            this.dgvNuevoPedido.Name = "dgvNuevoPedido";
            this.dgvNuevoPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNuevoPedido.Size = new System.Drawing.Size(482, 198);
            this.dgvNuevoPedido.TabIndex = 3;
            // 
            // ColRefArticulo
            // 
            this.ColRefArticulo.HeaderText = "REFARTICULO";
            this.ColRefArticulo.Name = "ColRefArticulo";
            this.ColRefArticulo.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "NOMBRE";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "CANTIDAD";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColPrecioUnitario
            // 
            this.ColPrecioUnitario.HeaderText = "PRECIOUNITARIO";
            this.ColPrecioUnitario.Name = "ColPrecioUnitario";
            this.ColPrecioUnitario.ReadOnly = true;
            // 
            // ColPrecioTotal
            // 
            this.ColPrecioTotal.HeaderText = "PRECIOTOTAL";
            this.ColPrecioTotal.Name = "ColPrecioTotal";
            this.ColPrecioTotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(569, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar artículo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(569, 265);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar artículo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcesar.Location = new System.Drawing.Point(569, 331);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(118, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "PROCESAR PEDIDO";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(618, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtRefCliente
            // 
            this.txtRefCliente.Enabled = false;
            this.txtRefCliente.Location = new System.Drawing.Point(48, 44);
            this.txtRefCliente.Name = "txtRefCliente";
            this.txtRefCliente.Size = new System.Drawing.Size(60, 20);
            this.txtRefCliente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ref. Cliente";
            // 
            // calendarFechaPedido
            // 
            this.calendarFechaPedido.Checked = false;
            this.calendarFechaPedido.Location = new System.Drawing.Point(315, 47);
            this.calendarFechaPedido.MinDate = new System.DateTime(2014, 12, 9, 0, 0, 0, 0);
            this.calendarFechaPedido.Name = "calendarFechaPedido";
            this.calendarFechaPedido.Size = new System.Drawing.Size(197, 20);
            this.calendarFechaPedido.TabIndex = 12;
            this.calendarFechaPedido.Value = new System.DateTime(2014, 12, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(312, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha de pedido";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(48, 97);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(197, 21);
            this.cbFormaPago.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(46, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Forma de pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(351, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Pedido";
            // 
            // btnExplorarClientes
            // 
            this.btnExplorarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnExplorarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExplorarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplorarClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExplorarClientes.Location = new System.Drawing.Point(140, 44);
            this.btnExplorarClientes.Name = "btnExplorarClientes";
            this.btnExplorarClientes.Size = new System.Drawing.Size(105, 23);
            this.btnExplorarClientes.TabIndex = 26;
            this.btnExplorarClientes.Text = "Explorar clientes...";
            this.btnExplorarClientes.UseVisualStyleBackColor = false;
            this.btnExplorarClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(312, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha de entrega";
            // 
            // calendarFechaEntrega
            // 
            this.calendarFechaEntrega.Checked = false;
            this.calendarFechaEntrega.Location = new System.Drawing.Point(315, 98);
            this.calendarFechaEntrega.MinDate = new System.DateTime(2014, 12, 9, 0, 0, 0, 0);
            this.calendarFechaEntrega.Name = "calendarFechaEntrega";
            this.calendarFechaEntrega.Size = new System.Drawing.Size(197, 20);
            this.calendarFechaEntrega.TabIndex = 30;
            this.calendarFechaEntrega.Value = new System.DateTime(2014, 12, 9, 0, 0, 0, 0);
            // 
            // btnAddArticulo
            // 
            this.btnAddArticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticulo.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddArticulo.Location = new System.Drawing.Point(569, 156);
            this.btnAddArticulo.Name = "btnAddArticulo";
            this.btnAddArticulo.Size = new System.Drawing.Size(118, 23);
            this.btnAddArticulo.TabIndex = 31;
            this.btnAddArticulo.Text = "Añadir artículo";
            this.btnAddArticulo.UseVisualStyleBackColor = false;
            this.btnAddArticulo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Location = new System.Drawing.Point(444, 377);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPedido.TabIndex = 32;
            // 
            // NuevoPedidoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySleepy.Properties.Resources.portal_simple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 435);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.btnAddArticulo);
            this.Controls.Add(this.calendarFechaEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExplorarClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calendarFechaPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvNuevoPedido);
            this.Font = new System.Drawing.Font("PORTAL", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NuevoPedidoGUI";
            this.Text = "NuevoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNuevoPedido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtRefCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calendarFechaPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExplorarClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker calendarFechaEntrega;
        private System.Windows.Forms.Button btnAddArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRefArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioTotal;
        private System.Windows.Forms.Label lblTotalPedido;
    }
}