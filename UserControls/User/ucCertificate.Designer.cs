namespace Elearning.UserControls.User
{
    partial class ucCertificate
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.picCourseImage = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblTimeFinish = new System.Windows.Forms.Label();
            this.btnViewDetails = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnViewCertificate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.Black;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(10, 5);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(10);
            this.siticonePanel1.Size = new System.Drawing.Size(730, 140);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.btnViewCertificate);
            this.siticonePanel3.Controls.Add(this.siticonePanel4);
            this.siticonePanel3.Controls.Add(this.btnViewDetails);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel3.Location = new System.Drawing.Point(520, 10);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.siticonePanel3.Size = new System.Drawing.Size(200, 120);
            this.siticonePanel3.TabIndex = 1;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblTimeFinish);
            this.siticonePanel2.Controls.Add(this.lblCourseName);
            this.siticonePanel2.Controls.Add(this.picCourseImage);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(10, 10);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(510, 120);
            this.siticonePanel2.TabIndex = 2;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(120, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Padding = new System.Windows.Forms.Padding(10, 25, 0, 0);
            this.lblCourseName.Size = new System.Drawing.Size(197, 57);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Course Name";
            // 
            // picCourseImage
            // 
            this.picCourseImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCourseImage.ImageRotate = 0F;
            this.picCourseImage.Location = new System.Drawing.Point(0, 0);
            this.picCourseImage.Name = "picCourseImage";
            this.picCourseImage.Size = new System.Drawing.Size(120, 120);
            this.picCourseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseImage.TabIndex = 4;
            this.picCourseImage.TabStop = false;
            // 
            // lblTimeFinish
            // 
            this.lblTimeFinish.AutoSize = true;
            this.lblTimeFinish.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimeFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeFinish.Location = new System.Drawing.Point(120, 57);
            this.lblTimeFinish.Name = "lblTimeFinish";
            this.lblTimeFinish.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lblTimeFinish.Size = new System.Drawing.Size(130, 28);
            this.lblTimeFinish.TabIndex = 6;
            this.lblTimeFinish.Text = "Lecturer name";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(0, 12);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(200, 45);
            this.btnViewDetails.TabIndex = 7;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel4.Location = new System.Drawing.Point(0, 57);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Size = new System.Drawing.Size(200, 5);
            this.siticonePanel4.TabIndex = 8;
            // 
            // btnViewCertificate
            // 
            this.btnViewCertificate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCertificate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCertificate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewCertificate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewCertificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCertificate.FillColor = System.Drawing.Color.White;
            this.btnViewCertificate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCertificate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.Location = new System.Drawing.Point(0, 62);
            this.btnViewCertificate.Name = "btnViewCertificate";
            this.btnViewCertificate.Size = new System.Drawing.Size(200, 45);
            this.btnViewCertificate.TabIndex = 9;
            this.btnViewCertificate.Text = "View certificate";
            this.btnViewCertificate.Click += new System.EventHandler(this.btnViewCertificate_Click);
            // 
            // ucCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel1);
            this.Name = "ucCertificate";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Size = new System.Drawing.Size(750, 150);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label lblCourseName;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox picCourseImage;
        private System.Windows.Forms.Label lblTimeFinish;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewCertificate;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetails;
    }
}
