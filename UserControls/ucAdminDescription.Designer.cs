namespace Elearning.UserControls
{
    partial class ucAdminDescription
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
            this.conInfo = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // conInfo
            // 
            this.conInfo.Controls.Add(this.lbDescription);
            this.conInfo.Controls.Add(this.label1);
            this.conInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conInfo.Location = new System.Drawing.Point(0, 0);
            this.conInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conInfo.Name = "conInfo";
            this.conInfo.Size = new System.Drawing.Size(1179, 103);
            this.conInfo.TabIndex = 5;
            this.conInfo.Text = "siticoneContainerControl5";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(0, 41);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.lbDescription.Size = new System.Drawing.Size(329, 27);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "This is the description of the course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("UTM Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(197, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // ucAdminDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.conInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1067, 98);
            this.Name = "ucAdminDescription";
            this.Size = new System.Drawing.Size(1179, 103);
            this.conInfo.ResumeLayout(false);
            this.conInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conInfo;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label1;
    }
}
