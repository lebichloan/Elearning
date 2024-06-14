namespace Elearning.UserControls.User
{
    partial class ucCourseModule
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
            this.lblModuleName = new System.Windows.Forms.Label();
            this.lblModuleOrdinal = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SuspendLayout();
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(30, 79);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(56, 23);
            this.lblModuleName.TabIndex = 10;
            this.lblModuleName.Text = "label1";
            this.lblModuleName.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // lblModuleOrdinal
            // 
            this.lblModuleOrdinal.AutoSize = true;
            this.lblModuleOrdinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleOrdinal.Location = new System.Drawing.Point(30, 28);
            this.lblModuleOrdinal.Name = "lblModuleOrdinal";
            this.lblModuleOrdinal.Size = new System.Drawing.Size(53, 23);
            this.lblModuleOrdinal.TabIndex = 9;
            this.lblModuleOrdinal.Text = "label1";
            this.lblModuleOrdinal.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Black;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(15, 116);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(711, 1);
            this.siticonePanel1.TabIndex = 11;
            // 
            // ucCourseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.lblModuleOrdinal);
            this.Name = "ucCourseModule";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(741, 132);
            this.Click += new System.EventHandler(this.ucCourseModule_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModuleOrdinal;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
    }
}
