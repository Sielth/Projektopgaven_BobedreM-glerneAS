
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
            this.handelKøberID_txt = new System.Windows.Forms.ComboBox();
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
            // handelKøberID_txt
            // 
            this.handelKøberID_txt.FormattingEnabled = true;
            this.handelKøberID_txt.Location = new System.Drawing.Point(160, 276);
            this.handelKøberID_txt.Name = "handelKøberID_txt";
            this.handelKøberID_txt.Size = new System.Drawing.Size(136, 28);
            this.handelKøberID_txt.TabIndex = 2;
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
            // HandelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 852);
            this.Controls.Add(this.handelID_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_slethandel);
            this.Controls.Add(this.btn_opdaterhandel);
            this.Controls.Add(this.btn_findhandel);
            this.Controls.Add(this.btn_oprethandel);
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(45, 270);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 10;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handelSalgspris_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.handelKøberID_txt);
            this.Controls.Add(this.handelSalgsID_cbox);
            this.Name = "HandelUI";
            this.Text = "HandelUI";
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
        private System.Windows.Forms.ComboBox handelKøberID_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;


        public System.Windows.Forms.ComboBox GetSagsID_txt()
        {
            return handelSalgsID_cbox;
        }
    }
}