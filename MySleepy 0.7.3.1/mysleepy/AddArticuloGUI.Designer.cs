namespace MySleepy
{
    partial class AddArticuloGUI
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
            this.btnExplorarArticulos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRefArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnCalcularImporte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExplorarArticulos
            // 
            this.btnExplorarArticulos.Location = new System.Drawing.Point(102, 35);
            this.btnExplorarArticulos.Name = "btnExplorarArticulos";
            this.btnExplorarArticulos.Size = new System.Drawing.Size(104, 23);
            this.btnExplorarArticulos.TabIndex = 31;
            this.btnExplorarArticulos.Text = "Explorar articulos...";
            this.btnExplorarArticulos.UseVisualStyleBackColor = true;
            this.btnExplorarArticulos.Click += new System.EventHandler(this.btnExplorarArticulos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ref. Articulo";
            // 
            // txtRefArticulo
            // 
            this.txtRefArticulo.Enabled = false;
            this.txtRefArticulo.Location = new System.Drawing.Point(16, 37);
            this.txtRefArticulo.Name = "txtRefArticulo";
            this.txtRefArticulo.Size = new System.Drawing.Size(60, 20);
            this.txtRefArticulo.TabIndex = 29;
            this.txtRefArticulo.TextChanged += new System.EventHandler(this.txtRefArticulo_TextChanged_1);
            this.txtRefArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefArticulo_KeyPress);
            this.txtRefArticulo.Leave += new System.EventHandler(this.txtRefArticulo_Leave);
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(16, 80);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(190, 20);
            this.txtNombreArticulo.TabIndex = 32;
            this.txtNombreArticulo.TextChanged += new System.EventHandler(this.txtNombreArticulo_TextChanged);
            this.txtNombreArticulo.Leave += new System.EventHandler(this.txtNombreArticulo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre del artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(16, 151);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 34;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(102, 151);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(104, 20);
            this.txtPrecioVenta.TabIndex = 36;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(211, 240);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(104, 20);
            this.txtImporte.TabIndex = 40;
            // 
            // btnCalcularImporte
            // 
            this.btnCalcularImporte.Location = new System.Drawing.Point(251, 186);
            this.btnCalcularImporte.Name = "btnCalcularImporte";
            this.btnCalcularImporte.Size = new System.Drawing.Size(64, 23);
            this.btnCalcularImporte.TabIndex = 41;
            this.btnCalcularImporte.Text = "Calcular";
            this.btnCalcularImporte.UseVisualStyleBackColor = true;
            this.btnCalcularImporte.Click += new System.EventHandler(this.btnCalcularImporte_Click);
            this.btnCalcularImporte.Leave += new System.EventHandler(this.btnCalcularImporte_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(251, 280);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(64, 23);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(16, 195);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 13);
            this.lblStock.TabIndex = 44;
            // 
            // AddArticuloGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 315);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcularImporte);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.btnExplorarArticulos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRefArticulo);
            this.Name = "AddArticuloGUI";
            this.Text = "AddArticuloGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtRefArticulo;
        public System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnCalcularImporte;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnExplorarArticulos;
        private System.Windows.Forms.Label lblStock;
    }
}