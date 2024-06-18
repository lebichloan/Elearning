﻿namespace Elearning.Forms
{
    partial class fAdminMain
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
            this.lbAppName = new System.Windows.Forms.Label();
            this.lbUserFullname = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnUserProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.conControl = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCourses = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnStatistics = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAccount = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.conMain = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).BeginInit();
            this.conControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAppName
            // 
            this.lbAppName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAppName.Font = new System.Drawing.Font("UTM Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbAppName.Location = new System.Drawing.Point(3, 3);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbAppName.Size = new System.Drawing.Size(176, 44);
            this.lbAppName.TabIndex = 3;
            this.lbAppName.Text = "E-Learning";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserFullname
            // 
            this.lbUserFullname.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUserFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUserFullname.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUserFullname.Location = new System.Drawing.Point(955, 3);
            this.lbUserFullname.Name = "lbUserFullname";
            this.lbUserFullname.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbUserFullname.Size = new System.Drawing.Size(203, 44);
            this.lbUserFullname.TabIndex = 2;
            this.lbUserFullname.Text = "Nguyễn Văn A";
            this.lbUserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lbUserFullname);
            this.panelTop.Controls.Add(this.btnUserProfile);
            this.panelTop.Controls.Add(this.lbAppName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(3);
            this.panelTop.Size = new System.Drawing.Size(1205, 50);
            this.panelTop.TabIndex = 1;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserProfile.ImageRotate = 0F;
            this.btnUserProfile.Location = new System.Drawing.Point(1158, 3);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnUserProfile.Size = new System.Drawing.Size(44, 44);
            this.btnUserProfile.TabIndex = 6;
            this.btnUserProfile.TabStop = false;
            // 
            // conControl
            // 
            this.conControl.Controls.Add(this.flowLayoutPanel1);
            this.conControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.conControl.Location = new System.Drawing.Point(0, 50);
            this.conControl.Margin = new System.Windows.Forms.Padding(4);
            this.conControl.Name = "conControl";
            this.conControl.Size = new System.Drawing.Size(1205, 79);
            this.conControl.TabIndex = 2;
            this.conControl.Text = "siticoneContainerControl2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCourses);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistics);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1205, 79);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCourses
            // 
            this.btnCourses.BorderRadius = 6;
            this.btnCourses.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnCourses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCourses.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnCourses.DisabledState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCourses.Enabled = false;
            this.btnCourses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = global::Elearning.Properties.Resources.syllabus;
            this.btnCourses.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCourses.Location = new System.Drawing.Point(27, 11);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(165, 58);
            this.btnCourses.TabIndex = 10;
            this.btnCourses.Text = "Courses";
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BorderRadius = 6;
            this.btnStatistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnStatistics.DisabledState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnStatistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatistics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::Elearning.Properties.Resources.syllabus;
            this.btnStatistics.ImageSize = new System.Drawing.Size(22, 22);
            this.btnStatistics.Location = new System.Drawing.Point(206, 11);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(165, 58);
            this.btnStatistics.TabIndex = 11;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 6;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::Elearning.Properties.Resources.syllabus;
            this.btnAccount.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAccount.Location = new System.Drawing.Point(385, 11);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(165, 58);
            this.btnAccount.TabIndex = 12;
            this.btnAccount.Text = "Account";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // conMain
            // 
            this.conMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMain.Location = new System.Drawing.Point(0, 129);
            this.conMain.Margin = new System.Windows.Forms.Padding(4);
            this.conMain.Name = "conMain";
            this.conMain.Size = new System.Drawing.Size(1205, 542);
            this.conMain.TabIndex = 3;
            this.conMain.Text = "siticoneContainerControl2";
            // 
            // fAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 671);
            this.Controls.Add(this.conMain);
            this.Controls.Add(this.conControl);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fAdminMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELearning Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAdminMain_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fAdminMain_FormClosed);
            this.Load += new System.EventHandler(this.ucAdminMain_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).EndInit();
            this.conControl.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbAppName;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox btnUserProfile;
        private System.Windows.Forms.Label lbUserFullname;
        private System.Windows.Forms.Panel panelTop;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conControl;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCourses;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStatistics;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAccount;
    }
}