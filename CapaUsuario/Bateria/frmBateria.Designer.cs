namespace CapaUsuario.Bateria
{
    partial class frmBateria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBateria));
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVIH = new System.Windows.Forms.ComboBox();
            this.cbSifilis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaTratamiento = new System.Windows.Forms.TextBox();
            this.dtpFechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaExamenOrina = new System.Windows.Forms.TextBox();
            this.dtpFechaOrina = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.nudOrina = new System.Windows.Forms.NumericUpDown();
            this.nudGlucosa = new System.Windows.Forms.NumericUpDown();
            this.nudHemoglobina = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoHistoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoBateria = new System.Windows.Forms.TextBox();
            this.dgvListaBateria = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.pbNuevo = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMensajeVIH = new System.Windows.Forms.TextBox();
            this.txtMensajeHemo = new System.Windows.Forms.TextBox();
            this.txtMensajeSifilis = new System.Windows.Forms.TextBox();
            this.txtMensajeOrina = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.pbAlerta = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hemoglobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifilis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glucosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechatratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlucosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHemoglobina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBateria)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(177, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Examen de Hemoblobina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Examen de VIH:";
            // 
            // cbVIH
            // 
            this.cbVIH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVIH.FormattingEnabled = true;
            this.cbVIH.Items.AddRange(new object[] {
            "REACTIVO",
            "NO REACTIVO"});
            this.cbVIH.Location = new System.Drawing.Point(221, 104);
            this.cbVIH.Name = "cbVIH";
            this.cbVIH.Size = new System.Drawing.Size(138, 21);
            this.cbVIH.TabIndex = 4;
            this.cbVIH.SelectedIndexChanged += new System.EventHandler(this.cbVIH_SelectedIndexChanged);
            // 
            // cbSifilis
            // 
            this.cbSifilis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSifilis.FormattingEnabled = true;
            this.cbSifilis.Items.AddRange(new object[] {
            "REACTIVO",
            "NO REACTIVO"});
            this.cbSifilis.Location = new System.Drawing.Point(226, 134);
            this.cbSifilis.Name = "cbSifilis";
            this.cbSifilis.Size = new System.Drawing.Size(138, 21);
            this.cbSifilis.TabIndex = 4;
            this.cbSifilis.SelectedIndexChanged += new System.EventHandler(this.cbSifilis_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Examen de Sifilis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Examen de Orina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Examen de Glucosa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtFechaTratamiento);
            this.groupBox1.Controls.Add(this.dtpFechaTratamiento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFechaExamenOrina);
            this.groupBox1.Controls.Add(this.dtpFechaOrina);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nudOrina);
            this.groupBox1.Controls.Add(this.nudGlucosa);
            this.groupBox1.Controls.Add(this.nudHemoglobina);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoHistoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigoBateria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbVIH);
            this.groupBox1.Controls.Add(this.cbSifilis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(165, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 168);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // txtFechaTratamiento
            // 
            this.txtFechaTratamiento.Location = new System.Drawing.Point(511, 138);
            this.txtFechaTratamiento.Name = "txtFechaTratamiento";
            this.txtFechaTratamiento.Size = new System.Drawing.Size(72, 20);
            this.txtFechaTratamiento.TabIndex = 108;
            // 
            // dtpFechaTratamiento
            // 
            this.dtpFechaTratamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTratamiento.Location = new System.Drawing.Point(511, 138);
            this.dtpFechaTratamiento.Name = "dtpFechaTratamiento";
            this.dtpFechaTratamiento.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaTratamiento.TabIndex = 106;
            this.dtpFechaTratamiento.ValueChanged += new System.EventHandler(this.dtpFechaTratamiento_ValueChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 107;
            this.label10.Text = "Fecha de tratamiento:";
            // 
            // txtFechaExamenOrina
            // 
            this.txtFechaExamenOrina.Location = new System.Drawing.Point(545, 104);
            this.txtFechaExamenOrina.Name = "txtFechaExamenOrina";
            this.txtFechaExamenOrina.Size = new System.Drawing.Size(72, 20);
            this.txtFechaExamenOrina.TabIndex = 105;
            // 
            // dtpFechaOrina
            // 
            this.dtpFechaOrina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrina.Location = new System.Drawing.Point(545, 104);
            this.dtpFechaOrina.Name = "dtpFechaOrina";
            this.dtpFechaOrina.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaOrina.TabIndex = 7;
            this.dtpFechaOrina.ValueChanged += new System.EventHandler(this.dtpFechaOrina_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Fecha de Examen de Orina:";
            // 
            // nudOrina
            // 
            this.nudOrina.Location = new System.Drawing.Point(496, 74);
            this.nudOrina.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudOrina.Name = "nudOrina";
            this.nudOrina.Size = new System.Drawing.Size(43, 20);
            this.nudOrina.TabIndex = 6;
            this.nudOrina.ValueChanged += new System.EventHandler(this.nudOrina_ValueChanged);
            // 
            // nudGlucosa
            // 
            this.nudGlucosa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGlucosa.Location = new System.Drawing.Point(511, 46);
            this.nudGlucosa.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.nudGlucosa.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudGlucosa.Name = "nudGlucosa";
            this.nudGlucosa.Size = new System.Drawing.Size(48, 20);
            this.nudGlucosa.TabIndex = 5;
            this.nudGlucosa.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudGlucosa.ValueChanged += new System.EventHandler(this.nudGlucosa_ValueChanged);
            // 
            // nudHemoglobina
            // 
            this.nudHemoglobina.DecimalPlaces = 1;
            this.nudHemoglobina.Location = new System.Drawing.Point(265, 74);
            this.nudHemoglobina.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudHemoglobina.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudHemoglobina.Name = "nudHemoglobina";
            this.nudHemoglobina.Size = new System.Drawing.Size(48, 20);
            this.nudHemoglobina.TabIndex = 2;
            this.nudHemoglobina.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudHemoglobina.ValueChanged += new System.EventHandler(this.nudHemoglobina_ValueChanged);
            this.nudHemoglobina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudHemoglobina_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Codigo Historia:";
            this.label8.Visible = false;
            // 
            // txtCodigoHistoria
            // 
            this.txtCodigoHistoria.Location = new System.Drawing.Point(287, 4);
            this.txtCodigoHistoria.Name = "txtCodigoHistoria";
            this.txtCodigoHistoria.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoHistoria.TabIndex = 96;
            this.txtCodigoHistoria.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Codigo Bateria:";
            this.label7.Visible = false;
            // 
            // txtCodigoBateria
            // 
            this.txtCodigoBateria.Location = new System.Drawing.Point(100, 4);
            this.txtCodigoBateria.Name = "txtCodigoBateria";
            this.txtCodigoBateria.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoBateria.TabIndex = 94;
            this.txtCodigoBateria.Visible = false;
            // 
            // dgvListaBateria
            // 
            this.dgvListaBateria.AllowUserToAddRows = false;
            this.dgvListaBateria.AllowUserToResizeColumns = false;
            this.dgvListaBateria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListaBateria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaBateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaBateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaBateria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaBateria.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaBateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.hemoglobina,
            this.vih,
            this.sifilis,
            this.glucosa,
            this.orina,
            this.Column9,
            this.fechatratamiento});
            this.dgvListaBateria.GridColor = System.Drawing.Color.White;
            this.dgvListaBateria.Location = new System.Drawing.Point(165, 171);
            this.dgvListaBateria.Name = "dgvListaBateria";
            this.dgvListaBateria.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaBateria.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaBateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaBateria.Size = new System.Drawing.Size(693, 114);
            this.dgvListaBateria.TabIndex = 99;
            this.dgvListaBateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaBateria_CellClick_1);
            this.dgvListaBateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaBateria_CellContentClick);
            this.dgvListaBateria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaBateria_CellFormatting);
            this.dgvListaBateria.SelectionChanged += new System.EventHandler(this.dgvListaBateria_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.btnInsertar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(165, 462);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 105);
            this.tableLayoutPanel1.TabIndex = 101;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(3, 62);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(167, 40);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Guardar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(176, 62);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(167, 40);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(522, 62);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 40);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(349, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 40);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(12, 66);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(107, 99);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 107;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Visible = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(12, 425);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(107, 99);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 106;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Visible = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // pbNuevo
            // 
            this.pbNuevo.BackColor = System.Drawing.Color.Transparent;
            this.pbNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("pbNuevo.Image")));
            this.pbNuevo.Location = new System.Drawing.Point(12, 320);
            this.pbNuevo.Name = "pbNuevo";
            this.pbNuevo.Size = new System.Drawing.Size(107, 99);
            this.pbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNuevo.TabIndex = 105;
            this.pbNuevo.TabStop = false;
            this.pbNuevo.Visible = false;
            this.pbNuevo.Click += new System.EventHandler(this.pbNuevo_Click);
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Location = new System.Drawing.Point(12, 195);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(107, 99);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 104;
            this.pbSalir.TabStop = false;
            this.pbSalir.Visible = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeVIH, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeHemo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeSifilis, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeOrina, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(129, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 129);
            this.tableLayoutPanel2.TabIndex = 102;
            // 
            // txtMensajeVIH
            // 
            this.txtMensajeVIH.BackColor = System.Drawing.Color.White;
            this.txtMensajeVIH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeVIH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeVIH.ForeColor = System.Drawing.Color.Red;
            this.txtMensajeVIH.Location = new System.Drawing.Point(3, 35);
            this.txtMensajeVIH.Multiline = true;
            this.txtMensajeVIH.Name = "txtMensajeVIH";
            this.txtMensajeVIH.Size = new System.Drawing.Size(302, 20);
            this.txtMensajeVIH.TabIndex = 104;
            this.txtMensajeVIH.TextChanged += new System.EventHandler(this.txtMensajeVIH_TextChanged);
            // 
            // txtMensajeHemo
            // 
            this.txtMensajeHemo.BackColor = System.Drawing.Color.White;
            this.txtMensajeHemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeHemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeHemo.ForeColor = System.Drawing.Color.Red;
            this.txtMensajeHemo.Location = new System.Drawing.Point(3, 3);
            this.txtMensajeHemo.Multiline = true;
            this.txtMensajeHemo.Name = "txtMensajeHemo";
            this.txtMensajeHemo.Size = new System.Drawing.Size(302, 20);
            this.txtMensajeHemo.TabIndex = 0;
            this.txtMensajeHemo.TextChanged += new System.EventHandler(this.txtMensajeHemo_TextChanged);
            // 
            // txtMensajeSifilis
            // 
            this.txtMensajeSifilis.BackColor = System.Drawing.Color.White;
            this.txtMensajeSifilis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeSifilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeSifilis.ForeColor = System.Drawing.Color.Red;
            this.txtMensajeSifilis.Location = new System.Drawing.Point(3, 67);
            this.txtMensajeSifilis.Multiline = true;
            this.txtMensajeSifilis.Name = "txtMensajeSifilis";
            this.txtMensajeSifilis.Size = new System.Drawing.Size(302, 20);
            this.txtMensajeSifilis.TabIndex = 2;
            this.txtMensajeSifilis.TextChanged += new System.EventHandler(this.txtMensajeSifilis_TextChanged);
            // 
            // txtMensajeOrina
            // 
            this.txtMensajeOrina.BackColor = System.Drawing.Color.White;
            this.txtMensajeOrina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeOrina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeOrina.ForeColor = System.Drawing.Color.Red;
            this.txtMensajeOrina.Location = new System.Drawing.Point(3, 99);
            this.txtMensajeOrina.Multiline = true;
            this.txtMensajeOrina.Name = "txtMensajeOrina";
            this.txtMensajeOrina.Size = new System.Drawing.Size(302, 20);
            this.txtMensajeOrina.TabIndex = 3;
            this.txtMensajeOrina.TextChanged += new System.EventHandler(this.txtMensajeOrina_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblAlerta);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.pbAlerta);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(165, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 174);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadro de precaución:";
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.Transparent;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.White;
            this.lblAlerta.Location = new System.Drawing.Point(471, 15);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(88, 20);
            this.lblAlerta.TabIndex = 103;
            this.lblAlerta.Text = "¡ALERTA!";
            // 
            // pbAlerta
            // 
            this.pbAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlerta.BackColor = System.Drawing.Color.White;
            this.pbAlerta.Image = ((System.Drawing.Image)(resources.GetObject("pbAlerta.Image")));
            this.pbAlerta.Location = new System.Drawing.Point(455, 42);
            this.pbAlerta.Name = "pbAlerta";
            this.pbAlerta.Size = new System.Drawing.Size(120, 117);
            this.pbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlerta.TabIndex = 99;
            this.pbAlerta.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::CapaUsuario.Properties.Resources.gestantecusco;
            this.pictureBox4.Location = new System.Drawing.Point(874, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 494);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 108;
            this.pictureBox4.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID BATERIA";
            this.Column1.HeaderText = "Codigo Bateria";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID HISTORIA CLINICA";
            this.Column2.HeaderText = "Codigo Historia";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FECHA EXAMEN";
            this.Column3.HeaderText = "Fecha Examen";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // hemoglobina
            // 
            this.hemoglobina.DataPropertyName = "HEMOGLOBINA";
            this.hemoglobina.HeaderText = "Examen Hemoglobina";
            this.hemoglobina.Name = "hemoglobina";
            this.hemoglobina.ReadOnly = true;
            // 
            // vih
            // 
            this.vih.DataPropertyName = "VIH";
            this.vih.HeaderText = "Examen VIH";
            this.vih.Name = "vih";
            this.vih.ReadOnly = true;
            // 
            // sifilis
            // 
            this.sifilis.DataPropertyName = "SIFILIS";
            this.sifilis.HeaderText = "Examen Sifilis";
            this.sifilis.Name = "sifilis";
            this.sifilis.ReadOnly = true;
            // 
            // glucosa
            // 
            this.glucosa.DataPropertyName = "GLUCOSA";
            this.glucosa.HeaderText = "Examen de Glucosa";
            this.glucosa.Name = "glucosa";
            this.glucosa.ReadOnly = true;
            // 
            // orina
            // 
            this.orina.DataPropertyName = "ORINA";
            this.orina.HeaderText = "Examen de Orina";
            this.orina.Name = "orina";
            this.orina.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "FECHA EXAMEN ORINA";
            this.Column9.HeaderText = "Fecha Examen Orina";
            this.Column9.Name = "Column9";
            // 
            // fechatratamiento
            // 
            this.fechatratamiento.DataPropertyName = "FECHA TRATAMIENTO";
            this.fechatratamiento.HeaderText = "Fecha de Tratamiento";
            this.fechatratamiento.Name = "fechatratamiento";
            this.fechatratamiento.ReadOnly = true;
            // 
            // frmBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 579);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbGuardar);
            this.Controls.Add(this.pbNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvListaBateria);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Bateria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlucosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHemoglobina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBateria)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVIH;
        private System.Windows.Forms.ComboBox cbSifilis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBateria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoHistoria;
        private System.Windows.Forms.PictureBox pbAlerta;
        private System.Windows.Forms.NumericUpDown nudHemoglobina;
        private System.Windows.Forms.NumericUpDown nudGlucosa;
        private System.Windows.Forms.NumericUpDown nudOrina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListaBateria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtMensajeOrina;
        private System.Windows.Forms.TextBox txtMensajeSifilis;
        private System.Windows.Forms.TextBox txtMensajeHemo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMensajeVIH;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.DateTimePicker dtpFechaOrina;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFechaExamenOrina;
        private System.Windows.Forms.TextBox txtFechaTratamiento;
        private System.Windows.Forms.DateTimePicker dtpFechaTratamiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.PictureBox pbNuevo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hemoglobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn vih;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifilis;
        private System.Windows.Forms.DataGridViewTextBoxColumn glucosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn orina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechatratamiento;
    }
}