namespace ProyectoFinal3
{
    partial class UserControlIniciarSesion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.textBoxNameUserLogIn = new System.Windows.Forms.TextBox();
            this.labelNameUserLogIn = new System.Windows.Forms.Label();
            this.textBoxLogInPassword = new System.Windows.Forms.TextBox();
            this.labelLogInPassword = new System.Windows.Forms.Label();
            this.labelNoAccount = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ProyectoFinal3.Properties.Resources.kobe;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogIn
            // 
            this.labelLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Noto Sans Cond", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogIn.Location = new System.Drawing.Point(460, 26);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(212, 39);
            this.labelLogIn.TabIndex = 2;
            this.labelLogIn.Text = "INICIAR SESIÓN";
            // 
            // textBoxNameUserLogIn
            // 
            this.textBoxNameUserLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameUserLogIn.Location = new System.Drawing.Point(391, 107);
            this.textBoxNameUserLogIn.Name = "textBoxNameUserLogIn";
            this.textBoxNameUserLogIn.Size = new System.Drawing.Size(376, 20);
            this.textBoxNameUserLogIn.TabIndex = 5;
            // 
            // labelNameUserLogIn
            // 
            this.labelNameUserLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameUserLogIn.AutoSize = true;
            this.labelNameUserLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUserLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNameUserLogIn.Location = new System.Drawing.Point(388, 88);
            this.labelNameUserLogIn.Name = "labelNameUserLogIn";
            this.labelNameUserLogIn.Size = new System.Drawing.Size(143, 16);
            this.labelNameUserLogIn.TabIndex = 4;
            this.labelNameUserLogIn.Text = "Nombre de usuario:";
            // 
            // textBoxLogInPassword
            // 
            this.textBoxLogInPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogInPassword.Location = new System.Drawing.Point(391, 192);
            this.textBoxLogInPassword.Name = "textBoxLogInPassword";
            this.textBoxLogInPassword.PasswordChar = '*';
            this.textBoxLogInPassword.Size = new System.Drawing.Size(380, 20);
            this.textBoxLogInPassword.TabIndex = 9;
            // 
            // labelLogInPassword
            // 
            this.labelLogInPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogInPassword.AutoSize = true;
            this.labelLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogInPassword.Location = new System.Drawing.Point(388, 173);
            this.labelLogInPassword.Name = "labelLogInPassword";
            this.labelLogInPassword.Size = new System.Drawing.Size(90, 16);
            this.labelLogInPassword.TabIndex = 8;
            this.labelLogInPassword.Text = "Contraseña:";
            // 
            // labelNoAccount
            // 
            this.labelNoAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoAccount.AutoSize = true;
            this.labelNoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoAccount.Location = new System.Drawing.Point(501, 340);
            this.labelNoAccount.Name = "labelNoAccount";
            this.labelNoAccount.Size = new System.Drawing.Size(146, 16);
            this.labelNoAccount.TabIndex = 13;
            this.labelNoAccount.Text = "¿No tienes una cuenta?";
            this.labelNoAccount.Click += new System.EventHandler(this.labelNoAccount_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogIn.AutoSize = true;
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(70)))), ((int)(((byte)(25)))));
            this.buttonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogIn.Location = new System.Drawing.Point(479, 268);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(183, 69);
            this.buttonLogIn.TabIndex = 12;
            this.buttonLogIn.Text = "INICIAR SESIÓN";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // UserControlIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.labelNoAccount);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxLogInPassword);
            this.Controls.Add(this.labelLogInPassword);
            this.Controls.Add(this.textBoxNameUserLogIn);
            this.Controls.Add(this.labelNameUserLogIn);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlIniciarSesion";
            this.Size = new System.Drawing.Size(784, 424);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.TextBox textBoxNameUserLogIn;
        private System.Windows.Forms.Label labelNameUserLogIn;
        private System.Windows.Forms.TextBox textBoxLogInPassword;
        private System.Windows.Forms.Label labelLogInPassword;
        private System.Windows.Forms.Label labelNoAccount;
        private System.Windows.Forms.Button buttonLogIn;
    }
}
