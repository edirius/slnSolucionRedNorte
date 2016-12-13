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
            this.btnTranseuntes = new System.Windows.Forms.Button();
            this.btnGestantesMorbilidad = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRNBajoPeso = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGestantesSin2ControlPuerperio = new System.Windows.Forms.Button();
            this.btnGestantesPresionAlta = new System.Windows.Forms.Button();
            this.btnGestantesConAnemia = new System.Windows.Forms.Button();
            this.btnGestantesConSifilis = new System.Windows.Forms.Button();
            this.btnGestantesConVIH = new System.Windows.Forms.Button();
            this.btnGestantesConInfeccionUrinaria = new System.Windows.Forms.Button();
            this.btnGestantesSinTratamiento = new System.Windows.Forms.Button();
            this.btnGestantesSinBateria = new System.Windows.Forms.Button();
            this.btnGestantesSinExamenOrina = new System.Windows.Forms.Button();
            this.btnGestantesSinControlPuerperio = new System.Windows.Forms.Button();
            this.btnGestantesSinCita = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(247, 9);
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
            this.cboAño.Location = new System.Drawing.Point(53, 3);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(171, 21);
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
            this.btnSalir.Location = new System.Drawing.Point(3, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 70);
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
            this.btnReporObstetras.Size = new System.Drawing.Size(115, 65);
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
            this.cboMes.Location = new System.Drawing.Point(280, 3);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(225, 21);
            this.cboMes.TabIndex = 109;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 9);
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
            this.btnGestantesNominal.Location = new System.Drawing.Point(3, 74);
            this.btnGestantesNominal.Name = "btnGestantesNominal";
            this.btnGestantesNominal.Size = new System.Drawing.Size(115, 65);
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
            this.dgvMicroRED.Size = new System.Drawing.Size(496, 224);
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
            this.groupBox1.Size = new System.Drawing.Size(508, 249);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 31);
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
            this.btnGestantesFechaPP.Location = new System.Drawing.Point(3, 216);
            this.btnGestantesFechaPP.Name = "btnGestantesFechaPP";
            this.btnGestantesFechaPP.Size = new System.Drawing.Size(115, 65);
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
            this.btnGestantesDadoParto.Location = new System.Drawing.Point(3, 287);
            this.btnGestantesDadoParto.Name = "btnGestantesDadoParto";
            this.btnGestantesDadoParto.Size = new System.Drawing.Size(115, 65);
            this.btnGestantesDadoParto.TabIndex = 115;
            this.btnGestantesDadoParto.Text = "Gestantes Dado Parto";
            this.btnGestantesDadoParto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesDadoParto.UseVisualStyleBackColor = false;
            this.btnGestantesDadoParto.Click += new System.EventHandler(this.btnGestantesDadoParto_Click);
            // 
            // btnTranseuntes
            // 
            this.btnTranseuntes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranseuntes.BackColor = System.Drawing.Color.MintCream;
            this.btnTranseuntes.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnTranseuntes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTranseuntes.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnTranseuntes.Location = new System.Drawing.Point(3, 145);
            this.btnTranseuntes.Name = "btnTranseuntes";
            this.btnTranseuntes.Size = new System.Drawing.Size(115, 65);
            this.btnTranseuntes.TabIndex = 116;
            this.btnTranseuntes.Text = "Transeuntes";
            this.btnTranseuntes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTranseuntes.UseVisualStyleBackColor = false;
            this.btnTranseuntes.Click += new System.EventHandler(this.btnTranseuntes_Click);
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
            this.btnGestantesMorbilidad.Location = new System.Drawing.Point(3, 3);
            this.btnGestantesMorbilidad.Name = "btnGestantesMorbilidad";
            this.btnGestantesMorbilidad.Size = new System.Drawing.Size(121, 64);
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
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesNominal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnReporObstetras, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTranseuntes, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesFechaPP, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnRNBajoPeso, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnGestantesDadoParto, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSalir, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(526, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(121, 502);
            this.tableLayoutPanel2.TabIndex = 118;
            // 
            // btnRNBajoPeso
            // 
            this.btnRNBajoPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRNBajoPeso.BackColor = System.Drawing.Color.MintCream;
            this.btnRNBajoPeso.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnRNBajoPeso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRNBajoPeso.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnRNBajoPeso.Location = new System.Drawing.Point(3, 358);
            this.btnRNBajoPeso.Name = "btnRNBajoPeso";
            this.btnRNBajoPeso.Size = new System.Drawing.Size(115, 65);
            this.btnRNBajoPeso.TabIndex = 120;
            this.btnRNBajoPeso.Text = "Recien Nacidos con Bajo Peso";
            this.btnRNBajoPeso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRNBajoPeso.UseVisualStyleBackColor = false;
            this.btnRNBajoPeso.Click += new System.EventHandler(this.btnRNBajoPeso_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesSin2ControlPuerperio, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesMorbilidad, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesPresionAlta, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesConAnemia, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesConSifilis, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesConVIH, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesConInfeccionUrinaria, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesSinTratamiento, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesSinBateria, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesSinExamenOrina, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesSinControlPuerperio, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnGestantesSinCita, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 304);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(508, 210);
            this.tableLayoutPanel3.TabIndex = 119;
            // 
            // btnGestantesSin2ControlPuerperio
            // 
            this.btnGestantesSin2ControlPuerperio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesSin2ControlPuerperio.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesSin2ControlPuerperio.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesSin2ControlPuerperio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesSin2ControlPuerperio.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesSin2ControlPuerperio.Location = new System.Drawing.Point(384, 143);
            this.btnGestantesSin2ControlPuerperio.Name = "btnGestantesSin2ControlPuerperio";
            this.btnGestantesSin2ControlPuerperio.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesSin2ControlPuerperio.TabIndex = 130;
            this.btnGestantesSin2ControlPuerperio.Text = "Puerpera sin 2do Control Puerperio";
            this.btnGestantesSin2ControlPuerperio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesSin2ControlPuerperio.UseVisualStyleBackColor = false;
            this.btnGestantesSin2ControlPuerperio.Click += new System.EventHandler(this.btnGestantesSin2ControlPuerperio_Click);
            // 
            // btnGestantesPresionAlta
            // 
            this.btnGestantesPresionAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesPresionAlta.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesPresionAlta.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesPresionAlta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesPresionAlta.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesPresionAlta.Location = new System.Drawing.Point(130, 3);
            this.btnGestantesPresionAlta.Name = "btnGestantesPresionAlta";
            this.btnGestantesPresionAlta.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesPresionAlta.TabIndex = 121;
            this.btnGestantesPresionAlta.Text = "Gestantes con Presion Arterial Elevada";
            this.btnGestantesPresionAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesPresionAlta.UseVisualStyleBackColor = false;
            this.btnGestantesPresionAlta.Click += new System.EventHandler(this.btnGestantesPresionAlta_Click);
            // 
            // btnGestantesConAnemia
            // 
            this.btnGestantesConAnemia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesConAnemia.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesConAnemia.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesConAnemia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesConAnemia.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesConAnemia.Location = new System.Drawing.Point(3, 73);
            this.btnGestantesConAnemia.Name = "btnGestantesConAnemia";
            this.btnGestantesConAnemia.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesConAnemia.TabIndex = 120;
            this.btnGestantesConAnemia.Text = "Gestantes con Anemia";
            this.btnGestantesConAnemia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesConAnemia.UseVisualStyleBackColor = false;
            this.btnGestantesConAnemia.Click += new System.EventHandler(this.btnGestantesConAnemia_Click);
            // 
            // btnGestantesConSifilis
            // 
            this.btnGestantesConSifilis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesConSifilis.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesConSifilis.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesConSifilis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesConSifilis.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesConSifilis.Location = new System.Drawing.Point(130, 73);
            this.btnGestantesConSifilis.Name = "btnGestantesConSifilis";
            this.btnGestantesConSifilis.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesConSifilis.TabIndex = 122;
            this.btnGestantesConSifilis.Text = "Gestantes con Sifilis";
            this.btnGestantesConSifilis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesConSifilis.UseVisualStyleBackColor = false;
            this.btnGestantesConSifilis.Click += new System.EventHandler(this.btnGestantesConSifilis_Click);
            // 
            // btnGestantesConVIH
            // 
            this.btnGestantesConVIH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesConVIH.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesConVIH.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesConVIH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesConVIH.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesConVIH.Location = new System.Drawing.Point(257, 73);
            this.btnGestantesConVIH.Name = "btnGestantesConVIH";
            this.btnGestantesConVIH.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesConVIH.TabIndex = 123;
            this.btnGestantesConVIH.Text = "Gestantes con VIH";
            this.btnGestantesConVIH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesConVIH.UseVisualStyleBackColor = false;
            this.btnGestantesConVIH.Click += new System.EventHandler(this.btnGestantesConVIH_Click);
            // 
            // btnGestantesConInfeccionUrinaria
            // 
            this.btnGestantesConInfeccionUrinaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesConInfeccionUrinaria.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesConInfeccionUrinaria.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesConInfeccionUrinaria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesConInfeccionUrinaria.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesConInfeccionUrinaria.Location = new System.Drawing.Point(384, 73);
            this.btnGestantesConInfeccionUrinaria.Name = "btnGestantesConInfeccionUrinaria";
            this.btnGestantesConInfeccionUrinaria.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesConInfeccionUrinaria.TabIndex = 124;
            this.btnGestantesConInfeccionUrinaria.Text = "Gestantes con Infección Urinaria";
            this.btnGestantesConInfeccionUrinaria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesConInfeccionUrinaria.UseVisualStyleBackColor = false;
            this.btnGestantesConInfeccionUrinaria.Click += new System.EventHandler(this.btnGestantesConInfeccionUrinaria_Click);
            // 
            // btnGestantesSinTratamiento
            // 
            this.btnGestantesSinTratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesSinTratamiento.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesSinTratamiento.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesSinTratamiento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesSinTratamiento.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesSinTratamiento.Location = new System.Drawing.Point(3, 143);
            this.btnGestantesSinTratamiento.Name = "btnGestantesSinTratamiento";
            this.btnGestantesSinTratamiento.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesSinTratamiento.TabIndex = 128;
            this.btnGestantesSinTratamiento.Text = "Gestantes sin Tratamiento";
            this.btnGestantesSinTratamiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesSinTratamiento.UseVisualStyleBackColor = false;
            this.btnGestantesSinTratamiento.Click += new System.EventHandler(this.btnGestantesSinTratamiento_Click);
            // 
            // btnGestantesSinBateria
            // 
            this.btnGestantesSinBateria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesSinBateria.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesSinBateria.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesSinBateria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesSinBateria.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesSinBateria.Location = new System.Drawing.Point(384, 3);
            this.btnGestantesSinBateria.Name = "btnGestantesSinBateria";
            this.btnGestantesSinBateria.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesSinBateria.TabIndex = 127;
            this.btnGestantesSinBateria.Text = "Gestantes sin Bateria";
            this.btnGestantesSinBateria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesSinBateria.UseVisualStyleBackColor = false;
            this.btnGestantesSinBateria.Click += new System.EventHandler(this.btnGestantesSinBateria_Click);
            // 
            // btnGestantesSinExamenOrina
            // 
            this.btnGestantesSinExamenOrina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesSinExamenOrina.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesSinExamenOrina.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesSinExamenOrina.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesSinExamenOrina.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesSinExamenOrina.Location = new System.Drawing.Point(130, 143);
            this.btnGestantesSinExamenOrina.Name = "btnGestantesSinExamenOrina";
            this.btnGestantesSinExamenOrina.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesSinExamenOrina.TabIndex = 129;
            this.btnGestantesSinExamenOrina.Text = "Gestantes sin Examen Orina";
            this.btnGestantesSinExamenOrina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesSinExamenOrina.UseVisualStyleBackColor = false;
            this.btnGestantesSinExamenOrina.Click += new System.EventHandler(this.btnGestantesSinExamenOrina_Click);
            // 
            // btnGestantesSinControlPuerperio
            // 
            this.btnGestantesSinControlPuerperio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesSinControlPuerperio.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesSinControlPuerperio.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesSinControlPuerperio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesSinControlPuerperio.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesSinControlPuerperio.Location = new System.Drawing.Point(257, 143);
            this.btnGestantesSinControlPuerperio.Name = "btnGestantesSinControlPuerperio";
            this.btnGestantesSinControlPuerperio.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesSinControlPuerperio.TabIndex = 126;
            this.btnGestantesSinControlPuerperio.Text = "Puerpera sin 1er Control Puerperio";
            this.btnGestantesSinControlPuerperio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesSinControlPuerperio.UseVisualStyleBackColor = false;
            this.btnGestantesSinControlPuerperio.Click += new System.EventHandler(this.btnGestantesSinControlPuerperio_Click);
            // 
            // btnGestantesSinCita
            // 
            this.btnGestantesSinCita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestantesSinCita.BackColor = System.Drawing.Color.MintCream;
            this.btnGestantesSinCita.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestantesSinCita.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestantesSinCita.ImageKey = "NetByte Design Studio - 0849.png";
            this.btnGestantesSinCita.Location = new System.Drawing.Point(257, 3);
            this.btnGestantesSinCita.Name = "btnGestantesSinCita";
            this.btnGestantesSinCita.Size = new System.Drawing.Size(121, 64);
            this.btnGestantesSinCita.TabIndex = 125;
            this.btnGestantesSinCita.Text = "Gestantes que no Acuden a sus Citas";
            this.btnGestantesSinCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGestantesSinCita.UseVisualStyleBackColor = false;
            this.btnGestantesSinCita.Click += new System.EventHandler(this.btnGestantesSinCita_Click);
            // 
            // frmReporteMicroRED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monitoreo.Properties.Resources.FondoFormularios2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 526);
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
        private System.Windows.Forms.Button btnTranseuntes;
        private System.Windows.Forms.Button btnGestantesMorbilidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRNBajoPeso;
        private System.Windows.Forms.Button btnGestantesPresionAlta;
        private System.Windows.Forms.Button btnGestantesConAnemia;
        private System.Windows.Forms.Button btnGestantesConSifilis;
        private System.Windows.Forms.Button btnGestantesConVIH;
        private System.Windows.Forms.Button btnGestantesConInfeccionUrinaria;
        private System.Windows.Forms.Button btnGestantesSinExamenOrina;
        private System.Windows.Forms.Button btnGestantesSinTratamiento;
        private System.Windows.Forms.Button btnGestantesSinBateria;
        private System.Windows.Forms.Button btnGestantesSinCita;
        private System.Windows.Forms.Button btnGestantesSinControlPuerperio;
        private System.Windows.Forms.Button btnGestantesSin2ControlPuerperio;
    }
}