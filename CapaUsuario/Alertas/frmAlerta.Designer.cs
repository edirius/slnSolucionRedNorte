namespace CapaUsuario.Alertas
{
    partial class frmAlerta
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
            this.label1 = new System.Windows.Forms.Label();
            this.lnkGestantesControlPreNatal = new System.Windows.Forms.LinkLabel();
            this.lnkGestantesConRiesgoPresionArterial = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALERTAS";
            // 
            // lnkGestantesControlPreNatal
            // 
            this.lnkGestantesControlPreNatal.AutoSize = true;
            this.lnkGestantesControlPreNatal.Location = new System.Drawing.Point(56, 80);
            this.lnkGestantesControlPreNatal.Name = "lnkGestantesControlPreNatal";
            this.lnkGestantesControlPreNatal.Size = new System.Drawing.Size(239, 13);
            this.lnkGestantesControlPreNatal.TabIndex = 1;
            this.lnkGestantesControlPreNatal.TabStop = true;
            this.lnkGestantesControlPreNatal.Text = "GESTANTES QUE NO ACUDIERON A SU CITA";
            this.lnkGestantesControlPreNatal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGestantesControlPreNatal_LinkClicked);
            // 
            // lnkGestantesConRiesgoPresionArterial
            // 
            this.lnkGestantesConRiesgoPresionArterial.AutoSize = true;
            this.lnkGestantesConRiesgoPresionArterial.Location = new System.Drawing.Point(56, 123);
            this.lnkGestantesConRiesgoPresionArterial.Name = "lnkGestantesConRiesgoPresionArterial";
            this.lnkGestantesConRiesgoPresionArterial.Size = new System.Drawing.Size(327, 13);
            this.lnkGestantesConRiesgoPresionArterial.TabIndex = 2;
            this.lnkGestantesConRiesgoPresionArterial.TabStop = true;
            this.lnkGestantesConRiesgoPresionArterial.Text = "GESTANTES CON RIESGO POR PRESION ARTERIAL ELEVADA";
            this.lnkGestantesConRiesgoPresionArterial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 446);
            this.Controls.Add(this.lnkGestantesConRiesgoPresionArterial);
            this.Controls.Add(this.lnkGestantesControlPreNatal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlerta";
            this.Load += new System.EventHandler(this.frmAlerta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkGestantesControlPreNatal;
        private System.Windows.Forms.LinkLabel lnkGestantesConRiesgoPresionArterial;
    }
}