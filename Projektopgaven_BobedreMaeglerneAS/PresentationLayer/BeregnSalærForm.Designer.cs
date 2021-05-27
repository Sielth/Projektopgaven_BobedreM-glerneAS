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
            this.workhard_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beregn_sagsID_cbox = new System.Windows.Forms.ComboBox();
            this.mæglerID_lbl = new System.Windows.Forms.Label();
            this.sagsID_lbl = new System.Windows.Forms.Label();
            this.btn_indsæt = new System.Windows.Forms.Button();
            this.beregn_hentData_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.beregn_mæglerID_txt = new System.Windows.Forms.TextBox();
            this.helplabel1 = new System.Windows.Forms.Label();
            this.helplabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(265, 239);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(121, 20);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tryk på \"Hent Data\" for at tjekke om";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "du er den rigtig medarbejde, der har lukket sagen";
            // 
            // beregn_mæglerID_txt
            // 
            this.beregn_mæglerID_txt.Location = new System.Drawing.Point(265, 157);
            this.beregn_mæglerID_txt.Name = "beregn_mæglerID_txt";
            this.beregn_mæglerID_txt.Size = new System.Drawing.Size(121, 20);
            this.beregn_mæglerID_txt.TabIndex = 36;
            // 
            // helplabel1
            // 
            this.helplabel1.AutoSize = true;
            this.helplabel1.ForeColor = System.Drawing.Color.Red;
            this.helplabel1.Location = new System.Drawing.Point(12, 280);
            this.helplabel1.Name = "helplabel1";
            this.helplabel1.Size = new System.Drawing.Size(361, 13);
            this.helplabel1.TabIndex = 37;
            this.helplabel1.Text = "Hvis din MæglerID ikke dukker op når du vælger den sag du har arbejdet i,";
            // 
            // helplabel2
            // 
            this.helplabel2.AutoSize = true;
            this.helplabel2.ForeColor = System.Drawing.Color.Red;
            this.helplabel2.Location = new System.Drawing.Point(12, 293);
            this.helplabel2.Name = "helplabel2";
            this.helplabel2.Size = new System.Drawing.Size(339, 13);
            this.helplabel2.TabIndex = 38;
            this.helplabel2.Text = "eller du har indtastet en forkert antal timer, venligst kontakt sekretæren";
            // 
            // BeregnSalærForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 315);
            this.Controls.Add(this.helplabel2);
            this.Controls.Add(this.helplabel1);
            this.Controls.Add(this.beregn_mæglerID_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.beregn_hentData_btn);
            this.Controls.Add(this.btn_indsæt);
            this.Controls.Add(this.sagsID_lbl);
            this.Controls.Add(this.mæglerID_lbl);
            this.Controls.Add(this.beregn_sagsID_cbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workhard_lbl);
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
        private System.Windows.Forms.Label workhard_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox beregn_sagsID_cbox;
        private System.Windows.Forms.Label mæglerID_lbl;
        private System.Windows.Forms.Label sagsID_lbl;
        private System.Windows.Forms.Button btn_indsæt;
        private System.Windows.Forms.Button beregn_hentData_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox beregn_mæglerID_txt;
        private System.Windows.Forms.Label helplabel1;
        private System.Windows.Forms.Label helplabel2;
    }
}