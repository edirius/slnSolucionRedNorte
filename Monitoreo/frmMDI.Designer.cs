namespace Monitoreo
{
    partial class frmMDI
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.slEstablecimiento = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microRedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.establecimientoSaludToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morbilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slNombre,
            this.slEstablecimiento});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slNombre
            // 
            this.slNombre.Name = "slNombre";
            this.slNombre.Size = new System.Drawing.Size(16, 17);
            this.slNombre.Text = "...";
            // 
            // slEstablecimiento
            // 
            this.slEstablecimiento.Name = "slEstablecimiento";
            this.slEstablecimiento.Size = new System.Drawing.Size(16, 17);
            this.slEstablecimiento.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.redToolStripMenuItem,
            this.morbilidadToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradoresToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mantenimientoToolStripMenuItem.Text = "Personal";
            // 
            // administradoresToolStripMenuItem
            // 
            this.administradoresToolStripMenuItem.Name = "administradoresToolStripMenuItem";
            this.administradoresToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.administradoresToolStripMenuItem.Text = "Administradores";
            this.administradoresToolStripMenuItem.Click += new System.EventHandler(this.administradoresToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microRedToolStripMenuItem1,
            this.establecimientoSaludToolStripMenuItem});
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.redToolStripMenuItem.Text = "Red Norte";
            // 
            // microRedToolStripMenuItem1
            // 
            this.microRedToolStripMenuItem1.Name = "microRedToolStripMenuItem1";
            this.microRedToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.microRedToolStripMenuItem1.Text = "Micro Red";
            this.microRedToolStripMenuItem1.Click += new System.EventHandler(this.microRedToolStripMenuItem1_Click);
            // 
            // establecimientoSaludToolStripMenuItem
            // 
            this.establecimientoSaludToolStripMenuItem.Name = "establecimientoSaludToolStripMenuItem";
            this.establecimientoSaludToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.establecimientoSaludToolStripMenuItem.Text = "Establecimiento Salud";
            this.establecimientoSaludToolStripMenuItem.Click += new System.EventHandler(this.establecimientoSaludToolStripMenuItem_Click);
            // 
            // morbilidadToolStripMenuItem
            // 
            this.morbilidadToolStripMenuItem.Name = "morbilidadToolStripMenuItem";
            this.morbilidadToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.morbilidadToolStripMenuItem.Text = "Morbilidad";
            this.morbilidadToolStripMenuItem.Click += new System.EventHandler(this.morbilidadToolStripMenuItem_Click_1);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoreo Sistema Control Gestantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slNombre;
        private System.Windows.Forms.ToolStripStatusLabel slEstablecimiento;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microRedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem establecimientoSaludToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morbilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}

