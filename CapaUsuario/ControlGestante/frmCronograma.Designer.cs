namespace CapaUsuario.ControlGestante
{
    partial class frmCronograma
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
            this.dtgCronograma = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCronograma)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCronograma
            // 
            this.dtgCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCronograma.Location = new System.Drawing.Point(23, 81);
            this.dtgCronograma.Name = "dtgCronograma";
            this.dtgCronograma.Size = new System.Drawing.Size(919, 178);
            this.dtgCronograma.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver cronograma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgCronograma);
            this.Name = "frmCronograma";
            this.Text = "frmCronograma";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCronograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCronograma;
        private System.Windows.Forms.Button button1;
    }
}