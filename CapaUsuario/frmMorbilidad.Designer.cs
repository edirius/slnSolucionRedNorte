namespace CapaUsuario
{
    partial class frmMorbilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMorbilidad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvMorbilidad_ = new System.Windows.Forms.DataGridView();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.dtpFechaMorbilidad = new System.Windows.Forms.DateTimePicker();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtBuscar_ = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dgvGM = new System.Windows.Forms.DataGridView();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.pbMor = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.pbMorbilidad = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorbilidad_)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGM)).BeginInit();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMor)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorbilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.dgvMorbilidad_);
            this.groupBox9.Controls.Add(this.groupBox17);
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox9.Location = new System.Drawing.Point(23, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(913, 329);
            this.groupBox9.TabIndex = 47;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Morbilidad(es)";
            // 
            // dgvMorbilidad_
            // 
            this.dgvMorbilidad_.AllowUserToAddRows = false;
            this.dgvMorbilidad_.AllowUserToDeleteRows = false;
            this.dgvMorbilidad_.AllowUserToOrderColumns = true;
            this.dgvMorbilidad_.AllowUserToResizeColumns = false;
            this.dgvMorbilidad_.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvMorbilidad_.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMorbilidad_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMorbilidad_.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMorbilidad_.BackgroundColor = System.Drawing.Color.White;
            this.dgvMorbilidad_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMorbilidad_.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMorbilidad_.Location = new System.Drawing.Point(7, 77);
            this.dgvMorbilidad_.MultiSelect = false;
            this.dgvMorbilidad_.Name = "dgvMorbilidad_";
            this.dgvMorbilidad_.ReadOnly = true;
            this.dgvMorbilidad_.RowHeadersVisible = false;
            this.dgvMorbilidad_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMorbilidad_.Size = new System.Drawing.Size(897, 246);
            this.dgvMorbilidad_.TabIndex = 30;
            this.dgvMorbilidad_.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMorbilidad__CellContentClick_1);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.dtpFechaMorbilidad);
            this.groupBox17.Location = new System.Drawing.Point(403, 19);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(111, 52);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Fecha:";
            // 
            // dtpFechaMorbilidad
            // 
            this.dtpFechaMorbilidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMorbilidad.Location = new System.Drawing.Point(6, 21);
            this.dtpFechaMorbilidad.Name = "dtpFechaMorbilidad";
            this.dtpFechaMorbilidad.Size = new System.Drawing.Size(97, 24);
            this.dtpFechaMorbilidad.TabIndex = 0;
            this.dtpFechaMorbilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaMorbilidad_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbFiltrar);
            this.groupBox11.Location = new System.Drawing.Point(223, 19);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(174, 52);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filtrar por:";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "Todo",
            "Extrema",
            "Potencial"});
            this.cbFiltrar.Location = new System.Drawing.Point(6, 19);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(162, 26);
            this.cbFiltrar.TabIndex = 0;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtBuscar_);
            this.groupBox10.Location = new System.Drawing.Point(7, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(210, 52);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Buscar:";
            // 
            // txtBuscar_
            // 
            this.txtBuscar_.Location = new System.Drawing.Point(6, 21);
            this.txtBuscar_.Name = "txtBuscar_";
            this.txtBuscar_.Size = new System.Drawing.Size(198, 24);
            this.txtBuscar_.TabIndex = 1;
            this.txtBuscar_.TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            this.txtBuscar_.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar__KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEliminar, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(155, 347);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(647, 62);
            this.tableLayoutPanel4.TabIndex = 48;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(209, 56);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::CapaUsuario.Properties.Resources.btnSuculentoRojo1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(433, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox15, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox18, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 415);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(913, 239);
            this.tableLayoutPanel5.TabIndex = 51;
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox15.BackColor = System.Drawing.Color.Transparent;
            this.groupBox15.Controls.Add(this.dgvGM);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(633, 233);
            this.groupBox15.TabIndex = 50;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Gestante con Morbilidad(es)";
            // 
            // dgvGM
            // 
            this.dgvGM.AllowUserToAddRows = false;
            this.dgvGM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvGM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGM.BackgroundColor = System.Drawing.Color.White;
            this.dgvGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGM.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvGM.Location = new System.Drawing.Point(6, 19);
            this.dgvGM.MultiSelect = false;
            this.dgvGM.Name = "dgvGM";
            this.dgvGM.ReadOnly = true;
            this.dgvGM.RowHeadersVisible = false;
            this.dgvGM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGM.Size = new System.Drawing.Size(622, 208);
            this.dgvGM.TabIndex = 20;
            this.dgvGM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGM_CellClick_1);
            this.dgvGM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGM_CellContentClick_1);
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.pbMor);
            this.groupBox18.Location = new System.Drawing.Point(642, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(268, 233);
            this.groupBox18.TabIndex = 51;
            this.groupBox18.TabStop = false;
            // 
            // pbMor
            // 
            this.pbMor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMor.BackgroundImage = global::CapaUsuario.Properties.Resources.Obstetra2;
            this.pbMor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMor.Location = new System.Drawing.Point(8, 9);
            this.pbMor.Name = "pbMor";
            this.pbMor.Size = new System.Drawing.Size(254, 219);
            this.pbMor.TabIndex = 52;
            this.pbMor.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.pbMorbilidad);
            this.groupBox12.Location = new System.Drawing.Point(642, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(268, 174);
            this.groupBox12.TabIndex = 51;
            this.groupBox12.TabStop = false;
            // 
            // pbMorbilidad
            // 
            this.pbMorbilidad.BackgroundImage = global::CapaUsuario.Properties.Resources.Obstetra1;
            this.pbMorbilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMorbilidad.Location = new System.Drawing.Point(6, 15);
            this.pbMorbilidad.Name = "pbMorbilidad";
            this.pbMorbilidad.Size = new System.Drawing.Size(256, 153);
            this.pbMorbilidad.TabIndex = 0;
            this.pbMorbilidad.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(218, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(209, 56);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMorbilidad
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaUsuario.Properties.Resources.FondoFormularios2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 666);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBox9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMorbilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morbilidad";
            this.Load += new System.EventHandler(this.frmMorbilidad_Load_1);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorbilidad_)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGM)).EndInit();
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMor)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMorbilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvPacienteMorbilidad;
        private System.Windows.Forms.TextBox txtMorbilidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buNuevo;
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMorbilidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaHC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtBuscar_;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.DateTimePicker dtpFechaMorbilidad;
        private System.Windows.Forms.DataGridView dgvMorbilidad_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.PictureBox pbMorbilidad;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.DataGridView dgvGM;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.PictureBox pbMor;
        private System.Windows.Forms.Button btnEliminar;
    }
}