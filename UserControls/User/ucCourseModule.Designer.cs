namespace Elearning.UserControls
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
            this.lblModuleOrdinal = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblModuleOrdinal
            // 
            this.lblModuleOrdinal.AutoSize = true;
            this.lblModuleOrdinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleOrdinal.Location = new System.Drawing.Point(15, 15);
            this.lblModuleOrdinal.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblModuleOrdinal.Name = "lblModuleOrdinal";
            this.lblModuleOrdinal.Size = new System.Drawing.Size(59, 23);
            this.lblModuleOrdinal.TabIndex = 3;
            this.lblModuleOrdinal.Text = "label1";
            this.lblModuleOrdinal.Click += new System.EventHandler(this.ucCouseModule_Clicked);
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(14, 53);
            this.lblModuleName.Margin = new System.Windows.Forms.Padding(5, 15, 0, 25);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(70, 28);
            this.lblModuleName.TabIndex = 4;
            this.lblModuleName.Text = "label1";
            this.lblModuleName.Click += new System.EventHandler(this.ucCouseModule_Clicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 1);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.ucCouseModule_Clicked);
            // 
            // ucCourseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.lblModuleOrdinal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucCourseModule";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(783, 100);
            this.Click += new System.EventHandler(this.ucCouseModule_Clicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModuleOrdinal;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Panel panel1;
    }
}
