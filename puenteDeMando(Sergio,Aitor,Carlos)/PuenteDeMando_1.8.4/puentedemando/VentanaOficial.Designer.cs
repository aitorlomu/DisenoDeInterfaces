namespace PuenteDeMando
{
    partial class VentanaOficial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaOficial));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lGraduacion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listOficiales = new System.Windows.Forms.ListBox();
            this.btnAscender = new System.Windows.Forms.Button();
            this.btnDegradar = new System.Windows.Forms.Button();
            this.lRaza = new System.Windows.Forms.Label();
            this.lEspSect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 361);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo en el cargo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuenteDeMando.Properties.Resources.Zulu;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 147);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.BackColor = System.Drawing.Color.Transparent;
            this.lNombre.ForeColor = System.Drawing.Color.White;
            this.lNombre.Location = new System.Drawing.Point(9, 172);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "Nombre";
            // 
            // lGraduacion
            // 
            this.lGraduacion.AutoSize = true;
            this.lGraduacion.BackColor = System.Drawing.Color.Transparent;
            this.lGraduacion.ForeColor = System.Drawing.Color.White;
            this.lGraduacion.Location = new System.Drawing.Point(9, 196);
            this.lGraduacion.Name = "lGraduacion";
            this.lGraduacion.Size = new System.Drawing.Size(62, 13);
            this.lGraduacion.TabIndex = 5;
            this.lGraduacion.Text = "Graduacion";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(409, 361);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(118, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Ir a puente de mando";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // listOficiales
            // 
            this.listOficiales.BackColor = System.Drawing.SystemColors.MenuText;
            this.listOficiales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listOficiales.FormattingEnabled = true;
            this.listOficiales.Location = new System.Drawing.Point(402, 12);
            this.listOficiales.Name = "listOficiales";
            this.listOficiales.Size = new System.Drawing.Size(125, 173);
            this.listOficiales.TabIndex = 7;
            // 
            // btnAscender
            // 
            this.btnAscender.Location = new System.Drawing.Point(424, 191);
            this.btnAscender.Name = "btnAscender";
            this.btnAscender.Size = new System.Drawing.Size(75, 23);
            this.btnAscender.TabIndex = 8;
            this.btnAscender.Text = "Ascender";
            this.btnAscender.UseVisualStyleBackColor = true;
            this.btnAscender.Click += new System.EventHandler(this.btnAscender_Click);
            // 
            // btnDegradar
            // 
            this.btnDegradar.Location = new System.Drawing.Point(424, 220);
            this.btnDegradar.Name = "btnDegradar";
            this.btnDegradar.Size = new System.Drawing.Size(75, 23);
            this.btnDegradar.TabIndex = 9;
            this.btnDegradar.Text = " Degradar";
            this.btnDegradar.UseVisualStyleBackColor = true;
            this.btnDegradar.Click += new System.EventHandler(this.btnDegradar_Click);
            // 
            // lRaza
            // 
            this.lRaza.AutoSize = true;
            this.lRaza.BackColor = System.Drawing.Color.Transparent;
            this.lRaza.ForeColor = System.Drawing.Color.White;
            this.lRaza.Location = new System.Drawing.Point(9, 217);
            this.lRaza.Name = "lRaza";
            this.lRaza.Size = new System.Drawing.Size(32, 13);
            this.lRaza.TabIndex = 10;
            this.lRaza.Text = "Raza";
            // 
            // lEspSect
            // 
            this.lEspSect.AutoSize = true;
            this.lEspSect.BackColor = System.Drawing.Color.Transparent;
            this.lEspSect.ForeColor = System.Drawing.Color.White;
            this.lEspSect.Location = new System.Drawing.Point(9, 240);
            this.lEspSect.Name = "lEspSect";
            this.lEspSect.Size = new System.Drawing.Size(98, 13);
            this.lEspSect.TabIndex = 11;
            this.lEspSect.Text = "Especialidad/secta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "C.Oficial:";
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.BackColor = System.Drawing.Color.Transparent;
            this.lClave.ForeColor = System.Drawing.Color.White;
            this.lClave.Location = new System.Drawing.Point(65, 265);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(33, 13);
            this.lClave.TabIndex = 13;
            this.lClave.Text = "clave";
            // 
            // VentanaOficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 396);
            this.ControlBox = false;
            this.Controls.Add(this.lClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lEspSect);
            this.Controls.Add(this.lRaza);
            this.Controls.Add(this.btnDegradar);
            this.Controls.Add(this.btnAscender);
            this.Controls.Add(this.listOficiales);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lGraduacion);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 434);
            this.MinimumSize = new System.Drawing.Size(555, 434);
            this.Name = "VentanaOficial";
            this.Text = "Oficiales";
            this.Load += new System.EventHandler(this.VentanaOficial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lGraduacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox listOficiales;
        private System.Windows.Forms.Button btnAscender;
        private System.Windows.Forms.Button btnDegradar;
        private System.Windows.Forms.Label lRaza;
        private System.Windows.Forms.Label lEspSect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lClave;
    }
}

