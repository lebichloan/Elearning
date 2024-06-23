namespace Elearning.UserControls.User
{
    partial class ucMyElearning
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
            this.panTop = new System.Windows.Forms.Panel();
            this.btnNotYet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnComplete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnAll = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.layoutMyCourses = new System.Windows.Forms.TableLayoutPanel();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.btnNotYet);
            this.panTop.Controls.Add(this.siticonePanel2);
            this.panTop.Controls.Add(this.btnComplete);
            this.panTop.Controls.Add(this.siticonePanel1);
            this.panTop.Controls.Add(this.btnAll);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(100, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panTop.Name = "panTop";
            this.panTop.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panTop.Size = new System.Drawing.Size(681, 52);
            this.panTop.TabIndex = 4;
            // 
            // btnNotYet
            // 
            this.btnNotYet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnNotYet.BorderRadius = 10;
            this.btnNotYet.BorderThickness = 1;
            this.btnNotYet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotYet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotYet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotYet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotYet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotYet.FillColor = System.Drawing.Color.White;
            this.btnNotYet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotYet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnNotYet.Location = new System.Drawing.Point(220, 8);
            this.btnNotYet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNotYet.Name = "btnNotYet";
            this.btnNotYet.Size = new System.Drawing.Size(96, 36);
            this.btnNotYet.TabIndex = 7;
            this.btnNotYet.Text = "Studying";
            this.btnNotYet.Click += new System.EventHandler(this.btnNotYet_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel2.Location = new System.Drawing.Point(212, 8);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(8, 36);
            this.siticonePanel2.TabIndex = 6;
            // 
            // btnComplete
            // 
            this.btnComplete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnComplete.BorderRadius = 10;
            this.btnComplete.BorderThickness = 1;
            this.btnComplete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComplete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComplete.FillColor = System.Drawing.Color.White;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnComplete.Location = new System.Drawing.Point(116, 8);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(96, 36);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Complete";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(108, 8);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(8, 36);
            this.siticonePanel1.TabIndex = 4;
            // 
            // btnAll
            // 
            this.btnAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAll.BorderRadius = 10;
            this.btnAll.BorderThickness = 1;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(12, 8);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(96, 36);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // layoutMyCourses
            // 
            this.layoutMyCourses.ColumnCount = 4;
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMyCourses.Location = new System.Drawing.Point(100, 52);
            this.layoutMyCourses.Name = "layoutMyCourses";
            this.layoutMyCourses.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.layoutMyCourses.RowCount = 2;
            this.layoutMyCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMyCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMyCourses.Size = new System.Drawing.Size(681, 482);
            this.layoutMyCourses.TabIndex = 5;
            // 
            // ucMyElearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutMyCourses);
            this.Controls.Add(this.panTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucMyElearning";
            this.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.Size = new System.Drawing.Size(881, 534);
            this.Load += new System.EventHandler(this.ucMyElearning_Load);
            this.panTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.TableLayoutPanel layoutMyCourses;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAll;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNotYet;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnComplete;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
    }
}
