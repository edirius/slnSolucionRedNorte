﻿namespace CapaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoObstetrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaPorPaciwinwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaEntreFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarEImportarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.slEstablecimiento = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.historiaClinicaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.exportarEImportarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoObstetrasToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacientesToolStripMenuItem.Text = "Personal";
            // 
            // mantenimientoObstetrasToolStripMenuItem
            // 
            this.mantenimientoObstetrasToolStripMenuItem.Name = "mantenimientoObstetrasToolStripMenuItem";
            this.mantenimientoObstetrasToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.mantenimientoObstetrasToolStripMenuItem.Text = "Mantenimiento Obstetras";
            this.mantenimientoObstetrasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoObstetrasToolStripMenuItem_Click);
            // 
            // historiaClinicaToolStripMenuItem
            // 
            this.historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            this.historiaClinicaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.historiaClinicaToolStripMenuItem.Text = "Historia Clinica";
            this.historiaClinicaToolStripMenuItem.Click += new System.EventHandler(this.historiaClinicaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaClinicaPorPaciwinwToolStripMenuItem,
            this.historiaClinicaEntreFechasToolStripMenuItem,
            this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historiaClinicaPorPaciwinwToolStripMenuItem
            // 
            this.historiaClinicaPorPaciwinwToolStripMenuItem.Name = "historiaClinicaPorPaciwinwToolStripMenuItem";
            this.historiaClinicaPorPaciwinwToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.historiaClinicaPorPaciwinwToolStripMenuItem.Text = "Monitor Gestante Por Paciente";
            this.historiaClinicaPorPaciwinwToolStripMenuItem.Click += new System.EventHandler(this.historiaClinicaPorPaciwinwToolStripMenuItem_Click);
            // 
            // historiaClinicaEntreFechasToolStripMenuItem
            // 
            this.historiaClinicaEntreFechasToolStripMenuItem.Name = "historiaClinicaEntreFechasToolStripMenuItem";
            this.historiaClinicaEntreFechasToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.historiaClinicaEntreFechasToolStripMenuItem.Text = "Monitor Gestante Entre Fechas";
            this.historiaClinicaEntreFechasToolStripMenuItem.Click += new System.EventHandler(this.historiaClinicaEntreFechasToolStripMenuItem_Click);
            // 
            // rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem
            // 
            this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem.Name = "rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem";
            this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem.Text = "Resumen Cantidad De Gestantes Por Microred/EE.SS.";
            this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem.Click += new System.EventHandler(this.rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem_Click);
            // 
            // exportarEImportarDatosToolStripMenuItem
            // 
            this.exportarEImportarDatosToolStripMenuItem.Name = "exportarEImportarDatosToolStripMenuItem";
            this.exportarEImportarDatosToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.exportarEImportarDatosToolStripMenuItem.Text = "Exportar e Importar Datos";
            this.exportarEImportarDatosToolStripMenuItem.Click += new System.EventHandler(this.exportarEImportarDatosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slNombre,
            this.slEstablecimiento});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 2;
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaUsuario.Properties.Resources.Fondo6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control  y Seguimiento de Gestantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
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
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoObstetrasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slNombre;
        private System.Windows.Forms.ToolStripStatusLabel slEstablecimiento;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaPorPaciwinwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaEntreFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESUMENCANTIDADDEGESTANTESPORMICROREDEESSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarEImportarDatosToolStripMenuItem;
    }
}