namespace CapaUsuario.Reportes
{
    partial class fControlGestanteporPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buAgregar = new System.Windows.Forms.Button();
            this.buEliminar = new System.Windows.Forms.Button();
            this.buImprimir = new System.Windows.Forms.Button();
            this.buNuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvGestante = new System.Windows.Forms.DataGridView();
            this.dgvListaGestantesReporte = new System.Windows.Forms.DataGridView();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGestantesReporte)).BeginInit();
            this.gbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gbFiltrar);
            this.groupBox2.Controls.Add(this.dgvGestante);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 289);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestantes";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvListaGestantesReporte);
            this.groupBox3.Location = new System.Drawing.Point(12, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 314);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Gestantes para Reporte";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buAgregar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buEliminar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buImprimir, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buNuevo, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 307);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buAgregar
            // 
            this.buAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buAgregar.Location = new System.Drawing.Point(267, 3);
            this.buAgregar.Name = "buAgregar";
            this.buAgregar.Size = new System.Drawing.Size(126, 48);
            this.buAgregar.TabIndex = 0;
            this.buAgregar.Text = "Agregar";
            this.buAgregar.UseVisualStyleBackColor = true;
            // 
            // buEliminar
            // 
            this.buEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buEliminar.Location = new System.Drawing.Point(399, 3);
            this.buEliminar.Name = "buEliminar";
            this.buEliminar.Size = new System.Drawing.Size(126, 48);
            this.buEliminar.TabIndex = 1;
            this.buEliminar.Text = "Eliminar";
            this.buEliminar.UseVisualStyleBackColor = true;
            // 
            // buImprimir
            // 
            this.buImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buImprimir.Location = new System.Drawing.Point(663, 3);
            this.buImprimir.Name = "buImprimir";
            this.buImprimir.Size = new System.Drawing.Size(126, 48);
            this.buImprimir.TabIndex = 2;
            this.buImprimir.Text = "Imprimir";
            this.buImprimir.UseVisualStyleBackColor = true;
            // 
            // buNuevo
            // 
            this.buNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buNuevo.Location = new System.Drawing.Point(531, 3);
            this.buNuevo.Name = "buNuevo";
            this.buNuevo.Size = new System.Drawing.Size(126, 48);
            this.buNuevo.TabIndex = 3;
            this.buNuevo.Text = "Nuevo";
            this.buNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBuscar);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbBuscar);
            this.groupBox4.Location = new System.Drawing.Point(9, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 53);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBuscar.Location = new System.Drawing.Point(11, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(85, 18);
            this.lblBuscar.TabIndex = 27;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(444, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "los registros del obstetra.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(444, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "La busqueda es en todos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(266, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(168, 20);
            this.txtBuscar.TabIndex = 32;
            // 
            // cbBuscar
            // 
            this.cbBuscar.BackColor = System.Drawing.Color.White;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Historia Clinica",
            "Apellido Paterno",
            "Apellido Materno",
            "Nombres",
            "DNI"});
            this.cbBuscar.Location = new System.Drawing.Point(100, 14);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(144, 26);
            this.cbBuscar.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(248, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = ":";
            // 
            // dgvGestante
            // 
            this.dgvGestante.AllowUserToAddRows = false;
            this.dgvGestante.AllowUserToDeleteRows = false;
            this.dgvGestante.AllowUserToOrderColumns = true;
            this.dgvGestante.AllowUserToResizeColumns = false;
            this.dgvGestante.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvGestante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGestante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestante.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvGestante.Location = new System.Drawing.Point(6, 78);
            this.dgvGestante.MultiSelect = false;
            this.dgvGestante.Name = "dgvGestante";
            this.dgvGestante.ReadOnly = true;
            this.dgvGestante.RowHeadersVisible = false;
            this.dgvGestante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestante.Size = new System.Drawing.Size(1046, 205);
            this.dgvGestante.TabIndex = 30;
            this.dgvGestante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestante_CellContentClick);
            // 
            // dgvListaGestantesReporte
            // 
            this.dgvListaGestantesReporte.AllowUserToAddRows = false;
            this.dgvListaGestantesReporte.AllowUserToDeleteRows = false;
            this.dgvListaGestantesReporte.AllowUserToOrderColumns = true;
            this.dgvListaGestantesReporte.AllowUserToResizeColumns = false;
            this.dgvListaGestantesReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvListaGestantesReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaGestantesReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaGestantesReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaGestantesReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaGestantesReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvListaGestantesReporte.Location = new System.Drawing.Point(6, 19);
            this.dgvListaGestantesReporte.MultiSelect = false;
            this.dgvListaGestantesReporte.Name = "dgvListaGestantesReporte";
            this.dgvListaGestantesReporte.ReadOnly = true;
            this.dgvListaGestantesReporte.RowHeadersVisible = false;
            this.dgvListaGestantesReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaGestantesReporte.Size = new System.Drawing.Size(1046, 289);
            this.dgvListaGestantesReporte.TabIndex = 31;
            this.dgvListaGestantesReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaGestantesReporte_CellContentClick);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.cbMonth);
            this.gbFiltrar.Controls.Add(this.label17);
            this.gbFiltrar.Controls.Add(this.label24);
            this.gbFiltrar.Controls.Add(this.cbYear);
            this.gbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbFiltrar.Location = new System.Drawing.Point(646, 15);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(347, 54);
            this.gbFiltrar.TabIndex = 33;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar por:";
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.White;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMonth.Location = new System.Drawing.Point(193, 19);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(148, 26);
            this.cbMonth.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.Location = new System.Drawing.Point(17, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Año:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label24.Location = new System.Drawing.Point(146, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 18);
            this.label24.TabIndex = 0;
            this.label24.Text = "Mes:";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.White;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(61, 19);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(79, 26);
            this.cbYear.TabIndex = 27;
            // 
            // fControlGestanteporPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fControlGestanteporPaciente";
            this.Text = "Control Gestante por Paciente";
            this.Load += new System.EventHandler(this.fControlGestanteporPaciente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGestantesReporte)).EndInit();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buAgregar;
        private System.Windows.Forms.Button buEliminar;
        private System.Windows.Forms.Button buImprimir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buNuevo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.DataGridView dgvGestante;
        private System.Windows.Forms.DataGridView dgvListaGestantesReporte;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbYear;
    }
}