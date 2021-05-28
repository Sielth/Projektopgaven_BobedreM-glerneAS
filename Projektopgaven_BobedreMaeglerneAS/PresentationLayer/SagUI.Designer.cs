namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class SagUI
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
            this.sagnr_lbl = new System.Windows.Forms.Label();
            this.sagStatus_lbl = new System.Windows.Forms.Label();
            this.sagID_txt = new System.Windows.Forms.TextBox();
            this.sagStatus_cbox = new System.Windows.Forms.ComboBox();
            this.sag_boligID_lbl = new System.Windows.Forms.Label();
            this.sag_ejendomsmæglerID_lbl = new System.Windows.Forms.Label();
            this.sag_sælgerID_lbl = new System.Windows.Forms.Label();
            this.sag_boligID_cbox = new System.Windows.Forms.ComboBox();
            this.sag_sælgerID_cbox = new System.Windows.Forms.ComboBox();
            this.sag_ejendomsmæglerID_cbox = new System.Windows.Forms.ComboBox();
            this.btn_OpretSag = new System.Windows.Forms.Button();
            this.btn_HentSag = new System.Windows.Forms.Button();
            this.btn_OpdaterSag = new System.Windows.Forms.Button();
            this.btn_SletSag = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejendomsmæglerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.komTilÅbentHusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.udtrækStatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Clear_OpretSag = new System.Windows.Forms.Button();
            this.allowRedigering_btn = new System.Windows.Forms.Button();
            this.btn_Clear_HentSag = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sagnr_lbl
            // 
            this.sagnr_lbl.AutoSize = true;
            this.sagnr_lbl.Location = new System.Drawing.Point(16, 68);
            this.sagnr_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sagnr_lbl.Name = "sagnr_lbl";
            this.sagnr_lbl.Size = new System.Drawing.Size(53, 17);
            this.sagnr_lbl.TabIndex = 0;
            this.sagnr_lbl.Text = "SagsID";
            // 
            // sagStatus_lbl
            // 
            this.sagStatus_lbl.AutoSize = true;
            this.sagStatus_lbl.Location = new System.Drawing.Point(16, 121);
            this.sagStatus_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sagStatus_lbl.Name = "sagStatus_lbl";
            this.sagStatus_lbl.Size = new System.Drawing.Size(48, 17);
            this.sagStatus_lbl.TabIndex = 1;
            this.sagStatus_lbl.Text = "Status";
            // 
            // sagID_txt
            // 
            this.sagID_txt.Location = new System.Drawing.Point(103, 64);
            this.sagID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.sagID_txt.Name = "sagID_txt";
            this.sagID_txt.Size = new System.Drawing.Size(160, 22);
            this.sagID_txt.TabIndex = 2;
            this.sagID_txt.Validating += new System.ComponentModel.CancelEventHandler(this.sagID_txt_Validating);
            this.sagID_txt.Validated += new System.EventHandler(this.sagID_txt_Validated);
            // 
            // sagStatus_cbox
            // 
            this.sagStatus_cbox.FormattingEnabled = true;
            this.sagStatus_cbox.Items.AddRange(new object[] {
            "Åben",
            "Lukket (solgt bolig)",
            "Lukket (andre grunde)"});
            this.sagStatus_cbox.Location = new System.Drawing.Point(103, 116);
            this.sagStatus_cbox.Margin = new System.Windows.Forms.Padding(4);
            this.sagStatus_cbox.Name = "sagStatus_cbox";
            this.sagStatus_cbox.Size = new System.Drawing.Size(160, 24);
            this.sagStatus_cbox.TabIndex = 3;
            // 
            // sag_boligID_lbl
            // 
            this.sag_boligID_lbl.AutoSize = true;
            this.sag_boligID_lbl.Location = new System.Drawing.Point(357, 68);
            this.sag_boligID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sag_boligID_lbl.Name = "sag_boligID_lbl";
            this.sag_boligID_lbl.Size = new System.Drawing.Size(56, 17);
            this.sag_boligID_lbl.TabIndex = 4;
            this.sag_boligID_lbl.Text = "Bolig ID";
            // 
            // sag_ejendomsmæglerID_lbl
            // 
            this.sag_ejendomsmæglerID_lbl.AutoSize = true;
            this.sag_ejendomsmæglerID_lbl.Location = new System.Drawing.Point(715, 68);
            this.sag_ejendomsmæglerID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sag_ejendomsmæglerID_lbl.Name = "sag_ejendomsmæglerID_lbl";
            this.sag_ejendomsmæglerID_lbl.Size = new System.Drawing.Size(135, 17);
            this.sag_ejendomsmæglerID_lbl.TabIndex = 5;
            this.sag_ejendomsmæglerID_lbl.Text = "Ejendomsmægler ID";
            // 
            // sag_sælgerID_lbl
            // 
            this.sag_sælgerID_lbl.AutoSize = true;
            this.sag_sælgerID_lbl.Location = new System.Drawing.Point(549, 68);
            this.sag_sælgerID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sag_sælgerID_lbl.Name = "sag_sælgerID_lbl";
            this.sag_sælgerID_lbl.Size = new System.Drawing.Size(71, 17);
            this.sag_sælgerID_lbl.TabIndex = 6;
            this.sag_sælgerID_lbl.Text = "Sælger ID";
            // 
            // sag_boligID_cbox
            // 
            this.sag_boligID_cbox.FormattingEnabled = true;
            this.sag_boligID_cbox.Location = new System.Drawing.Point(301, 116);
            this.sag_boligID_cbox.Margin = new System.Windows.Forms.Padding(4);
            this.sag_boligID_cbox.Name = "sag_boligID_cbox";
            this.sag_boligID_cbox.Size = new System.Drawing.Size(160, 24);
            this.sag_boligID_cbox.TabIndex = 7;
            // 
            // sag_sælgerID_cbox
            // 
            this.sag_sælgerID_cbox.FormattingEnabled = true;
            this.sag_sælgerID_cbox.Location = new System.Drawing.Point(503, 116);
            this.sag_sælgerID_cbox.Margin = new System.Windows.Forms.Padding(4);
            this.sag_sælgerID_cbox.Name = "sag_sælgerID_cbox";
            this.sag_sælgerID_cbox.Size = new System.Drawing.Size(160, 24);
            this.sag_sælgerID_cbox.TabIndex = 8;
            // 
            // sag_ejendomsmæglerID_cbox
            // 
            this.sag_ejendomsmæglerID_cbox.FormattingEnabled = true;
            this.sag_ejendomsmæglerID_cbox.Location = new System.Drawing.Point(701, 117);
            this.sag_ejendomsmæglerID_cbox.Margin = new System.Windows.Forms.Padding(4);
            this.sag_ejendomsmæglerID_cbox.Name = "sag_ejendomsmæglerID_cbox";
            this.sag_ejendomsmæglerID_cbox.Size = new System.Drawing.Size(160, 24);
            this.sag_ejendomsmæglerID_cbox.TabIndex = 9;
            // 
            // btn_OpretSag
            // 
            this.btn_OpretSag.Location = new System.Drawing.Point(16, 169);
            this.btn_OpretSag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpretSag.Name = "btn_OpretSag";
            this.btn_OpretSag.Size = new System.Drawing.Size(100, 28);
            this.btn_OpretSag.TabIndex = 10;
            this.btn_OpretSag.Text = "Opret Sag";
            this.btn_OpretSag.UseVisualStyleBackColor = true;
            this.btn_OpretSag.Click += new System.EventHandler(this.btn_OpretSag_Click);
            // 
            // btn_HentSag
            // 
            this.btn_HentSag.Location = new System.Drawing.Point(16, 169);
            this.btn_HentSag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HentSag.Name = "btn_HentSag";
            this.btn_HentSag.Size = new System.Drawing.Size(100, 28);
            this.btn_HentSag.TabIndex = 11;
            this.btn_HentSag.Text = "Hent Sag";
            this.btn_HentSag.UseVisualStyleBackColor = true;
            this.btn_HentSag.Click += new System.EventHandler(this.btn_HentSag_Click);
            // 
            // btn_OpdaterSag
            // 
            this.btn_OpdaterSag.Location = new System.Drawing.Point(380, 169);
            this.btn_OpdaterSag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpdaterSag.Name = "btn_OpdaterSag";
            this.btn_OpdaterSag.Size = new System.Drawing.Size(140, 28);
            this.btn_OpdaterSag.TabIndex = 12;
            this.btn_OpdaterSag.Text = "Save Changes";
            this.btn_OpdaterSag.UseVisualStyleBackColor = true;
            this.btn_OpdaterSag.Click += new System.EventHandler(this.btn_OpdaterSag_Click);
            // 
            // btn_SletSag
            // 
            this.btn_SletSag.Location = new System.Drawing.Point(16, 169);
            this.btn_SletSag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SletSag.Name = "btn_SletSag";
            this.btn_SletSag.Size = new System.Drawing.Size(100, 28);
            this.btn_SletSag.TabIndex = 13;
            this.btn_SletSag.Text = "Slet Sag";
            this.btn_SletSag.UseVisualStyleBackColor = true;
            this.btn_SletSag.Click += new System.EventHandler(this.btn_SletSag_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmæglerToolStripMenuItem,
            this.sælgerToolStripMenuItem,
            this.køberToolStripMenuItem,
            this.boligToolStripMenuItem,
            this.sagToolStripMenuItem,
            this.handelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejendomsmæglerToolStripMenuItem
            // 
            this.ejendomsmæglerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmægler_createToolStripMenuItem,
            this.ejendomsmægler_readToolStripMenuItem,
            this.ejendomsmægler_deleteToolStripMenuItem});
            this.ejendomsmæglerToolStripMenuItem.Name = "ejendomsmæglerToolStripMenuItem";
            this.ejendomsmæglerToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.ejendomsmæglerToolStripMenuItem.Text = "Ejendomsmægler";
            // 
            // ejendomsmægler_createToolStripMenuItem
            // 
            this.ejendomsmægler_createToolStripMenuItem.Name = "ejendomsmægler_createToolStripMenuItem";
            this.ejendomsmægler_createToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.ejendomsmægler_createToolStripMenuItem.Text = "Opret en ejendomsmægler";
            this.ejendomsmægler_createToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_createToolStripMenuItem_Click);
            // 
            // ejendomsmægler_readToolStripMenuItem
            // 
            this.ejendomsmægler_readToolStripMenuItem.Name = "ejendomsmægler_readToolStripMenuItem";
            this.ejendomsmægler_readToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.ejendomsmægler_readToolStripMenuItem.Text = "Hent og opdater en ejendomsmægler";
            this.ejendomsmægler_readToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_readToolStripMenuItem_Click);
            // 
            // ejendomsmægler_deleteToolStripMenuItem
            // 
            this.ejendomsmægler_deleteToolStripMenuItem.Name = "ejendomsmægler_deleteToolStripMenuItem";
            this.ejendomsmægler_deleteToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.ejendomsmægler_deleteToolStripMenuItem.Text = "Slet en ejendomsmægler";
            this.ejendomsmægler_deleteToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_deleteToolStripMenuItem_Click);
            // 
            // sælgerToolStripMenuItem
            // 
            this.sælgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sælger_createToolStripMenuItem,
            this.sælger_readToolStripMenuItem,
            this.sælger_deleteToolStripMenuItem});
            this.sælgerToolStripMenuItem.Name = "sælgerToolStripMenuItem";
            this.sælgerToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.sælgerToolStripMenuItem.Text = "Sælger";
            // 
            // sælger_createToolStripMenuItem
            // 
            this.sælger_createToolStripMenuItem.Name = "sælger_createToolStripMenuItem";
            this.sælger_createToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.sælger_createToolStripMenuItem.Text = "Opret Sælger";
            this.sælger_createToolStripMenuItem.Click += new System.EventHandler(this.sælger_createToolStripMenuItem_Click);
            // 
            // sælger_readToolStripMenuItem
            // 
            this.sælger_readToolStripMenuItem.Name = "sælger_readToolStripMenuItem";
            this.sælger_readToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.sælger_readToolStripMenuItem.Text = "Find og Opdater Sælger";
            this.sælger_readToolStripMenuItem.Click += new System.EventHandler(this.sælger_readToolStripMenuItem_Click);
            // 
            // sælger_deleteToolStripMenuItem
            // 
            this.sælger_deleteToolStripMenuItem.Name = "sælger_deleteToolStripMenuItem";
            this.sælger_deleteToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.sælger_deleteToolStripMenuItem.Text = "Slet Sælger";
            this.sælger_deleteToolStripMenuItem.Click += new System.EventHandler(this.sælger_deleteToolStripMenuItem_Click);
            // 
            // køberToolStripMenuItem
            // 
            this.køberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.køber_createToolStripMenuItem1,
            this.køber_readToolStripMenuItem1,
            this.køber_deleteToolStripMenuItem1});
            this.køberToolStripMenuItem.Name = "køberToolStripMenuItem";
            this.køberToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.køberToolStripMenuItem.Text = "Køber";
            // 
            // køber_createToolStripMenuItem1
            // 
            this.køber_createToolStripMenuItem1.Name = "køber_createToolStripMenuItem1";
            this.køber_createToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.køber_createToolStripMenuItem1.Text = "Opret Køber";
            this.køber_createToolStripMenuItem1.Click += new System.EventHandler(this.køber_createToolStripMenuItem1_Click);
            // 
            // køber_readToolStripMenuItem1
            // 
            this.køber_readToolStripMenuItem1.Name = "køber_readToolStripMenuItem1";
            this.køber_readToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.køber_readToolStripMenuItem1.Text = "Find og Opdater Køber";
            this.køber_readToolStripMenuItem1.Click += new System.EventHandler(this.køber_readToolStripMenuItem1_Click);
            // 
            // køber_deleteToolStripMenuItem1
            // 
            this.køber_deleteToolStripMenuItem1.Name = "køber_deleteToolStripMenuItem1";
            this.køber_deleteToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.køber_deleteToolStripMenuItem1.Text = "Slet Køber";
            this.køber_deleteToolStripMenuItem1.Click += new System.EventHandler(this.køber_deleteToolStripMenuItem1_Click);
            // 
            // boligToolStripMenuItem
            // 
            this.boligToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolig_createToolStripMenuItem2,
            this.bolig_readToolStripMenuItem2,
            this.bolig_deleteToolStripMenuItem2,
            this.komTilÅbentHusToolStripMenuItem});
            this.boligToolStripMenuItem.Name = "boligToolStripMenuItem";
            this.boligToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.boligToolStripMenuItem.Text = "Bolig";
            // 
            // bolig_createToolStripMenuItem2
            // 
            this.bolig_createToolStripMenuItem2.Name = "bolig_createToolStripMenuItem2";
            this.bolig_createToolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.bolig_createToolStripMenuItem2.Text = "Opret en ny Bolig";
            this.bolig_createToolStripMenuItem2.Click += new System.EventHandler(this.bolig_createToolStripMenuItem2_Click);
            // 
            // bolig_readToolStripMenuItem2
            // 
            this.bolig_readToolStripMenuItem2.Name = "bolig_readToolStripMenuItem2";
            this.bolig_readToolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.bolig_readToolStripMenuItem2.Text = "Hent og Opdater";
            this.bolig_readToolStripMenuItem2.Click += new System.EventHandler(this.bolig_readToolStripMenuItem2_Click);
            // 
            // bolig_deleteToolStripMenuItem2
            // 
            this.bolig_deleteToolStripMenuItem2.Name = "bolig_deleteToolStripMenuItem2";
            this.bolig_deleteToolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.bolig_deleteToolStripMenuItem2.Text = "Slet en Bolig";
            this.bolig_deleteToolStripMenuItem2.Click += new System.EventHandler(this.bolig_deleteToolStripMenuItem2_Click);
            // 
            // komTilÅbentHusToolStripMenuItem
            // 
            this.komTilÅbentHusToolStripMenuItem.Name = "komTilÅbentHusToolStripMenuItem";
            this.komTilÅbentHusToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.komTilÅbentHusToolStripMenuItem.Text = "Kom til Åbent Hus!";
            this.komTilÅbentHusToolStripMenuItem.Click += new System.EventHandler(this.komTilÅbentHusToolStripMenuItem_Click);
            // 
            // sagToolStripMenuItem
            // 
            this.sagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sagToolStripMenuItem.Name = "sagToolStripMenuItem";
            this.sagToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sagToolStripMenuItem.Text = "Sag";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.createToolStripMenuItem.Text = "Opret en ny Sag";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.readToolStripMenuItem.Text = "Hent og Opdater";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.deleteToolStripMenuItem.Text = "Slet en Sag";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // handelToolStripMenuItem
            // 
            this.handelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.udtrækStatistikToolStripMenuItem});
            this.handelToolStripMenuItem.Name = "handelToolStripMenuItem";
            this.handelToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.handelToolStripMenuItem.Text = "Handel";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.createToolStripMenuItem1.Text = "Opret Handel";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.readToolStripMenuItem1.Text = "Find og Opdater Handel";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.deleteToolStripMenuItem1.Text = "Slet Handel";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // udtrækStatistikToolStripMenuItem
            // 
            this.udtrækStatistikToolStripMenuItem.Name = "udtrækStatistikToolStripMenuItem";
            this.udtrækStatistikToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.udtrækStatistikToolStripMenuItem.Text = "Udtræk Statistik";
            this.udtrækStatistikToolStripMenuItem.Click += new System.EventHandler(this.udtrækStatistikToolStripMenuItem_Click);
            // 
            // btn_Clear_OpretSag
            // 
            this.btn_Clear_OpretSag.Location = new System.Drawing.Point(124, 169);
            this.btn_Clear_OpretSag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear_OpretSag.Name = "btn_Clear_OpretSag";
            this.btn_Clear_OpretSag.Size = new System.Drawing.Size(100, 28);
            this.btn_Clear_OpretSag.TabIndex = 19;
            this.btn_Clear_OpretSag.Text = "Clear";
            this.btn_Clear_OpretSag.UseVisualStyleBackColor = true;
            this.btn_Clear_OpretSag.Click += new System.EventHandler(this.btn_Clear_OpretSag_Click);
            // 
            // allowRedigering_btn
            // 
            this.allowRedigering_btn.Location = new System.Drawing.Point(232, 169);
            this.allowRedigering_btn.Margin = new System.Windows.Forms.Padding(4);
            this.allowRedigering_btn.Name = "allowRedigering_btn";
            this.allowRedigering_btn.Size = new System.Drawing.Size(140, 28);
            this.allowRedigering_btn.TabIndex = 20;
            this.allowRedigering_btn.Text = "Allow Redigering";
            this.allowRedigering_btn.UseVisualStyleBackColor = true;
            this.allowRedigering_btn.Click += new System.EventHandler(this.allowRedigering_btn_Click);
            // 
            // btn_Clear_HentSag
            // 
            this.btn_Clear_HentSag.Location = new System.Drawing.Point(124, 169);
            this.btn_Clear_HentSag.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear_HentSag.Name = "btn_Clear_HentSag";
            this.btn_Clear_HentSag.Size = new System.Drawing.Size(100, 28);
            this.btn_Clear_HentSag.TabIndex = 21;
            this.btn_Clear_HentSag.Text = "Clear";
            this.btn_Clear_HentSag.UseVisualStyleBackColor = true;
            this.btn_Clear_HentSag.Click += new System.EventHandler(this.btn_Clear_HentSag_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(915, 315);
            this.dataGridView1.TabIndex = 22;
            // 
            // SagUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Clear_HentSag);
            this.Controls.Add(this.allowRedigering_btn);
            this.Controls.Add(this.btn_Clear_OpretSag);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_SletSag);
            this.Controls.Add(this.btn_OpdaterSag);
            this.Controls.Add(this.btn_HentSag);
            this.Controls.Add(this.btn_OpretSag);
            this.Controls.Add(this.sag_ejendomsmæglerID_cbox);
            this.Controls.Add(this.sag_sælgerID_cbox);
            this.Controls.Add(this.sag_boligID_cbox);
            this.Controls.Add(this.sag_sælgerID_lbl);
            this.Controls.Add(this.sag_ejendomsmæglerID_lbl);
            this.Controls.Add(this.sag_boligID_lbl);
            this.Controls.Add(this.sagStatus_cbox);
            this.Controls.Add(this.sagID_txt);
            this.Controls.Add(this.sagStatus_lbl);
            this.Controls.Add(this.sagnr_lbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SagUI";
            this.Text = "SagUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sagnr_lbl;
        private System.Windows.Forms.Label sagStatus_lbl;
        private System.Windows.Forms.TextBox sagID_txt;
        private System.Windows.Forms.ComboBox sagStatus_cbox;
        private System.Windows.Forms.Label sag_boligID_lbl;
        private System.Windows.Forms.Label sag_ejendomsmæglerID_lbl;
        private System.Windows.Forms.Label sag_sælgerID_lbl;
        private System.Windows.Forms.ComboBox sag_boligID_cbox;
        private System.Windows.Forms.ComboBox sag_sælgerID_cbox;
        private System.Windows.Forms.ComboBox sag_ejendomsmæglerID_cbox;
        private System.Windows.Forms.Button btn_OpretSag;
        private System.Windows.Forms.Button btn_HentSag;
        private System.Windows.Forms.Button btn_OpdaterSag;
        private System.Windows.Forms.Button btn_SletSag;


        #region Get knapper
        public System.Windows.Forms.Button GetOpretSagKnap()
        {
            return btn_OpretSag;
        }

        public System.Windows.Forms.Button GetHentSagKnap()
        {
            return btn_HentSag;
        }

        public System.Windows.Forms.Button GetOpdaterSagKnap()
        {
            return btn_OpdaterSag;
        }

        public System.Windows.Forms.Button GetSletSagKnap()
        {
            return btn_SletSag;
        }

        public System.Windows.Forms.Button GetAllowRedigeringSagKnap()
        {
            return allowRedigering_btn;
        }

        public System.Windows.Forms.Button GetClearOpretSag()
        {
            return btn_Clear_OpretSag;
        }

        public System.Windows.Forms.Button GetClearHentKnap()
        {
            return btn_Clear_HentSag;
        }
        #endregion

        #region Get teksbokse
        public System.Windows.Forms.TextBox GetSagsIDTekstboks()
        {
            return sagID_txt;
        }

        public System.Windows.Forms.ComboBox GetSagStatusComboboks()
        {
            return sagStatus_cbox;
        }

        public System.Windows.Forms.ComboBox GetSagBoligIDComboboks()
        {
            return sag_boligID_cbox;
        }

        public System.Windows.Forms.ComboBox GetSagSælgerIDComboboks()
        {
            return sag_sælgerID_cbox;
        }

        public System.Windows.Forms.ComboBox GetSagMæglerIDComboboks()
        {
            return sag_ejendomsmæglerID_cbox;
        }

        #endregion

        public void DisableAll()
        {
            sagID_txt.Enabled = false;
            sagStatus_cbox.Enabled = false;
            sag_boligID_cbox.Enabled = false;
            sag_sælgerID_cbox.Enabled = false;
            sag_ejendomsmæglerID_cbox.Enabled = false;
        }

        public void EnableAll()
        {
            sagID_txt.Enabled = true;
            sagStatus_cbox.Enabled = true;
            sag_boligID_cbox.Enabled = true;
            sag_sælgerID_cbox.Enabled = true;
            sag_ejendomsmæglerID_cbox.Enabled = true;
        }

        public void ClearAll()
        {
            sagID_txt.Clear();
            sagStatus_cbox.SelectedItem = null;
            sagStatus_cbox.Text = null;
            sag_boligID_cbox.SelectedItem = null;
            sag_boligID_cbox.Text = null;
            sag_sælgerID_cbox.SelectedItem = null;
            sag_sælgerID_cbox.Text = null;
            sag_ejendomsmæglerID_cbox.SelectedItem = null;
            sag_ejendomsmæglerID_cbox.Text = null;
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmæglerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køber_createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boligToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolig_createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komTilÅbentHusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button btn_Clear_OpretSag;
        private System.Windows.Forms.Button allowRedigering_btn;
        private System.Windows.Forms.Button btn_Clear_HentSag;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem udtrækStatistikToolStripMenuItem;
    }
}