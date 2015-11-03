namespace MySleepy
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRepPassword = new System.Windows.Forms.TextBox();
            this.lblRepPassword = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 129);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cbRol.Location = new System.Drawing.Point(465, 70);
            this.cbRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(160, 23);
            this.cbRol.TabIndex = 2;
            this.cbRol.Text = "Seleccione un rol";
            this.cbRol.TextChanged += new System.EventHandler(this.cbRol_TextChanged);
            this.cbRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRol_KeyPress);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreCliente.Location = new System.Drawing.Point(113, 75);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(58, 15);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(91, 133);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtRepPassword
            // 
            this.txtRepPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtRepPassword.Location = new System.Drawing.Point(180, 185);
            this.txtRepPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRepPassword.Name = "txtRepPassword";
            this.txtRepPassword.PasswordChar = '*';
            this.txtRepPassword.Size = new System.Drawing.Size(132, 23);
            this.txtRepPassword.TabIndex = 5;
            this.txtRepPassword.UseSystemPasswordChar = true;
            this.txtRepPassword.TextChanged += new System.EventHandler(this.txtRepPassword_TextChanged);
            // 
            // lblRepPassword
            // 
            this.lblRepPassword.AutoSize = true;
            this.lblRepPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRepPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRepPassword.Location = new System.Drawing.Point(41, 188);
            this.lblRepPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepPassword.Name = "lblRepPassword";
            this.lblRepPassword.Size = new System.Drawing.Size(129, 15);
            this.lblRepPassword.TabIndex = 6;
            this.lblRepPassword.Text = "Repetir Contraseña";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Location = new System.Drawing.Point(427, 75);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 15);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrear.Location = new System.Drawing.Point(180, 247);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 27);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(465, 247);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 27);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MySleepy.Properties.Resources.portal_simple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 301);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblRepPassword);
            this.Controls.Add(this.txtRepPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("PORTAL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRepPassword;
        private System.Windows.Forms.Label lblRepPassword;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCerrar;
    }
}