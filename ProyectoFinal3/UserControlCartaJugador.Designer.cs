namespace ProyectoFinal3
{
    partial class UserControlCartaJugador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCardNamePlayer = new System.Windows.Forms.Label();
            this.pictureBoxCardPlayerImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardPlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.labelCardNamePlayer);
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.UserControlCartaJugador_Click);
            // 
            // labelCardNamePlayer
            // 
            this.labelCardNamePlayer.AutoSize = true;
            this.labelCardNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNamePlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCardNamePlayer.Location = new System.Drawing.Point(31, 20);
            this.labelCardNamePlayer.Name = "labelCardNamePlayer";
            this.labelCardNamePlayer.Size = new System.Drawing.Size(221, 24);
            this.labelCardNamePlayer.TabIndex = 0;
            this.labelCardNamePlayer.Text = "Giannis Antetokuompo";
            this.labelCardNamePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCardNamePlayer.Click += new System.EventHandler(this.UserControlCartaJugador_Click);
            // 
            // pictureBoxCardPlayerImage
            // 
            this.pictureBoxCardPlayerImage.Location = new System.Drawing.Point(22, 3);
            this.pictureBoxCardPlayerImage.Name = "pictureBoxCardPlayerImage";
            this.pictureBoxCardPlayerImage.Size = new System.Drawing.Size(230, 173);
            this.pictureBoxCardPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCardPlayerImage.TabIndex = 1;
            this.pictureBoxCardPlayerImage.TabStop = false;
            this.pictureBoxCardPlayerImage.Click += new System.EventHandler(this.UserControlCartaJugador_Click);
            // 
            // UserControlCartaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxCardPlayerImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserControlCartaJugador";
            this.Size = new System.Drawing.Size(272, 240);
            this.Click += new System.EventHandler(this.UserControlCartaJugador_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardPlayerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCardNamePlayer;
        private System.Windows.Forms.PictureBox pictureBoxCardPlayerImage;
    }
}
