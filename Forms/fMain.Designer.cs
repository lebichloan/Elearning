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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbUserFullname = new System.Windows.Forms.Label();
            this.btnUserProfile = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.lbAppName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.lbUserFullname);
            this.panelTop.Controls.Add(this.btnUserProfile);
            this.panelTop.Controls.Add(this.lbAppName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1228, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lbUserFullname
            // 
            this.lbUserFullname.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUserFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUserFullname.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUserFullname.Location = new System.Drawing.Point(976, 0);
            this.lbUserFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserFullname.Name = "lbUserFullname";
            this.lbUserFullname.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbUserFullname.Size = new System.Drawing.Size(202, 50);
            this.lbUserFullname.TabIndex = 2;
            this.lbUserFullname.Text = "Nguyễn Văn A";
            this.lbUserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserProfile.ImageRotate = 0F;
            this.btnUserProfile.Location = new System.Drawing.Point(1178, 0);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnUserProfile.Size = new System.Drawing.Size(50, 50);
            this.btnUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUserProfile.TabIndex = 6;
            this.btnUserProfile.TabStop = false;
            // 
            // lbAppName
            // 
            this.lbAppName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbAppName.Location = new System.Drawing.Point(0, 0);
            this.lbAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbAppName.Size = new System.Drawing.Size(176, 50);
            this.lbAppName.TabIndex = 3;
            this.lbAppName.Text = "E-Learning";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAppName.Click += new System.EventHandler(this.lbAppName_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1228, 629);
            this.panelMain.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1228, 679);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbUserFullname;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbAppName;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox btnUserProfile;
    }
}