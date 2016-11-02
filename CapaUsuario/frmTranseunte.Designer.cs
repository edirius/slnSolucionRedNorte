namespace CapaUsuario
{
    partial class frmTranseunte
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numEdadGestacional = new System.Windows.Forms.NumericUpDown();
            this.numPresionArterialD = new System.Windows.Forms.NumericUpDown();
            this.numPresionArterialS = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarControl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFUA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProximaCita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroCita = new System.Windows.Forms.TextBox();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadGestacional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numEdadGestacional);
            this.groupBox2.Controls.Add(this.numPresionArterialD);
            this.groupBox2.Controls.Add(this.numPresionArterialS);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnAgregarControl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFUA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpProximaCita);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpFechaCita);
            this.groupBox2.Controls.Add(this.txtNumeroCita);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 417);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transeunte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "de salud:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "establecimiento";
            // 
            // numEdadGestacional
            // 
            this.numEdadGestacional.Location = new System.Drawing.Point(486, 41);
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
            this.numEdadGestacional.TabIndex = 51;
            this.numEdadGestacional.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPresionArterialD
            // 
            this.numPresionArterialD.Location = new System.Drawing.Point(546, 81);
            this.numPresionArterialD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPresionArterialD.Name = "numPresionArterialD";
            this.numPresionArterialD.Size = new System.Drawing.Size(42, 20);
            this.numPresionArterialD.TabIndex = 50;
            this.numPresionArterialD.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // numPresionArterialS
            // 
            this.numPresionArterialS.Location = new System.Drawing.Point(487, 81);
            this.numPresionArterialS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPresionArterialS.Name = "numPresionArterialS";
            this.numPresionArterialS.Size = new System.Drawing.Size(40, 20);
            this.numPresionArterialS.TabIndex = 49;
            this.numPresionArterialS.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 48;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarControl
            // 
            this.btnAgregarControl.Location = new System.Drawing.Point(223, 164);
            this.btnAgregarControl.Name = "btnAgregarControl";
            this.btnAgregarControl.Size = new System.Drawing.Size(88, 29);
            this.btnAgregarControl.TabIndex = 47;
            this.btnAgregarControl.Text = "Guardar";
            this.btnAgregarControl.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Presion Arterial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numero Cita:";
            // 
            // txtFUA
            // 
            this.txtFUA.Location = new System.Drawing.Point(139, 43);
            this.txtFUA.MaxLength = 15;
            this.txtFUA.Name = "txtFUA";
            this.txtFUA.Size = new System.Drawing.Size(185, 20);
            this.txtFUA.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Origen de ";
            // 
            // dtpProximaCita
            // 
            this.dtpProximaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProximaCita.Location = new System.Drawing.Point(488, 114);
            this.dtpProximaCita.Name = "dtpProximaCita";
            this.dtpProximaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpProximaCita.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Proxima Cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Edad Gestacional:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha Cita:";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(139, 114);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCita.TabIndex = 37;
            // 
            // txtNumeroCita
            // 
            this.txtNumeroCita.Location = new System.Drawing.Point(139, 76);
            this.txtNumeroCita.Name = "txtNumeroCita";
            this.txtNumeroCita.Size = new System.Drawing.Size(185, 20);
            this.txtNumeroCita.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCitasMedicas);
            this.groupBox1.Location = new System.Drawing.Point(14, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 177);
            this.groupBox1.TabIndex = 35;
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
            // frmTranseunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 439);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTranseunte";
            this.Text = "Transeunte";
            this.Load += new System.EventHandler(this.frmTranseunte_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadGestacional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresionArterialS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numEdadGestacional;
        private System.Windows.Forms.NumericUpDown numPresionArterialD;
        private System.Windows.Forms.NumericUpDown numPresionArterialS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFUA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpProximaCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TextBox txtNumeroCita;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCitasMedicas;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}