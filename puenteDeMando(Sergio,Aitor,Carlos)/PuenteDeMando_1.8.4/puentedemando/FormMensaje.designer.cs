namespace PuenteDeMando
{
    partial class FormMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensaje));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cajaTexto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnForzarSeguridad = new System.Windows.Forms.Button();
            this.btnIrPuenteMando = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.columOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino: ";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(81, 26);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbOrigen.TabIndex = 2;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(81, 72);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 3;
            // 
            // cajaTexto
            // 
            this.cajaTexto.Location = new System.Drawing.Point(264, 23);
            this.cajaTexto.Multiline = true;
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.Size = new System.Drawing.Size(273, 100);
            this.cajaTexto.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(568, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(568, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnForzarSeguridad
            // 
            this.btnForzarSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForzarSeguridad.Location = new System.Drawing.Point(438, 377);
            this.btnForzarSeguridad.Name = "btnForzarSeguridad";
            this.btnForzarSeguridad.Size = new System.Drawing.Size(99, 23);
            this.btnForzarSeguridad.TabIndex = 7;
            this.btnForzarSeguridad.Text = "Forzar Seguridad";
            this.btnForzarSeguridad.UseVisualStyleBackColor = true;
            this.btnForzarSeguridad.Click += new System.EventHandler(this.btnForzarSeguridad_Click);
            // 
            // btnIrPuenteMando
            // 
            this.btnIrPuenteMando.Location = new System.Drawing.Point(568, 377);
            this.btnIrPuenteMando.Name = "btnIrPuenteMando";
            this.btnIrPuenteMando.Size = new System.Drawing.Size(136, 23);
            this.btnIrPuenteMando.TabIndex = 8;
            this.btnIrPuenteMando.Text = "Ir al puente de mando";
            this.btnIrPuenteMando.UseVisualStyleBackColor = true;
            this.btnIrPuenteMando.Click += new System.EventHandler(this.btnIrPuenteMando_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 377);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columOrigen,
            this.Destino,
            this.columTexto});
            this.dgvTabla.Location = new System.Drawing.Point(33, 184);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(655, 150);
            this.dgvTabla.TabIndex = 10;
            // 
            // columOrigen
            // 
            this.columOrigen.Frozen = true;
            this.columOrigen.HeaderText = "Origen";
            this.columOrigen.Name = "columOrigen";
            this.columOrigen.ReadOnly = true;
            this.columOrigen.Width = 150;
            // 
            // Destino
            // 
            this.Destino.Frozen = true;
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 150;
            // 
            // columTexto
            // 
            this.columTexto.Frozen = true;
            this.columTexto.HeaderText = "Texto";
            this.columTexto.Name = "columTexto";
            this.columTexto.ReadOnly = true;
            this.columTexto.Width = 350;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Copia de Seguridad";
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuenteDeMando.Properties.Resources.comunicacion;
            this.ClientSize = new System.Drawing.Size(723, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnIrPuenteMando);
            this.Controls.Add(this.btnForzarSeguridad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cajaTexto);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(739, 450);
            this.MinimumSize = new System.Drawing.Size(739, 450);
            this.Name = "FormMensaje";
            this.ShowInTaskbar = false;
            this.Text = "FormMensaje";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.TextBox cajaTexto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnForzarSeguridad;
        private System.Windows.Forms.Button btnIrPuenteMando;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTexto;
    }
}