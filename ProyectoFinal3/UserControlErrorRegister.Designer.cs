namespace ProyectoFinal3
{
    partial class UserControlErrorRegister
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
            this.labelTitleError = new System.Windows.Forms.Label();
            this.labelErrorDescription = new System.Windows.Forms.Label();
            this.labelErrorHelpUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProyectoFinal3.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(212, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitleError
            // 
            this.labelTitleError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleError.AutoSize = true;
            this.labelTitleError.Font = new System.Drawing.Font("Miriam CLM", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitleError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitleError.Location = new System.Drawing.Point(186, 91);
            this.labelTitleError.Name = "labelTitleError";
            this.labelTitleError.Size = new System.Drawing.Size(298, 29);
            this.labelTitleError.TabIndex = 1;
            this.labelTitleError.Text = "Error al registrar cuenta";
            // 
            // labelErrorDescription
            // 
            this.labelErrorDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelErrorDescription.AutoSize = true;
            this.labelErrorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelErrorDescription.Location = new System.Drawing.Point(90, 379);
            this.labelErrorDescription.Name = "labelErrorDescription";
            this.labelErrorDescription.Size = new System.Drawing.Size(499, 20);
            this.labelErrorDescription.TabIndex = 2;
            this.labelErrorDescription.Text = "Ha ocurrido un error al crear tu cuenta, vuelve a intentarlo mas tarde...";
            // 
            // labelErrorHelpUser
            // 
            this.labelErrorHelpUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelErrorHelpUser.AutoSize = true;
            this.labelErrorHelpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorHelpUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelErrorHelpUser.Location = new System.Drawing.Point(139, 410);
            this.labelErrorHelpUser.Name = "labelErrorHelpUser";
            this.labelErrorHelpUser.Size = new System.Drawing.Size(403, 16);
            this.labelErrorHelpUser.TabIndex = 3;
            this.labelErrorHelpUser.Text = "Pulsa el icono de la casa en la barra de tareas para volver al inicio";
            // 
            // UserControlErrorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.labelErrorHelpUser);
            this.Controls.Add(this.labelErrorDescription);
            this.Controls.Add(this.labelTitleError);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlErrorRegister";
            this.Size = new System.Drawing.Size(671, 544);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitleError;
        private System.Windows.Forms.Label labelErrorDescription;
        private System.Windows.Forms.Label labelErrorHelpUser;
    }
}
