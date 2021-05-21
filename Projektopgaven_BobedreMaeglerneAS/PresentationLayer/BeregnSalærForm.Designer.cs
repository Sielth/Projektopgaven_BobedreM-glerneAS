namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class BeregnSalærForm
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
            this.result_txt = new System.Windows.Forms.TextBox();
            this.antalTimer_lbl = new System.Windows.Forms.Label();
            this.antalTimer_txt = new System.Windows.Forms.TextBox();
            this.btn_beregnSalær = new System.Windows.Forms.Button();
            this.workhard_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beregn_mæglerID_cbox = new System.Windows.Forms.ComboBox();
            this.beregn_sagsID_cbox = new System.Windows.Forms.ComboBox();
            this.mæglerID_lbl = new System.Windows.Forms.Label();
            this.sagsID_lbl = new System.Windows.Forms.Label();
            this.btn_indsæt = new System.Windows.Forms.Button();
            this.beregn_handleID_cbox = new System.Windows.Forms.ComboBox();
            this.handelID_lbl = new System.Windows.Forms.Label();
            this.beregn_hentData_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(265, 301);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(121, 20);
            this.result_txt.TabIndex = 22;
            // 
            // antalTimer_lbl
            // 
            this.antalTimer_lbl.AutoSize = true;
            this.antalTimer_lbl.Location = new System.Drawing.Point(263, 257);
            this.antalTimer_lbl.Name = "antalTimer_lbl";
            this.antalTimer_lbl.Size = new System.Drawing.Size(60, 13);
            this.antalTimer_lbl.TabIndex = 21;
            this.antalTimer_lbl.Text = "Antal Timer";
            // 
            // antalTimer_txt
            // 
            this.antalTimer_txt.Location = new System.Drawing.Point(266, 273);
            this.antalTimer_txt.Name = "antalTimer_txt";
            this.antalTimer_txt.Size = new System.Drawing.Size(121, 20);
            this.antalTimer_txt.TabIndex = 20;
            // 
            // btn_beregnSalær
            // 
            this.btn_beregnSalær.Location = new System.Drawing.Point(62, 350);
            this.btn_beregnSalær.Name = "btn_beregnSalær";
            this.btn_beregnSalær.Size = new System.Drawing.Size(160, 25);
            this.btn_beregnSalær.TabIndex = 19;
            this.btn_beregnSalær.Text = "Beregn mæglerens salær";
            this.btn_beregnSalær.UseVisualStyleBackColor = true;
            // 
            // workhard_lbl
            // 
            this.workhard_lbl.AutoSize = true;
            this.workhard_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.workhard_lbl.ForeColor = System.Drawing.Color.Orange;
            this.workhard_lbl.Location = new System.Drawing.Point(12, 9);
            this.workhard_lbl.Name = "workhard_lbl";
            this.workhard_lbl.Size = new System.Drawing.Size(148, 16);
            this.workhard_lbl.TabIndex = 23;
            this.workhard_lbl.Text = "I WORK HARD TOO!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Denne modul er til at beregne ejendomsmægleres salær";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "efter de har solgt en bolig med stort indsats";
            // 
            // beregn_mæglerID_cbox
            // 
            this.beregn_mæglerID_cbox.FormattingEnabled = true;
            this.beregn_mæglerID_cbox.Location = new System.Drawing.Point(265, 233);
            this.beregn_mæglerID_cbox.Name = "beregn_mæglerID_cbox";
            this.beregn_mæglerID_cbox.Size = new System.Drawing.Size(121, 21);
            this.beregn_mæglerID_cbox.TabIndex = 26;
            // 
            // beregn_sagsID_cbox
            // 
            this.beregn_sagsID_cbox.FormattingEnabled = true;
            this.beregn_sagsID_cbox.Location = new System.Drawing.Point(15, 112);
            this.beregn_sagsID_cbox.Name = "beregn_sagsID_cbox";
            this.beregn_sagsID_cbox.Size = new System.Drawing.Size(121, 21);
            this.beregn_sagsID_cbox.TabIndex = 27;
            // 
            // mæglerID_lbl
            // 
            this.mæglerID_lbl.AutoSize = true;
            this.mæglerID_lbl.Location = new System.Drawing.Point(265, 217);
            this.mæglerID_lbl.Name = "mæglerID_lbl";
            this.mæglerID_lbl.Size = new System.Drawing.Size(57, 13);
            this.mæglerID_lbl.TabIndex = 28;
            this.mæglerID_lbl.Text = "Mægler ID";
            // 
            // sagsID_lbl
            // 
            this.sagsID_lbl.AutoSize = true;
            this.sagsID_lbl.Location = new System.Drawing.Point(12, 96);
            this.sagsID_lbl.Name = "sagsID_lbl";
            this.sagsID_lbl.Size = new System.Drawing.Size(45, 13);
            this.sagsID_lbl.TabIndex = 29;
            this.sagsID_lbl.Text = "Sags ID";
            // 
            // btn_indsæt
            // 
            this.btn_indsæt.Location = new System.Drawing.Point(91, 257);
            this.btn_indsæt.Name = "btn_indsæt";
            this.btn_indsæt.Size = new System.Drawing.Size(166, 23);
            this.btn_indsæt.TabIndex = 30;
            this.btn_indsæt.Text = "Indsæt timerne og beregn";
            this.btn_indsæt.UseVisualStyleBackColor = true;
            this.btn_indsæt.Click += new System.EventHandler(this.btn_indsæt_Click);
            // 
            // beregn_handleID_cbox
            // 
            this.beregn_handleID_cbox.FormattingEnabled = true;
            this.beregn_handleID_cbox.Location = new System.Drawing.Point(142, 112);
            this.beregn_handleID_cbox.Name = "beregn_handleID_cbox";
            this.beregn_handleID_cbox.Size = new System.Drawing.Size(121, 21);
            this.beregn_handleID_cbox.TabIndex = 31;
            // 
            // handelID_lbl
            // 
            this.handelID_lbl.AutoSize = true;
            this.handelID_lbl.Location = new System.Drawing.Point(139, 96);
            this.handelID_lbl.Name = "handelID_lbl";
            this.handelID_lbl.Size = new System.Drawing.Size(55, 13);
            this.handelID_lbl.TabIndex = 32;
            this.handelID_lbl.Text = "Handel ID";
            // 
            // beregn_hentData_btn
            // 
            this.beregn_hentData_btn.Location = new System.Drawing.Point(269, 112);
            this.beregn_hentData_btn.Name = "beregn_hentData_btn";
            this.beregn_hentData_btn.Size = new System.Drawing.Size(75, 23);
            this.beregn_hentData_btn.TabIndex = 33;
            this.beregn_hentData_btn.Text = "Hent Data";
            this.beregn_hentData_btn.UseVisualStyleBackColor = true;
            this.beregn_hentData_btn.Click += new System.EventHandler(this.beregn_hentData_btn_Click);
            // 
            // BeregnSalærForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 385);
            this.Controls.Add(this.beregn_hentData_btn);
            this.Controls.Add(this.handelID_lbl);
            this.Controls.Add(this.beregn_handleID_cbox);
            this.Controls.Add(this.btn_indsæt);
            this.Controls.Add(this.sagsID_lbl);
            this.Controls.Add(this.mæglerID_lbl);
            this.Controls.Add(this.beregn_sagsID_cbox);
            this.Controls.Add(this.beregn_mæglerID_cbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workhard_lbl);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.antalTimer_lbl);
            this.Controls.Add(this.antalTimer_txt);
            this.Controls.Add(this.btn_beregnSalær);
            this.Name = "BeregnSalærForm";
            this.Text = "BeregnSalærForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Label antalTimer_lbl;
        private System.Windows.Forms.TextBox antalTimer_txt;
        private System.Windows.Forms.Button btn_beregnSalær;
        private System.Windows.Forms.Label workhard_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox beregn_mæglerID_cbox;
        private System.Windows.Forms.ComboBox beregn_sagsID_cbox;
        private System.Windows.Forms.Label mæglerID_lbl;
        private System.Windows.Forms.Label sagsID_lbl;
        private System.Windows.Forms.Button btn_indsæt;
        private System.Windows.Forms.ComboBox beregn_handleID_cbox;
        private System.Windows.Forms.Label handelID_lbl;
        private System.Windows.Forms.Button beregn_hentData_btn;
    }
}