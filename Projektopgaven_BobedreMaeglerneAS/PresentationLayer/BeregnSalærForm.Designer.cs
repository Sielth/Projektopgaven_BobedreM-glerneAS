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
            this.lommeregner_lbl = new System.Windows.Forms.Label();
            this.intro_lbl1 = new System.Windows.Forms.Label();
            this.intro_lbl2 = new System.Windows.Forms.Label();
            this.beregn_sagsID_cbox = new System.Windows.Forms.ComboBox();
            this.mæglerID_lbl = new System.Windows.Forms.Label();
            this.sagsID_lbl = new System.Windows.Forms.Label();
            this.btn_indsæt = new System.Windows.Forms.Button();
            this.beregn_hentData_btn = new System.Windows.Forms.Button();
            this.hentdata_lbl1 = new System.Windows.Forms.Label();
            this.hentdata_lbl2 = new System.Windows.Forms.Label();
            this.beregn_mæglerID_txt = new System.Windows.Forms.TextBox();
            this.help_lbl1 = new System.Windows.Forms.Label();
            this.help_lbl2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.kr_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_txt
            // 
            this.result_txt.BackColor = System.Drawing.SystemColors.Control;
            this.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.Location = new System.Drawing.Point(265, 239);
            this.result_txt.Name = "result_txt";
            this.result_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.result_txt.Size = new System.Drawing.Size(92, 15);
            this.result_txt.TabIndex = 22;
            // 
            // antalTimer_lbl
            // 
            this.antalTimer_lbl.AutoSize = true;
            this.antalTimer_lbl.Location = new System.Drawing.Point(199, 187);
            this.antalTimer_lbl.Name = "antalTimer_lbl";
            this.antalTimer_lbl.Size = new System.Drawing.Size(60, 13);
            this.antalTimer_lbl.TabIndex = 21;
            this.antalTimer_lbl.Text = "Antal Timer";
            // 
            // antalTimer_txt
            // 
            this.antalTimer_txt.Location = new System.Drawing.Point(265, 184);
            this.antalTimer_txt.Name = "antalTimer_txt";
            this.antalTimer_txt.Size = new System.Drawing.Size(121, 20);
            this.antalTimer_txt.TabIndex = 20;
            // 
            // lommeregner_lbl
            // 
            this.lommeregner_lbl.AutoSize = true;
            this.lommeregner_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lommeregner_lbl.ForeColor = System.Drawing.Color.Orange;
            this.lommeregner_lbl.Location = new System.Drawing.Point(12, 9);
            this.lommeregner_lbl.Name = "lommeregner_lbl";
            this.lommeregner_lbl.Size = new System.Drawing.Size(145, 16);
            this.lommeregner_lbl.TabIndex = 23;
            this.lommeregner_lbl.Text = "Salær lommeregner";
            // 
            // intro_lbl1
            // 
            this.intro_lbl1.AutoSize = true;
            this.intro_lbl1.Location = new System.Drawing.Point(12, 25);
            this.intro_lbl1.Name = "intro_lbl1";
            this.intro_lbl1.Size = new System.Drawing.Size(269, 13);
            this.intro_lbl1.TabIndex = 24;
            this.intro_lbl1.Text = "Denne modul er til at beregne ejendomsmægleres salær";
            // 
            // intro_lbl2
            // 
            this.intro_lbl2.AutoSize = true;
            this.intro_lbl2.Location = new System.Drawing.Point(12, 38);
            this.intro_lbl2.Name = "intro_lbl2";
            this.intro_lbl2.Size = new System.Drawing.Size(208, 13);
            this.intro_lbl2.TabIndex = 25;
            this.intro_lbl2.Text = "efter de har solgt en bolig med stort indsats";
            // 
            // beregn_sagsID_cbox
            // 
            this.beregn_sagsID_cbox.FormattingEnabled = true;
            this.beregn_sagsID_cbox.Location = new System.Drawing.Point(265, 77);
            this.beregn_sagsID_cbox.Name = "beregn_sagsID_cbox";
            this.beregn_sagsID_cbox.Size = new System.Drawing.Size(121, 21);
            this.beregn_sagsID_cbox.TabIndex = 27;
            // 
            // mæglerID_lbl
            // 
            this.mæglerID_lbl.AutoSize = true;
            this.mæglerID_lbl.Location = new System.Drawing.Point(202, 160);
            this.mæglerID_lbl.Name = "mæglerID_lbl";
            this.mæglerID_lbl.Size = new System.Drawing.Size(57, 13);
            this.mæglerID_lbl.TabIndex = 28;
            this.mæglerID_lbl.Text = "Mægler ID";
            // 
            // sagsID_lbl
            // 
            this.sagsID_lbl.AutoSize = true;
            this.sagsID_lbl.Location = new System.Drawing.Point(12, 80);
            this.sagsID_lbl.Name = "sagsID_lbl";
            this.sagsID_lbl.Size = new System.Drawing.Size(175, 13);
            this.sagsID_lbl.TabIndex = 29;
            this.sagsID_lbl.Text = "Vælg den SagsID du lige har lukket";
            // 
            // btn_indsæt
            // 
            this.btn_indsæt.Location = new System.Drawing.Point(202, 210);
            this.btn_indsæt.Name = "btn_indsæt";
            this.btn_indsæt.Size = new System.Drawing.Size(184, 23);
            this.btn_indsæt.TabIndex = 30;
            this.btn_indsæt.Text = "Indsæt timerne og beregn";
            this.btn_indsæt.UseVisualStyleBackColor = true;
            this.btn_indsæt.Click += new System.EventHandler(this.btn_indsæt_Click);
            // 
            // beregn_hentData_btn
            // 
            this.beregn_hentData_btn.Location = new System.Drawing.Point(265, 117);
            this.beregn_hentData_btn.Name = "beregn_hentData_btn";
            this.beregn_hentData_btn.Size = new System.Drawing.Size(121, 21);
            this.beregn_hentData_btn.TabIndex = 33;
            this.beregn_hentData_btn.Text = "Hent Data";
            this.beregn_hentData_btn.UseVisualStyleBackColor = true;
            this.beregn_hentData_btn.Click += new System.EventHandler(this.beregn_hentData_btn_Click);
            // 
            // hentdata_lbl1
            // 
            this.hentdata_lbl1.AutoSize = true;
            this.hentdata_lbl1.Location = new System.Drawing.Point(12, 108);
            this.hentdata_lbl1.Name = "hentdata_lbl1";
            this.hentdata_lbl1.Size = new System.Drawing.Size(181, 13);
            this.hentdata_lbl1.TabIndex = 34;
            this.hentdata_lbl1.Text = "Tryk på \"Hent Data\" for at tjekke om";
            // 
            // hentdata_lbl2
            // 
            this.hentdata_lbl2.AutoSize = true;
            this.hentdata_lbl2.Location = new System.Drawing.Point(12, 121);
            this.hentdata_lbl2.Name = "hentdata_lbl2";
            this.hentdata_lbl2.Size = new System.Drawing.Size(238, 13);
            this.hentdata_lbl2.TabIndex = 35;
            this.hentdata_lbl2.Text = "du er den rigtig medarbejde, der har lukket sagen";
            // 
            // beregn_mæglerID_txt
            // 
            this.beregn_mæglerID_txt.Location = new System.Drawing.Point(265, 157);
            this.beregn_mæglerID_txt.Name = "beregn_mæglerID_txt";
            this.beregn_mæglerID_txt.Size = new System.Drawing.Size(121, 20);
            this.beregn_mæglerID_txt.TabIndex = 36;
            // 
            // help_lbl1
            // 
            this.help_lbl1.AutoSize = true;
            this.help_lbl1.ForeColor = System.Drawing.Color.Red;
            this.help_lbl1.Location = new System.Drawing.Point(12, 304);
            this.help_lbl1.Name = "help_lbl1";
            this.help_lbl1.Size = new System.Drawing.Size(361, 13);
            this.help_lbl1.TabIndex = 37;
            this.help_lbl1.Text = "Hvis din MæglerID ikke dukker op når du vælger den sag du har arbejdet i,";
            // 
            // help_lbl2
            // 
            this.help_lbl2.AutoSize = true;
            this.help_lbl2.ForeColor = System.Drawing.Color.Red;
            this.help_lbl2.Location = new System.Drawing.Point(12, 317);
            this.help_lbl2.Name = "help_lbl2";
            this.help_lbl2.Size = new System.Drawing.Size(142, 13);
            this.help_lbl2.TabIndex = 38;
            this.help_lbl2.Text = "venligst kontakt sekretæren.";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(265, 267);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 23);
            this.btn_Clear.TabIndex = 39;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // kr_lbl
            // 
            this.kr_lbl.AutoSize = true;
            this.kr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kr_lbl.Location = new System.Drawing.Point(363, 239);
            this.kr_lbl.Name = "kr_lbl";
            this.kr_lbl.Size = new System.Drawing.Size(21, 16);
            this.kr_lbl.TabIndex = 40;
            this.kr_lbl.Text = "kr";
            // 
            // BeregnSalærForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 339);
            this.Controls.Add(this.kr_lbl);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.help_lbl2);
            this.Controls.Add(this.help_lbl1);
            this.Controls.Add(this.beregn_mæglerID_txt);
            this.Controls.Add(this.hentdata_lbl2);
            this.Controls.Add(this.hentdata_lbl1);
            this.Controls.Add(this.beregn_hentData_btn);
            this.Controls.Add(this.btn_indsæt);
            this.Controls.Add(this.sagsID_lbl);
            this.Controls.Add(this.mæglerID_lbl);
            this.Controls.Add(this.beregn_sagsID_cbox);
            this.Controls.Add(this.intro_lbl2);
            this.Controls.Add(this.intro_lbl1);
            this.Controls.Add(this.lommeregner_lbl);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.antalTimer_lbl);
            this.Controls.Add(this.antalTimer_txt);
            this.Name = "BeregnSalærForm";
            this.Text = "BeregnSalærForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Label antalTimer_lbl;
        private System.Windows.Forms.TextBox antalTimer_txt;
        private System.Windows.Forms.Label lommeregner_lbl;
        private System.Windows.Forms.Label intro_lbl1;
        private System.Windows.Forms.Label intro_lbl2;
        private System.Windows.Forms.ComboBox beregn_sagsID_cbox;
        private System.Windows.Forms.Label mæglerID_lbl;
        private System.Windows.Forms.Label sagsID_lbl;
        private System.Windows.Forms.Button btn_indsæt;
        private System.Windows.Forms.Button beregn_hentData_btn;
        private System.Windows.Forms.Label hentdata_lbl1;
        private System.Windows.Forms.Label hentdata_lbl2;
        private System.Windows.Forms.TextBox beregn_mæglerID_txt;
        private System.Windows.Forms.Label help_lbl1;
        private System.Windows.Forms.Label help_lbl2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label kr_lbl;

        public void ClearAll()
        {
            beregn_sagsID_cbox.SelectedItem = null;
            beregn_mæglerID_txt.Clear();
            antalTimer_txt.Clear();
            result_txt.Clear();
        }
    }
}