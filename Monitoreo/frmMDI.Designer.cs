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
            this.monitoreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establecimientosDeSaludToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.morbilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microRedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.establecimientoSaludToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.monitoreoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem1,
            this.redToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // monitoreoToolStripMenuItem
            // 
            this.monitoreoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microRedToolStripMenuItem,
            this.establecimientosDeSaludToolStripMenuItem});
            this.monitoreoToolStripMenuItem.Name = "monitoreoToolStripMenuItem";
            this.monitoreoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.monitoreoToolStripMenuItem.Text = "Reportes";
            // 
            // microRedToolStripMenuItem
            // 
            this.microRedToolStripMenuItem.Name = "microRedToolStripMenuItem";
            this.microRedToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.microRedToolStripMenuItem.Text = "MicroRed";
            this.microRedToolStripMenuItem.Click += new System.EventHandler(this.microRedToolStripMenuItem_Click);
            // 
            // establecimientosDeSaludToolStripMenuItem
            // 
            this.establecimientosDeSaludToolStripMenuItem.Name = "establecimientosDeSaludToolStripMenuItem";
            this.establecimientosDeSaludToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.establecimientosDeSaludToolStripMenuItem.Text = "Establecimientos de Salud";
            this.establecimientosDeSaludToolStripMenuItem.Click += new System.EventHandler(this.establecimientosDeSaludToolStripMenuItem_Click);
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
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morbilidadToolStripMenuItem});
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            // 
            // morbilidadToolStripMenuItem
            // 
            this.morbilidadToolStripMenuItem.Name = "morbilidadToolStripMenuItem";
            this.morbilidadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.morbilidadToolStripMenuItem.Text = "Morbilidad";
            this.morbilidadToolStripMenuItem.Click += new System.EventHandler(this.morbilidadToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microRedToolStripMenuItem1,
            this.establecimientoSaludToolStripMenuItem});
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.redToolStripMenuItem.Text = "RED NORTE";
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
        private System.Windows.Forms.ToolStripMenuItem monitoreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem establecimientosDeSaludToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem morbilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microRedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem establecimientoSaludToolStripMenuItem;
    }
}

