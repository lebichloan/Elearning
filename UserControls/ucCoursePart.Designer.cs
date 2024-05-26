namespace Elearning.UserControls
{
    partial class ucCoursePart
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
            this.lblCoursePart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCoursePart
            // 
            this.lblCoursePart.AutoSize = true;
            this.lblCoursePart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursePart.Location = new System.Drawing.Point(45, 25);
            this.lblCoursePart.Name = "lblCoursePart";
            this.lblCoursePart.Size = new System.Drawing.Size(70, 28);
            this.lblCoursePart.TabIndex = 2;
            this.lblCoursePart.Text = "label1";
            // 
            // ucCoursePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCoursePart);
            this.Name = "ucCoursePart";
            this.Size = new System.Drawing.Size(800, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoursePart;
    }
}
