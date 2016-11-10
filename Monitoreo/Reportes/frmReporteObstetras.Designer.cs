namespace Monitoreo.Reportes
{
    partial class frmReporteObstetras
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
            this.cboEstablecimientoSalud = new System.Windows.Forms.ComboBox();
            this.dgvObstetra = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cboMicroRED = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObstetra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Micro RED";
            // 
            // cboEstablecimientoSalud
            // 
            this.cboEstablecimientoSalud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstablecimientoSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstablecimientoSalud.FormattingEnabled = true;
            this.cboEstablecimientoSalud.Location = new System.Drawing.Point(144, 39);
            this.cboEstablecimientoSalud.Name = "cboEstablecimientoSalud";
            this.cboEstablecimientoSalud.Size = new System.Drawing.Size(314, 21);
            this.cboEstablecimientoSalud.TabIndex = 1;
            this.cboEstablecimientoSalud.SelectedIndexChanged += new System.EventHandler(this.cboEstablecimientoSalud_SelectedIndexChanged);
            // 
            // dgvObstetra
            // 
            this.dgvObstetra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObstetra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObstetra.Location = new System.Drawing.Point(12, 66);
            this.dgvObstetra.Name = "dgvObstetra";
            this.dgvObstetra.Size = new System.Drawing.Size(446, 217);
            this.dgvObstetra.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.ImageKey = "NetByte Design Studio - 0957.png";
            this.btnSalir.Location = new System.Drawing.Point(383, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 65);
            this.btnSalir.TabIndex = 107;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.MintCream;
            this.btnImprimir.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnImprimir.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnImprimir.Location = new System.Drawing.Point(302, 289);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 65);
            this.btnImprimir.TabIndex = 106;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cboMicroRED
            // 
            this.cboMicroRED.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMicroRED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMicroRED.FormattingEnabled = true;
            this.cboMicroRED.Location = new System.Drawing.Point(144, 12);
            this.cboMicroRED.Name = "cboMicroRED";
            this.cboMicroRED.Size = new System.Drawing.Size(314, 21);
            this.cboMicroRED.TabIndex = 109;
            this.cboMicroRED.SelectedIndexChanged += new System.EventHandler(this.cboMicroRED_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Establecimiento de Salud";
            // 
            // frmReporteObstetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 366);
            this.Controls.Add(this.cboMicroRED);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvObstetra);
            this.Controls.Add(this.cboEstablecimientoSalud);
            this.Controls.Add(this.label1);
            this.Name = "frmReporteObstetras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Obstetras";
            this.Load += new System.EventHandler(this.frmReporteObstetras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObstetra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstablecimientoSalud;
        private System.Windows.Forms.DataGridView dgvObstetra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboMicroRED;
        private System.Windows.Forms.Label label2;
    }
}