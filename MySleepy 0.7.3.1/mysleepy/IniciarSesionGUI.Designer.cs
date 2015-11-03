namespace MySleepy
{
    partial class IniciarSesionGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioIS = new System.Windows.Forms.TextBox();
            this.txtContraseñaIS = new System.Windows.Forms.TextBox();
            this.btnAceptarIS = new System.Windows.Forms.Button();
            this.btnCancelarIS = new System.Windows.Forms.Button();
            this.lblTituloIS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PORTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(79, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("PORTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuarioIS
            // 
            this.txtUsuarioIS.Location = new System.Drawing.Point(210, 275);
            this.txtUsuarioIS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUsuarioIS.Name = "txtUsuarioIS";
            this.txtUsuarioIS.Size = new System.Drawing.Size(180, 32);
            this.txtUsuarioIS.TabIndex = 2;
            this.txtUsuarioIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioIS_KeyPress);
            // 
            // txtContraseñaIS
            // 
            this.txtContraseñaIS.Location = new System.Drawing.Point(210, 351);
            this.txtContraseñaIS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtContraseñaIS.Name = "txtContraseñaIS";
            this.txtContraseñaIS.PasswordChar = '*';
            this.txtContraseñaIS.Size = new System.Drawing.Size(180, 32);
            this.txtContraseñaIS.TabIndex = 3;
            this.txtContraseñaIS.UseSystemPasswordChar = true;
            this.txtContraseñaIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseñaIS_KeyPress);
            // 
            // btnAceptarIS
            // 
            this.btnAceptarIS.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarIS.Font = new System.Drawing.Font("PORTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarIS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarIS.Location = new System.Drawing.Point(124, 410);
            this.btnAceptarIS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAceptarIS.Name = "btnAceptarIS";
            this.btnAceptarIS.Size = new System.Drawing.Size(116, 35);
            this.btnAceptarIS.TabIndex = 4;
            this.btnAceptarIS.Text = "Aceptar";
            this.btnAceptarIS.UseVisualStyleBackColor = false;
            this.btnAceptarIS.Click += new System.EventHandler(this.btnAceptarIS_Click);
            // 
            // btnCancelarIS
            // 
            this.btnCancelarIS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarIS.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarIS.Font = new System.Drawing.Font("PORTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarIS.Location = new System.Drawing.Point(274, 410);
            this.btnCancelarIS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancelarIS.Name = "btnCancelarIS";
            this.btnCancelarIS.Size = new System.Drawing.Size(116, 35);
            this.btnCancelarIS.TabIndex = 5;
            this.btnCancelarIS.Text = "Cancelar";
            this.btnCancelarIS.UseVisualStyleBackColor = false;
            this.btnCancelarIS.Click += new System.EventHandler(this.btnCancelarIS_Click);
            // 
            // lblTituloIS
            // 
            this.lblTituloIS.AutoSize = true;
            this.lblTituloIS.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloIS.Font = new System.Drawing.Font("PORTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloIS.Location = new System.Drawing.Point(119, 211);
            this.lblTituloIS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTituloIS.Name = "lblTituloIS";
            this.lblTituloIS.Size = new System.Drawing.Size(259, 25);
            this.lblTituloIS.TabIndex = 6;
            this.lblTituloIS.Text = "ACCESO A LA APLICACIÓN";
            // 
            // IniciarSesionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::MySleepy.Properties.Resources.bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 663);
            this.Controls.Add(this.lblTituloIS);
            this.Controls.Add(this.btnCancelarIS);
            this.Controls.Add(this.btnAceptarIS);
            this.Controls.Add(this.txtContraseñaIS);
            this.Controls.Add(this.txtUsuarioIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PORTAL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IniciarSesionGUI";
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioIS;
        private System.Windows.Forms.TextBox txtContraseñaIS;
        private System.Windows.Forms.Button btnAceptarIS;
        private System.Windows.Forms.Button btnCancelarIS;
        private System.Windows.Forms.Label lblTituloIS;
    }
}