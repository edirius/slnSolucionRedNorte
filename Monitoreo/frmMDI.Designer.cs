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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.slEstablecimiento = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMicroREDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEstablecimientoDeSaludToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaciónDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reportesToolStripMenuItem,
            this.importaciónDeDatosToolStripMenuItem});
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
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalesToolStripMenuItem,
            this.porMicroREDToolStripMenuItem,
            this.porEstablecimientoDeSaludToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // porMicroREDToolStripMenuItem
            // 
            this.porMicroREDToolStripMenuItem.Name = "porMicroREDToolStripMenuItem";
            this.porMicroREDToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.porMicroREDToolStripMenuItem.Text = "Por Micro RED";
            this.porMicroREDToolStripMenuItem.Click += new System.EventHandler(this.porMicroREDToolStripMenuItem_Click);
            // 
            // porEstablecimientoDeSaludToolStripMenuItem
            // 
            this.porEstablecimientoDeSaludToolStripMenuItem.Name = "porEstablecimientoDeSaludToolStripMenuItem";
            this.porEstablecimientoDeSaludToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.porEstablecimientoDeSaludToolStripMenuItem.Text = "Por Establecimiento de Salud";
            this.porEstablecimientoDeSaludToolStripMenuItem.Click += new System.EventHandler(this.porEstablecimientoDeSaludToolStripMenuItem_Click);
            // 
            // importaciónDeDatosToolStripMenuItem
            // 
            this.importaciónDeDatosToolStripMenuItem.Name = "importaciónDeDatosToolStripMenuItem";
            this.importaciónDeDatosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.importaciónDeDatosToolStripMenuItem.Text = "Importación de datos";
            this.importaciónDeDatosToolStripMenuItem.Click += new System.EventHandler(this.importaciónDeDatosToolStripMenuItem_Click);
            // 
            // generalesToolStripMenuItem
            // 
            this.generalesToolStripMenuItem.Name = "generalesToolStripMenuItem";
            this.generalesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.generalesToolStripMenuItem.Text = "Generales";
            this.generalesToolStripMenuItem.Click += new System.EventHandler(this.generalesToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monitoreo.Properties.Resources.Fondo6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Monitoreo Gestantes";
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
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaciónDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMicroREDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEstablecimientoDeSaludToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalesToolStripMenuItem;
    }
}

