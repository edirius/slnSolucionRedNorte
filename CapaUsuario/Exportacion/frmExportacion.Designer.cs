namespace CapaUsuario.Exportacion
{
    partial class frmExportacion
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
            this.btnExportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObstetra = new System.Windows.Forms.Label();
            this.dlgGuardar = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(22, 132);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(116, 69);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTABLECIMIENTO DE SALUD:";
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(226, 41);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(35, 13);
            this.lblEstablecimiento.TabIndex = 2;
            this.lblEstablecimiento.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OBSTETRA :";
            // 
            // lblObstetra
            // 
            this.lblObstetra.AutoSize = true;
            this.lblObstetra.Location = new System.Drawing.Point(226, 81);
            this.lblObstetra.Name = "lblObstetra";
            this.lblObstetra.Size = new System.Drawing.Size(35, 13);
            this.lblObstetra.TabIndex = 4;
            this.lblObstetra.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 260);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(652, 146);
            this.textBox1.TabIndex = 5;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(541, 121);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(133, 69);
            this.btnImportar.TabIndex = 6;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // frmExportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 416);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblObstetra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEstablecimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Name = "frmExportacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Datos";
            this.Load += new System.EventHandler(this.frmExportacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObstetra;
        private System.Windows.Forms.SaveFileDialog dlgGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}