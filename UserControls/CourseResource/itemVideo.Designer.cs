namespace Elearning.UserControls.CourseResource
{
    partial class itemVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemVideo));
            this.lblResourceName = new System.Windows.Forms.Label();
            this.medVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceName.Location = new System.Drawing.Point(45, 30);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(53, 23);
            this.lblResourceName.TabIndex = 1;
            this.lblResourceName.Text = "label1";
            // 
            // medVideo
            // 
            this.medVideo.Enabled = true;
            this.medVideo.Location = new System.Drawing.Point(50, 55);
            this.medVideo.Name = "medVideo";
            this.medVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("medVideo.OcxState")));
            this.medVideo.Size = new System.Drawing.Size(400, 400);
            this.medVideo.TabIndex = 2;
            // 
            // itemVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.medVideo);
            this.Controls.Add(this.lblResourceName);
            this.Name = "itemVideo";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResourceName;
        private AxWMPLib.AxWindowsMediaPlayer medVideo;
    }
}
