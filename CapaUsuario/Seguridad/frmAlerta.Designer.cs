namespace CapaUsuario.Seguridad
{
    partial class frmAlerta
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
            this.pbAlerta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlerta
            // 
            this.pbAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlerta.BackColor = System.Drawing.Color.Transparent;
            this.pbAlerta.Image = global::CapaUsuario.Properties.Resources._433cca0dd88ef63c7c362799956c5b33;
            this.pbAlerta.Location = new System.Drawing.Point(12, 12);
            this.pbAlerta.Name = "pbAlerta";
            this.pbAlerta.Size = new System.Drawing.Size(372, 305);
            this.pbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlerta.TabIndex = 100;
            this.pbAlerta.TabStop = false;
            // 
            // frmAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 329);
            this.Controls.Add(this.pbAlerta);
            this.Name = "frmAlerta";
            this.Text = "frmAlerta";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlerta;
    }
}