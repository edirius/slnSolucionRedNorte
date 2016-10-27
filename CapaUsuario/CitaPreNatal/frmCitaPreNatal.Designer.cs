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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCitasMedicas = new System.Windows.Forms.DataGridView();
            this.txtNumeroCita = new System.Windows.Forms.TextBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colidtcitaprenatal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idthistoriaclinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumerocita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechacita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coledadgestacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpresionarterials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterialD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgCitasMedicas);
            this.groupBox1.Location = new System.Drawing.Point(25, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de las Citas Medicas";
            // 
            // dtgCitasMedicas
            // 
            this.dtgCitasMedicas.AllowUserToAddRows = false;
            this.dtgCitasMedicas.AllowUserToDeleteRows = false;
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
            this.colPresionArterialD});
            this.dtgCitasMedicas.Location = new System.Drawing.Point(12, 19);
            this.dtgCitasMedicas.Name = "dtgCitasMedicas";
            this.dtgCitasMedicas.ReadOnly = true;
            this.dtgCitasMedicas.Size = new System.Drawing.Size(565, 150);
            this.dtgCitasMedicas.TabIndex = 0;
            // 
            // txtNumeroCita
            // 
            this.txtNumeroCita.Location = new System.Drawing.Point(145, 25);
            this.txtNumeroCita.Name = "txtNumeroCita";
            this.txtNumeroCita.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCita.TabIndex = 1;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(145, 58);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCita.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(399, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 7;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(399, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(461, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 20);
            this.textBox4.TabIndex = 13;
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
            // colidtcitaprenatal
            // 
            this.colidtcitaprenatal.HeaderText = "codigo";
            this.colidtcitaprenatal.Name = "colidtcitaprenatal";
            this.colidtcitaprenatal.ReadOnly = true;
            this.colidtcitaprenatal.Visible = false;
            // 
            // idthistoriaclinica
            // 
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
            this.colpresionarterials.HeaderText = "PresionArterialS";
            this.colpresionarterials.Name = "colpresionarterials";
            this.colpresionarterials.ReadOnly = true;
            this.colpresionarterials.Visible = false;
            // 
            // colPresionArterialD
            // 
            this.colPresionArterialD.HeaderText = "Presion Arterial D";
            this.colPresionArterialD.Name = "colPresionArterialD";
            this.colPresionArterialD.ReadOnly = true;
            this.colPresionArterialD.Visible = false;
            // 
            // frmCitaPreNatal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.txtNumeroCita);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCitaPreNatal";
            this.Text = "Control Pre Natal";
            this.Load += new System.EventHandler(this.frmCitaPreNatal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasMedicas)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidtcitaprenatal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idthistoriaclinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumerocita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechacita;
        private System.Windows.Forms.DataGridViewTextBoxColumn coledadgestacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpresionarterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterialD;
    }
}