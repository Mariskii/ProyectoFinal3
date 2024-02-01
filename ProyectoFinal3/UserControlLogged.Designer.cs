namespace ProyectoFinal3
{
    partial class UserControlLogged
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
            this.labelCloseSession = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelFavouritePlayers = new System.Windows.Forms.Label();
            this.panelLoggedFavPlayers = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoggedFavPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCloseSession
            // 
            this.labelCloseSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseSession.AutoSize = true;
            this.labelCloseSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseSession.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCloseSession.Location = new System.Drawing.Point(66, 43);
            this.labelCloseSession.Name = "labelCloseSession";
            this.labelCloseSession.Size = new System.Drawing.Size(89, 16);
            this.labelCloseSession.TabIndex = 0;
            this.labelCloseSession.Text = "Cerrar Sesión";
            this.labelCloseSession.Click += new System.EventHandler(this.labelCloseSession_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(80, 25);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 18);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Usuario";
            // 
            // labelFavouritePlayers
            // 
            this.labelFavouritePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFavouritePlayers.AutoSize = true;
            this.labelFavouritePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavouritePlayers.Location = new System.Drawing.Point(69, 25);
            this.labelFavouritePlayers.Name = "labelFavouritePlayers";
            this.labelFavouritePlayers.Size = new System.Drawing.Size(131, 16);
            this.labelFavouritePlayers.TabIndex = 2;
            this.labelFavouritePlayers.Text = "Jugadores Favoritos";
            this.labelFavouritePlayers.Click += new System.EventHandler(this.panelLoggedFavPlayers_Click);
            this.labelFavouritePlayers.MouseEnter += new System.EventHandler(this.panelLogged_MouseEnter);
            this.labelFavouritePlayers.MouseLeave += new System.EventHandler(this.panelLogged_MouseLeave);
            // 
            // panelLoggedFavPlayers
            // 
            this.panelLoggedFavPlayers.Controls.Add(this.pictureBox1);
            this.panelLoggedFavPlayers.Controls.Add(this.labelFavouritePlayers);
            this.panelLoggedFavPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLoggedFavPlayers.Location = new System.Drawing.Point(0, 85);
            this.panelLoggedFavPlayers.Name = "panelLoggedFavPlayers";
            this.panelLoggedFavPlayers.Size = new System.Drawing.Size(211, 66);
            this.panelLoggedFavPlayers.TabIndex = 3;
            this.panelLoggedFavPlayers.Click += new System.EventHandler(this.panelLoggedFavPlayers_Click);
            this.panelLoggedFavPlayers.MouseEnter += new System.EventHandler(this.panelLogged_MouseEnter);
            this.panelLoggedFavPlayers.MouseLeave += new System.EventHandler(this.panelLogged_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal3.Properties.Resources.estrella;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panelLoggedFavPlayers_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panelLogged_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panelLogged_MouseLeave);
            // 
            // UserControlLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelLoggedFavPlayers);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelCloseSession);
            this.Name = "UserControlLogged";
            this.Size = new System.Drawing.Size(211, 479);
            this.panelLoggedFavPlayers.ResumeLayout(false);
            this.panelLoggedFavPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCloseSession;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelFavouritePlayers;
        private System.Windows.Forms.Panel panelLoggedFavPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
