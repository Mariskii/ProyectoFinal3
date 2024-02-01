namespace proyectoFinal
{
    partial class FormMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelToolsBar = new System.Windows.Forms.Panel();
            this.hamburguerMenu = new System.Windows.Forms.Panel();
            this.panelHBmenuContent = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.timerHMenu = new System.Windows.Forms.Timer(this.components);
            this.hamburguerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolsBar
            // 
            this.panelToolsBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolsBar.Name = "panelToolsBar";
            this.panelToolsBar.Size = new System.Drawing.Size(800, 70);
            this.panelToolsBar.TabIndex = 0;
            // 
            // hamburguerMenu
            // 
            this.hamburguerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(52)))));
            this.hamburguerMenu.Controls.Add(this.panelHBmenuContent);
            this.hamburguerMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.hamburguerMenu.Location = new System.Drawing.Point(0, 70);
            this.hamburguerMenu.MaximumSize = new System.Drawing.Size(226, 0);
            this.hamburguerMenu.Name = "hamburguerMenu";
            this.hamburguerMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hamburguerMenu.Size = new System.Drawing.Size(207, 380);
            this.hamburguerMenu.TabIndex = 1;
            // 
            // panelHBmenuContent
            // 
            this.panelHBmenuContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHBmenuContent.Location = new System.Drawing.Point(0, 6);
            this.panelHBmenuContent.Name = "panelHBmenuContent";
            this.panelHBmenuContent.Size = new System.Drawing.Size(204, 380);
            this.panelHBmenuContent.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 70);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 380);
            this.panelPrincipal.TabIndex = 2;
            // 
            // timerHMenu
            // 
            this.timerHMenu.Interval = 10;
            this.timerHMenu.Tick += new System.EventHandler(this.timerHMenu_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hamburguerMenu);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelToolsBar);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.hamburguerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolsBar;
        private System.Windows.Forms.Panel hamburguerMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Timer timerHMenu;
        private System.Windows.Forms.Panel panelHBmenuContent;
    }
}

