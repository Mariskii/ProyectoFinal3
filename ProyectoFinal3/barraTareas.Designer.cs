namespace proyectoFinal
{
    partial class barraTareas
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
            this.hambgMenuButton = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelInfoToolsBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hambgMenuButton
            // 
            this.hambgMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hambgMenuButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hambgMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hambgMenuButton.Image = global::ProyectoFinal3.Properties.Resources.icons8_menú_50;
            this.hambgMenuButton.Location = new System.Drawing.Point(612, 0);
            this.hambgMenuButton.Name = "hambgMenuButton";
            this.hambgMenuButton.Size = new System.Drawing.Size(72, 73);
            this.hambgMenuButton.TabIndex = 1;
            this.hambgMenuButton.UseVisualStyleBackColor = true;
            this.hambgMenuButton.Click += new System.EventHandler(this.hambgMenuButton_Click_1);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Image = global::ProyectoFinal3.Properties.Resources.icons8_casa_50;
            this.buttonInicio.Location = new System.Drawing.Point(0, 0);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(72, 73);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(273, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearching);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // labelInfoToolsBar
            // 
            this.labelInfoToolsBar.AutoSize = true;
            this.labelInfoToolsBar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoToolsBar.Location = new System.Drawing.Point(167, 31);
            this.labelInfoToolsBar.Name = "labelInfoToolsBar";
            this.labelInfoToolsBar.Size = new System.Drawing.Size(100, 16);
            this.labelInfoToolsBar.TabIndex = 3;
            this.labelInfoToolsBar.Text = "Buscar jugador:";
            // 
            // barraTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(133)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.labelInfoToolsBar);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.hambgMenuButton);
            this.Controls.Add(this.buttonInicio);
            this.Name = "barraTareas";
            this.Size = new System.Drawing.Size(684, 73);
            this.Load += new System.EventHandler(this.barraTareas_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button hambgMenuButton;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelInfoToolsBar;
    }
}
