namespace ProyectoFinal3
{
    partial class UserControlVistaJugadores
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelCartasJugadores = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(49, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(247, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Historial o Favoritos";
            // 
            // flowLayoutPanelCartasJugadores
            // 
            this.flowLayoutPanelCartasJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCartasJugadores.AutoScroll = true;
            this.flowLayoutPanelCartasJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.flowLayoutPanelCartasJugadores.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanelCartasJugadores.Name = "flowLayoutPanelCartasJugadores";
            this.flowLayoutPanelCartasJugadores.Size = new System.Drawing.Size(602, 373);
            this.flowLayoutPanelCartasJugadores.TabIndex = 1;
            // 
            // UserControlVistaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.flowLayoutPanelCartasJugadores);
            this.Controls.Add(this.labelTitle);
            this.Name = "UserControlVistaJugadores";
            this.Size = new System.Drawing.Size(602, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCartasJugadores;
    }
}
