namespace Elearning
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbUserFullname = new System.Windows.Forms.Label();
            this.btnUserProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.btnSignOut = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lbAppName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lbUserFullname);
            this.panelTop.Controls.Add(this.btnUserProfile);
            this.panelTop.Controls.Add(this.btnSignOut);
            this.panelTop.Controls.Add(this.lbAppName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.panelTop.Size = new System.Drawing.Size(1001, 40);
            this.panelTop.TabIndex = 0;
            // 
            // lbUserFullname
            // 
            this.lbUserFullname.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUserFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUserFullname.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUserFullname.Location = new System.Drawing.Point(751, 2);
            this.lbUserFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserFullname.Name = "lbUserFullname";
            this.lbUserFullname.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lbUserFullname.Size = new System.Drawing.Size(162, 36);
            this.lbUserFullname.TabIndex = 8;
            this.lbUserFullname.Text = "Nguyễn Văn A";
            this.lbUserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserProfile.ImageRotate = 0F;
            this.btnUserProfile.Location = new System.Drawing.Point(913, 2);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnUserProfile.Size = new System.Drawing.Size(40, 36);
            this.btnUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUserProfile.TabIndex = 9;
            this.btnUserProfile.TabStop = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageRotate = 0F;
            this.btnSignOut.Location = new System.Drawing.Point(953, 2);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(8);
            this.btnSignOut.Size = new System.Drawing.Size(40, 36);
            this.btnSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lbAppName
            // 
            this.lbAppName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAppName.Font = new System.Drawing.Font("UTM Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbAppName.Location = new System.Drawing.Point(2, 2);
            this.lbAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lbAppName.Size = new System.Drawing.Size(141, 36);
            this.lbAppName.TabIndex = 3;
            this.lbAppName.Text = "E-Learning";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAppName.Click += new System.EventHandler(this.lbAppName_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1001, 471);
            this.panelMain.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1001, 511);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbAppName;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox btnSignOut;
        private System.Windows.Forms.Label lbUserFullname;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox btnUserProfile;
    }
}