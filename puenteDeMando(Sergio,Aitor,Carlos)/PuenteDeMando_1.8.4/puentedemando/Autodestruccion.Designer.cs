namespace PuenteDeMando
{
    partial class Autodestruccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autodestruccion));
            this.prAutodestruccion = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbtiempo = new System.Windows.Forms.Label();
            this.BWAutodestruccion = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // prAutodestruccion
            // 
            this.prAutodestruccion.Location = new System.Drawing.Point(12, 43);
            this.prAutodestruccion.Maximum = 10;
            this.prAutodestruccion.Name = "prAutodestruccion";
            this.prAutodestruccion.Size = new System.Drawing.Size(260, 23);
            this.prAutodestruccion.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(102, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbtiempo
            // 
            this.lbtiempo.AutoSize = true;
            this.lbtiempo.BackColor = System.Drawing.Color.Transparent;
            this.lbtiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtiempo.Location = new System.Drawing.Point(138, 9);
            this.lbtiempo.Name = "lbtiempo";
            this.lbtiempo.Size = new System.Drawing.Size(0, 13);
            this.lbtiempo.TabIndex = 2;
            // 
            // BWAutodestruccion
            // 
            this.BWAutodestruccion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWAutodestruccion_DoWork);
            this.BWAutodestruccion.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWAutodestruccion_ProgressChanged);
            // 
            // Autodestruccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(291, 117);
            this.ControlBox = false;
            this.Controls.Add(this.lbtiempo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prAutodestruccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(307, 155);
            this.MinimumSize = new System.Drawing.Size(307, 155);
            this.Name = "Autodestruccion";
            this.Text = "Autodestruccion";
            this.Load += new System.EventHandler(this.Autodestruccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prAutodestruccion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbtiempo;
        private System.ComponentModel.BackgroundWorker BWAutodestruccion;
    }
}