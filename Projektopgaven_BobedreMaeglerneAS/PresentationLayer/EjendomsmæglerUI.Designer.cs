namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class EjendomsmæglerUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SletEjendomsmægler = new System.Windows.Forms.Button();
            this.btn_OpdaterEjendomsmægler = new System.Windows.Forms.Button();
            this.btn_HentEjendomsmægler = new System.Windows.Forms.Button();
            this.btn_OpretEjendomsmægler = new System.Windows.Forms.Button();
            this.Vej_txt = new System.Windows.Forms.TextBox();
            this.Postnummer_txt = new System.Windows.Forms.TextBox();
            this.Efternavn_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Telefon_txt = new System.Windows.Forms.TextBox();
            this.Fornavn_txt = new System.Windows.Forms.TextBox();
            this.CPR_txt = new System.Windows.Forms.TextBox();
            this.MæglerID_txt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejendomsmæglerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.boligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_bobedredbDataSet = new Projektopgaven_BobedreMaeglerneAS.ejendomsmægler_bobedredbDataSet();
            this.ejendomsmæglerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejendomsmæglerTableAdapter = new Projektopgaven_BobedreMaeglerneAS.ejendomsmægler_bobedredbDataSetTableAdapters.EjendomsmæglerTableAdapter();
            this.mæglerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmægler_bobedredbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mæglerIDDataGridViewTextBoxColumn,
            this.cPRDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fnavnDataGridViewTextBoxColumn,
            this.enavnDataGridViewTextBoxColumn,
            this.vejDataGridViewTextBoxColumn,
            this.postnummerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ejendomsmæglerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(655, 190);
            this.dataGridView1.TabIndex = 89;
            // 
            // btn_SletEjendomsmægler
            // 
            this.btn_SletEjendomsmægler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SletEjendomsmægler.Location = new System.Drawing.Point(524, 389);
            this.btn_SletEjendomsmægler.Name = "btn_SletEjendomsmægler";
            this.btn_SletEjendomsmægler.Size = new System.Drawing.Size(147, 23);
            this.btn_SletEjendomsmægler.TabIndex = 88;
            this.btn_SletEjendomsmægler.Text = "Slet Ejendomsmægler";
            this.btn_SletEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // btn_OpdaterEjendomsmægler
            // 
            this.btn_OpdaterEjendomsmægler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpdaterEjendomsmægler.Location = new System.Drawing.Point(372, 389);
            this.btn_OpdaterEjendomsmægler.Name = "btn_OpdaterEjendomsmægler";
            this.btn_OpdaterEjendomsmægler.Size = new System.Drawing.Size(147, 23);
            this.btn_OpdaterEjendomsmægler.TabIndex = 87;
            this.btn_OpdaterEjendomsmægler.Text = "Opdater Ejendomsmægler";
            this.btn_OpdaterEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // btn_HentEjendomsmægler
            // 
            this.btn_HentEjendomsmægler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_HentEjendomsmægler.Location = new System.Drawing.Point(220, 389);
            this.btn_HentEjendomsmægler.Name = "btn_HentEjendomsmægler";
            this.btn_HentEjendomsmægler.Size = new System.Drawing.Size(147, 23);
            this.btn_HentEjendomsmægler.TabIndex = 86;
            this.btn_HentEjendomsmægler.Text = "Hent Ejendomsmægler";
            this.btn_HentEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // btn_OpretEjendomsmægler
            // 
            this.btn_OpretEjendomsmægler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpretEjendomsmægler.Location = new System.Drawing.Point(68, 389);
            this.btn_OpretEjendomsmægler.Name = "btn_OpretEjendomsmægler";
            this.btn_OpretEjendomsmægler.Size = new System.Drawing.Size(147, 23);
            this.btn_OpretEjendomsmægler.TabIndex = 85;
            this.btn_OpretEjendomsmægler.Text = "Opret Ejendomsmægler";
            this.btn_OpretEjendomsmægler.UseVisualStyleBackColor = true;
            // 
            // Vej_txt
            // 
            this.Vej_txt.Location = new System.Drawing.Point(498, 101);
            this.Vej_txt.Name = "Vej_txt";
            this.Vej_txt.Size = new System.Drawing.Size(100, 20);
            this.Vej_txt.TabIndex = 84;
            // 
            // Postnummer_txt
            // 
            this.Postnummer_txt.Location = new System.Drawing.Point(498, 132);
            this.Postnummer_txt.Name = "Postnummer_txt";
            this.Postnummer_txt.Size = new System.Drawing.Size(100, 20);
            this.Postnummer_txt.TabIndex = 83;
            // 
            // Efternavn_txt
            // 
            this.Efternavn_txt.Location = new System.Drawing.Point(188, 132);
            this.Efternavn_txt.Name = "Efternavn_txt";
            this.Efternavn_txt.Size = new System.Drawing.Size(100, 20);
            this.Efternavn_txt.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(427, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Postnummer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(427, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Vej";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(427, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(427, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(123, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(123, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(123, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "CPR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "ID";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(498, 68);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(100, 20);
            this.Email_txt.TabIndex = 73;
            // 
            // Telefon_txt
            // 
            this.Telefon_txt.Location = new System.Drawing.Point(498, 40);
            this.Telefon_txt.Name = "Telefon_txt";
            this.Telefon_txt.Size = new System.Drawing.Size(100, 20);
            this.Telefon_txt.TabIndex = 72;
            // 
            // Fornavn_txt
            // 
            this.Fornavn_txt.Location = new System.Drawing.Point(188, 101);
            this.Fornavn_txt.Name = "Fornavn_txt";
            this.Fornavn_txt.Size = new System.Drawing.Size(100, 20);
            this.Fornavn_txt.TabIndex = 71;
            // 
            // CPR_txt
            // 
            this.CPR_txt.Location = new System.Drawing.Point(188, 68);
            this.CPR_txt.Name = "CPR_txt";
            this.CPR_txt.Size = new System.Drawing.Size(100, 20);
            this.CPR_txt.TabIndex = 70;
            // 
            // MæglerID_txt
            // 
            this.MæglerID_txt.Location = new System.Drawing.Point(188, 38);
            this.MæglerID_txt.Name = "MæglerID_txt";
            this.MæglerID_txt.Size = new System.Drawing.Size(100, 20);
            this.MæglerID_txt.TabIndex = 69;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmæglerToolStripMenuItem,
            this.sælgerToolStripMenuItem,
            this.køberToolStripMenuItem,
            this.boligToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 90;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejendomsmæglerToolStripMenuItem
            // 
            this.ejendomsmæglerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ejendomsmæglerToolStripMenuItem.Name = "ejendomsmæglerToolStripMenuItem";
            this.ejendomsmæglerToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ejendomsmæglerToolStripMenuItem.Text = "Ejendomsmægler";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sælgerToolStripMenuItem
            // 
            this.sælgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.sælgerToolStripMenuItem.Name = "sælgerToolStripMenuItem";
            this.sælgerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sælgerToolStripMenuItem.Text = "Sælger";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem1.Text = "Read";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // køberToolStripMenuItem
            // 
            this.køberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.readToolStripMenuItem2,
            this.updateToolStripMenuItem2,
            this.deleteToolStripMenuItem2});
            this.køberToolStripMenuItem.Name = "køberToolStripMenuItem";
            this.køberToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.køberToolStripMenuItem.Text = "Køber";
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem2.Text = "Create";
            // 
            // readToolStripMenuItem2
            // 
            this.readToolStripMenuItem2.Name = "readToolStripMenuItem2";
            this.readToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem2.Text = "Read";
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem2.Text = "Update";
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            // 
            // boligToolStripMenuItem
            // 
            this.boligToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem3,
            this.readToolStripMenuItem3,
            this.updateToolStripMenuItem3,
            this.deleteToolStripMenuItem3});
            this.boligToolStripMenuItem.Name = "boligToolStripMenuItem";
            this.boligToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.boligToolStripMenuItem.Text = "Bolig";
            // 
            // createToolStripMenuItem3
            // 
            this.createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            this.createToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem3.Text = "Create";
            // 
            // readToolStripMenuItem3
            // 
            this.readToolStripMenuItem3.Name = "readToolStripMenuItem3";
            this.readToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem3.Text = "Read";
            // 
            // updateToolStripMenuItem3
            // 
            this.updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            this.updateToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem3.Text = "Update";
            // 
            // deleteToolStripMenuItem3
            // 
            this.deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            this.deleteToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem3.Text = "Delete";
            // 
            // ejendomsmægler_bobedredbDataSet
            // 
            this.ejendomsmægler_bobedredbDataSet.DataSetName = "ejendomsmægler_bobedredbDataSet";
            this.ejendomsmægler_bobedredbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejendomsmæglerBindingSource
            // 
            this.ejendomsmæglerBindingSource.DataMember = "Ejendomsmægler";
            this.ejendomsmæglerBindingSource.DataSource = this.ejendomsmægler_bobedredbDataSet;
            // 
            // ejendomsmæglerTableAdapter
            // 
            this.ejendomsmæglerTableAdapter.ClearBeforeFill = true;
            // 
            // mæglerIDDataGridViewTextBoxColumn
            // 
            this.mæglerIDDataGridViewTextBoxColumn.DataPropertyName = "MæglerID";
            this.mæglerIDDataGridViewTextBoxColumn.HeaderText = "MæglerID";
            this.mæglerIDDataGridViewTextBoxColumn.Name = "mæglerIDDataGridViewTextBoxColumn";
            this.mæglerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPRDataGridViewTextBoxColumn
            // 
            this.cPRDataGridViewTextBoxColumn.DataPropertyName = "CPR";
            this.cPRDataGridViewTextBoxColumn.HeaderText = "CPR";
            this.cPRDataGridViewTextBoxColumn.Name = "cPRDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // fnavnDataGridViewTextBoxColumn
            // 
            this.fnavnDataGridViewTextBoxColumn.DataPropertyName = "Fnavn";
            this.fnavnDataGridViewTextBoxColumn.HeaderText = "Fnavn";
            this.fnavnDataGridViewTextBoxColumn.Name = "fnavnDataGridViewTextBoxColumn";
            // 
            // enavnDataGridViewTextBoxColumn
            // 
            this.enavnDataGridViewTextBoxColumn.DataPropertyName = "Enavn";
            this.enavnDataGridViewTextBoxColumn.HeaderText = "Enavn";
            this.enavnDataGridViewTextBoxColumn.Name = "enavnDataGridViewTextBoxColumn";
            // 
            // vejDataGridViewTextBoxColumn
            // 
            this.vejDataGridViewTextBoxColumn.DataPropertyName = "Vej";
            this.vejDataGridViewTextBoxColumn.HeaderText = "Vej";
            this.vejDataGridViewTextBoxColumn.Name = "vejDataGridViewTextBoxColumn";
            // 
            // postnummerDataGridViewTextBoxColumn
            // 
            this.postnummerDataGridViewTextBoxColumn.DataPropertyName = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.HeaderText = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.Name = "postnummerDataGridViewTextBoxColumn";
            // 
            // EjendomsmæglerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SletEjendomsmægler);
            this.Controls.Add(this.btn_OpdaterEjendomsmægler);
            this.Controls.Add(this.btn_HentEjendomsmægler);
            this.Controls.Add(this.btn_OpretEjendomsmægler);
            this.Controls.Add(this.Vej_txt);
            this.Controls.Add(this.Postnummer_txt);
            this.Controls.Add(this.Efternavn_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Telefon_txt);
            this.Controls.Add(this.Fornavn_txt);
            this.Controls.Add(this.CPR_txt);
            this.Controls.Add(this.MæglerID_txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EjendomsmæglerUI";
            this.Text = "EjendomsmæglerUI";
            this.Load += new System.EventHandler(this.EjendomsmæglerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmægler_bobedredbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejendomsmæglerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_SletEjendomsmægler;
        public System.Windows.Forms.Button btn_OpdaterEjendomsmægler;
        public System.Windows.Forms.Button btn_HentEjendomsmægler;
        public System.Windows.Forms.Button btn_OpretEjendomsmægler;
        private System.Windows.Forms.TextBox Vej_txt;
        private System.Windows.Forms.TextBox Postnummer_txt;
        private System.Windows.Forms.TextBox Efternavn_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Telefon_txt;
        private System.Windows.Forms.TextBox Fornavn_txt;
        private System.Windows.Forms.TextBox CPR_txt;
        private System.Windows.Forms.TextBox MæglerID_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmæglerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem boligToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem3;

        #region Get tekstbokse
        public System.Windows.Forms.TextBox GetMæglerIDTeksboks()
        {
            return MæglerID_txt;
        }
        #endregion

        private ejendomsmægler_bobedredbDataSet ejendomsmægler_bobedredbDataSet;
        private System.Windows.Forms.BindingSource ejendomsmæglerBindingSource;
        private ejendomsmægler_bobedredbDataSetTableAdapters.EjendomsmæglerTableAdapter ejendomsmæglerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mæglerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
    }
}