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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemVideo));
            this.panContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.medVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.progressBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.btnVolume = new System.Windows.Forms.PictureBox();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTimePlay = new System.Windows.Forms.Label();
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.panContainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).BeginInit();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).BeginInit();
            this.siticonePanel2.SuspendLayout();
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
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
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
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.progressBar);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(15, 357);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(5);
            this.siticonePanel3.Size = new System.Drawing.Size(440, 15);
            this.siticonePanel3.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(5, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.Size = new System.Drawing.Size(430, 5);
            this.progressBar.TabIndex = 7;
            this.progressBar.Text = "siticoneProgressBar2";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(99, 14);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(135, 24);
            this.trackBarVolume.TabIndex = 1;
            this.trackBarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.trackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarVolume_Scroll);
            // 
            // btnVolume
            // 
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.Location = new System.Drawing.Point(53, 5);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Padding = new System.Windows.Forms.Padding(5);
            this.btnVolume.Size = new System.Drawing.Size(40, 40);
            this.btnVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolume.TabIndex = 2;
            this.btnVolume.TabStop = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblTimePlay);
            this.siticonePanel2.Controls.Add(this.btnVolume);
            this.siticonePanel2.Controls.Add(this.trackBarVolume);
            this.siticonePanel2.Controls.Add(this.btnPlay);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel2.Location = new System.Drawing.Point(15, 372);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.siticonePanel2.Size = new System.Drawing.Size(440, 50);
            this.siticonePanel2.TabIndex = 4;
            // 
            // lblTimePlay
            // 
            this.lblTimePlay.AutoSize = true;
            this.lblTimePlay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlay.Location = new System.Drawing.Point(251, 14);
            this.lblTimePlay.Name = "lblTimePlay";
            this.lblTimePlay.Size = new System.Drawing.Size(55, 23);
            this.lblTimePlay.TabIndex = 3;
            this.lblTimePlay.Text = "label1";
            // 
            // timerVideo
            // 
            this.timerVideo.Enabled = true;
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
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
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private AxWMPLib.AxWindowsMediaPlayer medVideo;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private System.Windows.Forms.Label lblResourceName;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar progressBar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.PictureBox btnVolume;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar trackBarVolume;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Label lblTimePlay;
        private System.Windows.Forms.Timer timerVideo;
    }
}
