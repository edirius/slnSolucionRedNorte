namespace Monitoreo.Reportes
{
    partial class frmReporteMicroRED
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
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporObstetras = new System.Windows.Forms.Button();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNominalGestante = new System.Windows.Forms.Button();
            this.dgvMicroRED = new System.Windows.Forms.DataGridView();
            this.idtmicrored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroRED)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes";
            // 
            // cboAño
            // 
            this.cboAño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(52, 3);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(165, 21);
            this.cboAño.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.ImageKey = "NetByte Design Studio - 0957.png";
            this.btnSalir.Location = new System.Drawing.Point(427, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 65);
            this.btnSalir.TabIndex = 107;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReporObstetras
            // 
            this.btnReporObstetras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporObstetras.BackColor = System.Drawing.Color.MintCream;
            this.btnReporObstetras.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnReporObstetras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReporObstetras.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnReporObstetras.Location = new System.Drawing.Point(252, 336);
            this.btnReporObstetras.Name = "btnReporObstetras";
            this.btnReporObstetras.Size = new System.Drawing.Size(82, 65);
            this.btnReporObstetras.TabIndex = 106;
            this.btnReporObstetras.Text = "Obstetras";
            this.btnReporObstetras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporObstetras.UseVisualStyleBackColor = false;
            this.btnReporObstetras.Click += new System.EventHandler(this.btnReporObstetras_Click);
            // 
            // cboMes
            // 
            this.cboMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SETIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cboMes.Location = new System.Drawing.Point(272, 3);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(215, 21);
            this.cboMes.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Año";
            // 
            // btnNominalGestante
            // 
            this.btnNominalGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNominalGestante.BackColor = System.Drawing.Color.MintCream;
            this.btnNominalGestante.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnNominalGestante.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNominalGestante.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnNominalGestante.Location = new System.Drawing.Point(340, 336);
            this.btnNominalGestante.Name = "btnNominalGestante";
            this.btnNominalGestante.Size = new System.Drawing.Size(81, 65);
            this.btnNominalGestante.TabIndex = 110;
            this.btnNominalGestante.Text = "Nominal Gestantes";
            this.btnNominalGestante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNominalGestante.UseVisualStyleBackColor = false;
            this.btnNominalGestante.Click += new System.EventHandler(this.btnNominalGestante_Click);
            // 
            // dgvMicroRED
            // 
            this.dgvMicroRED.AllowUserToAddRows = false;
            this.dgvMicroRED.AllowUserToDeleteRows = false;
            this.dgvMicroRED.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMicroRED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroRED.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtmicrored,
            this.microred,
            this.direccion});
            this.dgvMicroRED.Location = new System.Drawing.Point(6, 19);
            this.dgvMicroRED.Name = "dgvMicroRED";
            this.dgvMicroRED.RowHeadersVisible = false;
            this.dgvMicroRED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMicroRED.Size = new System.Drawing.Size(478, 256);
            this.dgvMicroRED.TabIndex = 111;
            this.dgvMicroRED.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMicroRED_CellClick);
            // 
            // idtmicrored
            // 
            this.idtmicrored.HeaderText = "idtmicrored";
            this.idtmicrored.Name = "idtmicrored";
            this.idtmicrored.ReadOnly = true;
            this.idtmicrored.Visible = false;
            // 
            // microred
            // 
            this.microred.HeaderText = "Micro RED";
            this.microred.Name = "microred";
            this.microred.ReadOnly = true;
            this.microred.Width = 150;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMicroRED);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 281);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micro RED";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboAño, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMes, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 31);
            this.tableLayoutPanel1.TabIndex = 113;
            // 
            // frmReporteMicroRED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNominalGestante);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporObstetras);
            this.Name = "frmReporteMicroRED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Micro RED";
            this.Load += new System.EventHandler(this.frmReporteObstetras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroRED)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReporObstetras;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNominalGestante;
        private System.Windows.Forms.DataGridView dgvMicroRED;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtmicrored;
        private System.Windows.Forms.DataGridViewTextBoxColumn microred;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}