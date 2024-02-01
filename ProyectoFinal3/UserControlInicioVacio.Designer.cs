namespace ProyectoFinal3
{
    partial class UserControlInicioVacio
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
            this.labelTitleHelp = new System.Windows.Forms.Label();
            this.labelAyudaUsuarioBusqueda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleHelp
            // 
            this.labelTitleHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleHelp.AutoSize = true;
            this.labelTitleHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitleHelp.Location = new System.Drawing.Point(275, 189);
            this.labelTitleHelp.Name = "labelTitleHelp";
            this.labelTitleHelp.Size = new System.Drawing.Size(219, 33);
            this.labelTitleHelp.TabIndex = 0;
            this.labelTitleHelp.Text = "¿Eres Rookie?";
            // 
            // labelAyudaUsuarioBusqueda
            // 
            this.labelAyudaUsuarioBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAyudaUsuarioBusqueda.AutoSize = true;
            this.labelAyudaUsuarioBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyudaUsuarioBusqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAyudaUsuarioBusqueda.Location = new System.Drawing.Point(209, 236);
            this.labelAyudaUsuarioBusqueda.Name = "labelAyudaUsuarioBusqueda";
            this.labelAyudaUsuarioBusqueda.Size = new System.Drawing.Size(376, 16);
            this.labelAyudaUsuarioBusqueda.TabIndex = 1;
            this.labelAyudaUsuarioBusqueda.Text = "Para buscar jugadores utiliza el buscador de la parte superior,";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(220, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "para iniciar sesión utilizapulsa el icono superior a la derecha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(320, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "y pulsa en \"Iniciar Sesión\"";
            // 
            // UserControlInicioVacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAyudaUsuarioBusqueda);
            this.Controls.Add(this.labelTitleHelp);
            this.Name = "UserControlInicioVacio";
            this.Size = new System.Drawing.Size(741, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleHelp;
        private System.Windows.Forms.Label labelAyudaUsuarioBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
