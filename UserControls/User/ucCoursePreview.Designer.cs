namespace Elearning.UserControls
{
    partial class ucCoursePreview
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
            this.conInfo = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbLecturer = new System.Windows.Forms.Label();
            this.picImage = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.panMoreOption = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnRate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panMargin = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnViewCertificate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnViewDetails = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.conInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panMoreOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // conInfo
            // 
            this.conInfo.Controls.Add(this.btnViewDetails);
            this.conInfo.Controls.Add(this.siticonePanel1);
            this.conInfo.Controls.Add(this.panMoreOption);
            this.conInfo.Controls.Add(this.lbCourseName);
            this.conInfo.Controls.Add(this.lbLecturer);
            this.conInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conInfo.FillColor = System.Drawing.Color.Transparent;
            this.conInfo.Location = new System.Drawing.Point(15, 215);
            this.conInfo.Name = "conInfo";
            this.conInfo.Padding = new System.Windows.Forms.Padding(4, 10, 4, 5);
            this.conInfo.Size = new System.Drawing.Size(293, 218);
            this.conInfo.TabIndex = 1;
            this.conInfo.Text = "siticoneContainerControl1";
            // 
            // lbCourseName
            // 
            this.lbCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(4, 35);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(285, 50);
            this.lbCourseName.TabIndex = 1;
            this.lbCourseName.Text = "Introduction to Programming with C++: Basic mini course I";
            this.lbCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLecturer
            // 
            this.lbLecturer.BackColor = System.Drawing.Color.Transparent;
            this.lbLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLecturer.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLecturer.Location = new System.Drawing.Point(4, 10);
            this.lbLecturer.Name = "lbLecturer";
            this.lbLecturer.Size = new System.Drawing.Size(285, 25);
            this.lbLecturer.TabIndex = 0;
            this.lbLecturer.Text = "Prof. Nguyen Tran Dang Vo";
            this.lbLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.BorderRadius = 6;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(15, 15);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(293, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // panMoreOption
            // 
            this.panMoreOption.Controls.Add(this.btnViewCertificate);
            this.panMoreOption.Controls.Add(this.panMargin);
            this.panMoreOption.Controls.Add(this.btnRate);
            this.panMoreOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMoreOption.Location = new System.Drawing.Point(4, 154);
            this.panMoreOption.Name = "panMoreOption";
            this.panMoreOption.Size = new System.Drawing.Size(285, 59);
            this.panMoreOption.TabIndex = 5;
            // 
            // btnRate
            // 
            this.btnRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRate.FillColor = System.Drawing.Color.White;
            this.btnRate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnRate.Location = new System.Drawing.Point(0, 0);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(140, 59);
            this.btnRate.TabIndex = 3;
            this.btnRate.Text = "Rate course";
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // panMargin
            // 
            this.panMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMargin.Location = new System.Drawing.Point(140, 0);
            this.panMargin.Name = "panMargin";
            this.panMargin.Size = new System.Drawing.Size(5, 59);
            this.panMargin.TabIndex = 4;
            // 
            // btnViewCertificate
            // 
            this.btnViewCertificate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCertificate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCertificate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewCertificate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewCertificate.FillColor = System.Drawing.Color.White;
            this.btnViewCertificate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCertificate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.Location = new System.Drawing.Point(145, 0);
            this.btnViewCertificate.Name = "btnViewCertificate";
            this.btnViewCertificate.Size = new System.Drawing.Size(140, 59);
            this.btnViewCertificate.TabIndex = 5;
            this.btnViewCertificate.Text = "View certificate";
            this.btnViewCertificate.Click += new System.EventHandler(this.btnViewCertificate_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(4, 104);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(285, 45);
            this.btnViewDetails.TabIndex = 7;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(4, 149);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(285, 5);
            this.siticonePanel1.TabIndex = 6;
            // 
            // ucCoursePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.conInfo);
            this.Controls.Add(this.picImage);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximumSize = new System.Drawing.Size(325, 450);
            this.Name = "ucCoursePreview";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(323, 448);
            this.conInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panMoreOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox picImage;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conInfo;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbLecturer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panMoreOption;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRate;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panMargin;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetails;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewCertificate;
    }
}
