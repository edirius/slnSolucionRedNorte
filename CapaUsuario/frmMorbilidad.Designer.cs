namespace CapaUsuario
{
    partial class frmMorbilidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txt_NombreCompleto = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.dtpFechaHistoriaClinica = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvMorbilidad_ = new System.Windows.Forms.DataGridView();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.dtpFechaMorbilidad = new System.Windows.Forms.DateTimePicker();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtBuscar_ = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dgvGM = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorbilidad_)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtHistoriaClinica);
            this.groupBox13.Location = new System.Drawing.Point(6, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(204, 45);
            this.groupBox13.TabIndex = 44;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Historia Clinica";
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Enabled = false;
            this.txtHistoriaClinica.Location = new System.Drawing.Point(51, 17);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.Size = new System.Drawing.Size(100, 20);
            this.txtHistoriaClinica.TabIndex = 1;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dtpFecha);
            this.groupBox12.Location = new System.Drawing.Point(216, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(143, 47);
            this.groupBox12.TabIndex = 43;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(23, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(97, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txt_NombreCompleto);
            this.groupBox14.Controls.Add(this.txt_Edad);
            this.groupBox14.Controls.Add(this.txt_DNI);
            this.groupBox14.Controls.Add(this.label8);
            this.groupBox14.Controls.Add(this.label1);
            this.groupBox14.Controls.Add(this.label5);
            this.groupBox14.Location = new System.Drawing.Point(6, 72);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(690, 56);
            this.groupBox14.TabIndex = 42;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Gestante";
            // 
            // txt_NombreCompleto
            // 
            this.txt_NombreCompleto.Enabled = false;
            this.txt_NombreCompleto.Location = new System.Drawing.Point(269, 19);
            this.txt_NombreCompleto.Name = "txt_NombreCompleto";
            this.txt_NombreCompleto.Size = new System.Drawing.Size(314, 20);
            this.txt_NombreCompleto.TabIndex = 1;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Enabled = false;
            this.txt_Edad.Location = new System.Drawing.Point(639, 19);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(34, 20);
            this.txt_Edad.TabIndex = 1;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Enabled = false;
            this.txt_DNI.Location = new System.Drawing.Point(51, 19);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(100, 20);
            this.txt_DNI.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Edad:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DNI:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox13);
            this.groupBox7.Controls.Add(this.groupBox16);
            this.groupBox7.Controls.Add(this.groupBox12);
            this.groupBox7.Controls.Add(this.groupBox14);
            this.groupBox7.Location = new System.Drawing.Point(7, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(699, 140);
            this.groupBox7.TabIndex = 45;
            this.groupBox7.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.dtpFechaHistoriaClinica);
            this.groupBox16.Location = new System.Drawing.Point(216, 19);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(143, 47);
            this.groupBox16.TabIndex = 43;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Fecha";
            // 
            // dtpFechaHistoriaClinica
            // 
            this.dtpFechaHistoriaClinica.Enabled = false;
            this.dtpFechaHistoriaClinica.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHistoriaClinica.Location = new System.Drawing.Point(23, 17);
            this.dtpFechaHistoriaClinica.Name = "dtpFechaHistoriaClinica";
            this.dtpFechaHistoriaClinica.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaHistoriaClinica.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 705F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(714, 149);
            this.tableLayoutPanel3.TabIndex = 46;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.dgvMorbilidad_);
            this.groupBox9.Controls.Add(this.groupBox17);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Location = new System.Drawing.Point(23, 167);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(714, 219);
            this.groupBox9.TabIndex = 47;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Morbilidad(es)";
            // 
            // dgvMorbilidad_
            // 
            this.dgvMorbilidad_.AllowUserToAddRows = false;
            this.dgvMorbilidad_.AllowUserToDeleteRows = false;
            this.dgvMorbilidad_.AllowUserToOrderColumns = true;
            this.dgvMorbilidad_.AllowUserToResizeColumns = false;
            this.dgvMorbilidad_.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvMorbilidad_.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMorbilidad_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMorbilidad_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMorbilidad_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMorbilidad_.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMorbilidad_.Location = new System.Drawing.Point(7, 65);
            this.dgvMorbilidad_.MultiSelect = false;
            this.dgvMorbilidad_.Name = "dgvMorbilidad_";
            this.dgvMorbilidad_.ReadOnly = true;
            this.dgvMorbilidad_.RowHeadersVisible = false;
            this.dgvMorbilidad_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMorbilidad_.Size = new System.Drawing.Size(702, 148);
            this.dgvMorbilidad_.TabIndex = 30;
            this.dgvMorbilidad_.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMorbilidad__CellContentClick_1);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.dtpFechaMorbilidad);
            this.groupBox17.Location = new System.Drawing.Point(403, 19);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(111, 40);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Fecha:";
            // 
            // dtpFechaMorbilidad
            // 
            this.dtpFechaMorbilidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMorbilidad.Location = new System.Drawing.Point(6, 15);
            this.dtpFechaMorbilidad.Name = "dtpFechaMorbilidad";
            this.dtpFechaMorbilidad.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaMorbilidad.TabIndex = 0;
            this.dtpFechaMorbilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaMorbilidad_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbFiltrar);
            this.groupBox11.Location = new System.Drawing.Point(223, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(174, 40);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filtrar por:";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "Todo",
            "Extrema",
            "Potencial"});
            this.cbFiltrar.Location = new System.Drawing.Point(6, 14);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(162, 21);
            this.cbFiltrar.TabIndex = 0;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtBuscar_);
            this.groupBox10.Location = new System.Drawing.Point(7, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(210, 40);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Buscar:";
            // 
            // txtBuscar_
            // 
            this.txtBuscar_.Location = new System.Drawing.Point(6, 14);
            this.txtBuscar_.Name = "txtBuscar_";
            this.txtBuscar_.Size = new System.Drawing.Size(198, 20);
            this.txtBuscar_.TabIndex = 1;
            this.txtBuscar_.TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar__KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnGuardar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNuevo, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEliminar, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 392);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(714, 54);
            this.tableLayoutPanel4.TabIndex = 48;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(145, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 48);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(287, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(136, 48);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox15.Controls.Add(this.dgvGM);
            this.groupBox15.Location = new System.Drawing.Point(23, 452);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(714, 230);
            this.groupBox15.TabIndex = 49;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Gestante con Morbilidad(es)";
            // 
            // dgvGM
            // 
            this.dgvGM.AllowUserToAddRows = false;
            this.dgvGM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvGM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGM.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvGM.Location = new System.Drawing.Point(6, 19);
            this.dgvGM.MultiSelect = false;
            this.dgvGM.Name = "dgvGM";
            this.dgvGM.ReadOnly = true;
            this.dgvGM.RowHeadersVisible = false;
            this.dgvGM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGM.Size = new System.Drawing.Size(703, 205);
            this.dgvGM.TabIndex = 20;
            this.dgvGM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGM_CellClick);
            this.dgvGM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGM_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(429, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 48);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMorbilidad
            // 
            this.ClientSize = new System.Drawing.Size(766, 694);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmMorbilidad";
            this.Text = "Morbilidad";
            this.Load += new System.EventHandler(this.frmMorbilidad_Load_1);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorbilidad_)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvPacienteMorbilidad;
        private System.Windows.Forms.TextBox txtMorbilidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buNuevo;
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMorbilidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaHC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtHistoriaClinica;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NombreCompleto;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtBuscar_;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DateTimePicker dtpFechaHistoriaClinica;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.DateTimePicker dtpFechaMorbilidad;
        private System.Windows.Forms.DataGridView dgvMorbilidad_;
        private System.Windows.Forms.DataGridView dgvGM;
        private System.Windows.Forms.Button btnEliminar;
    }
}