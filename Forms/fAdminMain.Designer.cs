namespace Elearning.Forms
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbUserFullname = new System.Windows.Forms.Label();
            this.btnUserProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.lbAppName = new System.Windows.Forms.Label();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnNoti = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.conMain = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).BeginInit();
            this.siticoneContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lbUserFullname);
            this.panelTop.Controls.Add(this.btnUserProfile);
            this.panelTop.Controls.Add(this.lbAppName);
            this.panelTop.Controls.Add(this.siticoneContainerControl1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(904, 41);
            this.panelTop.TabIndex = 1;
            // 
            // lbUserFullname
            // 
            this.lbUserFullname.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUserFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUserFullname.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUserFullname.Location = new System.Drawing.Point(676, 0);
            this.lbUserFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserFullname.Name = "lbUserFullname";
            this.lbUserFullname.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lbUserFullname.Size = new System.Drawing.Size(152, 41);
            this.lbUserFullname.TabIndex = 2;
            this.lbUserFullname.Text = "Nguyễn Văn A";
            this.lbUserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserProfile.ImageRotate = 0F;
            this.btnUserProfile.Location = new System.Drawing.Point(828, 0);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnUserProfile.Size = new System.Drawing.Size(38, 41);
            this.btnUserProfile.TabIndex = 6;
            this.btnUserProfile.TabStop = false;
            // 
            // lbAppName
            // 
            this.lbAppName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAppName.Font = new System.Drawing.Font("UTM Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbAppName.Location = new System.Drawing.Point(0, 0);
            this.lbAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.lbAppName.Size = new System.Drawing.Size(132, 41);
            this.lbAppName.TabIndex = 3;
            this.lbAppName.Text = "E-Learning";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.btnNoti);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(866, 0);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(38, 41);
            this.siticoneContainerControl1.TabIndex = 7;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // btnNoti
            // 
            this.btnNoti.BackgroundImage = global::Elearning.Properties.Resources.light_notification;
            this.btnNoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNoti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNoti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNoti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNoti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoti.FillColor = System.Drawing.Color.Transparent;
            this.btnNoti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNoti.ForeColor = System.Drawing.Color.White;
            this.btnNoti.Location = new System.Drawing.Point(3, 3);
            this.btnNoti.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Size = new System.Drawing.Size(32, 35);
            this.btnNoti.TabIndex = 8;
            // 
            // conMain
            // 
            this.conMain.BackColor = System.Drawing.Color.White;
            this.conMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conMain.Location = new System.Drawing.Point(0, 41);
            this.conMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conMain.Name = "conMain";
            this.conMain.Size = new System.Drawing.Size(904, 504);
            this.conMain.TabIndex = 2;
            this.conMain.Text = "siticoneContainerControl2";
            // 
            // fAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 545);
            this.Controls.Add(this.conMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "fAdminMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELearning Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ucAdminMain_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).EndInit();
            this.siticoneContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbUserFullname;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox btnUserProfile;
        private System.Windows.Forms.Label lbAppName;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNoti;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conMain;
    }
}