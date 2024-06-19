namespace Elearning.Forms
{
    partial class fZoomVideo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fZoomVideo));
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.progressBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTimePlay = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnZoom = new System.Windows.Forms.PictureBox();
            this.medVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.siticonePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.progressBar);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 385);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.siticonePanel3.Size = new System.Drawing.Size(800, 15);
            this.siticonePanel3.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 5);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.Size = new System.Drawing.Size(800, 5);
            this.progressBar.TabIndex = 7;
            this.progressBar.Text = "siticoneProgressBar2";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblTimePlay);
            this.siticonePanel2.Controls.Add(this.btnVolume);
            this.siticonePanel2.Controls.Add(this.trackBarVolume);
            this.siticonePanel2.Controls.Add(this.btnPlay);
            this.siticonePanel2.Controls.Add(this.siticonePanel4);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 400);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.siticonePanel2.Size = new System.Drawing.Size(800, 50);
            this.siticonePanel2.TabIndex = 10;
            // 
            // lblTimePlay
            // 
            this.lblTimePlay.AutoSize = true;
            this.lblTimePlay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlay.Location = new System.Drawing.Point(251, 14);
            this.lblTimePlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimePlay.Name = "lblTimePlay";
            this.lblTimePlay.Size = new System.Drawing.Size(55, 23);
            this.lblTimePlay.TabIndex = 3;
            this.lblTimePlay.Text = "label1";
            // 
            // btnVolume
            // 
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.Location = new System.Drawing.Point(52, 5);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Padding = new System.Windows.Forms.Padding(5);
            this.btnVolume.Size = new System.Drawing.Size(40, 40);
            this.btnVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolume.TabIndex = 2;
            this.btnVolume.TabStop = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(99, 14);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(135, 24);
            this.trackBarVolume.TabIndex = 1;
            this.trackBarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarVolume_Scroll);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(5, 5);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(5);
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Controls.Add(this.btnZoom);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel4.Location = new System.Drawing.Point(600, 5);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Size = new System.Drawing.Size(200, 45);
            this.siticonePanel4.TabIndex = 5;
            // 
            // btnZoom
            // 
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.Location = new System.Drawing.Point(158, 3);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Padding = new System.Windows.Forms.Padding(5);
            this.btnZoom.Size = new System.Drawing.Size(40, 40);
            this.btnZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZoom.TabIndex = 5;
            this.btnZoom.TabStop = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // medVideo
            // 
            this.medVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medVideo.Enabled = true;
            this.medVideo.Location = new System.Drawing.Point(0, 0);
            this.medVideo.Name = "medVideo";
            this.medVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("medVideo.OcxState")));
            this.medVideo.Size = new System.Drawing.Size(800, 385);
            this.medVideo.TabIndex = 12;
            // 
            // timerVideo
            // 
            this.timerVideo.Enabled = true;
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
            // 
            // fZoomVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medVideo);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fZoomVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.siticonePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar progressBar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lblTimePlay;
        private System.Windows.Forms.PictureBox btnVolume;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar trackBarVolume;
        private System.Windows.Forms.PictureBox btnPlay;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private System.Windows.Forms.PictureBox btnZoom;
        private AxWMPLib.AxWindowsMediaPlayer medVideo;
        private System.Windows.Forms.Timer timerVideo;
    }
}