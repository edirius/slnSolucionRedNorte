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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMicroRED));
            this.label1 = new System.Windows.Forms.Label();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporObstetras = new System.Windows.Forms.Button();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestantesNominal = new System.Windows.Forms.Button();
            this.dgvMicroRED = new System.Windows.Forms.DataGridView();
            this.idtmicrored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGestantesFechaPP = new System.Windows.Forms.Button();
            this.btnGestantesDadoParto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGestantesMorbilidad = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroRED)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 9);
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
            this.cboAño.Location = new System.Drawing.Point(59, 3);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(192, 21);
            this.cboAño.TabIndex = 1;
            this.cboAño.SelectedIndexChanged += new System.EventHandler(this.cboAño_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.ImageKey = "NetByte Design Studio - 0957.png";
            this.btnSalir.Location = new System.Drawing.Point(3, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 64);
            this.btnSalir.TabIndex = 107;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReporObstetras
            // 
            this.btnReporObstetras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporObstetras.BackColor = System.Drawing.Color.MintCream;
            this.btnReporObstetras.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnReporObstetras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReporObstetras.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnReporObstetras.Location = new System.Drawing.Point(3, 3);
            this.btnReporObstetras.Name = "btnReporObstetras";
            this.btnReporObstetras.Size = new System.Drawing.Size(107, 59);
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
            "TODOS",
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
            this.cboMes.Location = new System.Drawing.Point(313, 3);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(251, 21);
            this.cboMes.TabIndex = 109;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Año";
            // 
            // btnGestantesNominal
            // 
            this.btnGestantesNominal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesNominal.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesNominal.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesNominal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesNominal.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesNominal.Location = new System.Drawing.Point(3, 3);
            this.btnGestantesNominal.Name = "btnGestantesNominal";
            this.btnGestantesNominal.Size = new System.Drawing.Size(95, 62);
            this.btnGestantesNominal.TabIndex = 110;
            this.btnGestantesNominal.Text = "Nominal Gestantes";
            this.btnGestantesNominal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesNominal.UseVisualStyleBackColor = false;
            this.btnGestantesNominal.Click += new System.EventHandler(this.btnGestantesNominal_Click);
            // 
            // dgvMicroRED
            // 
            this.dgvMicroRED.AllowUserToAddRows = false;
            this.dgvMicroRED.AllowUserToDeleteRows = false;
            this.dgvMicroRED.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMicroRED.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMicroRED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMicroRED.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtmicrored,
            this.microred,
            this.direccion});
            this.dgvMicroRED.Location = new System.Drawing.Point(6, 19);
            this.dgvMicroRED.Name = "dgvMicroRED";
            this.dgvMicroRED.RowHeadersVisible = false;
            this.dgvMicroRED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMicroRED.Size = new System.Drawing.Size(555, 314);
            this.dgvMicroRED.TabIndex = 111;
            this.dgvMicroRED.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMicroRED_CellClick);
            this.dgvMicroRED.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMicroRED_CellContentClick);
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
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvMicroRED);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 339);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micro RED";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 31);
            this.tableLayoutPanel1.TabIndex = 113;
            // 
            // btnGestantesFechaPP
            // 
            this.btnGestantesFechaPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesFechaPP.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesFechaPP.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesFechaPP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesFechaPP.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesFechaPP.Location = new System.Drawing.Point(3, 139);
            this.btnGestantesFechaPP.Name = "btnGestantesFechaPP";
            this.btnGestantesFechaPP.Size = new System.Drawing.Size(95, 62);
            this.btnGestantesFechaPP.TabIndex = 114;
            this.btnGestantesFechaPP.Text = "Gestantes Fecha P.P.";
            this.btnGestantesFechaPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesFechaPP.UseVisualStyleBackColor = false;
            this.btnGestantesFechaPP.Click += new System.EventHandler(this.btnGestantesFechaPP_Click);
            // 
            // btnGestantesDadoParto
            // 
            this.btnGestantesDadoParto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesDadoParto.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesDadoParto.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesDadoParto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesDadoParto.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesDadoParto.Location = new System.Drawing.Point(3, 207);
            this.btnGestantesDadoParto.Name = "btnGestantesDadoParto";
            this.btnGestantesDadoParto.Size = new System.Drawing.Size(95, 62);
            this.btnGestantesDadoParto.TabIndex = 115;
            this.btnGestantesDadoParto.Text = "Gestantes Dado Parto";
            this.btnGestantesDadoParto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesDadoParto.UseVisualStyleBackColor = false;
            this.btnGestantesDadoParto.Click += new System.EventHandler(this.btnGestantesDadoParto_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ImageKey = "NetByte Design Studio - 0849.png";
            this.button1.Location = new System.Drawing.Point(116, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 59);
            this.button1.TabIndex = 116;
            this.button1.Text = "Transeuntes";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnGestantesMorbilidad
            // 
            this.btnGestantesMorbilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesMorbilidad.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesMorbilidad.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesMorbilidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesMorbilidad.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesMorbilidad.Location = new System.Drawing.Point(3, 71);
            this.btnGestantesMorbilidad.Name = "btnGestantesMorbilidad";
            this.btnGestantesMorbilidad.Size = new System.Drawing.Size(95, 62);
            this.btnGestantesMorbilidad.TabIndex = 117;
            this.btnGestantesMorbilidad.Text = "Morbilidad Gestantes";
            this.btnGestantesMorbilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesMorbilidad.UseVisualStyleBackColor = false;
            this.btnGestantesMorbilidad.Click += new System.EventHandler(this.btnGestantesMorbilidad_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesNominal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesMorbilidad, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSalir, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesDadoParto, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesFechaPP, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(585, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(101, 410);
            this.tableLayoutPanel2.TabIndex = 118;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ImageKey = "NetByte Design Studio - 0849.png";
            this.button2.Location = new System.Drawing.Point(3, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 62);
            this.button2.TabIndex = 120;
            this.button2.Text = "Recien Nacidos Bajo Peso";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnReporObstetras, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 394);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(567, 65);
            this.tableLayoutPanel3.TabIndex = 119;
            // 
            // frmReporteMicroRED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monitoreo.Properties.Resources.FondoFormularios2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 471);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteMicroRED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Micro RED";
            this.Load += new System.EventHandler(this.frmReporteObstetras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMicroRED)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReporObstetras;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestantesNominal;
        private System.Windows.Forms.DataGridView dgvMicroRED;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtmicrored;
        private System.Windows.Forms.DataGridViewTextBoxColumn microred;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button btnGestantesFechaPP;
        private System.Windows.Forms.Button btnGestantesDadoParto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGestantesMorbilidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
    }
}