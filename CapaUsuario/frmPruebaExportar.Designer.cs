namespace CapaUsuario
{
    partial class frmPruebaExportar
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
            this.dgvListarMicrored = new System.Windows.Forms.DataGridView();
            this.dgvListarEstablecimientos = new System.Windows.Forms.DataGridView();
            this.dgvListarTodo = new System.Windows.Forms.DataGridView();
            this.btnCargarTablas = new System.Windows.Forms.Button();
            this.Microred1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Microred2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Microred3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establecimientos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtCadenaInicial = new System.Windows.Forms.TextBox();
            this.txtCadenaEncriptada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCadenaDesencriptada = new System.Windows.Forms.TextBox();
            this.txtCadenaFinal = new System.Windows.Forms.TextBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.dgvListaImportada = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDesencriptado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMicrored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEstablecimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImportada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesencriptado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarMicrored
            // 
            this.dgvListarMicrored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMicrored.Location = new System.Drawing.Point(11, 14);
            this.dgvListarMicrored.Name = "dgvListarMicrored";
            this.dgvListarMicrored.Size = new System.Drawing.Size(383, 61);
            this.dgvListarMicrored.TabIndex = 0;
            // 
            // dgvListarEstablecimientos
            // 
            this.dgvListarEstablecimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEstablecimientos.Location = new System.Drawing.Point(11, 81);
            this.dgvListarEstablecimientos.Name = "dgvListarEstablecimientos";
            this.dgvListarEstablecimientos.Size = new System.Drawing.Size(383, 63);
            this.dgvListarEstablecimientos.TabIndex = 1;
            // 
            // dgvListarTodo
            // 
            this.dgvListarTodo.AllowUserToAddRows = false;
            this.dgvListarTodo.AllowUserToDeleteRows = false;
            this.dgvListarTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Microred1,
            this.Microred2,
            this.Microred3,
            this.Establecimientos1});
            this.dgvListarTodo.Location = new System.Drawing.Point(12, 228);
            this.dgvListarTodo.Name = "dgvListarTodo";
            this.dgvListarTodo.Size = new System.Drawing.Size(566, 106);
            this.dgvListarTodo.TabIndex = 2;
            // 
            // btnCargarTablas
            // 
            this.btnCargarTablas.Location = new System.Drawing.Point(47, 175);
            this.btnCargarTablas.Name = "btnCargarTablas";
            this.btnCargarTablas.Size = new System.Drawing.Size(114, 35);
            this.btnCargarTablas.TabIndex = 3;
            this.btnCargarTablas.Text = "Cargar Tablas";
            this.btnCargarTablas.UseVisualStyleBackColor = true;
            this.btnCargarTablas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Microred1
            // 
            this.Microred1.HeaderText = "1";
            this.Microred1.Name = "Microred1";
            // 
            // Microred2
            // 
            this.Microred2.HeaderText = "2";
            this.Microred2.Name = "Microred2";
            // 
            // Microred3
            // 
            this.Microred3.HeaderText = "3";
            this.Microred3.Name = "Microred3";
            // 
            // Establecimientos1
            // 
            this.Establecimientos1.HeaderText = "E1";
            this.Establecimientos1.Name = "Establecimientos1";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(280, 340);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(114, 35);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtCadenaInicial
            // 
            this.txtCadenaInicial.Location = new System.Drawing.Point(213, 166);
            this.txtCadenaInicial.Name = "txtCadenaInicial";
            this.txtCadenaInicial.Size = new System.Drawing.Size(143, 20);
            this.txtCadenaInicial.TabIndex = 5;
            this.txtCadenaInicial.Text = "hola";
            // 
            // txtCadenaEncriptada
            // 
            this.txtCadenaEncriptada.Location = new System.Drawing.Point(443, 166);
            this.txtCadenaEncriptada.Name = "txtCadenaEncriptada";
            this.txtCadenaEncriptada.Size = new System.Drawing.Size(164, 20);
            this.txtCadenaEncriptada.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Encriptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCadenaDesencriptada
            // 
            this.txtCadenaDesencriptada.Location = new System.Drawing.Point(444, 192);
            this.txtCadenaDesencriptada.Name = "txtCadenaDesencriptada";
            this.txtCadenaDesencriptada.Size = new System.Drawing.Size(163, 20);
            this.txtCadenaDesencriptada.TabIndex = 9;
            // 
            // txtCadenaFinal
            // 
            this.txtCadenaFinal.Location = new System.Drawing.Point(212, 192);
            this.txtCadenaFinal.Name = "txtCadenaFinal";
            this.txtCadenaFinal.Size = new System.Drawing.Size(144, 20);
            this.txtCadenaFinal.TabIndex = 8;
            this.txtCadenaFinal.Text = "hola";
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(362, 190);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencriptar.TabIndex = 10;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // dgvListaImportada
            // 
            this.dgvListaImportada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaImportada.Location = new System.Drawing.Point(12, 381);
            this.dgvListaImportada.Name = "dgvListaImportada";
            this.dgvListaImportada.Size = new System.Drawing.Size(736, 105);
            this.dgvListaImportada.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Importar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDesencriptado
            // 
            this.dgvDesencriptado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesencriptado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDesencriptado.Location = new System.Drawing.Point(754, 12);
            this.dgvDesencriptado.Name = "dgvDesencriptado";
            this.dgvDesencriptado.Size = new System.Drawing.Size(477, 485);
            this.dgvDesencriptado.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // frmPruebaExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 509);
            this.Controls.Add(this.dgvDesencriptado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvListaImportada);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.txtCadenaDesencriptada);
            this.Controls.Add(this.txtCadenaFinal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCadenaEncriptada);
            this.Controls.Add(this.txtCadenaInicial);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCargarTablas);
            this.Controls.Add(this.dgvListarTodo);
            this.Controls.Add(this.dgvListarEstablecimientos);
            this.Controls.Add(this.dgvListarMicrored);
            this.Name = "frmPruebaExportar";
            this.Text = "frmPruebaExportar";
            this.Load += new System.EventHandler(this.frmPruebaExportar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMicrored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEstablecimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImportada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesencriptado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarMicrored;
        private System.Windows.Forms.DataGridView dgvListarEstablecimientos;
        private System.Windows.Forms.DataGridView dgvListarTodo;
        private System.Windows.Forms.Button btnCargarTablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Microred1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Microred2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Microred3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establecimientos1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtCadenaInicial;
        private System.Windows.Forms.TextBox txtCadenaEncriptada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCadenaDesencriptada;
        private System.Windows.Forms.TextBox txtCadenaFinal;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.DataGridView dgvListaImportada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDesencriptado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}