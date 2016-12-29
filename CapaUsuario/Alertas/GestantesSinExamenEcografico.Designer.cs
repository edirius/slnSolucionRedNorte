namespace CapaUsuario.Alertas
{
    partial class GestantesSinExamenEcografico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestantesSinExamenEcografico));
            this.CRVGestantesEco = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVGestantesEco
            // 
            this.CRVGestantesEco.ActiveViewIndex = -1;
            this.CRVGestantesEco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVGestantesEco.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVGestantesEco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVGestantesEco.Location = new System.Drawing.Point(0, 0);
            this.CRVGestantesEco.Name = "CRVGestantesEco";
            this.CRVGestantesEco.Size = new System.Drawing.Size(998, 536);
            this.CRVGestantesEco.TabIndex = 0;
            // 
            // GestantesSinExamenEcografico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 536);
            this.Controls.Add(this.CRVGestantesEco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestantesSinExamenEcografico";
            this.Text = "Reporte de Gestantes sin examen ecográfico";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVGestantesEco;
    }
}