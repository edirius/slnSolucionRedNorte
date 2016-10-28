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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVIH = new System.Windows.Forms.ComboBox();
            this.cbSifilis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListaBateria = new System.Windows.Forms.DataGridView();
            this.txtCodigoBateria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoHistoria = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudHemoglobina = new System.Windows.Forms.NumericUpDown();
            this.nudGlucosa = new System.Windows.Forms.NumericUpDown();
            this.pbAlerta = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHemoglobina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlucosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(61, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Examen de Hemoblobina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 126);
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
            this.cbVIH.Location = new System.Drawing.Point(100, 122);
            this.cbVIH.Name = "cbVIH";
            this.cbVIH.Size = new System.Drawing.Size(138, 21);
            this.cbVIH.TabIndex = 86;
            // 
            // cbSifilis
            // 
            this.cbSifilis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSifilis.FormattingEnabled = true;
            this.cbSifilis.Items.AddRange(new object[] {
            "REACTIVO",
            "NO REACTIVO"});
            this.cbSifilis.Location = new System.Drawing.Point(392, 59);
            this.cbSifilis.Name = "cbSifilis";
            this.cbSifilis.Size = new System.Drawing.Size(138, 21);
            this.cbSifilis.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Examen de Sifilis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Examen de Orina:";
            // 
            // txtOrina
            // 
            this.txtOrina.Location = new System.Drawing.Point(394, 91);
            this.txtOrina.Name = "txtOrina";
            this.txtOrina.Size = new System.Drawing.Size(136, 20);
            this.txtOrina.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Examen de Glucosa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.nudGlucosa);
            this.groupBox1.Controls.Add(this.nudHemoglobina);
            this.groupBox1.Controls.Add(this.pbAlerta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodigoHistoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigoBateria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOrina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbVIH);
            this.groupBox1.Controls.Add(this.cbSifilis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 168);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 377);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 46);
            this.tableLayoutPanel1.TabIndex = 98;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(555, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 40);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(279, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(141, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 40);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(3, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(132, 40);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(417, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 40);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvListaBateria
            // 
            this.dgvListaBateria.AllowUserToAddRows = false;
            this.dgvListaBateria.AllowUserToResizeColumns = false;
            this.dgvListaBateria.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvListaBateria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaBateria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaBateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaBateria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaBateria.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListaBateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvListaBateria.GridColor = System.Drawing.Color.White;
            this.dgvListaBateria.Location = new System.Drawing.Point(6, 171);
            this.dgvListaBateria.Name = "dgvListaBateria";
            this.dgvListaBateria.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaBateria.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaBateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaBateria.Size = new System.Drawing.Size(693, 199);
            this.dgvListaBateria.TabIndex = 97;
            this.dgvListaBateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaBateria_CellClick);
            // 
            // txtCodigoBateria
            // 
            this.txtCodigoBateria.Location = new System.Drawing.Point(100, 29);
            this.txtCodigoBateria.Name = "txtCodigoBateria";
            this.txtCodigoBateria.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoBateria.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Codigo Bateria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Codigo Historia:";
            // 
            // txtCodigoHistoria
            // 
            this.txtCodigoHistoria.Location = new System.Drawing.Point(287, 29);
            this.txtCodigoHistoria.Name = "txtCodigoHistoria";
            this.txtCodigoHistoria.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoHistoria.TabIndex = 96;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idtbateria";
            this.Column1.HeaderText = "Codigo Bateria";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idthistoriaclinica";
            this.Column2.HeaderText = "Codigo Historia";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fecha";
            this.Column3.HeaderText = "Fecha Examen";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "hemoglobina";
            this.Column4.HeaderText = "Examen Hemoglobina";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "vih";
            this.Column5.HeaderText = "Examen VIH";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sifilis";
            this.Column6.HeaderText = "Examen Sifilis";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "orina";
            this.Column7.HeaderText = "Examen de Orina";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "glucosa";
            this.Column8.HeaderText = "Examen de Glucosa";
            this.Column8.Name = "Column8";
            // 
            // nudHemoglobina
            // 
            this.nudHemoglobina.DecimalPlaces = 1;
            this.nudHemoglobina.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudHemoglobina.Location = new System.Drawing.Point(149, 92);
            this.nudHemoglobina.Name = "nudHemoglobina";
            this.nudHemoglobina.Size = new System.Drawing.Size(48, 20);
            this.nudHemoglobina.TabIndex = 100;
            // 
            // nudGlucosa
            // 
            this.nudGlucosa.DecimalPlaces = 1;
            this.nudGlucosa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudGlucosa.Location = new System.Drawing.Point(406, 123);
            this.nudGlucosa.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudGlucosa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudGlucosa.Name = "nudGlucosa";
            this.nudGlucosa.Size = new System.Drawing.Size(48, 20);
            this.nudGlucosa.TabIndex = 101;
            this.nudGlucosa.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pbAlerta
            // 
            this.pbAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAlerta.BackColor = System.Drawing.Color.Transparent;
            this.pbAlerta.Image = global::CapaUsuario.Properties.Resources._433cca0dd88ef63c7c362799956c5b33;
            this.pbAlerta.Location = new System.Drawing.Point(539, 9);
            this.pbAlerta.Name = "pbAlerta";
            this.pbAlerta.Size = new System.Drawing.Size(152, 152);
            this.pbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlerta.TabIndex = 99;
            this.pbAlerta.TabStop = false;
            // 
            // frmBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvListaBateria);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBateria";
            this.Text = "frmBateria";
            this.Load += new System.EventHandler(this.frmBateria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHemoglobina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlucosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).EndInit();
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
        private System.Windows.Forms.TextBox txtOrina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListaBateria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBateria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.PictureBox pbAlerta;
        private System.Windows.Forms.NumericUpDown nudHemoglobina;
        private System.Windows.Forms.NumericUpDown nudGlucosa;
    }
}