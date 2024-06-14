namespace Elearning.UserControls.CourseTest
{
    partial class itemTestResult
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblViewDetail = new System.Windows.Forms.Label();
            this.lblTestOrdinal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Black;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 59);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.siticonePanel1.Size = new System.Drawing.Size(750, 1);
            this.siticonePanel1.TabIndex = 0;
            // 
            // lblViewDetail
            // 
            this.lblViewDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblViewDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDetail.Location = new System.Drawing.Point(575, 0);
            this.lblViewDetail.Name = "lblViewDetail";
            this.lblViewDetail.Size = new System.Drawing.Size(175, 59);
            this.lblViewDetail.TabIndex = 12;
            this.lblViewDetail.Text = "View detail";
            this.lblViewDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblViewDetail.Click += new System.EventHandler(this.lblViewDetail_Click);
            // 
            // lblTestOrdinal
            // 
            this.lblTestOrdinal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTestOrdinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestOrdinal.Location = new System.Drawing.Point(0, 0);
            this.lblTestOrdinal.Name = "lblTestOrdinal";
            this.lblTestOrdinal.Size = new System.Drawing.Size(75, 59);
            this.lblTestOrdinal.TabIndex = 13;
            this.lblTestOrdinal.Text = "1";
            this.lblTestOrdinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(75, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(150, 59);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "00:01:30";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblState
            // 
            this.lblState.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(400, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(175, 59);
            this.lblState.TabIndex = 16;
            this.lblState.Text = "Hoàn thành";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(225, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(175, 59);
            this.lblScore.TabIndex = 17;
            this.lblScore.Text = "15";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTestOrdinal);
            this.Controls.Add(this.lblViewDetail);
            this.Controls.Add(this.siticonePanel1);
            this.MaximumSize = new System.Drawing.Size(750, 60);
            this.Name = "itemTestResult";
            this.Size = new System.Drawing.Size(750, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblViewDetail;
        private System.Windows.Forms.Label lblTestOrdinal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblScore;
    }
}
