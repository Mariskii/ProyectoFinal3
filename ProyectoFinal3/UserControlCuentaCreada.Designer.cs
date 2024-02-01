namespace ProyectoFinal3
{
    partial class UserControlCuentaCreada
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
            this.pictureBoxCorrect = new System.Windows.Forms.PictureBox();
            this.labelCorrectTitle = new System.Windows.Forms.Label();
            this.labelCorrectDescription = new System.Windows.Forms.Label();
            this.labelHelpCorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCorrect
            // 
            this.pictureBoxCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCorrect.Image = global::ProyectoFinal3.Properties.Resources.correcto;
            this.pictureBoxCorrect.Location = new System.Drawing.Point(145, 99);
            this.pictureBoxCorrect.Name = "pictureBoxCorrect";
            this.pictureBoxCorrect.Size = new System.Drawing.Size(244, 216);
            this.pictureBoxCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCorrect.TabIndex = 0;
            this.pictureBoxCorrect.TabStop = false;
            // 
            // labelCorrectTitle
            // 
            this.labelCorrectTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorrectTitle.AutoSize = true;
            this.labelCorrectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCorrectTitle.Location = new System.Drawing.Point(144, 53);
            this.labelCorrectTitle.Name = "labelCorrectTitle";
            this.labelCorrectTitle.Size = new System.Drawing.Size(245, 31);
            this.labelCorrectTitle.TabIndex = 1;
            this.labelCorrectTitle.Text = "ENHORABUENA!";
            // 
            // labelCorrectDescription
            // 
            this.labelCorrectDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorrectDescription.AutoSize = true;
            this.labelCorrectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCorrectDescription.Location = new System.Drawing.Point(128, 318);
            this.labelCorrectDescription.Name = "labelCorrectDescription";
            this.labelCorrectDescription.Size = new System.Drawing.Size(286, 16);
            this.labelCorrectDescription.TabIndex = 2;
            this.labelCorrectDescription.Text = "Tu cuenta ha sido creada correctamente";
            // 
            // labelHelpCorrect
            // 
            this.labelHelpCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHelpCorrect.AutoSize = true;
            this.labelHelpCorrect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelHelpCorrect.Location = new System.Drawing.Point(68, 334);
            this.labelHelpCorrect.Name = "labelHelpCorrect";
            this.labelHelpCorrect.Size = new System.Drawing.Size(422, 13);
            this.labelHelpCorrect.TabIndex = 3;
            this.labelHelpCorrect.Text = "Empieza a buscar estadísticas con el buscador o vuelve al inicio dando click en l" +
    "a casa";
            // 
            // UserControlCuentaCreada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.labelHelpCorrect);
            this.Controls.Add(this.labelCorrectDescription);
            this.Controls.Add(this.labelCorrectTitle);
            this.Controls.Add(this.pictureBoxCorrect);
            this.Name = "UserControlCuentaCreada";
            this.Size = new System.Drawing.Size(528, 431);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCorrect;
        private System.Windows.Forms.Label labelCorrectTitle;
        private System.Windows.Forms.Label labelCorrectDescription;
        private System.Windows.Forms.Label labelHelpCorrect;
    }
}
