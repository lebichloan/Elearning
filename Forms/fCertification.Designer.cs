namespace Elearning.Forms
{
    partial class fCertification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCertification));
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblTimeFinish = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.picCertificate = new System.Windows.Forms.PictureBox();
            this.btnDownload = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).BeginInit();
            this.btnDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(104, 367);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(945, 111);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Lê Thị Bích Loan";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourseName
            // 
            this.lblCourseName.BackColor = System.Drawing.Color.White;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(102, 522);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(947, 72);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "label1";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeFinish
            // 
            this.lblTimeFinish.BackColor = System.Drawing.Color.White;
            this.lblTimeFinish.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeFinish.Location = new System.Drawing.Point(192, 625);
            this.lblTimeFinish.Name = "lblTimeFinish";
            this.lblTimeFinish.Size = new System.Drawing.Size(260, 23);
            this.lblTimeFinish.TabIndex = 3;
            this.lblTimeFinish.Text = "Date: 16/06/2024";
            this.lblTimeFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(193)))), ((int)(((byte)(208)))));
            this.siticonePanel1.Location = new System.Drawing.Point(336, 465);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(500, 1);
            this.siticonePanel1.TabIndex = 4;
            // 
            // lblLecturer
            // 
            this.lblLecturer.BackColor = System.Drawing.Color.White;
            this.lblLecturer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturer.Location = new System.Drawing.Point(710, 625);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(260, 23);
            this.lblLecturer.TabIndex = 5;
            this.lblLecturer.Text = "lecturer";
            this.lblLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCertificate
            // 
            this.picCertificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.picCertificate.Image = ((System.Drawing.Image)(resources.GetObject("picCertificate.Image")));
            this.picCertificate.Location = new System.Drawing.Point(0, 0);
            this.picCertificate.Name = "picCertificate";
            this.picCertificate.Size = new System.Drawing.Size(1150, 813);
            this.picCertificate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCertificate.TabIndex = 0;
            this.picCertificate.TabStop = false;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnDownload.BorderRadius = 2;
            this.btnDownload.Controls.Add(this.label1);
            this.btnDownload.Controls.Add(this.pictureBox2);
            this.btnDownload.Location = new System.Drawing.Point(475, 13);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(5);
            this.btnDownload.Size = new System.Drawing.Size(275, 50);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Download Certificate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.White;
            this.siticonePanel2.Controls.Add(this.btnDownload);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 813);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1150, 107);
            this.siticonePanel2.TabIndex = 7;
            // 
            // fCertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1150, 920);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.lblTimeFinish);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picCertificate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fCertification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picCertificate)).EndInit();
            this.btnDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblTimeFinish;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.PictureBox picCertificate;
        private Siticone.Desktop.UI.WinForms.SiticonePanel btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
    }
}