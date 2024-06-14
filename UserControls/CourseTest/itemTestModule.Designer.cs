namespace Elearning.UserControls.CourseTest
{
    partial class itemTestModule
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
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblMandatory = new System.Windows.Forms.Label();
            this.lblTimeFinish = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BackColor = System.Drawing.Color.Black;
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(15, 54);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(940, 1);
            this.siticonePanel3.TabIndex = 31;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(387, 5);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(218, 49);
            this.lblTotalScore.TabIndex = 36;
            this.lblTotalScore.Text = "Tổng điểm";
            this.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMandatory
            // 
            this.lblMandatory.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMandatory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandatory.Location = new System.Drawing.Point(605, 5);
            this.lblMandatory.Name = "lblMandatory";
            this.lblMandatory.Size = new System.Drawing.Size(175, 49);
            this.lblMandatory.TabIndex = 35;
            this.lblMandatory.Text = "Bắt buộc";
            this.lblMandatory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeFinish
            // 
            this.lblTimeFinish.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimeFinish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeFinish.Location = new System.Drawing.Point(139, 5);
            this.lblTimeFinish.Name = "lblTimeFinish";
            this.lblTimeFinish.Size = new System.Drawing.Size(248, 49);
            this.lblTimeFinish.TabIndex = 34;
            this.lblTimeFinish.Text = "Ngày hoàn thành";
            this.lblTimeFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestName
            // 
            this.lblTestName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(15, 5);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(124, 49);
            this.lblTestName.TabIndex = 33;
            this.lblTestName.Text = "MINI TEST 1";
            this.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblState
            // 
            this.lblState.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(780, 5);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(175, 49);
            this.lblState.TabIndex = 32;
            this.lblState.Text = "Trạng thái";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemTestModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblMandatory);
            this.Controls.Add(this.lblTimeFinish);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.siticonePanel3);
            this.MaximumSize = new System.Drawing.Size(970, 60);
            this.Name = "itemTestModule";
            this.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.Size = new System.Drawing.Size(970, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblMandatory;
        private System.Windows.Forms.Label lblTimeFinish;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblState;
    }
}
