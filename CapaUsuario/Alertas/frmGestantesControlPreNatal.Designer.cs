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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestantesControlPreNatal));
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaGestantes
            // 
            this.dtgListaGestantes.AllowUserToAddRows = false;
            this.dtgListaGestantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dtgListaGestantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListaGestantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListaGestantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dtgListaGestantes.Size = new System.Drawing.Size(930, 450);
            this.dtgListaGestantes.TabIndex = 0;
            // 
            // colNumerocita
            // 
            this.colNumerocita.DataPropertyName = "numero";
            this.colNumerocita.HeaderText = "Numero Cita";
            this.colNumerocita.Name = "colNumerocita";
            this.colNumerocita.ReadOnly = true;
            // 
            // colDiferencia
            // 
            this.colDiferencia.DataPropertyName = "Diferencia";
            this.colDiferencia.HeaderText = "Diferencia Dias";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.ReadOnly = true;
            // 
            // colFechaProximaCita
            // 
            this.colFechaProximaCita.DataPropertyName = "fechacita";
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(851, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 56);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.MintCream;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(743, 490);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 56);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "&Vista preliminar";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmGestantesControlPreNatal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaUsuario.Properties.Resources.FondoFormularios1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 582);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtgListaGestantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGestantesControlPreNatal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relacion de Gestantes que no acuden a las citas.";
            this.Load += new System.EventHandler(this.frmGestantesControlPreNatal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaGestantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
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