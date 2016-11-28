﻿namespace Alertas
{
    partial class frmAlertas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlertas));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gestantes sin bateria");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gestantes con anemia");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gestantes sin tratamiento");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gestantes con sifilis reactivo");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Gestantes con VIH reactivo");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gestantes con infección urinaria");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gestantes sin examen de orina");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Alertas en bateria", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Gestantes que no acuden a sus citas");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Alertas en Citas", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Gestantes con presion arterial elevada");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Alertas en Presion Arterial", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Recien nacidos con bajo peso");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Alertas en Recien Nacidos", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Arbol = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRNBajoPeso = new System.Windows.Forms.TextBox();
            this.dgvRecienNacidosBajoPeso = new System.Windows.Forms.DataGridView();
            this.txtUltimaGestanteSinEOrina = new System.Windows.Forms.TextBox();
            this.txtUltimaGestanteVIH = new System.Windows.Forms.TextBox();
            this.txtUltimaGestanteInfeccion = new System.Windows.Forms.TextBox();
            this.txtUltimaGestanteSifilis = new System.Windows.Forms.TextBox();
            this.txtUltimaGestanteSinTrata = new System.Windows.Forms.TextBox();
            this.txtUltimaGestanteConAnemia = new System.Windows.Forms.TextBox();
            this.txtUltimaGestanteSinBateria = new System.Windows.Forms.TextBox();
            this.dgvGestantesSinExamenOrina = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGestantesInfeccionUrinaria = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGestantesVIH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGestantesSifilis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGestantesSinTratamiento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGestantesConAnemia = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoDeAlerta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAños = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGestantesSinBateria = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerActualizar = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecienNacidosBajoPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSinExamenOrina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesInfeccionUrinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesVIH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSifilis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSinTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesConAnemia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSinBateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Control de Alerta de GESSYS v.1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Arbol
            // 
            this.Arbol.BackColor = System.Drawing.Color.Black;
            this.Arbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Arbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arbol.Dock = System.Windows.Forms.DockStyle.Left;
            this.Arbol.Font = new System.Drawing.Font("Palatino", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arbol.ForeColor = System.Drawing.Color.White;
            this.Arbol.Location = new System.Drawing.Point(0, 0);
            this.Arbol.Name = "Arbol";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Gestantes sin bateria";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Gestantes con anemia";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Gestantes sin tratamiento";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Gestantes con sifilis reactivo";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Gestantes con VIH reactivo";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Gestantes con infección urinaria";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Gestantes sin examen de orina";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Alertas en bateria";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Gestantes que no acuden a sus citas";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Alertas en Citas";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Gestantes con presion arterial elevada";
            treeNode12.Name = "Node9";
            treeNode12.Text = "Alertas en Presion Arterial";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Recien nacidos con bajo peso";
            treeNode14.Name = "Node10";
            treeNode14.Text = "Alertas en Recien Nacidos";
            this.Arbol.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode12,
            treeNode14});
            this.Arbol.Size = new System.Drawing.Size(317, 630);
            this.Arbol.TabIndex = 3;
            this.Arbol.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Arbol_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtRNBajoPeso);
            this.groupBox1.Controls.Add(this.dgvRecienNacidosBajoPeso);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteSinEOrina);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteVIH);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteInfeccion);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteSifilis);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteSinTrata);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteConAnemia);
            this.groupBox1.Controls.Add(this.txtUltimaGestanteSinBateria);
            this.groupBox1.Controls.Add(this.dgvGestantesSinExamenOrina);
            this.groupBox1.Controls.Add(this.dgvGestantesInfeccionUrinaria);
            this.groupBox1.Controls.Add(this.dgvGestantesVIH);
            this.groupBox1.Controls.Add(this.dgvGestantesSifilis);
            this.groupBox1.Controls.Add(this.dgvGestantesSinTratamiento);
            this.groupBox1.Controls.Add(this.dgvGestantesConAnemia);
            this.groupBox1.Controls.Add(this.lblTipoDeAlerta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAños);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvGestantesSinBateria);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(323, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 598);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizador de gestantes con problemas:";
            // 
            // txtRNBajoPeso
            // 
            this.txtRNBajoPeso.Location = new System.Drawing.Point(837, 273);
            this.txtRNBajoPeso.Name = "txtRNBajoPeso";
            this.txtRNBajoPeso.Size = new System.Drawing.Size(100, 28);
            this.txtRNBajoPeso.TabIndex = 135;
            this.txtRNBajoPeso.Visible = false;
            this.txtRNBajoPeso.TextChanged += new System.EventHandler(this.txtRNBajoPeso_TextChanged);
            // 
            // dgvRecienNacidosBajoPeso
            // 
            this.dgvRecienNacidosBajoPeso.AllowUserToAddRows = false;
            this.dgvRecienNacidosBajoPeso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRecienNacidosBajoPeso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecienNacidosBajoPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecienNacidosBajoPeso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecienNacidosBajoPeso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecienNacidosBajoPeso.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecienNacidosBajoPeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecienNacidosBajoPeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecienNacidosBajoPeso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Column29,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28});
            this.dgvRecienNacidosBajoPeso.GridColor = System.Drawing.Color.White;
            this.dgvRecienNacidosBajoPeso.Location = new System.Drawing.Point(8, 268);
            this.dgvRecienNacidosBajoPeso.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecienNacidosBajoPeso.Name = "dgvRecienNacidosBajoPeso";
            this.dgvRecienNacidosBajoPeso.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecienNacidosBajoPeso.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecienNacidosBajoPeso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecienNacidosBajoPeso.Size = new System.Drawing.Size(929, 500);
            this.dgvRecienNacidosBajoPeso.TabIndex = 134;
            this.dgvRecienNacidosBajoPeso.Visible = false;
            // 
            // txtUltimaGestanteSinEOrina
            // 
            this.txtUltimaGestanteSinEOrina.Location = new System.Drawing.Point(837, 246);
            this.txtUltimaGestanteSinEOrina.Name = "txtUltimaGestanteSinEOrina";
            this.txtUltimaGestanteSinEOrina.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteSinEOrina.TabIndex = 133;
            this.txtUltimaGestanteSinEOrina.Visible = false;
            this.txtUltimaGestanteSinEOrina.TextChanged += new System.EventHandler(this.txtUltimaGestanteSinEOrina_TextChanged);
            // 
            // txtUltimaGestanteVIH
            // 
            this.txtUltimaGestanteVIH.Location = new System.Drawing.Point(837, 195);
            this.txtUltimaGestanteVIH.Name = "txtUltimaGestanteVIH";
            this.txtUltimaGestanteVIH.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteVIH.TabIndex = 132;
            this.txtUltimaGestanteVIH.Visible = false;
            this.txtUltimaGestanteVIH.TextChanged += new System.EventHandler(this.txtUltimaGestanteVIH_TextChanged);
            // 
            // txtUltimaGestanteInfeccion
            // 
            this.txtUltimaGestanteInfeccion.Location = new System.Drawing.Point(837, 220);
            this.txtUltimaGestanteInfeccion.Name = "txtUltimaGestanteInfeccion";
            this.txtUltimaGestanteInfeccion.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteInfeccion.TabIndex = 132;
            this.txtUltimaGestanteInfeccion.Visible = false;
            this.txtUltimaGestanteInfeccion.TextChanged += new System.EventHandler(this.txtUltimaGestanteInfeccion_TextChanged);
            // 
            // txtUltimaGestanteSifilis
            // 
            this.txtUltimaGestanteSifilis.Location = new System.Drawing.Point(837, 170);
            this.txtUltimaGestanteSifilis.Name = "txtUltimaGestanteSifilis";
            this.txtUltimaGestanteSifilis.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteSifilis.TabIndex = 131;
            this.txtUltimaGestanteSifilis.Visible = false;
            this.txtUltimaGestanteSifilis.TextChanged += new System.EventHandler(this.txtUltimaGestanteSifilis_TextChanged);
            // 
            // txtUltimaGestanteSinTrata
            // 
            this.txtUltimaGestanteSinTrata.Location = new System.Drawing.Point(837, 144);
            this.txtUltimaGestanteSinTrata.Name = "txtUltimaGestanteSinTrata";
            this.txtUltimaGestanteSinTrata.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteSinTrata.TabIndex = 130;
            this.txtUltimaGestanteSinTrata.Visible = false;
            this.txtUltimaGestanteSinTrata.TextChanged += new System.EventHandler(this.txtUltimaGestanteSinTrata_TextChanged);
            // 
            // txtUltimaGestanteConAnemia
            // 
            this.txtUltimaGestanteConAnemia.Location = new System.Drawing.Point(837, 118);
            this.txtUltimaGestanteConAnemia.Name = "txtUltimaGestanteConAnemia";
            this.txtUltimaGestanteConAnemia.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteConAnemia.TabIndex = 129;
            this.txtUltimaGestanteConAnemia.Visible = false;
            this.txtUltimaGestanteConAnemia.TextChanged += new System.EventHandler(this.txtUltimaGestanteConAnemia_TextChanged);
            // 
            // txtUltimaGestanteSinBateria
            // 
            this.txtUltimaGestanteSinBateria.Location = new System.Drawing.Point(837, 91);
            this.txtUltimaGestanteSinBateria.Name = "txtUltimaGestanteSinBateria";
            this.txtUltimaGestanteSinBateria.Size = new System.Drawing.Size(100, 28);
            this.txtUltimaGestanteSinBateria.TabIndex = 128;
            this.txtUltimaGestanteSinBateria.Visible = false;
            this.txtUltimaGestanteSinBateria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvGestantesSinExamenOrina
            // 
            this.dgvGestantesSinExamenOrina.AllowUserToAddRows = false;
            this.dgvGestantesSinExamenOrina.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGestantesSinExamenOrina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGestantesSinExamenOrina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesSinExamenOrina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesSinExamenOrina.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesSinExamenOrina.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesSinExamenOrina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGestantesSinExamenOrina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesSinExamenOrina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.Column20,
            this.Column21,
            this.Column22});
            this.dgvGestantesSinExamenOrina.GridColor = System.Drawing.Color.White;
            this.dgvGestantesSinExamenOrina.Location = new System.Drawing.Point(55, 242);
            this.dgvGestantesSinExamenOrina.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesSinExamenOrina.Name = "dgvGestantesSinExamenOrina";
            this.dgvGestantesSinExamenOrina.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesSinExamenOrina.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGestantesSinExamenOrina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesSinExamenOrina.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesSinExamenOrina.TabIndex = 126;
            this.dgvGestantesSinExamenOrina.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nro";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "N°";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 55;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column20.DataPropertyName = "Nombres";
            this.Column20.FillWeight = 116.0275F;
            this.Column20.HeaderText = "Nombres";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 250;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column21.DataPropertyName = "telefono";
            this.Column21.FillWeight = 179.5775F;
            this.Column21.HeaderText = "Teléfono";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Width = 85;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "direccion";
            this.Column22.FillWeight = 4.394985F;
            this.Column22.HeaderText = "Dirección";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // dgvGestantesInfeccionUrinaria
            // 
            this.dgvGestantesInfeccionUrinaria.AllowUserToAddRows = false;
            this.dgvGestantesInfeccionUrinaria.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGestantesInfeccionUrinaria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGestantesInfeccionUrinaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesInfeccionUrinaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesInfeccionUrinaria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesInfeccionUrinaria.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesInfeccionUrinaria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGestantesInfeccionUrinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesInfeccionUrinaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dgvGestantesInfeccionUrinaria.GridColor = System.Drawing.Color.White;
            this.dgvGestantesInfeccionUrinaria.Location = new System.Drawing.Point(55, 219);
            this.dgvGestantesInfeccionUrinaria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesInfeccionUrinaria.Name = "dgvGestantesInfeccionUrinaria";
            this.dgvGestantesInfeccionUrinaria.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesInfeccionUrinaria.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGestantesInfeccionUrinaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesInfeccionUrinaria.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesInfeccionUrinaria.TabIndex = 125;
            this.dgvGestantesInfeccionUrinaria.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nro";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "N°";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 55;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column16.DataPropertyName = "Nombres";
            this.Column16.HeaderText = "Nombres";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 250;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column17.DataPropertyName = "telefono";
            this.Column17.HeaderText = "Teléfono";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 83;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "direccion";
            this.Column18.HeaderText = "Dirección";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column19.DataPropertyName = "orina";
            this.Column19.HeaderText = "Orina";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 50;
            // 
            // dgvGestantesVIH
            // 
            this.dgvGestantesVIH.AllowUserToAddRows = false;
            this.dgvGestantesVIH.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGestantesVIH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvGestantesVIH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesVIH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesVIH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesVIH.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesVIH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGestantesVIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesVIH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvGestantesVIH.GridColor = System.Drawing.Color.White;
            this.dgvGestantesVIH.Location = new System.Drawing.Point(55, 195);
            this.dgvGestantesVIH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesVIH.Name = "dgvGestantesVIH";
            this.dgvGestantesVIH.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesVIH.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvGestantesVIH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesVIH.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesVIH.TabIndex = 124;
            this.dgvGestantesVIH.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nro";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "N°";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column13.DataPropertyName = "Nombres";
            this.Column13.HeaderText = "Nombres";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 250;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column14.DataPropertyName = "telefono";
            this.Column14.HeaderText = "Teléfono";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 83;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "direccion";
            this.Column15.HeaderText = "Dirección";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // dgvGestantesSifilis
            // 
            this.dgvGestantesSifilis.AllowUserToAddRows = false;
            this.dgvGestantesSifilis.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGestantesSifilis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvGestantesSifilis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesSifilis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesSifilis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesSifilis.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesSifilis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGestantesSifilis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesSifilis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvGestantesSifilis.GridColor = System.Drawing.Color.White;
            this.dgvGestantesSifilis.Location = new System.Drawing.Point(55, 170);
            this.dgvGestantesSifilis.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesSifilis.Name = "dgvGestantesSifilis";
            this.dgvGestantesSifilis.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesSifilis.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvGestantesSifilis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesSifilis.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesSifilis.TabIndex = 123;
            this.dgvGestantesSifilis.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nro";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn3.HeaderText = "N°";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 55;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.DataPropertyName = "Nombres";
            this.Column10.HeaderText = "Nombres";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 250;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column11.DataPropertyName = "telefono";
            this.Column11.HeaderText = "Teléfono";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 83;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "direccion";
            this.Column12.HeaderText = "Dirección";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // dgvGestantesSinTratamiento
            // 
            this.dgvGestantesSinTratamiento.AllowUserToAddRows = false;
            this.dgvGestantesSinTratamiento.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dgvGestantesSinTratamiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvGestantesSinTratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesSinTratamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesSinTratamiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesSinTratamiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesSinTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestantesSinTratamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvGestantesSinTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesSinTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvGestantesSinTratamiento.GridColor = System.Drawing.Color.White;
            this.dgvGestantesSinTratamiento.Location = new System.Drawing.Point(55, 144);
            this.dgvGestantesSinTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesSinTratamiento.Name = "dgvGestantesSinTratamiento";
            this.dgvGestantesSinTratamiento.RowHeadersVisible = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesSinTratamiento.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvGestantesSinTratamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesSinTratamiento.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesSinTratamiento.TabIndex = 122;
            this.dgvGestantesSinTratamiento.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nro";
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn2.HeaderText = "N°";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "Nombres";
            this.Column7.HeaderText = "Nombres";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 250;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.DataPropertyName = "telefono";
            this.Column8.HeaderText = "Teléfono";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 83;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "direccion";
            this.Column9.HeaderText = "Dirección";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // dgvGestantesConAnemia
            // 
            this.dgvGestantesConAnemia.AllowUserToAddRows = false;
            this.dgvGestantesConAnemia.AllowUserToResizeRows = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGestantesConAnemia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvGestantesConAnemia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesConAnemia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesConAnemia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesConAnemia.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesConAnemia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestantesConAnemia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvGestantesConAnemia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesConAnemia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nombres,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvGestantesConAnemia.GridColor = System.Drawing.Color.White;
            this.dgvGestantesConAnemia.Location = new System.Drawing.Point(55, 118);
            this.dgvGestantesConAnemia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesConAnemia.Name = "dgvGestantesConAnemia";
            this.dgvGestantesConAnemia.RowHeadersVisible = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesConAnemia.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvGestantesConAnemia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesConAnemia.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesConAnemia.TabIndex = 121;
            this.dgvGestantesConAnemia.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nro";
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn1.HeaderText = "N°";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 250;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "telefono";
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 83;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "direccion";
            this.Column5.HeaderText = "Dirección";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "hemoglobina";
            this.Column6.HeaderText = "Hemoglobina";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lblTipoDeAlerta
            // 
            this.lblTipoDeAlerta.AutoSize = true;
            this.lblTipoDeAlerta.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeAlerta.ForeColor = System.Drawing.Color.Black;
            this.lblTipoDeAlerta.Location = new System.Drawing.Point(333, 30);
            this.lblTipoDeAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDeAlerta.Name = "lblTipoDeAlerta";
            this.lblTipoDeAlerta.Size = new System.Drawing.Size(158, 21);
            this.lblTipoDeAlerta.TabIndex = 120;
            this.lblTipoDeAlerta.Text = "Gestantes sin bateria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(233, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Tipo de Alerta:";
            // 
            // cbAños
            // 
            this.cbAños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAños.ForeColor = System.Drawing.Color.Black;
            this.cbAños.FormattingEnabled = true;
            this.cbAños.Location = new System.Drawing.Point(517, 55);
            this.cbAños.Margin = new System.Windows.Forms.Padding(4);
            this.cbAños.Name = "cbAños";
            this.cbAños.Size = new System.Drawing.Size(79, 28);
            this.cbAños.TabIndex = 105;
            this.cbAños.SelectedIndexChanged += new System.EventHandler(this.cbAños_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(273, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(478, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Año:";
            // 
            // dgvGestantesSinBateria
            // 
            this.dgvGestantesSinBateria.AllowUserToAddRows = false;
            this.dgvGestantesSinBateria.AllowUserToDeleteRows = false;
            this.dgvGestantesSinBateria.AllowUserToResizeRows = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGestantesSinBateria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvGestantesSinBateria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestantesSinBateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestantesSinBateria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestantesSinBateria.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestantesSinBateria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGestantesSinBateria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGestantesSinBateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestantesSinBateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesSinBateria.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvGestantesSinBateria.GridColor = System.Drawing.Color.White;
            this.dgvGestantesSinBateria.Location = new System.Drawing.Point(55, 91);
            this.dgvGestantesSinBateria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestantesSinBateria.Name = "dgvGestantesSinBateria";
            this.dgvGestantesSinBateria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesSinBateria.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvGestantesSinBateria.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestantesSinBateria.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvGestantesSinBateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestantesSinBateria.Size = new System.Drawing.Size(824, 500);
            this.dgvGestantesSinBateria.TabIndex = 118;
            this.dgvGestantesSinBateria.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Nro";
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle25;
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.DataPropertyName = "Nombres";
            this.name.HeaderText = "Nombres";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "telefono";
            this.Column2.HeaderText = "Teléfono";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "direccion";
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.ForeColor = System.Drawing.Color.Black;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cbMes.Location = new System.Drawing.Point(320, 55);
            this.cbMes.Margin = new System.Windows.Forms.Padding(4);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(156, 28);
            this.cbMes.TabIndex = 104;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Alertas.Properties.Resources.images__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timerActualizar
            // 
            this.timerActualizar.Interval = 1000;
            this.timerActualizar.Tick += new System.EventHandler(this.timerActualizar_Tick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nro";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "N°";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 55;
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "Nombres";
            this.Column29.HeaderText = "Nombres";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column23.DataPropertyName = "dni";
            this.Column23.HeaderText = "DNI";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 75;
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column24.DataPropertyName = "fechaderivado";
            this.Column24.HeaderText = "F.Derivado";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 85;
            // 
            // Column25
            // 
            this.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column25.DataPropertyName = "peso";
            this.Column25.HeaderText = "Peso";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 50;
            // 
            // Column26
            // 
            this.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column26.DataPropertyName = "sexo";
            this.Column26.HeaderText = "Sexo";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Width = 50;
            // 
            // Column27
            // 
            this.Column27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column27.DataPropertyName = "microred";
            this.Column27.HeaderText = "Microred";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Width = 120;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "descripcion";
            this.Column28.HeaderText = "Establecimiento de Salud";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            // 
            // frmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Arbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.Name = "frmAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadro de Alertas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlertas_FormClosing);
            this.Load += new System.EventHandler(this.frmAlertas_Load);
            this.Move += new System.EventHandler(this.frmAlertas_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecienNacidosBajoPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSinExamenOrina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesInfeccionUrinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesVIH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSifilis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSinTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesConAnemia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestantesSinBateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TreeView Arbol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAños;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.DataGridView dgvGestantesSinBateria;
        private System.Windows.Forms.Label lblTipoDeAlerta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvGestantesConAnemia;
        private System.Windows.Forms.DataGridView dgvGestantesSinExamenOrina;
        private System.Windows.Forms.DataGridView dgvGestantesInfeccionUrinaria;
        private System.Windows.Forms.DataGridView dgvGestantesVIH;
        private System.Windows.Forms.DataGridView dgvGestantesSifilis;
        private System.Windows.Forms.DataGridView dgvGestantesSinTratamiento;
        private System.Windows.Forms.TextBox txtUltimaGestanteSinBateria;
        private System.Windows.Forms.TextBox txtUltimaGestanteVIH;
        private System.Windows.Forms.TextBox txtUltimaGestanteInfeccion;
        private System.Windows.Forms.TextBox txtUltimaGestanteSifilis;
        private System.Windows.Forms.TextBox txtUltimaGestanteSinTrata;
        private System.Windows.Forms.TextBox txtUltimaGestanteConAnemia;
        private System.Windows.Forms.TextBox txtUltimaGestanteSinEOrina;
        private System.Windows.Forms.Timer timerActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridView dgvRecienNacidosBajoPeso;
        private System.Windows.Forms.TextBox txtRNBajoPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
    }
}