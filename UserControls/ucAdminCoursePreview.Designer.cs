namespace Elearning.UserControls
{
    partial class ucAdminCoursePreview
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
            this.pbImage = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.btnViewDetails = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbLecturer = new System.Windows.Forms.Label();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbOriginalPrice = new System.Windows.Forms.Label();
            this.lbFinalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BorderRadius = 6;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(14, 14);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(290, 179);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BorderRadius = 5;
            this.btnViewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(14, 326);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(290, 44);
            this.btnViewDetails.TabIndex = 6;
            this.btnViewDetails.Text = "View and Edit";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lbCourseName
            // 
            this.lbCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(14, 214);
            this.lbCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(290, 52);
            this.lbCourseName.TabIndex = 5;
            this.lbCourseName.Text = "Introduction to Programming with C++: Basic mini course I";
            this.lbCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLecturer
            // 
            this.lbLecturer.BackColor = System.Drawing.Color.Transparent;
            this.lbLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLecturer.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLecturer.Location = new System.Drawing.Point(14, 193);
            this.lbLecturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLecturer.Name = "lbLecturer";
            this.lbLecturer.Size = new System.Drawing.Size(290, 21);
            this.lbLecturer.TabIndex = 4;
            this.lbLecturer.Text = "Prof. Nguyen Tran Dang Vo";
            this.lbLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.BackColor = System.Drawing.SystemColors.Control;
            this.siticoneContainerControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticoneContainerControl1.BorderRadius = 8;
            this.siticoneContainerControl1.BorderThickness = 1;
            this.siticoneContainerControl1.Controls.Add(this.siticoneContainerControl2);
            this.siticoneContainerControl1.Controls.Add(this.btnViewDetails);
            this.siticoneContainerControl1.Controls.Add(this.lbCourseName);
            this.siticoneContainerControl1.Controls.Add(this.lbLecturer);
            this.siticoneContainerControl1.Controls.Add(this.pbImage);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(14);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(318, 384);
            this.siticoneContainerControl1.TabIndex = 7;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.lbFinalPrice);
            this.siticoneContainerControl2.Controls.Add(this.lbOriginalPrice);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl2.FillColor = System.Drawing.SystemColors.Control;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(14, 266);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Size = new System.Drawing.Size(290, 31);
            this.siticoneContainerControl2.TabIndex = 7;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // lbOriginalPrice
            // 
            this.lbOriginalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbOriginalPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbOriginalPrice.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginalPrice.Location = new System.Drawing.Point(0, 0);
            this.lbOriginalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOriginalPrice.Name = "lbOriginalPrice";
            this.lbOriginalPrice.Size = new System.Drawing.Size(150, 31);
            this.lbOriginalPrice.TabIndex = 5;
            this.lbOriginalPrice.Text = "Prof. Nguyen Tran Dang Vo";
            this.lbOriginalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFinalPrice
            // 
            this.lbFinalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbFinalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbFinalPrice.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalPrice.Location = new System.Drawing.Point(154, 0);
            this.lbFinalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFinalPrice.Name = "lbFinalPrice";
            this.lbFinalPrice.Size = new System.Drawing.Size(136, 31);
            this.lbFinalPrice.TabIndex = 6;
            this.lbFinalPrice.Text = "Prof. Nguyen Tran Dang Vo";
            this.lbFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucAdminCoursePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.Name = "ucAdminCoursePreview";
            this.Size = new System.Drawing.Size(318, 384);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox pbImage;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetails;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbLecturer;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private System.Windows.Forms.Label lbFinalPrice;
        private System.Windows.Forms.Label lbOriginalPrice;
    }
}
