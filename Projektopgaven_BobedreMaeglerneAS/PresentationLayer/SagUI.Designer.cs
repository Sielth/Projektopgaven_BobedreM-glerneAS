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
            this.sagsnr_lbl = new System.Windows.Forms.Label();
            this.sagsStatus_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sagsnr_lbl
            // 
            this.sagsnr_lbl.AutoSize = true;
            this.sagsnr_lbl.Location = new System.Drawing.Point(22, 23);
            this.sagsnr_lbl.Name = "sagsnr_lbl";
            this.sagsnr_lbl.Size = new System.Drawing.Size(43, 13);
            this.sagsnr_lbl.TabIndex = 0;
            this.sagsnr_lbl.Text = "Sags nr";
            // 
            // sagsStatus_lbl
            // 
            this.sagsStatus_lbl.AutoSize = true;
            this.sagsStatus_lbl.Location = new System.Drawing.Point(22, 71);
            this.sagsStatus_lbl.Name = "sagsStatus_lbl";
            this.sagsStatus_lbl.Size = new System.Drawing.Size(37, 13);
            this.sagsStatus_lbl.TabIndex = 1;
            this.sagsStatus_lbl.Text = "Status";
            // 
            // SagUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sagsStatus_lbl);
            this.Controls.Add(this.sagsnr_lbl);
            this.Name = "SagUI";
            this.Text = "SagUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sagsnr_lbl;
        private System.Windows.Forms.Label sagsStatus_lbl;
    }
}