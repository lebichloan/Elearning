namespace Elearning.Forms
{
    partial class fDetailTestResult
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
            this.panButton = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnDoTest = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblFinishTest = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.panHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTestOrdinal = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblLastState = new System.Windows.Forms.Label();
            this.lblOrdinalPass = new System.Windows.Forms.Label();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tbDetailTestResult = new System.Windows.Forms.TableLayoutPanel();
            this.panButton.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panButton
            // 
            this.panButton.Controls.Add(this.btnDoTest);
            this.panButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButton.Location = new System.Drawing.Point(50, 533);
            this.panButton.Name = "panButton";
            this.panButton.Size = new System.Drawing.Size(750, 70);
            this.panButton.TabIndex = 9;
            // 
            // btnDoTest
            // 
            this.btnDoTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoTest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDoTest.ForeColor = System.Drawing.Color.White;
            this.btnDoTest.Location = new System.Drawing.Point(308, 17);
            this.btnDoTest.Name = "btnDoTest";
            this.btnDoTest.Size = new System.Drawing.Size(150, 50);
            this.btnDoTest.TabIndex = 20;
            this.btnDoTest.Text = "Do the test";
            this.btnDoTest.Visible = false;
            this.btnDoTest.Click += new System.EventHandler(this.btnDoTest_Click);
            // 
            // lblFinishTest
            // 
            this.lblFinishTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFinishTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishTest.Location = new System.Drawing.Point(50, 50);
            this.lblFinishTest.Name = "lblFinishTest";
            this.lblFinishTest.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.lblFinishTest.Size = new System.Drawing.Size(750, 50);
            this.lblFinishTest.TabIndex = 7;
            this.lblFinishTest.Text = "Bạn đã hoàn thành";
            this.lblFinishTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblState
            // 
            this.lblState.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(50, 100);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblState.Size = new System.Drawing.Size(750, 50);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "Trạng thái";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeader
            // 
            this.panHeader.Controls.Add(this.label2);
            this.panHeader.Controls.Add(this.label3);
            this.panHeader.Controls.Add(this.label4);
            this.panHeader.Controls.Add(this.lblTestOrdinal);
            this.panHeader.Controls.Add(this.siticonePanel3);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(50, 150);
            this.panHeader.Name = "panHeader";
            this.panHeader.Padding = new System.Windows.Forms.Padding(15, 10, 15, 5);
            this.panHeader.Size = new System.Drawing.Size(750, 66);
            this.panHeader.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 50);
            this.label2.TabIndex = 23;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 50);
            this.label3.TabIndex = 22;
            this.label3.Text = "State";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 50);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestOrdinal
            // 
            this.lblTestOrdinal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTestOrdinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestOrdinal.Location = new System.Drawing.Point(15, 10);
            this.lblTestOrdinal.Name = "lblTestOrdinal";
            this.lblTestOrdinal.Size = new System.Drawing.Size(100, 50);
            this.lblTestOrdinal.TabIndex = 20;
            this.lblTestOrdinal.Text = "Ordinal";
            this.lblTestOrdinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BackColor = System.Drawing.Color.Black;
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(15, 60);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(720, 1);
            this.siticonePanel3.TabIndex = 18;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblLastState);
            this.siticonePanel2.Controls.Add(this.lblOrdinalPass);
            this.siticonePanel2.Controls.Add(this.lblLastScore);
            this.siticonePanel2.Controls.Add(this.label7);
            this.siticonePanel2.Controls.Add(this.siticonePanel4);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel2.Location = new System.Drawing.Point(50, 467);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.siticonePanel2.Size = new System.Drawing.Size(750, 66);
            this.siticonePanel2.TabIndex = 13;
            // 
            // lblLastState
            // 
            this.lblLastState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastState.ForeColor = System.Drawing.Color.Red;
            this.lblLastState.Location = new System.Drawing.Point(304, 6);
            this.lblLastState.Name = "lblLastState";
            this.lblLastState.Size = new System.Drawing.Size(256, 55);
            this.lblLastState.TabIndex = 23;
            this.lblLastState.Text = "Hoàn thành";
            this.lblLastState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdinalPass
            // 
            this.lblOrdinalPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOrdinalPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinalPass.Location = new System.Drawing.Point(560, 6);
            this.lblOrdinalPass.Name = "lblOrdinalPass";
            this.lblOrdinalPass.Size = new System.Drawing.Size(175, 55);
            this.lblOrdinalPass.TabIndex = 22;
            this.lblOrdinalPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastScore
            // 
            this.lblLastScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLastScore.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastScore.Location = new System.Drawing.Point(154, 6);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.Size = new System.Drawing.Size(150, 55);
            this.lblLastScore.TabIndex = 21;
            this.lblLastScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 6);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(139, 55);
            this.label7.TabIndex = 20;
            this.label7.Text = "Result";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.BackColor = System.Drawing.Color.Black;
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel4.Location = new System.Drawing.Point(15, 5);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Size = new System.Drawing.Size(720, 1);
            this.siticonePanel4.TabIndex = 18;
            // 
            // tbDetailTestResult
            // 
            this.tbDetailTestResult.ColumnCount = 1;
            this.tbDetailTestResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbDetailTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetailTestResult.Location = new System.Drawing.Point(50, 216);
            this.tbDetailTestResult.MaximumSize = new System.Drawing.Size(750, 327);
            this.tbDetailTestResult.Name = "tbDetailTestResult";
            this.tbDetailTestResult.RowCount = 1;
            this.tbDetailTestResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbDetailTestResult.Size = new System.Drawing.Size(750, 251);
            this.tbDetailTestResult.TabIndex = 14;
            // 
            // fDetailTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 653);
            this.Controls.Add(this.tbDetailTestResult);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.panButton);
            this.Controls.Add(this.lblFinishTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fDetailTestResult";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTestResult";
            this.panButton.ResumeLayout(false);
            this.panHeader.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel panButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDoTest;
        private System.Windows.Forms.Label lblFinishTest;
        private System.Windows.Forms.Label lblState;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTestOrdinal;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lblLastState;
        private System.Windows.Forms.Label lblOrdinalPass;
        private System.Windows.Forms.Label lblLastScore;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private System.Windows.Forms.TableLayoutPanel tbDetailTestResult;
    }
}