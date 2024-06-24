namespace Elearning.UserControls.User
{
    partial class itemTest
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
            this.panContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblViewDetail = new System.Windows.Forms.Label();
            this.panContainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panContainer.BorderColor = System.Drawing.Color.Silver;
            this.panContainer.BorderRadius = 10;
            this.panContainer.BorderThickness = 1;
            this.panContainer.Controls.Add(this.siticonePanel1);
            this.panContainer.Controls.Add(this.siticonePanel2);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(8, 8);
            this.panContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(4);
            this.panContainer.Size = new System.Drawing.Size(464, 100);
            this.panContainer.TabIndex = 0;
            this.panContainer.Click += new System.EventHandler(this.GoToTest_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.lblTestName);
            this.siticonePanel1.Controls.Add(this.lblState);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(4, 4);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(24, 24, 24, 16);
            this.siticonePanel1.Size = new System.Drawing.Size(318, 92);
            this.siticonePanel1.TabIndex = 10;
            this.siticonePanel1.Click += new System.EventHandler(this.GoToTest_Click);
            // 
            // lblTestName
            // 
            this.lblTestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.ForeColor = System.Drawing.Color.Black;
            this.lblTestName.Location = new System.Drawing.Point(24, 24);
            this.lblTestName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(270, 34);
            this.lblTestName.TabIndex = 11;
            this.lblTestName.Text = "label1";
            this.lblTestName.Click += new System.EventHandler(this.GoToTest_Click);
            // 
            // lblState
            // 
            this.lblState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(24, 58);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(270, 18);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "Not yet";
            this.lblState.Click += new System.EventHandler(this.GoToTest_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblViewDetail);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel2.Location = new System.Drawing.Point(322, 4);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.siticonePanel2.Size = new System.Drawing.Size(138, 92);
            this.siticonePanel2.TabIndex = 11;
            this.siticonePanel2.Click += new System.EventHandler(this.GoToTest_Click);
            // 
            // lblViewDetail
            // 
            this.lblViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDetail.Location = new System.Drawing.Point(24, 16);
            this.lblViewDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewDetail.Name = "lblViewDetail";
            this.lblViewDetail.Size = new System.Drawing.Size(90, 60);
            this.lblViewDetail.TabIndex = 10;
            this.lblViewDetail.Text = "View detail";
            this.lblViewDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblViewDetail.Click += new System.EventHandler(this.lblViewDetail_Click);
            // 
            // itemTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "itemTest";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(480, 116);
            this.Click += new System.EventHandler(this.GoToTest_Click);
            this.panContainer.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lblViewDetail;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTestName;
    }
}
