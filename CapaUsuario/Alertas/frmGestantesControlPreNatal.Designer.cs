namespace CapaUsuario.Alertas
{
    partial class frmGestantesControlPreNatal
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
            this.colNumerocita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaProximaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdtHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colNumerocita,
            this.colDiferencia,
            this.colFechaProximaCita,
            this.colDNI,
            this.colNombres,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colCodigoHistoriaClinica,
            this.colFUA,
            this.colIdtHistoriaClinica});
            this.dtgListaGestantes.Location = new System.Drawing.Point(12, 12);
            this.dtgListaGestantes.Name = "dtgListaGestantes";
            this.dtgListaGestantes.ReadOnly = true;
            this.dtgListaGestantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaGestantes.Size = new System.Drawing.Size(838, 218);
            this.dtgListaGestantes.TabIndex = 0;
            // 
            // colNumerocita
            // 
            this.colNumerocita.DataPropertyName = "numero";
            this.colNumerocita.HeaderText = "Numero Cita";
            this.colNumerocita.Name = "colNumerocita";
            this.colNumerocita.ReadOnly = true;
            this.colNumerocita.Width = 50;
            // 
            // colDiferencia
            // 
            this.colDiferencia.DataPropertyName = "Diferencia";
            this.colDiferencia.HeaderText = "Diferencia Dias";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.ReadOnly = true;
            this.colDiferencia.Width = 60;
            // 
            // colFechaProximaCita
            // 
            this.colFechaProximaCita.DataPropertyName = "fechaProximaCita";
            this.colFechaProximaCita.HeaderText = "Fecha de la Cita";
            this.colFechaProximaCita.Name = "colFechaProximaCita";
            this.colFechaProximaCita.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.DataPropertyName = "dni";
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 70;
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
            // colCodigoHistoriaClinica
            // 
            this.colCodigoHistoriaClinica.DataPropertyName = "codigohistoriaclinica";
            this.colCodigoHistoriaClinica.HeaderText = "Historia Clinica";
            this.colCodigoHistoriaClinica.Name = "colCodigoHistoriaClinica";
            this.colCodigoHistoriaClinica.ReadOnly = true;
            // 
            // colFUA
            // 
            this.colFUA.DataPropertyName = "fua";
            this.colFUA.HeaderText = "FUA";
            this.colFUA.Name = "colFUA";
            this.colFUA.ReadOnly = true;
            // 
            // colIdtHistoriaClinica
            // 
            this.colIdtHistoriaClinica.DataPropertyName = "idtHistoriaclinica";
            this.colIdtHistoriaClinica.HeaderText = "Codigo Historia Clinica";
            this.colIdtHistoriaClinica.Name = "colIdtHistoriaClinica";
            this.colIdtHistoriaClinica.ReadOnly = true;
            this.colIdtHistoriaClinica.Visible = false;
            // 
            // frmGestantesControlPreNatal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 316);
            this.Controls.Add(this.dtgListaGestantes);
            this.Name = "frmGestantesControlPreNatal";
            this.Text = "Relacion de Gestantes que no acuden a las citas.";
            this.Load += new System.EventHandler(this.frmGestantesControlPreNatal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaGestantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumerocita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaProximaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdtHistoriaClinica;
    }
}