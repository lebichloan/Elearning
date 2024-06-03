﻿namespace Elearning.UserControls
{
    partial class ucCourse
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
            this.panTop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnViewDetail = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblDone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.picCourseImage = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.btnBackHome = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.layoutResource = new System.Windows.Forms.TableLayoutPanel();
            this.layoutModule = new System.Windows.Forms.TableLayoutPanel();
            this.panTop.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticoneContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseImage)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.SystemColors.Window;
            this.panTop.Controls.Add(this.siticonePanel3);
            this.panTop.Controls.Add(this.btnBackHome);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1100, 50);
            this.panTop.TabIndex = 0;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.siticoneContainerControl1);
            this.siticonePanel3.Controls.Add(this.picCourseImage);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.siticonePanel3.Size = new System.Drawing.Size(783, 50);
            this.siticonePanel3.TabIndex = 11;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.btnViewDetail);
            this.siticoneContainerControl1.Controls.Add(this.lblDone);
            this.siticoneContainerControl1.Controls.Add(this.panel2);
            this.siticoneContainerControl1.Controls.Add(this.lblLecturerName);
            this.siticoneContainerControl1.Controls.Add(this.panel1);
            this.siticoneContainerControl1.Controls.Add(this.lblCourseName);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(50, 0);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(733, 40);
            this.siticoneContainerControl1.TabIndex = 4;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Location = new System.Drawing.Point(383, 10);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(150, 30);
            this.btnViewDetail.TabIndex = 14;
            this.btnViewDetail.Text = "View detail";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblDone.ForeColor = System.Drawing.Color.Red;
            this.lblDone.Location = new System.Drawing.Point(313, 10);
            this.lblDone.Name = "lblDone";
            this.lblDone.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDone.Size = new System.Drawing.Size(70, 27);
            this.lblDone.TabIndex = 12;
            this.lblDone.Text = "Done";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(312, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 30);
            this.panel2.TabIndex = 11;
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLecturerName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblLecturerName.Location = new System.Drawing.Point(157, 10);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblLecturerName.Size = new System.Drawing.Size(155, 27);
            this.lblLecturerName.TabIndex = 10;
            this.lblLecturerName.Text = "Lecturer name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(156, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 30);
            this.panel1.TabIndex = 9;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.Location = new System.Drawing.Point(10, 10);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCourseName.Size = new System.Drawing.Size(146, 27);
            this.lblCourseName.TabIndex = 8;
            this.lblCourseName.Text = "Course Name";
            // 
            // picCourseImage
            // 
            this.picCourseImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCourseImage.ImageRotate = 0F;
            this.picCourseImage.Location = new System.Drawing.Point(10, 0);
            this.picCourseImage.Margin = new System.Windows.Forms.Padding(0);
            this.picCourseImage.Name = "picCourseImage";
            this.picCourseImage.Size = new System.Drawing.Size(40, 40);
            this.picCourseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseImage.TabIndex = 1;
            this.picCourseImage.TabStop = false;
            // 
            // btnBackHome
            // 
            this.btnBackHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackHome.ForeColor = System.Drawing.Color.White;
            this.btnBackHome.Location = new System.Drawing.Point(950, 0);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(150, 45);
            this.btnBackHome.TabIndex = 10;
            this.btnBackHome.Text = "Back";
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.layoutResource);
            this.siticonePanel1.Controls.Add(this.layoutModule);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 50);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1100, 600);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Black;
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel2.Location = new System.Drawing.Point(462, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(5);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1, 600);
            this.siticonePanel2.TabIndex = 5;
            // 
            // layoutResource
            // 
            this.layoutResource.ColumnCount = 1;
            this.layoutResource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutResource.Location = new System.Drawing.Point(462, 0);
            this.layoutResource.Name = "layoutResource";
            this.layoutResource.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.layoutResource.RowCount = 2;
            this.layoutResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResource.Size = new System.Drawing.Size(638, 600);
            this.layoutResource.TabIndex = 4;
            // 
            // layoutModule
            // 
            this.layoutModule.ColumnCount = 1;
            this.layoutModule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutModule.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutModule.Location = new System.Drawing.Point(0, 0);
            this.layoutModule.Name = "layoutModule";
            this.layoutModule.RowCount = 2;
            this.layoutModule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutModule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutModule.Size = new System.Drawing.Size(462, 600);
            this.layoutModule.TabIndex = 3;
            // 
            // ucCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.panTop);
            this.Name = "ucCourse";
            this.Size = new System.Drawing.Size(1100, 650);
            this.panTop.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseImage)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panTop;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.TableLayoutPanel layoutResource;
        private System.Windows.Forms.TableLayoutPanel layoutModule;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBackHome;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox picCourseImage;
        private System.Windows.Forms.Label lblLecturerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetail;
    }
}