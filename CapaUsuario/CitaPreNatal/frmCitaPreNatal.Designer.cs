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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadGestacional)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCitasMedicas);
            this.groupBox1.Location = new System.Drawing.Point(25, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 187);
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
            this.dtgCitasMedicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCitasMedicas.Size = new System.Drawing.Size(619, 150);
            this.dtgCitasMedicas.TabIndex = 0;
            this.dtgCitasMedicas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgCitasMedicas_CellFormatting);
            // 
            // colidtcitaprenatal
            // 
            this.colidtcitaprenatal.DataPropertyName = "idtcitaprenatal";
            this.colidtcitaprenatal.HeaderText = "codigo";
            this.colidtcitaprenatal.Name = "colidtcitaprenatal";
            this.colidtcitaprenatal.ReadOnly = true;
            this.colidtcitaprenatal.Visible = false;
            // 
            // idthistoriaclinica
            // 
            this.idthistoriaclinica.DataPropertyName = "idthistoriaclinica";
            this.idthistoriaclinica.HeaderText = "Codigo Historia Clinia";
            this.idthistoriaclinica.Name = "idthistoriaclinica";
            this.idthistoriaclinica.ReadOnly = true;
            this.idthistoriaclinica.Visible = false;
            // 
            // colnumerocita
            // 
            this.colnumerocita.DataPropertyName = "numeroCita";
            this.colnumerocita.HeaderText = "Numero";
            this.colnumerocita.Name = "colnumerocita";
            this.colnumerocita.ReadOnly = true;
            this.colnumerocita.Width = 60;
            // 
            // colfechacita
            // 
            this.colfechacita.DataPropertyName = "fechacita";
            this.colfechacita.HeaderText = "Fecha Cita";
            this.colfechacita.Name = "colfechacita";
            this.colfechacita.ReadOnly = true;
            // 
            // coledadgestacional
            // 
            this.coledadgestacional.DataPropertyName = "edadgestacional";
            this.coledadgestacional.HeaderText = "Edad Gestacional";
            this.coledadgestacional.Name = "coledadgestacional";
            this.coledadgestacional.ReadOnly = true;
            // 
            // colFUA
            // 
            this.colFUA.DataPropertyName = "fua";
            this.colFUA.HeaderText = "FUA";
            this.colFUA.Name = "colFUA";
            this.colFUA.ReadOnly = true;
            // 
            // colPresionArterial
            // 
            this.colPresionArterial.DataPropertyName = "presionarterial";
            this.colPresionArterial.HeaderText = "Presion Arterial";
            this.colPresionArterial.Name = "colPresionArterial";
            this.colPresionArterial.ReadOnly = true;
            // 
            // colpresionarterials
            // 
            this.colpresionarterials.DataPropertyName = "presionarterials";
            this.colpresionarterials.HeaderText = "PresionArterialS";
            this.colpresionarterials.Name = "colpresionarterials";
            this.colpresionarterials.ReadOnly = true;
            this.colpresionarterials.Visible = false;
            // 
            // colPresionArterialD
            // 
            this.colPresionArterialD.DataPropertyName = "presionarteriald";
            this.colPresionArterialD.HeaderText = "Presion Arterial D";
            this.colPresionArterialD.Name = "colPresionArterialD";
            this.colPresionArterialD.ReadOnly = true;
            this.colPresionArterialD.Visible = false;
            // 
            // colFechaProximaCita
            // 
            this.colFechaProximaCita.DataPropertyName = "fechaProximaCita";
            this.colFechaProximaCita.HeaderText = "Fecha Proxima Cita";
            this.colFechaProximaCita.Name = "colFechaProximaCita";
            this.colFechaProximaCita.ReadOnly = true;
            // 
            // txtNumeroCita
            // 
            this.txtNumeroCita.Location = new System.Drawing.Point(145, 25);
            this.txtNumeroCita.Name = "txtNumeroCita";
            this.txtNumeroCita.Size = new System.Drawing.Size(42, 20);
            this.txtNumeroCita.TabIndex = 1;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(145, 58);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCita.TabIndex = 2;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad Gestacional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proxima Cita:";
            // 
            // dtpProximaCita
            // 
            this.dtpProximaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProximaCita.Location = new System.Drawing.Point(399, 90);
            this.dtpProximaCita.Name = "dtpProximaCita";
            this.dtpProximaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpProximaCita.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FUA:";
            // 
            // txtFUA
            // 
            this.txtFUA.Location = new System.Drawing.Point(399, 58);
            this.txtFUA.MaxLength = 15;
            this.txtFUA.Name = "txtFUA";
            this.txtFUA.Size = new System.Drawing.Size(100, 20);
            this.txtFUA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero Cita:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Presion Arterial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "/";
            // 
            // btnAgregarControl
            // 
            this.btnAgregarControl.BackColor = System.Drawing.Color.MintCream;
            this.btnAgregarControl.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarControl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarControl.Location = new System.Drawing.Point(37, 130);
            this.btnAgregarControl.Name = "btnAgregarControl";
            this.btnAgregarControl.Size = new System.Drawing.Size(75, 45);
            this.btnAgregarControl.TabIndex = 15;
            this.btnAgregarControl.Text = "Agregar";
            this.btnAgregarControl.UseVisualStyleBackColor = false;
            this.btnAgregarControl.Click += new System.EventHandler(this.btnAgregarControl_Click);
            // 
            // numPresionArterialS
            // 
            this.numPresionArterialS.Location = new System.Drawing.Point(398, 26);
            this.numPresionArterialS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPresionArterialS.Name = "numPresionArterialS";
            this.numPresionArterialS.Size = new System.Drawing.Size(40, 20);
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
            this.numPresionArterialD.Location = new System.Drawing.Point(457, 25);
            this.numPresionArterialD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPresionArterialD.Name = "numPresionArterialD";
            this.numPresionArterialD.Size = new System.Drawing.Size(42, 20);
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
            this.numEdadGestacional.Location = new System.Drawing.Point(145, 90);
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
            this.numEdadGestacional.Size = new System.Drawing.Size(41, 20);
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
            this.btnImprimir.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnImprimir.Location = new System.Drawing.Point(575, 130);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 45);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmCitaPreNatal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 410);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.numEdadGestacional);
            this.Controls.Add(this.numPresionArterialD);
            this.Controls.Add(this.numPresionArterialS);
            this.Controls.Add(this.btnAgregarControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFUA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpProximaCita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.txtNumeroCita);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCitaPreNatal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "------ Control Pre Natal -------";
            this.Load += new System.EventHandler(this.frmCitaPreNatal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadGestacional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown numPresionArterialS;
        private System.Windows.Forms.NumericUpDown numPresionArterialD;
        private System.Windows.Forms.NumericUpDown numEdadGestacional;
        private System.Windows.Forms.Button btnImprimir;
    }
}