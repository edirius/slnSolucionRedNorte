namespace CapaUsuario.CitaPreNatal
{
    partial class frmCitaPreNatal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitaPreNatal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCitasMedicas = new System.Windows.Forms.DataGridView();
            this.colidtcitaprenatal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idthistoriaclinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumerocita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechacita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coledadgestacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpresionarterials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterialD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaProximaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroCita = new System.Windows.Forms.TextBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpProximaCita = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFUA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarControl = new System.Windows.Forms.Button();
            this.numPresionArterialS = new System.Windows.Forms.NumericUpDown();
            this.numPresionArterialD = new System.Windows.Forms.NumericUpDown();
            this.numEdadGestacional = new System.Windows.Forms.NumericUpDown();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbAlerta = new System.Windows.Forms.PictureBox();
            this.txtAlerta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadGestacional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtgCitasMedicas);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de las Citas Medicas";
            // 
            // dtgCitasMedicas
            // 
            this.dtgCitasMedicas.AllowUserToAddRows = false;
            this.dtgCitasMedicas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dtgCitasMedicas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCitasMedicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCitasMedicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCitasMedicas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCitasMedicas.BackgroundColor = System.Drawing.Color.White;
            this.dtgCitasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCitasMedicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidtcitaprenatal,
            this.idthistoriaclinica,
            this.colnumerocita,
            this.colfechacita,
            this.coledadgestacional,
            this.colFUA,
            this.colPresionArterial,
            this.colpresionarterials,
            this.colPresionArterialD,
            this.colFechaProximaCita});
            this.dtgCitasMedicas.Location = new System.Drawing.Point(6, 19);
            this.dtgCitasMedicas.Name = "dtgCitasMedicas";
            this.dtgCitasMedicas.ReadOnly = true;
            this.dtgCitasMedicas.RowHeadersVisible = false;
            this.dtgCitasMedicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCitasMedicas.Size = new System.Drawing.Size(638, 200);
            this.dtgCitasMedicas.TabIndex = 0;
            this.dtgCitasMedicas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgCitasMedicas_CellFormatting);
            this.dtgCitasMedicas.SelectionChanged += new System.EventHandler(this.dtgCitasMedicas_SelectionChanged);
            this.dtgCitasMedicas.Click += new System.EventHandler(this.dtgCitasMedicas_Click);
            // 
            // colidtcitaprenatal
            // 
            this.colidtcitaprenatal.DataPropertyName = "idtcitaprenatal";
            this.colidtcitaprenatal.HeaderText = "CODIGO";
            this.colidtcitaprenatal.Name = "colidtcitaprenatal";
            this.colidtcitaprenatal.ReadOnly = true;
            this.colidtcitaprenatal.Visible = false;
            // 
            // idthistoriaclinica
            // 
            this.idthistoriaclinica.DataPropertyName = "idthistoriaclinica";
            this.idthistoriaclinica.HeaderText = "CODIGO HISTORIA CLINICA";
            this.idthistoriaclinica.Name = "idthistoriaclinica";
            this.idthistoriaclinica.ReadOnly = true;
            this.idthistoriaclinica.Visible = false;
            // 
            // colnumerocita
            // 
            this.colnumerocita.DataPropertyName = "NUMERO DE CITA";
            this.colnumerocita.HeaderText = "NUMERO DE CITA";
            this.colnumerocita.Name = "colnumerocita";
            this.colnumerocita.ReadOnly = true;
            // 
            // colfechacita
            // 
            this.colfechacita.DataPropertyName = "FECHA CITA";
            this.colfechacita.HeaderText = "FECHA CITA";
            this.colfechacita.Name = "colfechacita";
            this.colfechacita.ReadOnly = true;
            // 
            // coledadgestacional
            // 
            this.coledadgestacional.DataPropertyName = "EDAD GESTACIONAL";
            this.coledadgestacional.HeaderText = "EDAD GESTACIONAL";
            this.coledadgestacional.Name = "coledadgestacional";
            this.coledadgestacional.ReadOnly = true;
            // 
            // colFUA
            // 
            this.colFUA.DataPropertyName = "FUA";
            this.colFUA.HeaderText = "FUA";
            this.colFUA.Name = "colFUA";
            this.colFUA.ReadOnly = true;
            // 
            // colPresionArterial
            // 
            this.colPresionArterial.DataPropertyName = "PRESION ARTERIAL";
            this.colPresionArterial.HeaderText = "PRESION ARTERIAL";
            this.colPresionArterial.Name = "colPresionArterial";
            this.colPresionArterial.ReadOnly = true;
            // 
            // colpresionarterials
            // 
            this.colpresionarterials.DataPropertyName = "PRESION ARTERIAL S";
            this.colpresionarterials.HeaderText = "PRESION ARTERIAL S";
            this.colpresionarterials.Name = "colpresionarterials";
            this.colpresionarterials.ReadOnly = true;
            this.colpresionarterials.Visible = false;
            // 
            // colPresionArterialD
            // 
            this.colPresionArterialD.DataPropertyName = "PRESION ARTERIAL D";
            this.colPresionArterialD.HeaderText = "PRESION ARTERIAL D";
            this.colPresionArterialD.Name = "colPresionArterialD";
            this.colPresionArterialD.ReadOnly = true;
            this.colPresionArterialD.Visible = false;
            // 
            // colFechaProximaCita
            // 
            this.colFechaProximaCita.DataPropertyName = "FECHA PROXIMA CITA";
            this.colFechaProximaCita.HeaderText = "FECHA PROXIMA CITA";
            this.colFechaProximaCita.Name = "colFechaProximaCita";
            this.colFechaProximaCita.ReadOnly = true;
            // 
            // txtNumeroCita
            // 
            this.txtNumeroCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCita.Location = new System.Drawing.Point(118, 34);
            this.txtNumeroCita.Name = "txtNumeroCita";
            this.txtNumeroCita.ReadOnly = true;
            this.txtNumeroCita.Size = new System.Drawing.Size(42, 24);
            this.txtNumeroCita.TabIndex = 1;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(105, 66);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(100, 24);
            this.dtpFechaCita.TabIndex = 2;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad Gestacional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proxima Cita:";
            // 
            // dtpProximaCita
            // 
            this.dtpProximaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProximaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProximaCita.Location = new System.Drawing.Point(322, 65);
            this.dtpProximaCita.Name = "dtpProximaCita";
            this.dtpProximaCita.Size = new System.Drawing.Size(100, 24);
            this.dtpProximaCita.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "FUA:";
            // 
            // txtFUA
            // 
            this.txtFUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFUA.Location = new System.Drawing.Point(267, 98);
            this.txtFUA.MaxLength = 15;
            this.txtFUA.Name = "txtFUA";
            this.txtFUA.Size = new System.Drawing.Size(100, 24);
            this.txtFUA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero Cita:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Presion Arterial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "/";
            // 
            // btnAgregarControl
            // 
            this.btnAgregarControl.BackColor = System.Drawing.Color.MintCream;
            this.btnAgregarControl.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculento;
            this.btnAgregarControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarControl.ForeColor = System.Drawing.Color.White;
            this.btnAgregarControl.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarControl.Name = "btnAgregarControl";
            this.btnAgregarControl.Size = new System.Drawing.Size(173, 59);
            this.btnAgregarControl.TabIndex = 15;
            this.btnAgregarControl.Text = "Nuevo";
            this.btnAgregarControl.UseVisualStyleBackColor = false;
            this.btnAgregarControl.Click += new System.EventHandler(this.btnAgregarControl_Click);
            // 
            // numPresionArterialS
            // 
            this.numPresionArterialS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPresionArterialS.Location = new System.Drawing.Point(332, 35);
            this.numPresionArterialS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPresionArterialS.Name = "numPresionArterialS";
            this.numPresionArterialS.Size = new System.Drawing.Size(49, 24);
            this.numPresionArterialS.TabIndex = 16;
            this.numPresionArterialS.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numPresionArterialS.ValueChanged += new System.EventHandler(this.numPresionArterialS_ValueChanged);
            // 
            // numPresionArterialD
            // 
            this.numPresionArterialD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPresionArterialD.Location = new System.Drawing.Point(410, 35);
            this.numPresionArterialD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPresionArterialD.Name = "numPresionArterialD";
            this.numPresionArterialD.Size = new System.Drawing.Size(42, 24);
            this.numPresionArterialD.TabIndex = 17;
            this.numPresionArterialD.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numPresionArterialD.ValueChanged += new System.EventHandler(this.numPresionArterialD_ValueChanged);
            // 
            // numEdadGestacional
            // 
            this.numEdadGestacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdadGestacional.Location = new System.Drawing.Point(151, 100);
            this.numEdadGestacional.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numEdadGestacional.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEdadGestacional.Name = "numEdadGestacional";
            this.numEdadGestacional.Size = new System.Drawing.Size(41, 24);
            this.numEdadGestacional.TabIndex = 18;
            this.numEdadGestacional.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.MintCream;
            this.btnImprimir.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculento;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(3, 198);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(173, 59);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardar.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculento;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(3, 68);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 59);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MintCream;
            this.btnEliminar.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculento;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(3, 133);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 59);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculento;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(3, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 59);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbAlerta
            // 
            this.pbAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlerta.BackColor = System.Drawing.Color.Transparent;
            this.pbAlerta.Image = ((System.Drawing.Image)(resources.GetObject("pbAlerta.Image")));
            this.pbAlerta.Location = new System.Drawing.Point(6, 37);
            this.pbAlerta.Name = "pbAlerta";
            this.pbAlerta.Size = new System.Drawing.Size(164, 97);
            this.pbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlerta.TabIndex = 100;
            this.pbAlerta.TabStop = false;
            this.pbAlerta.Visible = false;
            // 
            // txtAlerta
            // 
            this.txtAlerta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAlerta.Location = new System.Drawing.Point(39, 145);
            this.txtAlerta.Name = "txtAlerta";
            this.txtAlerta.Size = new System.Drawing.Size(100, 13);
            this.txtAlerta.TabIndex = 101;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numPresionArterialS);
            this.groupBox2.Controls.Add(this.txtNumeroCita);
            this.groupBox2.Controls.Add(this.dtpFechaCita);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpProximaCita);
            this.groupBox2.Controls.Add(this.numPresionArterialD);
            this.groupBox2.Controls.Add(this.numEdadGestacional);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFUA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 188);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnAgregarControl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGuardar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSalir, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnImprimir, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(668, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(179, 325);
            this.tableLayoutPanel3.TabIndex = 105;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.pbAlerta);
            this.groupBox3.Controls.Add(this.txtAlerta);
            this.groupBox3.Location = new System.Drawing.Point(486, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 188);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            // 
            // frmCitaPreNatal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaUsuario.Properties.Resources.FondoFormularios2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCitaPreNatal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "------ Cita Pre Natal -----";
            this.Load += new System.EventHandler(this.frmCitaPreNatal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadGestacional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCitasMedicas;
        private System.Windows.Forms.TextBox txtNumeroCita;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpProximaCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFUA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarControl;
        private System.Windows.Forms.NumericUpDown numPresionArterialS;
        private System.Windows.Forms.NumericUpDown numPresionArterialD;
        private System.Windows.Forms.NumericUpDown numEdadGestacional;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbAlerta;
        private System.Windows.Forms.TextBox txtAlerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidtcitaprenatal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idthistoriaclinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumerocita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechacita;
        private System.Windows.Forms.DataGridViewTextBoxColumn coledadgestacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpresionarterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterialD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaProximaCita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}