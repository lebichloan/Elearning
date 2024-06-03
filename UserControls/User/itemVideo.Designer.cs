namespace Elearning.UserControls
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
            this.panContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.medVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.panContainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.BorderColor = System.Drawing.Color.Black;
            this.panContainer.BorderThickness = 1;
            this.panContainer.Controls.Add(this.siticonePanel1);
            this.panContainer.Controls.Add(this.siticoneCustomGradientPanel1);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(10, 10);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panContainer.Size = new System.Drawing.Size(480, 480);
            this.panContainer.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.medVideo);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(5, 53);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.siticonePanel1.Size = new System.Drawing.Size(470, 422);
            this.siticonePanel1.TabIndex = 6;
            // 
            // medVideo
            // 
            this.medVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medVideo.Enabled = true;
            this.medVideo.Location = new System.Drawing.Point(15, 0);
            this.medVideo.Name = "medVideo";
            this.medVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("medVideo.OcxState")));
            this.medVideo.Size = new System.Drawing.Size(440, 372);
            this.medVideo.TabIndex = 5;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.btnPlay);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel2.Location = new System.Drawing.Point(15, 372);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(440, 50);
            this.siticonePanel2.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(5, 5);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.lblResourceName);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(5, 5);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(470, 48);
            this.siticoneCustomGradientPanel1.TabIndex = 5;
            // 
            // lblResourceName
            // 
            this.lblResourceName.AutoSize = true;
            this.lblResourceName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceName.Location = new System.Drawing.Point(30, 15);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(53, 23);
            this.lblResourceName.TabIndex = 2;
            this.lblResourceName.Text = "label1";
            // 
            // itemVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Name = "itemVideo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(500, 500);
            this.panContainer.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private AxWMPLib.AxWindowsMediaPlayer medVideo;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.PictureBox btnPlay;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private System.Windows.Forms.Label lblResourceName;
    }
}
