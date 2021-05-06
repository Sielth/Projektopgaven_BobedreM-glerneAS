using System.Collections.Generic;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoligUI));
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
            this.btn_HentBolig = new System.Windows.Forms.Button();
            this.btn_OpdaterBolig = new System.Windows.Forms.Button();
            this.btn_SletBolig = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boligID_lbl = new System.Windows.Forms.Label();
            this.boligVej_lbl = new System.Windows.Forms.Label();
            this.boligPostnr_lbl = new System.Windows.Forms.Label();
            this.boligType_lbl = new System.Windows.Forms.Label();
            this.boligVærelser_lbl = new System.Windows.Forms.Label();
            this.boligEtager_lbl = new System.Windows.Forms.Label();
            this.boligKvm_lbl = new System.Windows.Forms.Label();
            this.boligBygningsår_lbl = new System.Windows.Forms.Label();
            this.boligUdbudspris_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_SælgBolig = new System.Windows.Forms.Button();
            this.btn_Clear_OpretBolig = new System.Windows.Forms.Button();
            this.btn_Clear_HentBolig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligVærelser_tbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligEtager_tbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // boligID_txt
            // 
            resources.ApplyResources(this.boligID_txt, "boligID_txt");
            this.boligID_txt.Name = "boligID_txt";
            this.boligID_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligID_txt_Validating);
            this.boligID_txt.Validated += new System.EventHandler(this.boligID_txt_Validated);
            // 
            // boligVej_txt
            // 
            resources.ApplyResources(this.boligVej_txt, "boligVej_txt");
            this.boligVej_txt.Name = "boligVej_txt";
            this.boligVej_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligVej_txt_Validating);
            this.boligVej_txt.Validated += new System.EventHandler(this.boligVej_txt_Validated);
            // 
            // boligPostnr_txt
            // 
            resources.ApplyResources(this.boligPostnr_txt, "boligPostnr_txt");
            this.boligPostnr_txt.Name = "boligPostnr_txt";
            this.boligPostnr_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligPostnr_txt_Validating);
            this.boligPostnr_txt.Validated += new System.EventHandler(this.boligPostnr_txt_Validated);
            // 
            // boligKvm_txt
            // 
            resources.ApplyResources(this.boligKvm_txt, "boligKvm_txt");
            this.boligKvm_txt.Name = "boligKvm_txt";
            this.boligKvm_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligKvm_txt_Validating);
            this.boligKvm_txt.Validated += new System.EventHandler(this.boligKvm_txt_Validated);
            // 
            // boligUdbudspris_txt
            // 
            resources.ApplyResources(this.boligUdbudspris_txt, "boligUdbudspris_txt");
            this.boligUdbudspris_txt.Name = "boligUdbudspris_txt";
            this.boligUdbudspris_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligUdbudspris_txt_Validating);
            this.boligUdbudspris_txt.Validated += new System.EventHandler(this.boligUdbudspris_txt_Validated);
            // 
            // btn_OpretBolig
            // 
            resources.ApplyResources(this.btn_OpretBolig, "btn_OpretBolig");
            this.btn_OpretBolig.Name = "btn_OpretBolig";
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
            resources.GetString("boligType_cbox.Items"),
            resources.GetString("boligType_cbox.Items1"),
            resources.GetString("boligType_cbox.Items2")});
            resources.ApplyResources(this.boligType_cbox, "boligType_cbox");
            this.boligType_cbox.Name = "boligType_cbox";
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
            // 
            // boligHave_ckBox
            // 
            resources.ApplyResources(this.boligHave_ckBox, "boligHave_ckBox");
            this.boligHave_ckBox.Name = "boligHave_ckBox";
            this.boligHave_ckBox.UseVisualStyleBackColor = true;
            // 
            // boligBygningsÅr_dtp
            // 
            resources.ApplyResources(this.boligBygningsÅr_dtp, "boligBygningsÅr_dtp");
            this.boligBygningsÅr_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boligBygningsÅr_dtp.Name = "boligBygningsÅr_dtp";
            // 
            // boligRenoveret_ckbox
            // 
            resources.ApplyResources(this.boligRenoveret_ckbox, "boligRenoveret_ckbox");
            this.boligRenoveret_ckbox.Name = "boligRenoveret_ckbox";
            this.boligRenoveret_ckbox.UseVisualStyleBackColor = true;
            this.boligRenoveret_ckbox.CheckedChanged += new System.EventHandler(this.boligRenoveret_ckbox_CheckedChanged);
            // 
            // boligRenoveringsÅr_dtp
            // 
            resources.ApplyResources(this.boligRenoveringsÅr_dtp, "boligRenoveringsÅr_dtp");
            this.boligRenoveringsÅr_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boligRenoveringsÅr_dtp.Name = "boligRenoveringsÅr_dtp";
            // 
            // btn_HentBolig
            // 
            resources.ApplyResources(this.btn_HentBolig, "btn_HentBolig");
            this.btn_HentBolig.Name = "btn_HentBolig";
            this.btn_HentBolig.UseVisualStyleBackColor = true;
            this.btn_HentBolig.Click += new System.EventHandler(this.btn_HentBolig_Click);
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
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
            // boligKvm_lbl
            // 
            resources.ApplyResources(this.boligKvm_lbl, "boligKvm_lbl");
            this.boligKvm_lbl.Name = "boligKvm_lbl";
            // 
            // boligBygningsår_lbl
            // 
            resources.ApplyResources(this.boligBygningsår_lbl, "boligBygningsår_lbl");
            this.boligBygningsår_lbl.Name = "boligBygningsår_lbl";
            // 
            // boligUdbudspris_lbl
            // 
            resources.ApplyResources(this.boligUdbudspris_lbl, "boligUdbudspris_lbl");
            this.boligUdbudspris_lbl.Name = "boligUdbudspris_lbl";
            // 
            // btn_SælgBolig
            // 
            resources.ApplyResources(this.btn_SælgBolig, "btn_SælgBolig");
            this.btn_SælgBolig.Name = "btn_SælgBolig";
            this.btn_SælgBolig.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_OpretBolig
            // 
            resources.ApplyResources(this.btn_Clear_OpretBolig, "btn_Clear_OpretBolig");
            this.btn_Clear_OpretBolig.Name = "btn_Clear_OpretBolig";
            this.btn_Clear_OpretBolig.UseVisualStyleBackColor = true;
            this.btn_Clear_OpretBolig.Click += new System.EventHandler(this.btn_Clear_OpretBolig_Click);
            // 
            // btn_Clear_HentBolig
            // 
            resources.ApplyResources(this.btn_Clear_HentBolig, "btn_Clear_HentBolig");
            this.btn_Clear_HentBolig.Name = "btn_Clear_HentBolig";
            this.btn_Clear_HentBolig.UseVisualStyleBackColor = true;
            this.btn_Clear_HentBolig.Click += new System.EventHandler(this.btn_Clear_HentBolig_Click);
            // 
            // BoligUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btn_Clear_HentBolig);
            this.Controls.Add(this.btn_Clear_OpretBolig);
            this.Controls.Add(this.btn_SælgBolig);
            this.Controls.Add(this.boligUdbudspris_lbl);
            this.Controls.Add(this.boligBygningsår_lbl);
            this.Controls.Add(this.boligKvm_lbl);
            this.Controls.Add(this.boligEtager_lbl);
            this.Controls.Add(this.boligVærelser_lbl);
            this.Controls.Add(this.boligType_lbl);
            this.Controls.Add(this.boligPostnr_lbl);
            this.Controls.Add(this.boligVej_lbl);
            this.Controls.Add(this.boligID_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SletBolig);
            this.Controls.Add(this.btn_OpdaterBolig);
            this.Controls.Add(this.btn_HentBolig);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligVærelser_tbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligEtager_tbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boligID_txt;
        private System.Windows.Forms.TextBox boligVej_txt;
        private System.Windows.Forms.TextBox boligPostnr_txt;
        private System.Windows.Forms.TextBox boligKvm_txt;
        private System.Windows.Forms.TextBox boligUdbudspris_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox boligHave_ckBox;
        private System.Windows.Forms.TrackBar boligEtager_tbar;
        private System.Windows.Forms.TrackBar boligVærelser_tbar;
        private System.Windows.Forms.ComboBox boligType_cbox;
        private System.Windows.Forms.DateTimePicker boligRenoveringsÅr_dtp;
        private System.Windows.Forms.CheckBox boligRenoveret_ckbox;
        private System.Windows.Forms.DateTimePicker boligBygningsÅr_dtp;
        private System.Windows.Forms.Button btn_HentBolig;
        private System.Windows.Forms.Button btn_OpretBolig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label boligUdbudspris_lbl;
        private System.Windows.Forms.Label boligBygningsår_lbl;
        private System.Windows.Forms.Label boligKvm_lbl;
        private System.Windows.Forms.Label boligEtager_lbl;
        private System.Windows.Forms.Label boligVærelser_lbl;
        private System.Windows.Forms.Label boligType_lbl;
        private System.Windows.Forms.Label boligPostnr_lbl;
        private System.Windows.Forms.Label boligVej_lbl;
        private System.Windows.Forms.Label boligID_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_SletBolig;
        private System.Windows.Forms.Button btn_OpdaterBolig;
        private System.Windows.Forms.Button btn_SælgBolig;
        private System.Windows.Forms.Button btn_Clear_OpretBolig;
        private System.Windows.Forms.Button btn_Clear_HentBolig;
        /// <summary>
        /// Method to call a Button or a TextBox etc. from another class without making it public (also called Getters) _Alessia
        /// </summary>
        public System.Windows.Forms.Button GetOpretBoligButton()
        {
            return btn_OpretBolig;
        }

        public System.Windows.Forms.Button GetHentBoligButton()
        {
            return btn_HentBolig;
        }

        public System.Windows.Forms.Button GetOpdaterBoligButton()
        {
            return btn_OpdaterBolig;
        }

        public System.Windows.Forms.Button GetSletBoligButton()
        {
            return btn_SletBolig;
        }

        public System.Windows.Forms.Button GetSælgBoligButton()
        {
            return btn_SælgBolig;
        }

        public System.Windows.Forms.TextBox GetBoligIDTextbox() 
        {
            return boligID_txt;
        }

        public System.Windows.Forms.TextBox GetBoligUdbudsprisTextbox()
        {
            return boligUdbudspris_txt;
        }

        public System.Windows.Forms.DateTimePicker GetBoligRenoveringsÅrDateTimePicker()
        {
            return boligRenoveringsÅr_dtp;
        }

        public System.Windows.Forms.CheckBox GetBoligRenoveretCheckBox()
        {
            return boligRenoveret_ckbox;
        }

        public void DisableAll()
        {
            boligID_txt.Enabled = false;
            boligVej_txt.Enabled = false;
            boligPostnr_txt.Enabled = false;
            boligType_cbox.Enabled = false;
            boligVærelser_tbar.Enabled = false;
            boligEtager_tbar.Enabled = false;
            boligKvm_txt.Enabled = false;
            boligBygningsÅr_dtp.Enabled = false;
            boligRenoveret_ckbox.Enabled = false;
            boligRenoveringsÅr_dtp.Enabled = false;
            boligHave_ckBox.Enabled = false;
            boligUdbudspris_txt.Enabled = false;
        }

        public void EnableAll()
        {
            boligID_txt.Enabled = true;
            boligVej_txt.Enabled = true;
            boligPostnr_txt.Enabled = true;
            boligType_cbox.Enabled = true;
            boligVærelser_tbar.Enabled = true;
            boligEtager_tbar.Enabled = true;
            boligKvm_txt.Enabled = true;
            boligBygningsÅr_dtp.Enabled = true;
            boligRenoveret_ckbox.Enabled = true;
            boligRenoveringsÅr_dtp.Enabled = true;
            boligHave_ckBox.Enabled = true;
            boligUdbudspris_txt.Enabled = true;
        }

        public void ClearAll()
        {
            boligID_txt.Clear();
            boligVej_txt.Clear();
            boligPostnr_txt.Clear();
            boligType_cbox.Items.Clear();
            boligVærelser_tbar.Value = boligVærelser_tbar.Minimum;
            boligEtager_tbar.Value = boligEtager_tbar.Minimum;
            boligKvm_txt.Clear();
            boligBygningsÅr_dtp.Value = System.DateTime.Now;
            boligRenoveret_ckbox.Checked = false;
            boligRenoveringsÅr_dtp.Value = System.DateTime.Now;
            boligHave_ckBox.Checked = false;
            boligUdbudspris_txt.Clear();

        }
    }
}