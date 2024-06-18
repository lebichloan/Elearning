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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblModuleOrdinal = new System.Windows.Forms.Label();
            this.lbModuleDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(14, 11);
            this.lblModuleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(55, 21);
            this.lblModuleName.TabIndex = 10;
            this.lblModuleName.Text = "label1";
            this.lblModuleName.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Black;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(12, 82);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(569, 1);
            this.siticonePanel1.TabIndex = 11;
            // 
            // lblModuleOrdinal
            // 
            this.lblModuleOrdinal.AutoSize = true;
            this.lblModuleOrdinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleOrdinal.Location = new System.Drawing.Point(479, 45);
            this.lblModuleOrdinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleOrdinal.Name = "lblModuleOrdinal";
            this.lblModuleOrdinal.Size = new System.Drawing.Size(45, 19);
            this.lblModuleOrdinal.TabIndex = 9;
            this.lblModuleOrdinal.Text = "label1";
            this.lblModuleOrdinal.Visible = false;
            this.lblModuleOrdinal.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // lbModuleDescription
            // 
            this.lbModuleDescription.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModuleDescription.Location = new System.Drawing.Point(14, 32);
            this.lbModuleDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModuleDescription.Name = "lbModuleDescription";
            this.lbModuleDescription.Size = new System.Drawing.Size(565, 38);
            this.lbModuleDescription.TabIndex = 12;
            this.lbModuleDescription.Text = "label1";
            this.lbModuleDescription.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // ucCourseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lbModuleDescription);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.lblModuleOrdinal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucCourseModule";
            this.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.Size = new System.Drawing.Size(593, 83);
            this.Click += new System.EventHandler(this.ucCourseModule_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModuleName;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblModuleOrdinal;
        private System.Windows.Forms.Label lbModuleDescription;
    }
}
