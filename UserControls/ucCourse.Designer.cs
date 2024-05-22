namespace Elearning.UserControls
{
    partial class ucCourse
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
            this.flpStep = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpStep
            // 
            this.flpStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpStep.Location = new System.Drawing.Point(0, 0);
            this.flpStep.Name = "flpStep";
            this.flpStep.Size = new System.Drawing.Size(300, 650);
            this.flpStep.TabIndex = 0;
            // 
            // flpMain
            // 
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(300, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(800, 650);
            this.flpMain.TabIndex = 1;
            // 
            // ucCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.flpStep);
            this.Name = "ucCourse";
            this.Size = new System.Drawing.Size(1100, 650);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStep;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
    }
}
