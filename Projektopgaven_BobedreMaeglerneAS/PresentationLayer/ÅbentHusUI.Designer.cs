namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class ÅbentHusUI
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
            this.åbentHus_boligListe_lbox = new System.Windows.Forms.ListBox();
            this.åbentHus_bogstav1_txt = new System.Windows.Forms.TextBox();
            this.åbentHus_bogstav2_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // åbentHus_boligListe_lbox
            // 
            this.åbentHus_boligListe_lbox.FormattingEnabled = true;
            this.åbentHus_boligListe_lbox.Location = new System.Drawing.Point(12, 152);
            this.åbentHus_boligListe_lbox.Name = "åbentHus_boligListe_lbox";
            this.åbentHus_boligListe_lbox.Size = new System.Drawing.Size(776, 290);
            this.åbentHus_boligListe_lbox.TabIndex = 0;
            // 
            // åbentHus_bogstav1_txt
            // 
            this.åbentHus_bogstav1_txt.Location = new System.Drawing.Point(305, 88);
            this.åbentHus_bogstav1_txt.Name = "åbentHus_bogstav1_txt";
            this.åbentHus_bogstav1_txt.Size = new System.Drawing.Size(22, 20);
            this.åbentHus_bogstav1_txt.TabIndex = 1;
            // 
            // åbentHus_bogstav2_txt
            // 
            this.åbentHus_bogstav2_txt.Location = new System.Drawing.Point(362, 88);
            this.åbentHus_bogstav2_txt.Name = "åbentHus_bogstav2_txt";
            this.åbentHus_bogstav2_txt.Size = new System.Drawing.Size(22, 20);
            this.åbentHus_bogstav2_txt.TabIndex = 2;
            // 
            // ÅbentHusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.åbentHus_bogstav2_txt);
            this.Controls.Add(this.åbentHus_bogstav1_txt);
            this.Controls.Add(this.åbentHus_boligListe_lbox);
            this.Name = "ÅbentHusUI";
            this.Text = "ÅbentHusUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox åbentHus_boligListe_lbox;
        private System.Windows.Forms.TextBox åbentHus_bogstav1_txt;
        private System.Windows.Forms.TextBox åbentHus_bogstav2_txt;
    }
}