namespace ProyectoFinal3
{
    partial class userControlNoAccount
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
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.labelCrearCuenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal3.Properties.Resources.user_interface;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesion.Location = new System.Drawing.Point(97, 17);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(104, 20);
            this.labelIniciarSesion.TabIndex = 1;
            this.labelIniciarSesion.Text = "Iniciar Sesión";
            this.labelIniciarSesion.Click += new System.EventHandler(this.labelIniciarSesion_Click);
            // 
            // labelCrearCuenta
            // 
            this.labelCrearCuenta.AutoSize = true;
            this.labelCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCrearCuenta.Location = new System.Drawing.Point(117, 37);
            this.labelCrearCuenta.Name = "labelCrearCuenta";
            this.labelCrearCuenta.Size = new System.Drawing.Size(68, 13);
            this.labelCrearCuenta.TabIndex = 2;
            this.labelCrearCuenta.Text = "Crear cuenta";
            this.labelCrearCuenta.Click += new System.EventHandler(this.labelCrearCuenta_Click);
            // 
            // userControlNoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelCrearCuenta);
            this.Controls.Add(this.labelIniciarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "userControlNoAccount";
            this.Size = new System.Drawing.Size(211, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Label labelCrearCuenta;
    }
}
