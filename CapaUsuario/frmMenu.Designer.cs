namespace CapaUsuario
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establecimientoSaludToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establecimientoDeSaludToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.historiaClinicaToolStripMenuItem,
            this.establecimientoSaludToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // mantenimientoPacientesToolStripMenuItem
            // 
            this.mantenimientoPacientesToolStripMenuItem.Name = "mantenimientoPacientesToolStripMenuItem";
            this.mantenimientoPacientesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.mantenimientoPacientesToolStripMenuItem.Text = "Mantenimiento Pacientes";
            this.mantenimientoPacientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPacientesToolStripMenuItem_Click);
            // 
            // historiaClinicaToolStripMenuItem
            // 
            this.historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            this.historiaClinicaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.historiaClinicaToolStripMenuItem.Text = "Historia Clinica";
            this.historiaClinicaToolStripMenuItem.Click += new System.EventHandler(this.historiaClinicaToolStripMenuItem_Click);
            // 
            // establecimientoSaludToolStripMenuItem
            // 
            this.establecimientoSaludToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microredToolStripMenuItem,
            this.establecimientoDeSaludToolStripMenuItem});
            this.establecimientoSaludToolStripMenuItem.Name = "establecimientoSaludToolStripMenuItem";
            this.establecimientoSaludToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.establecimientoSaludToolStripMenuItem.Text = "Establecimiento Salud";
            // 
            // microredToolStripMenuItem
            // 
            this.microredToolStripMenuItem.Name = "microredToolStripMenuItem";
            this.microredToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.microredToolStripMenuItem.Text = "Microred";
            this.microredToolStripMenuItem.Click += new System.EventHandler(this.microredToolStripMenuItem_Click);
            // 
            // establecimientoDeSaludToolStripMenuItem
            // 
            this.establecimientoDeSaludToolStripMenuItem.Name = "establecimientoDeSaludToolStripMenuItem";
            this.establecimientoDeSaludToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.establecimientoDeSaludToolStripMenuItem.Text = "Establecimiento de Salud";
            this.establecimientoDeSaludToolStripMenuItem.Click += new System.EventHandler(this.establecimientoDeSaludToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem establecimientoSaludToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem establecimientoDeSaludToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}