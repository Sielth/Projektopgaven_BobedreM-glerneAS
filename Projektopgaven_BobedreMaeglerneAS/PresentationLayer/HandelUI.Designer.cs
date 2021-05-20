
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
            return dateTimePicker2;
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
            this.ejendomsmægler_updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.komTilÅbentHusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // handelSalgsID_cbox
            // 
            this.handelSalgsID_cbox.FormattingEnabled = true;
            this.handelSalgsID_cbox.Location = new System.Drawing.Point(160, 213);
            this.handelSalgsID_cbox.Name = "handelSalgsID_cbox";
            this.handelSalgsID_cbox.Size = new System.Drawing.Size(136, 28);
            this.handelSalgsID_cbox.TabIndex = 0;
            // 
            // handelKøberID_cbox
            // 
            this.handelKøberID_cbox.FormattingEnabled = true;
            this.handelKøberID_cbox.Location = new System.Drawing.Point(160, 276);
            this.handelKøberID_cbox.Name = "handelKøberID_cbox";
            this.handelKøberID_cbox.Size = new System.Drawing.Size(136, 28);
            this.handelKøberID_cbox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // handelSalgspris_txt
            // 
            this.handelSalgspris_txt.Location = new System.Drawing.Point(160, 152);
            this.handelSalgspris_txt.Name = "handelSalgspris_txt";
            this.handelSalgspris_txt.Size = new System.Drawing.Size(136, 26);
            this.handelSalgspris_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SagsID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salgspris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "KøberID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Udtræk Statistik";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_oprethandel
            // 
            this.btn_oprethandel.Location = new System.Drawing.Point(95, 412);
            this.btn_oprethandel.Name = "btn_oprethandel";
            this.btn_oprethandel.Size = new System.Drawing.Size(159, 36);
            this.btn_oprethandel.TabIndex = 10;
            this.btn_oprethandel.Text = "Opret handel";
            this.btn_oprethandel.UseVisualStyleBackColor = true;
            this.btn_oprethandel.Click += new System.EventHandler(this.btn_oprethandel_Click);
            // 
            // btn_findhandel
            // 
            this.btn_findhandel.Location = new System.Drawing.Point(275, 414);
            this.btn_findhandel.Name = "btn_findhandel";
            this.btn_findhandel.Size = new System.Drawing.Size(159, 36);
            this.btn_findhandel.TabIndex = 11;
            this.btn_findhandel.Text = "Find handel";
            this.btn_findhandel.UseVisualStyleBackColor = true;
            this.btn_findhandel.Click += new System.EventHandler(this.btn_findhandel_Click);
            // 
            // btn_opdaterhandel
            // 
            this.btn_opdaterhandel.Location = new System.Drawing.Point(460, 414);
            this.btn_opdaterhandel.Name = "btn_opdaterhandel";
            this.btn_opdaterhandel.Size = new System.Drawing.Size(159, 38);
            this.btn_opdaterhandel.TabIndex = 12;
            this.btn_opdaterhandel.Text = "Opdater handel";
            this.btn_opdaterhandel.UseVisualStyleBackColor = true;
            this.btn_opdaterhandel.Click += new System.EventHandler(this.btn_opdaterhandel_Click);
            // 
            // btn_slethandel
            // 
            this.btn_slethandel.Location = new System.Drawing.Point(646, 414);
            this.btn_slethandel.Name = "btn_slethandel";
            this.btn_slethandel.Size = new System.Drawing.Size(159, 38);
            this.btn_slethandel.TabIndex = 13;
            this.btn_slethandel.Text = "Slet handel";
            this.btn_slethandel.UseVisualStyleBackColor = true;
            this.btn_slethandel.Click += new System.EventHandler(this.btn_slethandel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "HandelID";
            // 
            // handelID_txt
            // 
            this.handelID_txt.Location = new System.Drawing.Point(160, 92);
            this.handelID_txt.Name = "handelID_txt";
            this.handelID_txt.Size = new System.Drawing.Size(136, 26);
            this.handelID_txt.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(45, 270);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 35);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejendomsmæglerToolStripMenuItem
            // 
            this.ejendomsmæglerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmægler_createToolStripMenuItem,
            this.ejendomsmægler_readToolStripMenuItem,
            this.ejendomsmægler_updateToolStripMenuItem,
            this.ejendomsmægler_deleteToolStripMenuItem});
            this.ejendomsmæglerToolStripMenuItem.Name = "ejendomsmæglerToolStripMenuItem";
            this.ejendomsmæglerToolStripMenuItem.Size = new System.Drawing.Size(167, 29);
            this.ejendomsmæglerToolStripMenuItem.Text = "Ejendomsmægler";
            // 
            // ejendomsmægler_createToolStripMenuItem
            // 
            this.ejendomsmægler_createToolStripMenuItem.Name = "ejendomsmægler_createToolStripMenuItem";
            this.ejendomsmægler_createToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.ejendomsmægler_createToolStripMenuItem.Text = "Create";
            this.ejendomsmægler_createToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_createToolStripMenuItem_Click);
            // 
            // ejendomsmægler_readToolStripMenuItem
            // 
            this.ejendomsmægler_readToolStripMenuItem.Name = "ejendomsmægler_readToolStripMenuItem";
            this.ejendomsmægler_readToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.ejendomsmægler_readToolStripMenuItem.Text = "Read";
            this.ejendomsmægler_readToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_readToolStripMenuItem_Click);
            // 
            // ejendomsmægler_updateToolStripMenuItem
            // 
            this.ejendomsmægler_updateToolStripMenuItem.Name = "ejendomsmægler_updateToolStripMenuItem";
            this.ejendomsmægler_updateToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.ejendomsmægler_updateToolStripMenuItem.Text = "Update";
            this.ejendomsmægler_updateToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_updateToolStripMenuItem_Click);
            // 
            // ejendomsmægler_deleteToolStripMenuItem
            // 
            this.ejendomsmægler_deleteToolStripMenuItem.Name = "ejendomsmægler_deleteToolStripMenuItem";
            this.ejendomsmægler_deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.ejendomsmægler_deleteToolStripMenuItem.Text = "Delete";
            this.ejendomsmægler_deleteToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_deleteToolStripMenuItem_Click);
            // 
            // sælgerToolStripMenuItem
            // 
            this.sælgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sælger_createToolStripMenuItem,
            this.sælger_readToolStripMenuItem,
            this.sælger_updateToolStripMenuItem,
            this.sælger_deleteToolStripMenuItem});
            this.sælgerToolStripMenuItem.Name = "sælgerToolStripMenuItem";
            this.sælgerToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.sælgerToolStripMenuItem.Text = "Sælger";
            // 
            // sælger_createToolStripMenuItem
            // 
            this.sælger_createToolStripMenuItem.Name = "sælger_createToolStripMenuItem";
            this.sælger_createToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.sælger_createToolStripMenuItem.Text = "Create";
            this.sælger_createToolStripMenuItem.Click += new System.EventHandler(this.sælger_createToolStripMenuItem_Click);
            // 
            // sælger_readToolStripMenuItem
            // 
            this.sælger_readToolStripMenuItem.Name = "sælger_readToolStripMenuItem";
            this.sælger_readToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.sælger_readToolStripMenuItem.Text = "Read";
            this.sælger_readToolStripMenuItem.Click += new System.EventHandler(this.sælger_readToolStripMenuItem_Click);
            // 
            // sælger_updateToolStripMenuItem
            // 
            this.sælger_updateToolStripMenuItem.Name = "sælger_updateToolStripMenuItem";
            this.sælger_updateToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.sælger_updateToolStripMenuItem.Text = "Update";
            this.sælger_updateToolStripMenuItem.Click += new System.EventHandler(this.sælger_updateToolStripMenuItem_Click);
            // 
            // sælger_deleteToolStripMenuItem
            // 
            this.sælger_deleteToolStripMenuItem.Name = "sælger_deleteToolStripMenuItem";
            this.sælger_deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.sælger_deleteToolStripMenuItem.Text = "Delete";
            this.sælger_deleteToolStripMenuItem.Click += new System.EventHandler(this.sælger_deleteToolStripMenuItem_Click);
            // 
            // køberToolStripMenuItem
            // 
            this.køberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.køber_createToolStripMenuItem1,
            this.køber_readToolStripMenuItem1,
            this.køber_updateToolStripMenuItem1,
            this.køber_deleteToolStripMenuItem1});
            this.køberToolStripMenuItem.Name = "køberToolStripMenuItem";
            this.køberToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.køberToolStripMenuItem.Text = "Køber";
            // 
            // køber_createToolStripMenuItem1
            // 
            this.køber_createToolStripMenuItem1.Name = "køber_createToolStripMenuItem1";
            this.køber_createToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.køber_createToolStripMenuItem1.Text = "Create";
            this.køber_createToolStripMenuItem1.Click += new System.EventHandler(this.køber_createToolStripMenuItem1_Click);
            // 
            // køber_readToolStripMenuItem1
            // 
            this.køber_readToolStripMenuItem1.Name = "køber_readToolStripMenuItem1";
            this.køber_readToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.køber_readToolStripMenuItem1.Text = "Read";
            this.køber_readToolStripMenuItem1.Click += new System.EventHandler(this.køber_readToolStripMenuItem1_Click);
            // 
            // køber_updateToolStripMenuItem1
            // 
            this.køber_updateToolStripMenuItem1.Name = "køber_updateToolStripMenuItem1";
            this.køber_updateToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.køber_updateToolStripMenuItem1.Text = "Update";
            this.køber_updateToolStripMenuItem1.Click += new System.EventHandler(this.køber_updateToolStripMenuItem1_Click);
            // 
            // køber_deleteToolStripMenuItem1
            // 
            this.køber_deleteToolStripMenuItem1.Name = "køber_deleteToolStripMenuItem1";
            this.køber_deleteToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.køber_deleteToolStripMenuItem1.Text = "Delete";
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
            this.boligToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.boligToolStripMenuItem.Text = "Bolig";
            // 
            // bolig_createToolStripMenuItem2
            // 
            this.bolig_createToolStripMenuItem2.Name = "bolig_createToolStripMenuItem2";
            this.bolig_createToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.bolig_createToolStripMenuItem2.Text = "Opret en ny Bolig";
            this.bolig_createToolStripMenuItem2.Click += new System.EventHandler(this.bolig_createToolStripMenuItem2_Click);
            // 
            // bolig_readToolStripMenuItem2
            // 
            this.bolig_readToolStripMenuItem2.Name = "bolig_readToolStripMenuItem2";
            this.bolig_readToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.bolig_readToolStripMenuItem2.Text = "Hent og Opdater";
            this.bolig_readToolStripMenuItem2.Click += new System.EventHandler(this.bolig_readToolStripMenuItem2_Click);
            // 
            // bolig_deleteToolStripMenuItem2
            // 
            this.bolig_deleteToolStripMenuItem2.Name = "bolig_deleteToolStripMenuItem2";
            this.bolig_deleteToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.bolig_deleteToolStripMenuItem2.Text = "Slet en Bolig";
            this.bolig_deleteToolStripMenuItem2.Click += new System.EventHandler(this.bolig_deleteToolStripMenuItem2_Click);
            // 
            // komTilÅbentHusToolStripMenuItem
            // 
            this.komTilÅbentHusToolStripMenuItem.Name = "komTilÅbentHusToolStripMenuItem";
            this.komTilÅbentHusToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.komTilÅbentHusToolStripMenuItem.Text = "Kom til Åbent Hus!";
            this.komTilÅbentHusToolStripMenuItem.Click += new System.EventHandler(this.komTilÅbentHusToolStripMenuItem_Click);
            // 
            // sagToolStripMenuItem
            // 
            this.sagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sagToolStripMenuItem.Name = "sagToolStripMenuItem";
            this.sagToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.sagToolStripMenuItem.Text = "Sag";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.createToolStripMenuItem.Text = "Create ";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // handelToolStripMenuItem
            // 
            this.handelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.handelToolStripMenuItem.Name = "handelToolStripMenuItem";
            this.handelToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.handelToolStripMenuItem.Text = "Handel";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.readToolStripMenuItem1.Text = "Read";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(172, 34);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // HandelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 852);
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
            this.Name = "HandelUI";
            this.Text = "HandelUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

        #region Get knapper
        public System.Windows.Forms.Button GetOpretHandelKnap()
        {
            return btn_oprethandel;
        }

        public System.Windows.Forms.Button GetFindHandelKnap()
        {
            return btn_findhandel;
        }

        public System.Windows.Forms.Button GetOpdaterHandelKnap()
        {
            return btn_opdaterhandel;
        }

        public System.Windows.Forms.Button GetSletHandelKnap()
        {
            return btn_slethandel;
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmæglerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køber_createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boligToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolig_createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem komTilÅbentHusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}