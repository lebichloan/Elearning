namespace Elearning.UserControls.CourseTest
{
    partial class itemModuleTestResult
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
            this.lblModuleState = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tbAllTest = new System.Windows.Forms.TableLayoutPanel();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.lblModuleName);
            this.siticonePanel1.Controls.Add(this.lblModuleState);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.siticonePanel1.Size = new System.Drawing.Size(910, 55);
            this.siticonePanel1.TabIndex = 0;
            // 
            // lblModuleState
            // 
            this.lblModuleState.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblModuleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleState.ForeColor = System.Drawing.Color.Red;
            this.lblModuleState.Location = new System.Drawing.Point(611, 0);
            this.lblModuleState.Name = "lblModuleState";
            this.lblModuleState.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblModuleState.Size = new System.Drawing.Size(284, 54);
            this.lblModuleState.TabIndex = 17;
            this.lblModuleState.Text = "Đã hoàn thành";
            this.lblModuleState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Black;
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel2.Location = new System.Drawing.Point(15, 54);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(880, 1);
            this.siticonePanel2.TabIndex = 0;
            // 
            // tbAllTest
            // 
            this.tbAllTest.AutoSize = true;
            this.tbAllTest.ColumnCount = 1;
            this.tbAllTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAllTest.Location = new System.Drawing.Point(0, 55);
            this.tbAllTest.Name = "tbAllTest";
            this.tbAllTest.RowCount = 1;
            this.tbAllTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllTest.Size = new System.Drawing.Size(910, 245);
            this.tbAllTest.TabIndex = 26;
            // 
            // lblModuleName
            // 
            this.lblModuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(15, 0);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblModuleName.Size = new System.Drawing.Size(596, 54);
            this.lblModuleName.TabIndex = 18;
            this.lblModuleName.Text = "Module 1";
            this.lblModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemModuleTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.tbAllTest);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "itemModuleTestResult";
            this.Size = new System.Drawing.Size(910, 300);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lblModuleState;
        private System.Windows.Forms.TableLayoutPanel tbAllTest;
        private System.Windows.Forms.Label lblModuleName;
    }
}
