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
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblGoToTest = new System.Windows.Forms.Label();
            this.panContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.BorderColor = System.Drawing.Color.Black;
            this.panContainer.BorderThickness = 1;
            this.panContainer.Controls.Add(this.lblGoToTest);
            this.panContainer.Controls.Add(this.lblTestName);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(10, 10);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panContainer.Size = new System.Drawing.Size(580, 68);
            this.panContainer.TabIndex = 0;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(30, 25);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(56, 23);
            this.lblTestName.TabIndex = 8;
            this.lblTestName.Text = "label1";
            this.lblTestName.Click += new System.EventHandler(this.lblGoToTest_Click);
            // 
            // lblGoToTest
            // 
            this.lblGoToTest.AutoSize = true;
            this.lblGoToTest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToTest.Location = new System.Drawing.Point(469, 25);
            this.lblGoToTest.Name = "lblGoToTest";
            this.lblGoToTest.Size = new System.Drawing.Size(84, 23);
            this.lblGoToTest.TabIndex = 9;
            this.lblGoToTest.Text = "Go to test";
            this.lblGoToTest.Click += new System.EventHandler(this.lblGoToTest_Click);
            // 
            // itemTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Name = "itemTest";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 88);
            this.panContainer.ResumeLayout(false);
            this.panContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panContainer;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblGoToTest;
    }
}
