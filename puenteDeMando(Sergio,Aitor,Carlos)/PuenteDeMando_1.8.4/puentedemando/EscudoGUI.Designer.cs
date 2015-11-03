namespace PuenteDeMando
{
    partial class EscudoGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscudoGUI));
            this.btSalir = new System.Windows.Forms.Button();
            this.prBEscudo = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDaniadas = new System.Windows.Forms.Label();
            this.dgvEscudo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbComprobacion = new System.Windows.Forms.ProgressBar();
            this.lbCompro = new System.Windows.Forms.Label();
            this.lbEligeCas = new System.Windows.Forms.Label();
            this.pbEligeCasillas = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscudo)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(157, 389);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(169, 28);
            this.btSalir.TabIndex = 0;
            this.btSalir.Text = "Al Puente de Mando";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // prBEscudo
            // 
            this.prBEscudo.Location = new System.Drawing.Point(12, 12);
            this.prBEscudo.Maximum = 64;
            this.prBEscudo.Name = "prBEscudo";
            this.prBEscudo.Size = new System.Drawing.Size(487, 23);
            this.prBEscudo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(193, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Casillas dañadas:";
            // 
            // lbDaniadas
            // 
            this.lbDaniadas.AutoSize = true;
            this.lbDaniadas.BackColor = System.Drawing.Color.Black;
            this.lbDaniadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaniadas.ForeColor = System.Drawing.Color.Lime;
            this.lbDaniadas.Location = new System.Drawing.Point(225, 281);
            this.lbDaniadas.Name = "lbDaniadas";
            this.lbDaniadas.Size = new System.Drawing.Size(97, 55);
            this.lbDaniadas.TabIndex = 4;
            this.lbDaniadas.Text = "nro";
            // 
            // dgvEscudo
            // 
            this.dgvEscudo.AllowUserToAddRows = false;
            this.dgvEscudo.AllowUserToDeleteRows = false;
            this.dgvEscudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscudo.ColumnHeadersVisible = false;
            this.dgvEscudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvEscudo.Location = new System.Drawing.Point(12, 41);
            this.dgvEscudo.Name = "dgvEscudo";
            this.dgvEscudo.ReadOnly = true;
            this.dgvEscudo.RowHeadersVisible = false;
            this.dgvEscudo.Size = new System.Drawing.Size(487, 181);
            this.dgvEscudo.TabIndex = 5;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Column1";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Column2";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Column3";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Column4";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Column5";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Column6";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "Column7";
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "Column8";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // pbComprobacion
            // 
            this.pbComprobacion.Location = new System.Drawing.Point(23, 318);
            this.pbComprobacion.Maximum = 30;
            this.pbComprobacion.Name = "pbComprobacion";
            this.pbComprobacion.Size = new System.Drawing.Size(158, 23);
            this.pbComprobacion.TabIndex = 6;
            this.pbComprobacion.Value = 30;
            // 
            // lbCompro
            // 
            this.lbCompro.AutoSize = true;
            this.lbCompro.BackColor = System.Drawing.Color.Transparent;
            this.lbCompro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCompro.Location = new System.Drawing.Point(12, 250);
            this.lbCompro.Name = "lbCompro";
            this.lbCompro.Size = new System.Drawing.Size(176, 36);
            this.lbCompro.TabIndex = 7;
            this.lbCompro.Text = "Próxima comprobación \r\ndel escudo:";
            // 
            // lbEligeCas
            // 
            this.lbEligeCas.AutoSize = true;
            this.lbEligeCas.BackColor = System.Drawing.Color.Transparent;
            this.lbEligeCas.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEligeCas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbEligeCas.Location = new System.Drawing.Point(371, 250);
            this.lbEligeCas.Name = "lbEligeCas";
            this.lbEligeCas.Size = new System.Drawing.Size(144, 36);
            this.lbEligeCas.TabIndex = 9;
            this.lbEligeCas.Text = "Próxima elección \r\nde casilla:";
            // 
            // pbEligeCasillas
            // 
            this.pbEligeCasillas.Location = new System.Drawing.Point(374, 318);
            this.pbEligeCasillas.Maximum = 5;
            this.pbEligeCasillas.Name = "pbEligeCasillas";
            this.pbEligeCasillas.Size = new System.Drawing.Size(125, 23);
            this.pbEligeCasillas.TabIndex = 8;
            this.pbEligeCasillas.Value = 5;
            // 
            // EscudoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 443);
            this.ControlBox = false;
            this.Controls.Add(this.lbEligeCas);
            this.Controls.Add(this.pbEligeCasillas);
            this.Controls.Add(this.lbCompro);
            this.Controls.Add(this.pbComprobacion);
            this.Controls.Add(this.dgvEscudo);
            this.Controls.Add(this.lbDaniadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prBEscudo);
            this.Controls.Add(this.btSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(531, 481);
            this.MinimumSize = new System.Drawing.Size(531, 481);
            this.Name = "EscudoGUI";
            this.Text = "Escudo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void setDanio(int num)
        {
            lbDaniadas.Text = "" + num;
        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.ProgressBar prBEscudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDaniadas;
        private System.Windows.Forms.DataGridView dgvEscudo;
        private System.Windows.Forms.ProgressBar pbComprobacion;
        private System.Windows.Forms.Label lbCompro;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.Label lbEligeCas;
        private System.Windows.Forms.ProgressBar pbEligeCasillas;
    }
}