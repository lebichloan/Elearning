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
            this.lbModuleDescription = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.SuspendLayout();
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(12, 10);
            this.lblModuleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(52, 21);
            this.lblModuleName.TabIndex = 10;
            this.lblModuleName.Text = "label1";
            this.lblModuleName.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // lblModuleOrdinal
            // 
            this.lblModuleOrdinal.AutoSize = true;
            this.lblModuleOrdinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleOrdinal.Location = new System.Drawing.Point(479, 55);
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
            this.lbModuleDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbModuleDescription.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModuleDescription.Location = new System.Drawing.Point(12, 31);
            this.lbModuleDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModuleDescription.Name = "lbModuleDescription";
            this.lbModuleDescription.Size = new System.Drawing.Size(421, 38);
            this.lbModuleDescription.TabIndex = 12;
            this.lbModuleDescription.Text = "label1";
            this.lbModuleDescription.Click += new System.EventHandler(this.ucCourseModule_Click);
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticoneSeparator1.FillColor = System.Drawing.Color.Silver;
            this.siticoneSeparator1.Location = new System.Drawing.Point(12, 73);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(421, 10);
            this.siticoneSeparator1.TabIndex = 13;
            // 
            // ucCourseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.lbModuleDescription);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.lblModuleOrdinal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucCourseModule";
            this.Padding = new System.Windows.Forms.Padding(12, 10, 12, 0);
            this.Size = new System.Drawing.Size(445, 83);
            this.Click += new System.EventHandler(this.ucCourseModule_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModuleOrdinal;
        private System.Windows.Forms.Label lbModuleDescription;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
    }
}
