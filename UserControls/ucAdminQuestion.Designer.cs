namespace Elearning.UserControls
{
    partial class ucAdminQuestion
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
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbType = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.siticoneContainerControl3 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl4 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.siticoneContainerControl3.SuspendLayout();
            this.siticoneContainerControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.BorderColor = System.Drawing.Color.Gray;
            this.siticoneContainerControl1.BorderRadius = 4;
            this.siticoneContainerControl1.BorderThickness = 1;
            this.siticoneContainerControl1.Controls.Add(this.siticoneContainerControl2);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(5);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(411, 66);
            this.siticoneContainerControl1.TabIndex = 0;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            this.siticoneContainerControl1.Click += new System.EventHandler(this.question_Click);
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.lbType);
            this.siticoneContainerControl2.Controls.Add(this.lbName);
            this.siticoneContainerControl2.Controls.Add(this.siticoneContainerControl3);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(5, 5);
            this.siticoneContainerControl2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Size = new System.Drawing.Size(401, 56);
            this.siticoneContainerControl2.TabIndex = 1;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            this.siticoneContainerControl2.Click += new System.EventHandler(this.question_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbType.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(0, 26);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(106, 22);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Short answer";
            this.lbType.Click += new System.EventHandler(this.question_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(113, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Question 13";
            this.lbName.Click += new System.EventHandler(this.question_Click);
            // 
            // siticoneContainerControl3
            // 
            this.siticoneContainerControl3.Controls.Add(this.siticoneContainerControl4);
            this.siticoneContainerControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl3.Location = new System.Drawing.Point(325, 0);
            this.siticoneContainerControl3.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneContainerControl3.Name = "siticoneContainerControl3";
            this.siticoneContainerControl3.Size = new System.Drawing.Size(76, 56);
            this.siticoneContainerControl3.TabIndex = 3;
            this.siticoneContainerControl3.Text = "siticoneContainerControl3";
            // 
            // siticoneContainerControl4
            // 
            this.siticoneContainerControl4.Controls.Add(this.btnDelete);
            this.siticoneContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl4.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneContainerControl4.Name = "siticoneContainerControl4";
            this.siticoneContainerControl4.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.siticoneContainerControl4.Size = new System.Drawing.Size(76, 56);
            this.siticoneContainerControl4.TabIndex = 1;
            this.siticoneContainerControl4.Text = "siticoneContainerControl4";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Elearning.Properties.Resources.remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(33, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ucAdminQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucAdminQuestion";
            this.Size = new System.Drawing.Size(411, 66);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.siticoneContainerControl2.PerformLayout();
            this.siticoneContainerControl3.ResumeLayout(false);
            this.siticoneContainerControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbName;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl3;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
    }
}
