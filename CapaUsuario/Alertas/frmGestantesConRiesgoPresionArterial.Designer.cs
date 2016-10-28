﻿namespace CapaUsuario.Alertas
{
    partial class frmGestantesConRiesgoPresionArterial
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
            this.dtgListaGestantes = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaProximaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterialS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterialD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdthistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresionArterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaGestantes
            // 
            this.dtgListaGestantes.AllowUserToAddRows = false;
            this.dtgListaGestantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dtgListaGestantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListaGestantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaGestantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colFechaProximaCita,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colDNI,
            this.colPresionArterialS,
            this.colPresionArterialD,
            this.colFUA,
            this.colIdthistoriaClinica,
            this.colCodigoHistoriaClinica,
            this.colPresionArterial});
            this.dtgListaGestantes.Location = new System.Drawing.Point(12, 29);
            this.dtgListaGestantes.MultiSelect = false;
            this.dtgListaGestantes.Name = "dtgListaGestantes";
            this.dtgListaGestantes.ReadOnly = true;
            this.dtgListaGestantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaGestantes.Size = new System.Drawing.Size(872, 255);
            this.dtgListaGestantes.TabIndex = 0;
            this.dtgListaGestantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "numero";
            this.colNumero.HeaderText = "Numero Cita";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 50;
            // 
            // colFechaProximaCita
            // 
            this.colFechaProximaCita.DataPropertyName = "fechaproximacita";
            this.colFechaProximaCita.HeaderText = "Fecha Proxima Cita";
            this.colFechaProximaCita.Name = "colFechaProximaCita";
            this.colFechaProximaCita.ReadOnly = true;
            // 
            // colNombres
            // 
            this.colNombres.DataPropertyName = "nombres";
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.DataPropertyName = "apellidopaterno";
            this.colApellidoPaterno.HeaderText = "Apellido Paterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.ReadOnly = true;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.DataPropertyName = "apellidomaterno";
            this.colApellidoMaterno.HeaderText = "Apellido Materno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.DataPropertyName = "dni";
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 80;
            // 
            // colPresionArterialS
            // 
            this.colPresionArterialS.DataPropertyName = "presionarterials";
            this.colPresionArterialS.HeaderText = "PresionArterialS";
            this.colPresionArterialS.Name = "colPresionArterialS";
            this.colPresionArterialS.ReadOnly = true;
            this.colPresionArterialS.Visible = false;
            this.colPresionArterialS.Width = 50;
            // 
            // colPresionArterialD
            // 
            this.colPresionArterialD.DataPropertyName = "presionarteriald";
            this.colPresionArterialD.HeaderText = "Presion Arterial D";
            this.colPresionArterialD.Name = "colPresionArterialD";
            this.colPresionArterialD.ReadOnly = true;
            this.colPresionArterialD.Visible = false;
            this.colPresionArterialD.Width = 50;
            // 
            // colFUA
            // 
            this.colFUA.DataPropertyName = "fua";
            this.colFUA.HeaderText = "FUA";
            this.colFUA.Name = "colFUA";
            this.colFUA.ReadOnly = true;
            // 
            // colIdthistoriaClinica
            // 
            this.colIdthistoriaClinica.DataPropertyName = "idthistoriaclinica";
            this.colIdthistoriaClinica.HeaderText = "id Historia Clinica";
            this.colIdthistoriaClinica.Name = "colIdthistoriaClinica";
            this.colIdthistoriaClinica.ReadOnly = true;
            this.colIdthistoriaClinica.Visible = false;
            // 
            // colCodigoHistoriaClinica
            // 
            this.colCodigoHistoriaClinica.DataPropertyName = "codigohistoriaclinica";
            this.colCodigoHistoriaClinica.HeaderText = "Codigo Historia Clinica";
            this.colCodigoHistoriaClinica.Name = "colCodigoHistoriaClinica";
            this.colCodigoHistoriaClinica.ReadOnly = true;
            // 
            // colPresionArterial
            // 
            this.colPresionArterial.DataPropertyName = "presionarterial";
            this.colPresionArterial.HeaderText = "Presion Arterial";
            this.colPresionArterial.Name = "colPresionArterial";
            this.colPresionArterial.ReadOnly = true;
            this.colPresionArterial.Width = 80;
            // 
            // frmGestantesConRiesgoPresionArterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 358);
            this.Controls.Add(this.dtgListaGestantes);
            this.Name = "frmGestantesConRiesgoPresionArterial";
            this.Text = "frmGestantesConRiesgoPresionArterial";
            this.Load += new System.EventHandler(this.frmGestantesConRiesgoPresionArterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaGestantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaProximaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterialS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterialD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdthistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresionArterial;
    }
}