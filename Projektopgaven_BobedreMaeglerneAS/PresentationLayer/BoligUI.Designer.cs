namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class BoligUI
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
            this.boligID_txt = new System.Windows.Forms.TextBox();
            this.boligVej_txt = new System.Windows.Forms.TextBox();
            this.boligPostnr_txt = new System.Windows.Forms.TextBox();
            this.boligKvm_txt = new System.Windows.Forms.TextBox();
            this.boligUdbudspris_txt = new System.Windows.Forms.TextBox();
            this.btn_OpretBolig = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.boligType_cbox = new System.Windows.Forms.ComboBox();
            this.boligVærelser_tbar = new System.Windows.Forms.TrackBar();
            this.boligEtager_tbar = new System.Windows.Forms.TrackBar();
            this.boligHave_ckBox = new System.Windows.Forms.CheckBox();
            this.boligBygningsÅr_dtp = new System.Windows.Forms.DateTimePicker();
            this.boligRenoveret_ckbox = new System.Windows.Forms.CheckBox();
            this.boligRenoveringsÅr_dtp = new System.Windows.Forms.DateTimePicker();
            this.boligID_lbl = new System.Windows.Forms.Label();
            this.boligVej_lbl = new System.Windows.Forms.Label();
            this.boligPostnr_lbl = new System.Windows.Forms.Label();
            this.boligType_lbl = new System.Windows.Forms.Label();
            this.boligVærelser_lbl = new System.Windows.Forms.Label();
            this.boligEtager_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_HentBolig = new System.Windows.Forms.Button();
            this.btn_OpdaterBolig = new System.Windows.Forms.Button();
            this.btn_SletBolig = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligVærelser_tbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligEtager_tbar)).BeginInit();
            this.SuspendLayout();
            // 
            // boligID_txt
            // 
            this.boligID_txt.Location = new System.Drawing.Point(12, 12);
            this.boligID_txt.Name = "boligID_txt";
            this.boligID_txt.Size = new System.Drawing.Size(100, 20);
            this.boligID_txt.TabIndex = 0;
            this.boligID_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligID_txt_Validating);
            this.boligID_txt.Validated += new System.EventHandler(this.boligID_txt_Validated);
            // 
            // boligVej_txt
            // 
            this.boligVej_txt.Location = new System.Drawing.Point(12, 38);
            this.boligVej_txt.Name = "boligVej_txt";
            this.boligVej_txt.Size = new System.Drawing.Size(100, 20);
            this.boligVej_txt.TabIndex = 1;
            this.boligVej_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligVej_txt_Validating);
            this.boligVej_txt.Validated += new System.EventHandler(this.boligVej_txt_Validated);
            // 
            // boligPostnr_txt
            // 
            this.boligPostnr_txt.Location = new System.Drawing.Point(12, 64);
            this.boligPostnr_txt.Name = "boligPostnr_txt";
            this.boligPostnr_txt.Size = new System.Drawing.Size(100, 20);
            this.boligPostnr_txt.TabIndex = 2;
            this.boligPostnr_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligPostnr_txt_Validating);
            this.boligPostnr_txt.Validated += new System.EventHandler(this.boligPostnr_txt_Validated);
            // 
            // boligKvm_txt
            // 
            this.boligKvm_txt.Location = new System.Drawing.Point(12, 219);
            this.boligKvm_txt.Name = "boligKvm_txt";
            this.boligKvm_txt.Size = new System.Drawing.Size(100, 20);
            this.boligKvm_txt.TabIndex = 6;
            this.boligKvm_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligKvm_txt_Validating);
            this.boligKvm_txt.Validated += new System.EventHandler(this.boligKvm_txt_Validated);
            // 
            // boligUdbudspris_txt
            // 
            this.boligUdbudspris_txt.Location = new System.Drawing.Point(12, 245);
            this.boligUdbudspris_txt.Name = "boligUdbudspris_txt";
            this.boligUdbudspris_txt.Size = new System.Drawing.Size(100, 20);
            this.boligUdbudspris_txt.TabIndex = 7;
            // 
            // btn_OpretBolig
            // 
            this.btn_OpretBolig.Location = new System.Drawing.Point(37, 372);
            this.btn_OpretBolig.Name = "btn_OpretBolig";
            this.btn_OpretBolig.Size = new System.Drawing.Size(75, 23);
            this.btn_OpretBolig.TabIndex = 11;
            this.btn_OpretBolig.Text = "Opret Bolig";
            this.btn_OpretBolig.UseVisualStyleBackColor = true;
            this.btn_OpretBolig.Click += new System.EventHandler(this.btn_OpretBolig_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // boligType_cbox
            // 
            this.boligType_cbox.FormattingEnabled = true;
            this.boligType_cbox.Items.AddRange(new object[] {
            "Villa",
            "Lejlighed",
            "Rækkehus"});
            this.boligType_cbox.Location = new System.Drawing.Point(12, 90);
            this.boligType_cbox.Name = "boligType_cbox";
            this.boligType_cbox.Size = new System.Drawing.Size(100, 21);
            this.boligType_cbox.TabIndex = 12;
            // 
            // boligVærelser_tbar
            // 
            resources.ApplyResources(this.boligVærelser_tbar, "boligVærelser_tbar");
            this.boligVærelser_tbar.Maximum = 5;
            this.boligVærelser_tbar.Minimum = 1;
            this.boligVærelser_tbar.Name = "boligVærelser_tbar";
            this.boligVærelser_tbar.Value = 1;
            this.boligVærelser_tbar.Scroll += new System.EventHandler(this.boligVærelser_tbar_Scroll);
            // 
            // boligEtager_tbar
            // 
            resources.ApplyResources(this.boligEtager_tbar, "boligEtager_tbar");
            this.boligEtager_tbar.Maximum = 5;
            this.boligEtager_tbar.Minimum = 1;
            this.boligEtager_tbar.Name = "boligEtager_tbar";
            this.boligEtager_tbar.Value = 1;
            this.boligEtager_tbar.Scroll += new System.EventHandler(this.boligEtager_tbar_Scroll);
            this.boligVærelser_tbar.Location = new System.Drawing.Point(12, 117);
            this.boligVærelser_tbar.Name = "boligVærelser_tbar";
            this.boligVærelser_tbar.Size = new System.Drawing.Size(100, 45);
            this.boligVærelser_tbar.TabIndex = 13;
            // 
            // boligEtager_tbar
            // 
            this.boligEtager_tbar.Location = new System.Drawing.Point(12, 168);
            this.boligEtager_tbar.Name = "boligEtager_tbar";
            this.boligEtager_tbar.Size = new System.Drawing.Size(100, 45);
            this.boligEtager_tbar.TabIndex = 14;
            // 
            // boligHave_ckBox
            // 
            this.boligHave_ckBox.AutoSize = true;
            this.boligHave_ckBox.Location = new System.Drawing.Point(12, 271);
            this.boligHave_ckBox.Name = "boligHave_ckBox";
            this.boligHave_ckBox.Size = new System.Drawing.Size(58, 17);
            this.boligHave_ckBox.TabIndex = 15;
            this.boligHave_ckBox.Text = "Have?";
            this.boligHave_ckBox.UseVisualStyleBackColor = true;
            // 
            // boligBygningsÅr_dtp
            // 
            this.boligBygningsÅr_dtp.CustomFormat = "yyyy";
            this.boligBygningsÅr_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boligBygningsÅr_dtp.Location = new System.Drawing.Point(12, 294);
            this.boligBygningsÅr_dtp.Name = "boligBygningsÅr_dtp";
            this.boligBygningsÅr_dtp.Size = new System.Drawing.Size(100, 20);
            this.boligBygningsÅr_dtp.TabIndex = 16;
            // 
            // boligRenoveret_ckbox
            // 
            this.boligRenoveret_ckbox.AutoSize = true;
            this.boligRenoveret_ckbox.Location = new System.Drawing.Point(12, 323);
            this.boligRenoveret_ckbox.Name = "boligRenoveret_ckbox";
            this.boligRenoveret_ckbox.Size = new System.Drawing.Size(82, 17);
            this.boligRenoveret_ckbox.TabIndex = 17;
            this.boligRenoveret_ckbox.Text = "Renoveret?";
            this.boligRenoveret_ckbox.UseVisualStyleBackColor = true;
            // 
            // boligRenoveringsÅr_dtp
            // 
            this.boligRenoveringsÅr_dtp.CustomFormat = "yyyy";
            this.boligRenoveringsÅr_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boligRenoveringsÅr_dtp.Location = new System.Drawing.Point(12, 346);
            this.boligRenoveringsÅr_dtp.Name = "boligRenoveringsÅr_dtp";
            // 
            // boligID_lbl
            // 
            resources.ApplyResources(this.boligID_lbl, "boligID_lbl");
            this.boligID_lbl.Name = "boligID_lbl";
            // 
            // boligVej_lbl
            // 
            resources.ApplyResources(this.boligVej_lbl, "boligVej_lbl");
            this.boligVej_lbl.Name = "boligVej_lbl";
            // 
            // boligPostnr_lbl
            // 
            resources.ApplyResources(this.boligPostnr_lbl, "boligPostnr_lbl");
            this.boligPostnr_lbl.Name = "boligPostnr_lbl";
            // 
            // boligType_lbl
            // 
            resources.ApplyResources(this.boligType_lbl, "boligType_lbl");
            this.boligType_lbl.Name = "boligType_lbl";
            // 
            // boligVærelser_lbl
            // 
            resources.ApplyResources(this.boligVærelser_lbl, "boligVærelser_lbl");
            this.boligVærelser_lbl.Name = "boligVærelser_lbl";
            // 
            // boligEtager_lbl
            // 
            resources.ApplyResources(this.boligEtager_lbl, "boligEtager_lbl");
            this.boligEtager_lbl.Name = "boligEtager_lbl";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btn_HentBolig
            // 
            resources.ApplyResources(this.btn_HentBolig, "btn_HentBolig");
            this.btn_HentBolig.Name = "btn_HentBolig";
            this.btn_HentBolig.UseVisualStyleBackColor = true;
            // 
            // btn_OpdaterBolig
            // 
            resources.ApplyResources(this.btn_OpdaterBolig, "btn_OpdaterBolig");
            this.btn_OpdaterBolig.Name = "btn_OpdaterBolig";
            this.btn_OpdaterBolig.UseVisualStyleBackColor = true;
            // 
            // btn_SletBolig
            // 
            resources.ApplyResources(this.btn_SletBolig, "btn_SletBolig");
            this.btn_SletBolig.Name = "btn_SletBolig";
            this.btn_SletBolig.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.boligRenoveringsÅr_dtp.Size = new System.Drawing.Size(100, 20);
            this.boligRenoveringsÅr_dtp.TabIndex = 18;
            // 
            // BoligUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SletBolig);
            this.Controls.Add(this.btn_OpdaterBolig);
            this.Controls.Add(this.btn_HentBolig);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boligEtager_lbl);
            this.Controls.Add(this.boligVærelser_lbl);
            this.Controls.Add(this.boligType_lbl);
            this.Controls.Add(this.boligPostnr_lbl);
            this.Controls.Add(this.boligVej_lbl);
            this.Controls.Add(this.boligID_lbl);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boligRenoveringsÅr_dtp);
            this.Controls.Add(this.boligRenoveret_ckbox);
            this.Controls.Add(this.boligBygningsÅr_dtp);
            this.Controls.Add(this.boligHave_ckBox);
            this.Controls.Add(this.boligEtager_tbar);
            this.Controls.Add(this.boligVærelser_tbar);
            this.Controls.Add(this.boligType_cbox);
            this.Controls.Add(this.btn_OpretBolig);
            this.Controls.Add(this.boligUdbudspris_txt);
            this.Controls.Add(this.boligKvm_txt);
            this.Controls.Add(this.boligPostnr_txt);
            this.Controls.Add(this.boligVej_txt);
            this.Controls.Add(this.boligID_txt);
            this.Name = "BoligUI";
            this.Text = "BoligUI";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligVærelser_tbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligEtager_tbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boligID_txt;
        private System.Windows.Forms.TextBox boligVej_txt;
        private System.Windows.Forms.TextBox boligPostnr_txt;
        private System.Windows.Forms.TextBox boligKvm_txt;
        private System.Windows.Forms.TextBox boligUdbudspris_txt;
        private System.Windows.Forms.Button btn_OpretBolig;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox boligHave_ckBox;
        private System.Windows.Forms.TrackBar boligEtager_tbar;
        private System.Windows.Forms.TrackBar boligVærelser_tbar;
        private System.Windows.Forms.ComboBox boligType_cbox;
        private System.Windows.Forms.DateTimePicker boligRenoveringsÅr_dtp;
        private System.Windows.Forms.CheckBox boligRenoveret_ckbox;
        private System.Windows.Forms.DateTimePicker boligBygningsÅr_dtp;
        private System.Windows.Forms.Button btn_SletBolig;
        private System.Windows.Forms.Button btn_OpdaterBolig;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label boligEtager_lbl;
        private System.Windows.Forms.Label boligVærelser_lbl;
        private System.Windows.Forms.Label boligType_lbl;
        private System.Windows.Forms.Label boligPostnr_lbl;
        private System.Windows.Forms.Label boligVej_lbl;
        private System.Windows.Forms.Label boligID_lbl;
        public System.Windows.Forms.Button btn_HentBolig;
        public System.Windows.Forms.Button btn_OpretBolig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}