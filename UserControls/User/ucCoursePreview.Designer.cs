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
            this.btnViewDetails = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tbButton = new System.Windows.Forms.TableLayoutPanel();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbLecturer = new System.Windows.Forms.Label();
            this.picImage = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.conInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // conInfo
            // 
            this.conInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.conInfo.BorderRadius = 8;
            this.conInfo.BorderThickness = 1;
            this.conInfo.Controls.Add(this.btnViewDetails);
            this.conInfo.Controls.Add(this.siticonePanel1);
            this.conInfo.Controls.Add(this.tbButton);
            this.conInfo.Controls.Add(this.lbCourseName);
            this.conInfo.Controls.Add(this.lbLecturer);
            this.conInfo.Controls.Add(this.picImage);
            this.conInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conInfo.FillColor = System.Drawing.Color.Transparent;
            this.conInfo.Location = new System.Drawing.Point(0, 0);
            this.conInfo.Margin = new System.Windows.Forms.Padding(2);
            this.conInfo.Name = "conInfo";
            this.conInfo.Padding = new System.Windows.Forms.Padding(15);
            this.conInfo.Size = new System.Drawing.Size(388, 450);
            this.conInfo.TabIndex = 1;
            this.conInfo.Text = "siticoneContainerControl1";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BorderRadius = 4;
            this.btnViewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(15, 331);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(358, 54);
            this.btnViewDetails.TabIndex = 10;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(15, 385);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(358, 5);
            this.siticonePanel1.TabIndex = 9;
            // 
            // tbButton
            // 
            this.tbButton.ColumnCount = 3;
            this.tbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbButton.Location = new System.Drawing.Point(15, 390);
            this.tbButton.Name = "tbButton";
            this.tbButton.RowCount = 1;
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbButton.Size = new System.Drawing.Size(358, 45);
            this.tbButton.TabIndex = 8;
            // 
            // lbCourseName
            // 
            this.lbCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(15, 240);
            this.lbCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(358, 55);
            this.lbCourseName.TabIndex = 1;
            this.lbCourseName.Text = "Introduction to Programming with C++: Basic mini course I";
            this.lbCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLecturer
            // 
            this.lbLecturer.BackColor = System.Drawing.Color.Transparent;
            this.lbLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLecturer.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLecturer.Location = new System.Drawing.Point(15, 215);
            this.lbLecturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLecturer.Name = "lbLecturer";
            this.lbLecturer.Size = new System.Drawing.Size(358, 25);
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
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(358, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // ucCoursePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.conInfo);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.Name = "ucCoursePreview";
            this.Size = new System.Drawing.Size(388, 450);
            this.conInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox picImage;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conInfo;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbLecturer;
        //private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewCertificate;
        private System.Windows.Forms.TableLayoutPanel tbButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetails;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
    }
}
