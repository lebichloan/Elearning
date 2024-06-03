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
            this.panContainer.Location = new System.Drawing.Point(10, 10);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panContainer.Size = new System.Drawing.Size(580, 130);
            this.panContainer.TabIndex = 0;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.btnDownload);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel2.Location = new System.Drawing.Point(515, 5);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(60, 120);
            this.siticonePanel2.TabIndex = 6;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(10, 40);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(10);
            this.btnDownload.Size = new System.Drawing.Size(40, 40);
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
            this.lblLinkFile.Location = new System.Drawing.Point(30, 75);
            this.lblLinkFile.Name = "lblLinkFile";
            this.lblLinkFile.Size = new System.Drawing.Size(56, 23);
            this.lblLinkFile.TabIndex = 8;
            this.lblLinkFile.Text = "label1";
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceName.Location = new System.Drawing.Point(30, 25);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(53, 23);
            this.lblResourceName.TabIndex = 7;
            this.lblResourceName.Text = "label1";
            // 
            // itemFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Name = "itemFile";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 150);
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
