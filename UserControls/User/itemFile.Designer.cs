namespace Elearning.UserControls
{
    partial class itemFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemFile));
            this.panContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.lblLinkFile = new System.Windows.Forms.Label();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.panContainer.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.BorderColor = System.Drawing.Color.Black;
            this.panContainer.BorderThickness = 1;
            this.panContainer.Controls.Add(this.siticonePanel2);
            this.panContainer.Controls.Add(this.lblLinkFile);
            this.panContainer.Controls.Add(this.lblResourceName);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(8, 8);
            this.panContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panContainer.Size = new System.Drawing.Size(464, 104);
            this.panContainer.TabIndex = 0;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.btnDownload);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel2.Location = new System.Drawing.Point(412, 4);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(48, 96);
            this.siticonePanel2.TabIndex = 6;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(8, 32);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDownload.Size = new System.Drawing.Size(32, 32);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownload.TabIndex = 3;
            this.btnDownload.TabStop = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblLinkFile
            // 
            this.lblLinkFile.AutoSize = true;
            this.lblLinkFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkFile.Location = new System.Drawing.Point(24, 60);
            this.lblLinkFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkFile.Name = "lblLinkFile";
            this.lblLinkFile.Size = new System.Drawing.Size(46, 19);
            this.lblLinkFile.TabIndex = 8;
            this.lblLinkFile.Text = "label1";
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceName.Location = new System.Drawing.Point(24, 20);
            this.lblResourceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(51, 21);
            this.lblResourceName.TabIndex = 7;
            this.lblResourceName.Text = "label1";
            // 
            // itemFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "itemFile";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Size = new System.Drawing.Size(480, 120);
            this.panContainer.ResumeLayout(false);
            this.panContainer.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.PictureBox btnDownload;
        private System.Windows.Forms.Label lblLinkFile;
        private System.Windows.Forms.Label lblResourceName;
    }
}
