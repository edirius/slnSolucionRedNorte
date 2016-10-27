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
            this.dtgListaGestantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaGestantes
            // 
            this.dtgListaGestantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaGestantes.Location = new System.Drawing.Point(27, 51);
            this.dtgListaGestantes.Name = "dtgListaGestantes";
            this.dtgListaGestantes.Size = new System.Drawing.Size(556, 218);
            this.dtgListaGestantes.TabIndex = 0;
            // 
            // frmGestantesControlPreNatal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 316);
            this.Controls.Add(this.dtgListaGestantes);
            this.Name = "frmGestantesControlPreNatal";
            this.Text = "Relacion de Gestantes que no acuden a las citas.";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaGestantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaGestantes;
    }
}