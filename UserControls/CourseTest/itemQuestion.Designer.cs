namespace Elearning.UserControls.CourseTest
{
    partial class itemQuestion
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
            this.btnQuestionOrdinal = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // btnQuestionOrdinal
            // 
            this.btnQuestionOrdinal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnQuestionOrdinal.BorderRadius = 5;
            this.btnQuestionOrdinal.BorderThickness = 1;
            this.btnQuestionOrdinal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuestionOrdinal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuestionOrdinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuestionOrdinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuestionOrdinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuestionOrdinal.FillColor = System.Drawing.Color.White;
            this.btnQuestionOrdinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionOrdinal.ForeColor = System.Drawing.Color.Black;
            this.btnQuestionOrdinal.Location = new System.Drawing.Point(5, 5);
            this.btnQuestionOrdinal.Name = "btnQuestionOrdinal";
            this.btnQuestionOrdinal.Size = new System.Drawing.Size(50, 50);
            this.btnQuestionOrdinal.TabIndex = 17;
            this.btnQuestionOrdinal.Text = "1";
            // 
            // itemQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuestionOrdinal);
            this.MaximumSize = new System.Drawing.Size(60, 60);
            this.Name = "itemQuestion";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(60, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton btnQuestionOrdinal;
    }
}
