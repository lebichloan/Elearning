namespace Elearning.UserControls
{
    partial class ucMyElearning
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
            this.layoutMyCourses = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // layoutMyCourses
            // 
            this.layoutMyCourses.ColumnCount = 4;
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutMyCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMyCourses.Location = new System.Drawing.Point(0, 0);
            this.layoutMyCourses.Margin = new System.Windows.Forms.Padding(4);
            this.layoutMyCourses.Name = "layoutMyCourses";
            this.layoutMyCourses.Padding = new System.Windows.Forms.Padding(4);
            this.layoutMyCourses.RowCount = 2;
            this.layoutMyCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMyCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMyCourses.Size = new System.Drawing.Size(1101, 667);
            this.layoutMyCourses.TabIndex = 3;
            // 
            // ucMyElearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutMyCourses);
            this.Name = "ucMyElearning";
            this.Size = new System.Drawing.Size(1101, 667);
            this.Load += new System.EventHandler(this.ucMyElearning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMyCourses;
    }
}
