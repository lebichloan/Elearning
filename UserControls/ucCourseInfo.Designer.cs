namespace Elearning.UserControls
{
    partial class ucCourseInfo
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
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbLecturer = new System.Windows.Forms.Label();
            this.conTop = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl4 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnRegister = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl3 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnBackHome = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.conTop.SuspendLayout();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.siticoneContainerControl4.SuspendLayout();
            this.siticoneContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCourseName
            // 
            this.lbCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(0, 0);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbCourseName.Size = new System.Drawing.Size(982, 43);
            this.lbCourseName.TabIndex = 0;
            this.lbCourseName.Text = "Introduction to Programming with C++: Basic mini course I";
            this.lbCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLecturer
            // 
            this.lbLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLecturer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLecturer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLecturer.Location = new System.Drawing.Point(0, 43);
            this.lbLecturer.Name = "lbLecturer";
            this.lbLecturer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbLecturer.Size = new System.Drawing.Size(982, 24);
            this.lbLecturer.TabIndex = 1;
            this.lbLecturer.Text = "Prof. Nguyen Tran Dang Vo";
            // 
            // conTop
            // 
            this.conTop.BackColor = System.Drawing.Color.Transparent;
            this.conTop.Controls.Add(this.siticoneContainerControl1);
            this.conTop.Controls.Add(this.siticoneContainerControl2);
            this.conTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.conTop.FillColor = System.Drawing.Color.Transparent;
            this.conTop.Location = new System.Drawing.Point(0, 0);
            this.conTop.Name = "conTop";
            this.conTop.Size = new System.Drawing.Size(1233, 80);
            this.conTop.TabIndex = 2;
            this.conTop.Text = "siticoneContainerControl1";
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.lbLecturer);
            this.siticoneContainerControl1.Controls.Add(this.lbCourseName);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(982, 80);
            this.siticoneContainerControl1.TabIndex = 2;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.siticoneContainerControl4);
            this.siticoneContainerControl2.Controls.Add(this.siticoneContainerControl3);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(982, 0);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(0, 5, 4, 5);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(251, 80);
            this.siticoneContainerControl2.TabIndex = 1;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // siticoneContainerControl4
            // 
            this.siticoneContainerControl4.Controls.Add(this.btnRegister);
            this.siticoneContainerControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl4.Location = new System.Drawing.Point(7, 5);
            this.siticoneContainerControl4.Name = "siticoneContainerControl4";
            this.siticoneContainerControl4.Padding = new System.Windows.Forms.Padding(3);
            this.siticoneContainerControl4.Size = new System.Drawing.Size(120, 70);
            this.siticoneContainerControl4.TabIndex = 3;
            this.siticoneContainerControl4.Text = "Enroll now";
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 2;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(3, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(114, 64);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // siticoneContainerControl3
            // 
            this.siticoneContainerControl3.Controls.Add(this.btnBackHome);
            this.siticoneContainerControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl3.Location = new System.Drawing.Point(127, 5);
            this.siticoneContainerControl3.Name = "siticoneContainerControl3";
            this.siticoneContainerControl3.Padding = new System.Windows.Forms.Padding(3);
            this.siticoneContainerControl3.Size = new System.Drawing.Size(120, 70);
            this.siticoneContainerControl3.TabIndex = 0;
            this.siticoneContainerControl3.Text = "siticoneContainerControl3";
            // 
            // btnBackHome
            // 
            this.btnBackHome.BorderRadius = 2;
            this.btnBackHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackHome.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.ForeColor = System.Drawing.Color.White;
            this.btnBackHome.Location = new System.Drawing.Point(3, 3);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(114, 64);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "Back to home";
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // ucCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.conTop);
            this.Name = "ucCourseInfo";
            this.Size = new System.Drawing.Size(1233, 667);
            this.conTop.ResumeLayout(false);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.siticoneContainerControl4.ResumeLayout(false);
            this.siticoneContainerControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbLecturer;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conTop;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRegister;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBackHome;
    }
}
