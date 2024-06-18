namespace Elearning.UserControls.User
{
    partial class ucYourCertificate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAllCertificate = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tbAllCertificate
            // 
            this.tbAllCertificate.ColumnCount = 1;
            this.tbAllCertificate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAllCertificate.Location = new System.Drawing.Point(0, 0);
            this.tbAllCertificate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAllCertificate.Name = "tbAllCertificate";
            this.tbAllCertificate.RowCount = 2;
            this.tbAllCertificate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllCertificate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllCertificate.Size = new System.Drawing.Size(481, 598);
            this.tbAllCertificate.TabIndex = 0;
            // 
            // ucYourCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tbAllCertificate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucYourCertificate";
            this.Size = new System.Drawing.Size(601, 747);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbAllCertificate;
    }
}
