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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecienNacido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecienNacido = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoHistoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoRN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudApgar1 = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudApgar5 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.pbAlerta = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMensajePeso = new System.Windows.Forms.TextBox();
            this.txtMensajeApgar5 = new System.Windows.Forms.TextBox();
            this.txtMensajeApgar1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APGAR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APGAR5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecienNacido)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar5)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecienNacido
            // 
            this.dgvRecienNacido.AllowUserToAddRows = false;
            this.dgvRecienNacido.AllowUserToResizeColumns = false;
            this.dgvRecienNacido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRecienNacido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecienNacido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecienNacido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecienNacido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecienNacido.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecienNacido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecienNacido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecienNacido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.APGAR1,
            this.APGAR5,
            this.PESO,
            this.Column6,
            this.Column4});
            this.dgvRecienNacido.GridColor = System.Drawing.Color.White;
            this.dgvRecienNacido.Location = new System.Drawing.Point(9, 19);
            this.dgvRecienNacido.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecienNacido.Name = "dgvRecienNacido";
            this.dgvRecienNacido.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecienNacido.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecienNacido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecienNacido.Size = new System.Drawing.Size(634, 121);
            this.dgvRecienNacido.TabIndex = 105;
            this.dgvRecienNacido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecienNacido_CellClick);
            this.dgvRecienNacido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecienNacido_CellContentClick);
            this.dgvRecienNacido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecienNacido_CellFormatting);
            this.dgvRecienNacido.SelectionChanged += new System.EventHandler(this.dgvRecienNacido_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoHistoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigoRN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudApgar1);
            this.groupBox1.Controls.Add(this.nudPeso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudApgar5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(347, 186);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APGAR:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(259, 26);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(39, 26);
            this.cbSexo.TabIndex = 105;
            this.cbSexo.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 97;
            this.label8.Text = "Codigo Historia:";
            this.label8.Visible = false;
            // 
            // txtCodigoHistoria
            // 
            this.txtCodigoHistoria.Location = new System.Drawing.Point(384, 0);
            this.txtCodigoHistoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoHistoria.Name = "txtCodigoHistoria";
            this.txtCodigoHistoria.Size = new System.Drawing.Size(121, 24);
            this.txtCodigoHistoria.TabIndex = 96;
            this.txtCodigoHistoria.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "1er minuto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 95;
            this.label7.Text = "Codigo RN:";
            this.label7.Visible = false;
            // 
            // txtCodigoRN
            // 
            this.txtCodigoRN.Location = new System.Drawing.Point(203, 148);
            this.txtCodigoRN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoRN.Name = "txtCodigoRN";
            this.txtCodigoRN.Size = new System.Drawing.Size(121, 24);
            this.txtCodigoRN.TabIndex = 94;
            this.txtCodigoRN.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "5er minuto:";
            // 
            // nudApgar1
            // 
            this.nudApgar1.Location = new System.Drawing.Point(112, 28);
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
            // nudPeso
            // 
            this.nudPeso.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPeso.Location = new System.Drawing.Point(112, 100);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(205, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 104;
            this.label5.Text = "Sexo:";
            // 
            // nudApgar5
            // 
            this.nudApgar5.Location = new System.Drawing.Point(112, 64);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Peso(gr):";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(346, 74);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Derivado a enfermeria:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(86, 26);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(157, 24);
            this.dtpFecha.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Fecha:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(4, 128);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 54);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "&Eliminar";
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
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(4, 4);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(158, 54);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "&Guardar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculentoRojo7;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(4, 191);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 56);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.groupBox2.Controls.Add(this.pbAlerta);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(13, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(648, 180);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadro de precauciones:";
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.Transparent;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.White;
            this.lblAlerta.Location = new System.Drawing.Point(427, 129);
            this.lblAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(144, 31);
            this.lblAlerta.TabIndex = 103;
            this.lblAlerta.Text = "¡ALERTA!";
            this.lblAlerta.Click += new System.EventHandler(this.lblAlerta_Click);
            // 
            // pbAlerta
            // 
            this.pbAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlerta.BackColor = System.Drawing.Color.Transparent;
            this.pbAlerta.Image = ((System.Drawing.Image)(resources.GetObject("pbAlerta.Image")));
            this.pbAlerta.Location = new System.Drawing.Point(349, 14);
            this.pbAlerta.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlerta.Name = "pbAlerta";
            this.pbAlerta.Size = new System.Drawing.Size(291, 111);
            this.pbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlerta.TabIndex = 99;
            this.pbAlerta.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtMensajePeso, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeApgar5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMensajeApgar1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 25);
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
            this.txtMensajePeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtMensajeApgar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtMensajeApgar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnInsertar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnNuevo, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(668, 288);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(166, 251);
            this.tableLayoutPanel3.TabIndex = 109;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(4, 66);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(158, 54);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(366, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 269);
            this.groupBox4.TabIndex = 110;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUsuario.Properties.Resources.RecienNacido;
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvRecienNacido);
            this.groupBox5.Location = new System.Drawing.Point(12, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(650, 151);
            this.groupBox5.TabIndex = 111;
            this.groupBox5.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idtreciennacido";
            this.Column1.HeaderText = "ID RECIEN NACIDO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idthistoriaclinica";
            this.Column2.HeaderText = "HISTORIA CLINICA";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "fechaderivado";
            this.Column3.HeaderText = "Fecha de Derivado";
            this.Column3.MinimumWidth = 80;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 105;
            // 
            // APGAR1
            // 
            this.APGAR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.APGAR1.DataPropertyName = "apgar1";
            this.APGAR1.HeaderText = "Apgar1";
            this.APGAR1.Name = "APGAR1";
            this.APGAR1.ReadOnly = true;
            this.APGAR1.Width = 70;
            // 
            // APGAR5
            // 
            this.APGAR5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.APGAR5.DataPropertyName = "apgar5";
            this.APGAR5.HeaderText = "Apgar5";
            this.APGAR5.Name = "APGAR5";
            this.APGAR5.ReadOnly = true;
            this.APGAR5.Width = 70;
            // 
            // PESO
            // 
            this.PESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PESO.DataPropertyName = "peso";
            this.PESO.HeaderText = "Peso";
            this.PESO.Name = "PESO";
            this.PESO.ReadOnly = true;
            this.PESO.Width = 70;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "sexo";
            this.Column6.HeaderText = "Sexo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Nombres";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Obstetra";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmRecienNacido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaUsuario.Properties.Resources.FondoFormularios2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 629);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(868, 668);
            this.Name = "frmRecienNacido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atencion al Recien Nacido";
            this.Load += new System.EventHandler(this.frmRecienNacido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecienNacido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApgar5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudApgar5;
        private System.Windows.Forms.NumericUpDown nudApgar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtMensajePeso;
        private System.Windows.Forms.TextBox txtMensajeApgar5;
        private System.Windows.Forms.PictureBox pbAlerta;
        private System.Windows.Forms.TextBox txtMensajeApgar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn APGAR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn APGAR5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}