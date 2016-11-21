namespace CapaUsuario
{
    partial class fBuscarCicloGestante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvHC = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Controls.Add(this.dgvHC);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1174, 657);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Explorar Control de Gestantes:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 628F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 863F));
            this.tableLayoutPanel4.Controls.Add(this.gbFiltrar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.gbBuscar, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1149, 60);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.cbMonth);
            this.gbFiltrar.Controls.Add(this.label17);
            this.gbFiltrar.Controls.Add(this.label24);
            this.gbFiltrar.Controls.Add(this.cbYear);
            this.gbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbFiltrar.Location = new System.Drawing.Point(631, 3);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(347, 54);
            this.gbFiltrar.TabIndex = 32;
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
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
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
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.comboBox2);
            this.gbBuscar.Controls.Add(this.label28);
            this.gbBuscar.Controls.Add(this.lblBuscar);
            this.gbBuscar.Controls.Add(this.label15);
            this.gbBuscar.Controls.Add(this.label11);
            this.gbBuscar.Controls.Add(this.comboBox1);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.cbBuscar);
            this.gbBuscar.Controls.Add(this.label12);
            this.gbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbBuscar.Location = new System.Drawing.Point(3, 3);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(622, 54);
            this.gbBuscar.TabIndex = 31;
            this.gbBuscar.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(785, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 26);
            this.comboBox2.TabIndex = 28;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label28.Location = new System.Drawing.Point(830, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 18);
            this.label28.TabIndex = 0;
            this.label28.Text = "Año:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBuscar.Location = new System.Drawing.Point(6, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(85, 18);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label15.Location = new System.Drawing.Point(829, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(439, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "los registros del obstetra.";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(810, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 26);
            this.comboBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(439, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "La busqueda es en todos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(261, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(168, 24);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.cbBuscar.Location = new System.Drawing.Point(95, 17);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(144, 26);
            this.cbBuscar.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.Location = new System.Drawing.Point(243, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = ":";
            // 
            // dgvHC
            // 
            this.dgvHC.AllowUserToAddRows = false;
            this.dgvHC.AllowUserToDeleteRows = false;
            this.dgvHC.AllowUserToOrderColumns = true;
            this.dgvHC.AllowUserToResizeColumns = false;
            this.dgvHC.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvHC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHC.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvHC.Location = new System.Drawing.Point(15, 85);
            this.dgvHC.MultiSelect = false;
            this.dgvHC.Name = "dgvHC";
            this.dgvHC.ReadOnly = true;
            this.dgvHC.RowHeadersVisible = false;
            this.dgvHC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHC.Size = new System.Drawing.Size(1149, 564);
            this.dgvHC.TabIndex = 29;
            // 
            // fBuscarCicloGestante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 681);
            this.Controls.Add(this.groupBox3);
            this.Name = "fBuscarCicloGestante";
            this.Text = "Buscar en Control de Gestante(s)";
            this.Load += new System.EventHandler(this.fBuscarCicloGestante_Load);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvHC;
    }
}