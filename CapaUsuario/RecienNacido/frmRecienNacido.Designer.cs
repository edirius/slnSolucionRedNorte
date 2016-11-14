namespace CapaUsuario.RecienNacido
{
    partial class frmRecienNacido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecienNacido));
            this.dgvRecienNacido = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APGAR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APGAR5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudApgar5 = new System.Windows.Forms.NumericUpDown();
            this.nudApgar1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoHistoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoRN = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMensajePeso = new System.Windows.Forms.TextBox();
            this.txtMensajeApgar5 = new System.Windows.Forms.TextBox();
            this.txtMensajeApgar1 = new System.Windows.Forms.TextBox();
            this.pbAlerta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecienNacido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecienNacido
            // 
            this.dgvRecienNacido.AllowUserToAddRows = false;
            this.dgvRecienNacido.AllowUserToResizeColumns = false;
            this.dgvRecienNacido.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRecienNacido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecienNacido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecienNacido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecienNacido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecienNacido.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecienNacido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecienNacido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.APGAR1,
            this.APGAR5,
            this.PESO,
            this.Column6});
            this.dgvRecienNacido.GridColor = System.Drawing.Color.White;
            this.dgvRecienNacido.Location = new System.Drawing.Point(59, 254);
            this.dgvRecienNacido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecienNacido.Name = "dgvRecienNacido";
            this.dgvRecienNacido.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecienNacido.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecienNacido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecienNacido.Size = new System.Drawing.Size(744, 145);
            this.dgvRecienNacido.TabIndex = 105;
            this.dgvRecienNacido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecienNacido_CellClick);
            this.dgvRecienNacido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecienNacido_CellContentClick);
            this.dgvRecienNacido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecienNacido_CellFormatting);
            this.dgvRecienNacido.SelectionChanged += new System.EventHandler(this.dgvRecienNacido_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID RECIEN NACIDO";
            this.Column1.HeaderText = "ID RECIEN NACIDO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HISTORIA CLINICA";
            this.Column2.HeaderText = "HISTORIA CLINICA";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FECHA DERIVADO";
            this.Column3.HeaderText = "FECHA DERIVADO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // APGAR1
            // 
            this.APGAR1.DataPropertyName = "APGAR1";
            this.APGAR1.HeaderText = "APGAR1";
            this.APGAR1.Name = "APGAR1";
            this.APGAR1.ReadOnly = true;
            // 
            // APGAR5
            // 
            this.APGAR5.DataPropertyName = "APGAR5";
            this.APGAR5.HeaderText = "APGAR5";
            this.APGAR5.Name = "APGAR5";
            this.APGAR5.ReadOnly = true;
            // 
            // PESO
            // 
            this.PESO.DataPropertyName = "PESO";
            this.PESO.HeaderText = "PESO";
            this.PESO.Name = "PESO";
            this.PESO.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SEXO";
            this.Column6.HeaderText = "SEXO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoHistoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigoRN);
            this.groupBox1.Location = new System.Drawing.Point(40, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(785, 233);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSexo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nudPeso);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudApgar5);
            this.groupBox4.Controls.Add(this.nudApgar1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(315, 60);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(462, 148);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AGPAR:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(301, 26);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(39, 26);
            this.cbSexo.TabIndex = 105;
            this.cbSexo.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 104;
            this.label5.Text = "Sexo:";
            // 
            // nudPeso
            // 
            this.nudPeso.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPeso.Location = new System.Drawing.Point(154, 100);
            this.nudPeso.Margin = new System.Windows.Forms.Padding(4);
            this.nudPeso.Maximum = new decimal(new int[] {
            4200,
            0,
            0,
            0});
            this.nudPeso.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(69, 24);
            this.nudPeso.TabIndex = 103;
            this.nudPeso.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPeso.ValueChanged += new System.EventHandler(this.nudPeso_ValueChanged);
            this.nudPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPeso_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Peso(gr):";
            // 
            // nudApgar5
            // 
            this.nudApgar5.Location = new System.Drawing.Point(154, 64);
            this.nudApgar5.Margin = new System.Windows.Forms.Padding(4);
            this.nudApgar5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudApgar5.Name = "nudApgar5";
            this.nudApgar5.Size = new System.Drawing.Size(51, 24);
            this.nudApgar5.TabIndex = 101;
            this.nudApgar5.ValueChanged += new System.EventHandler(this.nudApgar5_ValueChanged);
            this.nudApgar5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudApgar5_KeyPress);
            // 
            // nudApgar1
            // 
            this.nudApgar1.Location = new System.Drawing.Point(154, 28);
            this.nudApgar1.Margin = new System.Windows.Forms.Padding(4);
            this.nudApgar1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudApgar1.Name = "nudApgar1";
            this.nudApgar1.Size = new System.Drawing.Size(51, 24);
            this.nudApgar1.TabIndex = 100;
            this.nudApgar1.ValueChanged += new System.EventHandler(this.nudApgar1_ValueChanged);
            this.nudApgar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudApgar1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "5er minuto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "1er minuto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(27, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(275, 80);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Derivado a enfermeria:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(96, 30);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(157, 24);
            this.dtpFecha.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 97;
            this.label8.Text = "Codigo Historia:";
            this.label8.Visible = false;
            // 
            // txtCodigoHistoria
            // 
            this.txtCodigoHistoria.Location = new System.Drawing.Point(440, 26);
            this.txtCodigoHistoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoHistoria.Name = "txtCodigoHistoria";
            this.txtCodigoHistoria.Size = new System.Drawing.Size(121, 24);
            this.txtCodigoHistoria.TabIndex = 96;
            this.txtCodigoHistoria.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 95;
            this.label7.Text = "Codigo RN:";
            this.label7.Visible = false;
            // 
            // txtCodigoRN
            // 
            this.txtCodigoRN.Location = new System.Drawing.Point(159, 26);
            this.txtCodigoRN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoRN.Name = "txtCodigoRN";
            this.txtCodigoRN.Size = new System.Drawing.Size(121, 24);
            this.txtCodigoRN.TabIndex = 94;
            this.txtCodigoRN.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 585);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 60);
            this.tableLayoutPanel1.TabIndex = 107;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(360, 6);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 50);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertar.BackgroundImage")));
            this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(4, 6);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(170, 50);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "GUARDAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(538, 6);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 50);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(182, 6);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(170, 50);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "LIMPIAR";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblAlerta);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.pbAlerta);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(52, 418);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(744, 165);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadro de precaución:";
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.Transparent;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.White;
            this.lblAlerta.Location = new System.Drawing.Point(529, 16);
            this.lblAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(88, 20);
            this.lblAlerta.TabIndex = 103;
            this.lblAlerta.Text = "¡ALERTA!";
            this.lblAlerta.Click += new System.EventHandler(this.lblAlerta_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtMensajePeso, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeApgar5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeApgar1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 115);
            this.tableLayoutPanel2.TabIndex = 102;
            // 
            // txtMensajePeso
            // 
            this.txtMensajePeso.BackColor = System.Drawing.Color.White;
            this.txtMensajePeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajePeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajePeso.ForeColor = System.Drawing.Color.Red;
            this.txtMensajePeso.Location = new System.Drawing.Point(4, 80);
            this.txtMensajePeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensajePeso.Multiline = true;
            this.txtMensajePeso.Name = "txtMensajePeso";
            this.txtMensajePeso.Size = new System.Drawing.Size(280, 31);
            this.txtMensajePeso.TabIndex = 2;
            this.txtMensajePeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMensajePeso.TextChanged += new System.EventHandler(this.txtMensajePeso_TextChanged_1);
            // 
            // txtMensajeApgar5
            // 
            this.txtMensajeApgar5.BackColor = System.Drawing.Color.White;
            this.txtMensajeApgar5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeApgar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeApgar5.ForeColor = System.Drawing.Color.Red;
            this.txtMensajeApgar5.Location = new System.Drawing.Point(4, 42);
            this.txtMensajeApgar5.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensajeApgar5.Multiline = true;
            this.txtMensajeApgar5.Name = "txtMensajeApgar5";
            this.txtMensajeApgar5.Size = new System.Drawing.Size(280, 30);
            this.txtMensajeApgar5.TabIndex = 1;
            this.txtMensajeApgar5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMensajeApgar5.TextChanged += new System.EventHandler(this.txtMensajeApgar5_TextChanged_1);
            // 
            // txtMensajeApgar1
            // 
            this.txtMensajeApgar1.BackColor = System.Drawing.Color.White;
            this.txtMensajeApgar1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensajeApgar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeApgar1.ForeColor = System.Drawing.Color.Red;
            this.txtMensajeApgar1.Location = new System.Drawing.Point(4, 4);
            this.txtMensajeApgar1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensajeApgar1.Multiline = true;
            this.txtMensajeApgar1.Name = "txtMensajeApgar1";
            this.txtMensajeApgar1.Size = new System.Drawing.Size(280, 30);
            this.txtMensajeApgar1.TabIndex = 0;
            this.txtMensajeApgar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMensajeApgar1.TextChanged += new System.EventHandler(this.txtMensajeApgar1_TextChanged);
            // 
            // pbAlerta
            // 
            this.pbAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlerta.BackColor = System.Drawing.Color.Transparent;
            this.pbAlerta.Image = ((System.Drawing.Image)(resources.GetObject("pbAlerta.Image")));
            this.pbAlerta.Location = new System.Drawing.Point(434, 40);
            this.pbAlerta.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlerta.Name = "pbAlerta";
            this.pbAlerta.Size = new System.Drawing.Size(265, 117);
            this.pbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlerta.TabIndex = 99;
            this.pbAlerta.TabStop = false;
            // 
            // frmRecienNacido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(849, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvRecienNacido);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecienNacido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atencion al Recien Nacido";
            this.Load += new System.EventHandler(this.frmRecienNacido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecienNacido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecienNacido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoHistoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoRN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudApgar5;
        private System.Windows.Forms.NumericUpDown nudApgar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn APGAR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn APGAR5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtMensajePeso;
        private System.Windows.Forms.TextBox txtMensajeApgar5;
        private System.Windows.Forms.TextBox txtMensajeApgar1;
        private System.Windows.Forms.PictureBox pbAlerta;
    }
}