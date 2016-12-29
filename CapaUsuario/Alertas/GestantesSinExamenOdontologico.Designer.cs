namespace CapaUsuario.Alertas
{
    partial class GestantesSinExamenOdontologico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestantesSinExamenOdontologico));
            this.CRVGestanteOdonto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVGestanteOdonto
            // 
            this.CRVGestanteOdonto.ActiveViewIndex = -1;
            this.CRVGestanteOdonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVGestanteOdonto.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVGestanteOdonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVGestanteOdonto.Location = new System.Drawing.Point(0, 0);
            this.CRVGestanteOdonto.Name = "CRVGestanteOdonto";
            this.CRVGestanteOdonto.Size = new System.Drawing.Size(991, 535);
            this.CRVGestanteOdonto.TabIndex = 1;
            // 
            // GestantesSinExamenOdontologico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 535);
            this.Controls.Add(this.CRVGestanteOdonto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestantesSinExamenOdontologico";
            this.Text = "Reporte de Gestantes sin examen odontológico";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVGestanteOdonto;
    }
}