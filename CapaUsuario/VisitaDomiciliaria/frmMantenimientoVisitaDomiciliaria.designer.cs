﻿namespace CapaUsuario.VisitaDomiciliaria
{
    partial class frmMantenimientoVisitaDomiciliaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMotivoGestante = new System.Windows.Forms.ComboBox();
            this.dtpFechaGestante = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFuaGestante = new System.Windows.Forms.TextBox();
            this.txtDetalleGestante = new System.Windows.Forms.TextBox();
            this.dgvVisitaDomiciliariaGestante = new System.Windows.Forms.DataGridView();
            this.idtvisitadomiciliaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvVisitaDomiciliariaPuerperaRN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMotivoPuerpera = new System.Windows.Forms.ComboBox();
            this.dtpFechaPuerpera = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFuaPuerpera = new System.Windows.Forms.TextBox();
            this.txtDetallePuerpera = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.cboMotivoRN = new System.Windows.Forms.ComboBox();
            this.dtpFechaRN = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFuaRN = new System.Windows.Forms.TextBox();
            this.txtDetalleRN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitaDomiciliariaGestante)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitaDomiciliariaPuerperaRN)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 508);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.dgvVisitaDomiciliariaGestante);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VISITA GESTANTE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMotivoGestante, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaGestante, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFuaGestante, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDetalleGestante, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(256, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 140);
            this.tableLayoutPanel1.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 133;
            this.label10.Text = "Fecha :";
            // 
            // cboMotivoGestante
            // 
            this.cboMotivoGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cboMotivoGestante, 3);
            this.cboMotivoGestante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoGestante.FormattingEnabled = true;
            this.cboMotivoGestante.Items.AddRange(new object[] {
            "1. V.D. a gestantes atendidas, antes del segundo APN.",
            "2. V.D. a gestantes, puerperas y/o recien nacido que no acude a cita prevista.",
            "3. V.D. a gestantes, puerpera y/o recien nacido con signos de alarma que acude a " +
                "cita prevista.",
            "4. V.D. para aplicación de ficha de plan de parto.",
            "5. V.D. a puerpera y/o recien nacido de parto domiciliario.",
            "6. V.D. a gestantes con riesgo nutricional.",
            "7. Gestante con fecha probable de Parto Próximo.",
            "8. Puerpera y/o recien nacido Normal.",
            "9. Otros."});
            this.cboMotivoGestante.Location = new System.Drawing.Point(55, 29);
            this.cboMotivoGestante.Name = "cboMotivoGestante";
            this.cboMotivoGestante.Size = new System.Drawing.Size(383, 21);
            this.cboMotivoGestante.TabIndex = 129;
            // 
            // dtpFechaGestante
            // 
            this.dtpFechaGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaGestante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGestante.Location = new System.Drawing.Point(55, 3);
            this.dtpFechaGestante.Name = "dtpFechaGestante";
            this.dtpFechaGestante.Size = new System.Drawing.Size(133, 20);
            this.dtpFechaGestante.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 132;
            this.label11.Text = "Motivo :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 131;
            this.label12.Text = "Detalle :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 135;
            this.label13.Text = "FUA :";
            // 
            // txtFuaGestante
            // 
            this.txtFuaGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuaGestante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuaGestante.Location = new System.Drawing.Point(234, 3);
            this.txtFuaGestante.Name = "txtFuaGestante";
            this.txtFuaGestante.Size = new System.Drawing.Size(204, 20);
            this.txtFuaGestante.TabIndex = 134;
            // 
            // txtDetalleGestante
            // 
            this.txtDetalleGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalleGestante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDetalleGestante, 3);
            this.txtDetalleGestante.Location = new System.Drawing.Point(55, 56);
            this.txtDetalleGestante.Multiline = true;
            this.txtDetalleGestante.Name = "txtDetalleGestante";
            this.txtDetalleGestante.Size = new System.Drawing.Size(383, 81);
            this.txtDetalleGestante.TabIndex = 130;
            // 
            // dgvVisitaDomiciliariaGestante
            // 
            this.dgvVisitaDomiciliariaGestante.AllowUserToAddRows = false;
            this.dgvVisitaDomiciliariaGestante.AllowUserToDeleteRows = false;
            this.dgvVisitaDomiciliariaGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisitaDomiciliariaGestante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitaDomiciliariaGestante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtvisitadomiciliaria,
            this.fecha,
            this.motivo,
            this.fua,
            this.detalle});
            this.dgvVisitaDomiciliariaGestante.Location = new System.Drawing.Point(6, 152);
            this.dgvVisitaDomiciliariaGestante.Name = "dgvVisitaDomiciliariaGestante";
            this.dgvVisitaDomiciliariaGestante.ReadOnly = true;
            this.dgvVisitaDomiciliariaGestante.RowHeadersVisible = false;
            this.dgvVisitaDomiciliariaGestante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitaDomiciliariaGestante.Size = new System.Drawing.Size(882, 194);
            this.dgvVisitaDomiciliariaGestante.TabIndex = 112;
            this.dgvVisitaDomiciliariaGestante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitaDomiciliaria_CellClick);
            this.dgvVisitaDomiciliariaGestante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitaDomiciliaria_CellContentClick);
            this.dgvVisitaDomiciliariaGestante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitaDomiciliaria_CellDoubleClick);
            // 
            // idtvisitadomiciliaria
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idtvisitadomiciliaria.DefaultCellStyle = dataGridViewCellStyle4;
            this.idtvisitadomiciliaria.HeaderText = "idtvisitadomiciliaria";
            this.idtvisitadomiciliaria.Name = "idtvisitadomiciliaria";
            this.idtvisitadomiciliaria.ReadOnly = true;
            this.idtvisitadomiciliaria.Visible = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 75;
            // 
            // motivo
            // 
            this.motivo.HeaderText = "MOTIVO";
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            this.motivo.Width = 250;
            // 
            // fua
            // 
            this.fua.HeaderText = "FUA";
            this.fua.Name = "fua";
            this.fua.ReadOnly = true;
            this.fua.Width = 200;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "DETALLE";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvVisitaDomiciliariaPuerperaRN);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VISITA PUERPERA / RECIEN NACIDO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVisitaDomiciliariaPuerperaRN
            // 
            this.dgvVisitaDomiciliariaPuerperaRN.AllowUserToAddRows = false;
            this.dgvVisitaDomiciliariaPuerperaRN.AllowUserToDeleteRows = false;
            this.dgvVisitaDomiciliariaPuerperaRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisitaDomiciliariaPuerperaRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitaDomiciliariaPuerperaRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvVisitaDomiciliariaPuerperaRN.Location = new System.Drawing.Point(6, 152);
            this.dgvVisitaDomiciliariaPuerperaRN.Name = "dgvVisitaDomiciliariaPuerperaRN";
            this.dgvVisitaDomiciliariaPuerperaRN.ReadOnly = true;
            this.dgvVisitaDomiciliariaPuerperaRN.RowHeadersVisible = false;
            this.dgvVisitaDomiciliariaPuerperaRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitaDomiciliariaPuerperaRN.Size = new System.Drawing.Size(949, 324);
            this.dgvVisitaDomiciliariaPuerperaRN.TabIndex = 113;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "idtvisitadomiciliaria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "MOTIVO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "FUA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "DETALLE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(949, 140);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puerpera";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboMotivoPuerpera, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaPuerpera, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtFuaPuerpera, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDetallePuerpera, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(455, 109);
            this.tableLayoutPanel3.TabIndex = 114;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 133;
            this.label14.Text = "Fecha :";
            // 
            // cboMotivoPuerpera
            // 
            this.cboMotivoPuerpera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.cboMotivoPuerpera, 3);
            this.cboMotivoPuerpera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoPuerpera.FormattingEnabled = true;
            this.cboMotivoPuerpera.Items.AddRange(new object[] {
            "1. V.D. a gestantes atendidas, antes del segundo APN.",
            "2. V.D. a gestantes, puerperas y/o recien nacido que no acude a cita prevista.",
            "3. V.D. a gestantes, puerpera y/o recien nacido con signos de alarma que acude a " +
                "cita prevista.",
            "4. V.D. para aplicación de ficha de plan de parto.",
            "5. V.D. a puerpera y/o recien nacido de parto domiciliario.",
            "6. V.D. a gestantes con riesgo nutricional.",
            "7. Gestante con fecha probable de Parto Próximo.",
            "8. Puerpera y/o recien nacido Normal.",
            "9. Otros."});
            this.cboMotivoPuerpera.Location = new System.Drawing.Point(55, 29);
            this.cboMotivoPuerpera.Name = "cboMotivoPuerpera";
            this.cboMotivoPuerpera.Size = new System.Drawing.Size(397, 21);
            this.cboMotivoPuerpera.TabIndex = 129;
            // 
            // dtpFechaPuerpera
            // 
            this.dtpFechaPuerpera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPuerpera.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPuerpera.Location = new System.Drawing.Point(55, 3);
            this.dtpFechaPuerpera.Name = "dtpFechaPuerpera";
            this.dtpFechaPuerpera.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaPuerpera.TabIndex = 128;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 132;
            this.label15.Text = "Motivo :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 131;
            this.label16.Text = "Detalle :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(200, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 135;
            this.label17.Text = "FUA :";
            // 
            // txtFuaPuerpera
            // 
            this.txtFuaPuerpera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuaPuerpera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuaPuerpera.Location = new System.Drawing.Point(240, 3);
            this.txtFuaPuerpera.Name = "txtFuaPuerpera";
            this.txtFuaPuerpera.Size = new System.Drawing.Size(212, 20);
            this.txtFuaPuerpera.TabIndex = 134;
            // 
            // txtDetallePuerpera
            // 
            this.txtDetallePuerpera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetallePuerpera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel3.SetColumnSpan(this.txtDetallePuerpera, 3);
            this.txtDetallePuerpera.Location = new System.Drawing.Point(55, 56);
            this.txtDetallePuerpera.Multiline = true;
            this.txtDetallePuerpera.Name = "txtDetallePuerpera";
            this.txtDetallePuerpera.Size = new System.Drawing.Size(397, 50);
            this.txtDetallePuerpera.TabIndex = 130;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(477, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recien Nacido";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboMotivoRN, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.dtpFechaRN, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtFuaRN, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDetalleRN, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(455, 109);
            this.tableLayoutPanel4.TabIndex = 114;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 133;
            this.label18.Text = "Fecha :";
            // 
            // cboMotivoRN
            // 
            this.cboMotivoRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.cboMotivoRN, 3);
            this.cboMotivoRN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoRN.FormattingEnabled = true;
            this.cboMotivoRN.Items.AddRange(new object[] {
            "1. V.D. a gestantes atendidas, antes del segundo APN.",
            "2. V.D. a gestantes, puerperas y/o recien nacido que no acude a cita prevista.",
            "3. V.D. a gestantes, puerpera y/o recien nacido con signos de alarma que acude a " +
                "cita prevista.",
            "4. V.D. para aplicación de ficha de plan de parto.",
            "5. V.D. a puerpera y/o recien nacido de parto domiciliario.",
            "6. V.D. a gestantes con riesgo nutricional.",
            "7. Gestante con fecha probable de Parto Próximo.",
            "8. Puerpera y/o recien nacido Normal.",
            "9. Otros."});
            this.cboMotivoRN.Location = new System.Drawing.Point(55, 29);
            this.cboMotivoRN.Name = "cboMotivoRN";
            this.cboMotivoRN.Size = new System.Drawing.Size(397, 21);
            this.cboMotivoRN.TabIndex = 129;
            // 
            // dtpFechaRN
            // 
            this.dtpFechaRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaRN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRN.Location = new System.Drawing.Point(55, 3);
            this.dtpFechaRN.Name = "dtpFechaRN";
            this.dtpFechaRN.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaRN.TabIndex = 128;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 132;
            this.label19.Text = "Motivo :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 131;
            this.label20.Text = "Detalle :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(200, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 135;
            this.label21.Text = "FUA :";
            // 
            // txtFuaRN
            // 
            this.txtFuaRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuaRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuaRN.Location = new System.Drawing.Point(240, 3);
            this.txtFuaRN.Name = "txtFuaRN";
            this.txtFuaRN.Size = new System.Drawing.Size(212, 20);
            this.txtFuaRN.TabIndex = 134;
            // 
            // txtDetalleRN
            // 
            this.txtDetalleRN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalleRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel4.SetColumnSpan(this.txtDetalleRN, 3);
            this.txtDetalleRN.Location = new System.Drawing.Point(55, 56);
            this.txtDetalleRN.Multiline = true;
            this.txtDetalleRN.Name = "txtDetalleRN";
            this.txtDetalleRN.Size = new System.Drawing.Size(397, 50);
            this.txtDetalleRN.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "1. V.D. a gestantes atendidas, antes del segundo APN.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 526);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 136);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "9. Otros.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 115;
            this.label8.Text = "8. Puerpera y/o recien nacido Normal.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 13);
            this.label7.TabIndex = 114;
            this.label7.Text = "7. Gestante con fecha probable de Parto Próximo.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "6. V.D. a gestantes con riesgo nutricional.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "5. V.D. a puerpera y/o recien nacido de parto domiciliario.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "4. V.D. para aplicación de ficha de plan de parto.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "3. V.D. a gestantes, puerpera y/o recien nacido con signos de alarma que acude a " +
    "cita prevista.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "2. V.D. a gestantes, puerperas y/o recien nacido que no acude a cita prevista.";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.ImageKey = "ssss.png";
            this.btnSalir.Location = new System.Drawing.Point(898, 609);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 53);
            this.btnSalir.TabIndex = 111;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.ImageIndex = 1;
            this.btnNuevo.Location = new System.Drawing.Point(809, 550);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 53);
            this.btnNuevo.TabIndex = 110;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.MintCream;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.ImageKey = "118.png";
            this.btnEliminar.Location = new System.Drawing.Point(898, 550);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 53);
            this.btnEliminar.TabIndex = 114;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.ImageKey = "13.png";
            this.btnGuardar.Location = new System.Drawing.Point(809, 609);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 53);
            this.btnGuardar.TabIndex = 113;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmMantenimientoVisitaDomiciliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 674);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMantenimientoVisitaDomiciliaria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Visitas Domiciliarias";
            this.Load += new System.EventHandler(this.frmVisitaDomiciliaria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitaDomiciliariaGestante)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitaDomiciliariaPuerperaRN)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVisitaDomiciliariaGestante;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMotivoGestante;
        private System.Windows.Forms.DateTimePicker dtpFechaGestante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFuaGestante;
        private System.Windows.Forms.TextBox txtDetalleGestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtvisitadomiciliaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fua;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridView dgvVisitaDomiciliariaPuerperaRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboMotivoPuerpera;
        private System.Windows.Forms.DateTimePicker dtpFechaPuerpera;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFuaPuerpera;
        private System.Windows.Forms.TextBox txtDetallePuerpera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboMotivoRN;
        private System.Windows.Forms.DateTimePicker dtpFechaRN;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtFuaRN;
        private System.Windows.Forms.TextBox txtDetalleRN;
    }
}