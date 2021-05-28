
namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class HandelUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        public System.Windows.Forms.DateTimePicker GetStartDate()
        {
            return dateTimePicker1;
        }
        public System.Windows.Forms.DateTimePicker GetEndDate()
        {
            return dateTimePicker3;
        }
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
            this.handelSalgsID_cbox = new System.Windows.Forms.ComboBox();
            this.handelKøberID_cbox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.handelSalgspris_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_oprethandel = new System.Windows.Forms.Button();
            this.btn_findhandel = new System.Windows.Forms.Button();
            this.btn_opdaterhandel = new System.Windows.Forms.Button();
            this.btn_slethandel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.handelID_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.statistik_solgteboliger_lbox = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.stats_lbl = new System.Windows.Forms.Label();
            this.udtrækstat_lbl1 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl2 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl3 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl4 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl7 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl6 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl5 = new System.Windows.Forms.Label();
            this.udtrækstat_lbl8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allowRedigering_btn = new System.Windows.Forms.Button();
            this.clearOpret_btn = new System.Windows.Forms.Button();
            this.clearOpdater_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // handelSalgsID_cbox
            // 
            this.handelSalgsID_cbox.FormattingEnabled = true;
            this.handelSalgsID_cbox.Location = new System.Drawing.Point(120, 133);
            this.handelSalgsID_cbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handelSalgsID_cbox.Name = "handelSalgsID_cbox";
            this.handelSalgsID_cbox.Size = new System.Drawing.Size(121, 24);
            this.handelSalgsID_cbox.TabIndex = 0;
            // 
            // handelKøberID_cbox
            // 
            this.handelKøberID_cbox.FormattingEnabled = true;
            this.handelKøberID_cbox.Location = new System.Drawing.Point(120, 164);
            this.handelKøberID_cbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handelKøberID_cbox.Name = "handelKøberID_cbox";
            this.handelKøberID_cbox.Size = new System.Drawing.Size(121, 24);
            this.handelKøberID_cbox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 60);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            // 
            // handelSalgspris_txt
            // 
            this.handelSalgspris_txt.Location = new System.Drawing.Point(120, 103);
            this.handelSalgspris_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handelSalgspris_txt.Name = "handelSalgspris_txt";
            this.handelSalgspris_txt.Size = new System.Drawing.Size(121, 22);
            this.handelSalgspris_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SagsID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salgspris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "KøberID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Udtræk Statistik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_oprethandel
            // 
            this.btn_oprethandel.Location = new System.Drawing.Point(627, 74);
            this.btn_oprethandel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_oprethandel.Name = "btn_oprethandel";
            this.btn_oprethandel.Size = new System.Drawing.Size(141, 30);
            this.btn_oprethandel.TabIndex = 10;
            this.btn_oprethandel.Text = "Opret handel";
            this.btn_oprethandel.UseVisualStyleBackColor = true;
            this.btn_oprethandel.Click += new System.EventHandler(this.btn_oprethandel_Click);
            // 
            // btn_findhandel
            // 
            this.btn_findhandel.Location = new System.Drawing.Point(470, 60);
            this.btn_findhandel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_findhandel.Name = "btn_findhandel";
            this.btn_findhandel.Size = new System.Drawing.Size(141, 30);
            this.btn_findhandel.TabIndex = 11;
            this.btn_findhandel.Text = "Find handel";
            this.btn_findhandel.UseVisualStyleBackColor = true;
            this.btn_findhandel.Click += new System.EventHandler(this.btn_findhandel_Click);
            // 
            // btn_opdaterhandel
            // 
            this.btn_opdaterhandel.Location = new System.Drawing.Point(470, 146);
            this.btn_opdaterhandel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_opdaterhandel.Name = "btn_opdaterhandel";
            this.btn_opdaterhandel.Size = new System.Drawing.Size(141, 30);
            this.btn_opdaterhandel.TabIndex = 12;
            this.btn_opdaterhandel.Text = "Opdater handel";
            this.btn_opdaterhandel.UseVisualStyleBackColor = true;
            this.btn_opdaterhandel.Click += new System.EventHandler(this.btn_opdaterhandel_Click);
            // 
            // btn_slethandel
            // 
            this.btn_slethandel.Location = new System.Drawing.Point(470, 60);
            this.btn_slethandel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_slethandel.Name = "btn_slethandel";
            this.btn_slethandel.Size = new System.Drawing.Size(141, 30);
            this.btn_slethandel.TabIndex = 13;
            this.btn_slethandel.Text = "Slet handel";
            this.btn_slethandel.UseVisualStyleBackColor = true;
            this.btn_slethandel.Click += new System.EventHandler(this.btn_slethandel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "HandelID";
            // 
            // handelID_txt
            // 
            this.handelID_txt.Location = new System.Drawing.Point(120, 74);
            this.handelID_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.handelID_txt.Name = "handelID_txt";
            this.handelID_txt.Size = new System.Drawing.Size(121, 22);
            this.handelID_txt.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(45, 270);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 10;
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
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 16;
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
            this.sælger_createToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sælger_createToolStripMenuItem.Text = "Opret en sælger";
            this.sælger_createToolStripMenuItem.Click += new System.EventHandler(this.sælger_createToolStripMenuItem_Click);
            // 
            // sælger_readToolStripMenuItem
            // 
            this.sælger_readToolStripMenuItem.Name = "sælger_readToolStripMenuItem";
            this.sælger_readToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sælger_readToolStripMenuItem.Text = "Hent og opdater en sælger";
            this.sælger_readToolStripMenuItem.Click += new System.EventHandler(this.sælger_readToolStripMenuItem_Click);
            // 
            // sælger_deleteToolStripMenuItem
            // 
            this.sælger_deleteToolStripMenuItem.Name = "sælger_deleteToolStripMenuItem";
            this.sælger_deleteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sælger_deleteToolStripMenuItem.Text = "Slet en sælger";
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
            this.bolig_createToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.bolig_createToolStripMenuItem2.Text = "Opret en ny Bolig";
            this.bolig_createToolStripMenuItem2.Click += new System.EventHandler(this.bolig_createToolStripMenuItem2_Click);
            // 
            // bolig_readToolStripMenuItem2
            // 
            this.bolig_readToolStripMenuItem2.Name = "bolig_readToolStripMenuItem2";
            this.bolig_readToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.bolig_readToolStripMenuItem2.Text = "Hent og Opdater";
            this.bolig_readToolStripMenuItem2.Click += new System.EventHandler(this.bolig_readToolStripMenuItem2_Click);
            // 
            // bolig_deleteToolStripMenuItem2
            // 
            this.bolig_deleteToolStripMenuItem2.Name = "bolig_deleteToolStripMenuItem2";
            this.bolig_deleteToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.bolig_deleteToolStripMenuItem2.Text = "Slet en Bolig";
            this.bolig_deleteToolStripMenuItem2.Click += new System.EventHandler(this.bolig_deleteToolStripMenuItem2_Click);
            // 
            // komTilÅbentHusToolStripMenuItem
            // 
            this.komTilÅbentHusToolStripMenuItem.Name = "komTilÅbentHusToolStripMenuItem";
            this.komTilÅbentHusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Opret en ny Sag";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readToolStripMenuItem.Text = "Hent og Opdater";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.udtrækStatistikToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.udtrækStatistikToolStripMenuItem.Text = "Udtræk Statistik";
            this.udtrækStatistikToolStripMenuItem.Click += new System.EventHandler(this.udtrækStatistikToolStripMenuItem_Click_1);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Location = new System.Drawing.Point(349, 103);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 17;
            // 
            // statistik_solgteboliger_lbox
            // 
            this.statistik_solgteboliger_lbox.FormattingEnabled = true;
            this.statistik_solgteboliger_lbox.ItemHeight = 16;
            this.statistik_solgteboliger_lbox.Location = new System.Drawing.Point(16, 270);
            this.statistik_solgteboliger_lbox.Margin = new System.Windows.Forms.Padding(4);
            this.statistik_solgteboliger_lbox.Name = "statistik_solgteboliger_lbox";
            this.statistik_solgteboliger_lbox.Size = new System.Drawing.Size(533, 340);
            this.statistik_solgteboliger_lbox.TabIndex = 18;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(627, 465);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(141, 28);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // stats_lbl
            // 
            this.stats_lbl.AutoSize = true;
            this.stats_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.stats_lbl.ForeColor = System.Drawing.Color.Orange;
            this.stats_lbl.Location = new System.Drawing.Point(12, 229);
            this.stats_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stats_lbl.Name = "stats_lbl";
            this.stats_lbl.Size = new System.Drawing.Size(728, 20);
            this.stats_lbl.TabIndex = 20;
            this.stats_lbl.Text = "Statistik_________________________________________________________________";
            // 
            // udtrækstat_lbl1
            // 
            this.udtrækstat_lbl1.AutoSize = true;
            this.udtrækstat_lbl1.Location = new System.Drawing.Point(631, 270);
            this.udtrækstat_lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl1.Name = "udtrækstat_lbl1";
            this.udtrækstat_lbl1.Size = new System.Drawing.Size(136, 17);
            this.udtrækstat_lbl1.TabIndex = 21;
            this.udtrækstat_lbl1.Text = "Tryk denne knap for";
            // 
            // udtrækstat_lbl2
            // 
            this.udtrækstat_lbl2.AutoSize = true;
            this.udtrækstat_lbl2.Location = new System.Drawing.Point(599, 286);
            this.udtrækstat_lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl2.Name = "udtrækstat_lbl2";
            this.udtrækstat_lbl2.Size = new System.Drawing.Size(170, 17);
            this.udtrækstat_lbl2.TabIndex = 22;
            this.udtrækstat_lbl2.Text = "at få vist de solgte boliger";
            // 
            // udtrækstat_lbl3
            // 
            this.udtrækstat_lbl3.AutoSize = true;
            this.udtrækstat_lbl3.Location = new System.Drawing.Point(632, 302);
            this.udtrækstat_lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl3.Name = "udtrækstat_lbl3";
            this.udtrækstat_lbl3.Size = new System.Drawing.Size(137, 17);
            this.udtrækstat_lbl3.TabIndex = 23;
            this.udtrækstat_lbl3.Text = "i en bestemt periode";
            // 
            // udtrækstat_lbl4
            // 
            this.udtrækstat_lbl4.AutoSize = true;
            this.udtrækstat_lbl4.Location = new System.Drawing.Point(617, 318);
            this.udtrækstat_lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl4.Name = "udtrækstat_lbl4";
            this.udtrækstat_lbl4.Size = new System.Drawing.Size(150, 17);
            this.udtrækstat_lbl4.TabIndex = 24;
            this.udtrækstat_lbl4.Text = "over i boxen til venstre";
            // 
            // udtrækstat_lbl7
            // 
            this.udtrækstat_lbl7.AutoSize = true;
            this.udtrækstat_lbl7.Location = new System.Drawing.Point(632, 430);
            this.udtrækstat_lbl7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl7.Name = "udtrækstat_lbl7";
            this.udtrækstat_lbl7.Size = new System.Drawing.Size(137, 17);
            this.udtrækstat_lbl7.TabIndex = 27;
            this.udtrækstat_lbl7.Text = "i en bestemt periode";
            // 
            // udtrækstat_lbl6
            // 
            this.udtrækstat_lbl6.AutoSize = true;
            this.udtrækstat_lbl6.Location = new System.Drawing.Point(589, 414);
            this.udtrækstat_lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl6.Name = "udtrækstat_lbl6";
            this.udtrækstat_lbl6.Size = new System.Drawing.Size(180, 17);
            this.udtrækstat_lbl6.TabIndex = 26;
            this.udtrækstat_lbl6.Text = "at få gemt de solgte boliger";
            // 
            // udtrækstat_lbl5
            // 
            this.udtrækstat_lbl5.AutoSize = true;
            this.udtrækstat_lbl5.Location = new System.Drawing.Point(631, 398);
            this.udtrækstat_lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl5.Name = "udtrækstat_lbl5";
            this.udtrækstat_lbl5.Size = new System.Drawing.Size(136, 17);
            this.udtrækstat_lbl5.TabIndex = 25;
            this.udtrækstat_lbl5.Text = "Tryk denne knap for";
            // 
            // udtrækstat_lbl8
            // 
            this.udtrækstat_lbl8.AutoSize = true;
            this.udtrækstat_lbl8.Location = new System.Drawing.Point(696, 446);
            this.udtrækstat_lbl8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udtrækstat_lbl8.Name = "udtrækstat_lbl8";
            this.udtrækstat_lbl8.Size = new System.Drawing.Size(71, 17);
            this.udtrækstat_lbl8.TabIndex = 28;
            this.udtrækstat_lbl8.Text = "i en text fil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(752, 382);
            this.dataGridView1.TabIndex = 29;
            // 
            // allowRedigering_btn
            // 
            this.allowRedigering_btn.Location = new System.Drawing.Point(470, 118);
            this.allowRedigering_btn.Name = "allowRedigering_btn";
            this.allowRedigering_btn.Size = new System.Drawing.Size(106, 23);
            this.allowRedigering_btn.TabIndex = 30;
            this.allowRedigering_btn.Text = "Allow redigering";
            this.allowRedigering_btn.UseVisualStyleBackColor = true;
            this.allowRedigering_btn.Click += new System.EventHandler(this.allowRedigering_btn_Click);
            // 
            // clearOpret_btn
            // 
            this.clearOpret_btn.Location = new System.Drawing.Point(470, 89);
            this.clearOpret_btn.Name = "clearOpret_btn";
            this.clearOpret_btn.Size = new System.Drawing.Size(106, 23);
            this.clearOpret_btn.TabIndex = 31;
            this.clearOpret_btn.Text = "Clear";
            this.clearOpret_btn.UseVisualStyleBackColor = true;
            this.clearOpret_btn.Click += new System.EventHandler(this.clearOpret_btn_Click);
            // 
            // clearOpdater_btn
            // 
            this.clearOpdater_btn.Location = new System.Drawing.Point(470, 89);
            this.clearOpdater_btn.Name = "clearOpdater_btn";
            this.clearOpdater_btn.Size = new System.Drawing.Size(106, 23);
            this.clearOpdater_btn.TabIndex = 32;
            this.clearOpdater_btn.Text = "Clear";
            this.clearOpdater_btn.UseVisualStyleBackColor = true;
            this.clearOpdater_btn.Click += new System.EventHandler(this.clearOpdater_btn_Click);
            // 
            // HandelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 509);
            this.Controls.Add(this.clearOpdater_btn);
            this.Controls.Add(this.clearOpret_btn);
            this.Controls.Add(this.allowRedigering_btn);
            this.Controls.Add(this.udtrækstat_lbl8);
            this.Controls.Add(this.udtrækstat_lbl7);
            this.Controls.Add(this.udtrækstat_lbl6);
            this.Controls.Add(this.udtrækstat_lbl5);
            this.Controls.Add(this.udtrækstat_lbl4);
            this.Controls.Add(this.udtrækstat_lbl3);
            this.Controls.Add(this.udtrækstat_lbl2);
            this.Controls.Add(this.udtrækstat_lbl1);
            this.Controls.Add(this.stats_lbl);
            this.Controls.Add(this.save);
            this.Controls.Add(this.statistik_solgteboliger_lbox);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.handelID_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_slethandel);
            this.Controls.Add(this.btn_opdaterhandel);
            this.Controls.Add(this.btn_findhandel);
            this.Controls.Add(this.btn_oprethandel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handelSalgspris_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.handelKøberID_cbox);
            this.Controls.Add(this.handelSalgsID_cbox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HandelUI";
            this.Text = "HandelUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox handelSalgsID_cbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox handelSalgspris_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_oprethandel;
        private System.Windows.Forms.Button btn_findhandel;
        private System.Windows.Forms.Button btn_opdaterhandel;
        private System.Windows.Forms.Button btn_slethandel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox handelID_txt;
        private System.Windows.Forms.ComboBox handelKøberID_cbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
        private System.Windows.Forms.ToolStripMenuItem komTilÅbentHusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ListBox statistik_solgteboliger_lbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ToolStripMenuItem udtrækStatistikToolStripMenuItem;
        private System.Windows.Forms.Label stats_lbl;
        private System.Windows.Forms.Label udtrækstat_lbl1;
        private System.Windows.Forms.Label udtrækstat_lbl2;
        private System.Windows.Forms.Label udtrækstat_lbl3;
        private System.Windows.Forms.Label udtrækstat_lbl4;
        private System.Windows.Forms.Label udtrækstat_lbl7;
        private System.Windows.Forms.Label udtrækstat_lbl6;
        private System.Windows.Forms.Label udtrækstat_lbl5;
        private System.Windows.Forms.Label udtrækstat_lbl8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button allowRedigering_btn;
        private System.Windows.Forms.Button clearOpret_btn;
        private System.Windows.Forms.Button clearOpdater_btn;

        #region Get knapper
        public System.Windows.Forms.Button GetOpretHandelKnap()
        {
            return btn_oprethandel;
        }

        public System.Windows.Forms.Button GetFindHandelKnap()
        {
            return btn_findhandel;
        }

        public System.Windows.Forms.Button GetStatistikKnap()
        {
            return button1;
        }

        public System.Windows.Forms.Button GetOpdaterHandelKnap()
        {
            return btn_opdaterhandel;
        }

        public System.Windows.Forms.Button GetSletHandelKnap()
        {
            return btn_slethandel;
        }

        public System.Windows.Forms.Button GetSaveStatistikKnap()
        {
            return save;
        }

        public System.Windows.Forms.Button GetClearOpdater()
        {
            return clearOpdater_btn;
        }

        public System.Windows.Forms.Button GetClearOpret()
        {
            return clearOpret_btn;
        }

        public System.Windows.Forms.Button GetAllowRedigering()
        {
            return allowRedigering_btn;
        }
        #endregion

        #region Get tekstbokse og combobokse
        public System.Windows.Forms.TextBox GetHandelIDTekstboks()
        {
            return handelID_txt;
        }

        public System.Windows.Forms.DateTimePicker GetHandelsdatoDatetime()
        {
            return dateTimePicker1;
        }

        public System.Windows.Forms.DateTimePicker GetHandelsslutdatoDatetime()
        {
            return dateTimePicker3;
        }

        public System.Windows.Forms.TextBox GetHandelSalgsprisTekstboks()
        {
            return handelSalgspris_txt;
        }

        public System.Windows.Forms.ComboBox GetHandelSagsIDComboboks()
        {
            return handelSalgsID_cbox;
        }

        public System.Windows.Forms.ComboBox GetHandelKøberIDComboboks()
        {
            return handelKøberID_cbox;
        }
        #endregion

        #region GetListBox
        public System.Windows.Forms.ListBox GetStatistikListbox()
        {
            return statistik_solgteboliger_lbox;
        }
        #endregion

        #region Get Labels
        public System.Windows.Forms.Label Get_udtrækstat_lbl1() { return udtrækstat_lbl1; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl2() { return udtrækstat_lbl2; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl3() { return udtrækstat_lbl3; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl4() { return udtrækstat_lbl4; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl7() { return udtrækstat_lbl7; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl6() { return udtrækstat_lbl6; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl5() { return udtrækstat_lbl5; }
        public System.Windows.Forms.Label Get_udtrækstat_lbl8() { return udtrækstat_lbl8; }
        public System.Windows.Forms.Label Get_stats_lbl() { return stats_lbl; }
        public System.Windows.Forms.DataGridView GetGridView() { return dataGridView1; }
        #endregion

        public void ClearAll()
        {
            handelID_txt.Text = null;
            handelSalgspris_txt.Text = null;
            handelSalgsID_cbox.SelectedItem = null;
            handelKøberID_cbox.SelectedItem = null;
        }

        public void EnableAll()
        {
            handelID_txt.Enabled = true;
            handelSalgspris_txt.Enabled = true;
            handelSalgsID_cbox.Enabled = true;
            handelKøberID_cbox.Enabled = true;
        }

        public void DisableAll()
        {
            handelID_txt.Enabled = false;
            handelSalgspris_txt.Enabled = false;
            handelSalgsID_cbox.Enabled = false;
            handelKøberID_cbox.Enabled = false;
        }
    }
}