namespace Elearning.Forms
{
    partial class fFinishCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFinishCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnViewCertificate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnRateCourse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Congratulations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(800, 350);
            this.siticonePanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "You had finished this course";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.btnViewCertificate);
            this.siticonePanel2.Controls.Add(this.btnRateCourse);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 471);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(800, 108);
            this.siticonePanel2.TabIndex = 5;
            // 
            // btnViewCertificate
            // 
            this.btnViewCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.BorderThickness = 1;
            this.btnViewCertificate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCertificate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCertificate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewCertificate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewCertificate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewCertificate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCertificate.ForeColor = System.Drawing.Color.White;
            this.btnViewCertificate.Location = new System.Drawing.Point(412, 29);
            this.btnViewCertificate.Name = "btnViewCertificate";
            this.btnViewCertificate.Size = new System.Drawing.Size(200, 50);
            this.btnViewCertificate.TabIndex = 27;
            this.btnViewCertificate.Text = "View certificate";
            this.btnViewCertificate.Click += new System.EventHandler(this.btnViewCertificate_Click);
            // 
            // btnRateCourse
            // 
            this.btnRateCourse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnRateCourse.BorderThickness = 1;
            this.btnRateCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRateCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRateCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRateCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRateCourse.FillColor = System.Drawing.Color.White;
            this.btnRateCourse.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnRateCourse.Location = new System.Drawing.Point(189, 29);
            this.btnRateCourse.Name = "btnRateCourse";
            this.btnRateCourse.Size = new System.Drawing.Size(200, 50);
            this.btnRateCourse.TabIndex = 26;
            this.btnRateCourse.Text = "Rate course";
            this.btnRateCourse.Click += new System.EventHandler(this.btnRateCourse_Click);
            // 
            // fFinishCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fFinishCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewCertificate;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRateCourse;
    }
}