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
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbLecturer = new System.Windows.Forms.Label();
            this.pbImaga = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.conInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImaga)).BeginInit();
            this.SuspendLayout();
            // 
            // conInfo
            // 
            this.conInfo.Controls.Add(this.btnViewDetails);
            this.conInfo.Controls.Add(this.lbCourseName);
            this.conInfo.Controls.Add(this.lbLecturer);
            this.conInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conInfo.FillColor = System.Drawing.Color.Transparent;
            this.conInfo.Location = new System.Drawing.Point(10, 127);
            this.conInfo.Name = "conInfo";
            this.conInfo.Padding = new System.Windows.Forms.Padding(4, 10, 4, 5);
            this.conInfo.Size = new System.Drawing.Size(228, 111);
            this.conInfo.TabIndex = 1;
            this.conInfo.Text = "siticoneContainerControl1";
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
            this.btnViewDetails.Location = new System.Drawing.Point(4, 71);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(220, 35);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lbCourseName
            // 
            this.lbCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(4, 20);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(220, 50);
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
            this.lbLecturer.Size = new System.Drawing.Size(220, 10);
            this.lbLecturer.TabIndex = 0;
            this.lbLecturer.Text = "Prof. Nguyen Tran Dang Vo";
            this.lbLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbImaga
            // 
            this.pbImaga.BackColor = System.Drawing.Color.Transparent;
            this.pbImaga.BorderRadius = 6;
            this.pbImaga.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImaga.ImageRotate = 0F;
            this.pbImaga.Location = new System.Drawing.Point(10, 10);
            this.pbImaga.Name = "pbImaga";
            this.pbImaga.Size = new System.Drawing.Size(228, 117);
            this.pbImaga.TabIndex = 0;
            this.pbImaga.TabStop = false;
            // 
            // ucCoursePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.conInfo);
            this.Controls.Add(this.pbImaga);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "ucCoursePreview";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(248, 248);
            this.conInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImaga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox pbImaga;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conInfo;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbLecturer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetails;
    }
}
