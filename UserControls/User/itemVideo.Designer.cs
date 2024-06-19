﻿namespace Elearning.UserControls
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
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.progressBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.medVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTimePlay = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.PictureBox();
            this.trackBarVolume = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnZoom = new System.Windows.Forms.PictureBox();
            this.panContainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).BeginInit();
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
            this.panContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panContainer.Size = new System.Drawing.Size(605, 605);
            this.panContainer.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel3);
            this.siticonePanel1.Controls.Add(this.medVideo);
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(5, 53);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.siticonePanel1.Size = new System.Drawing.Size(595, 547);
            this.siticonePanel1.TabIndex = 6;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.progressBar);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(15, 482);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.siticonePanel3.Size = new System.Drawing.Size(565, 15);
            this.siticonePanel3.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 5);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.Size = new System.Drawing.Size(565, 5);
            this.progressBar.TabIndex = 7;
            this.progressBar.Text = "siticoneProgressBar2";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // medVideo
            // 
            this.medVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medVideo.Enabled = true;
            this.medVideo.Location = new System.Drawing.Point(15, 0);
            this.medVideo.Margin = new System.Windows.Forms.Padding(2);
            this.medVideo.Name = "medVideo";
            this.medVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("medVideo.OcxState")));
            this.medVideo.Size = new System.Drawing.Size(565, 497);
            this.medVideo.TabIndex = 5;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblTimePlay);
            this.siticonePanel2.Controls.Add(this.btnVolume);
            this.siticonePanel2.Controls.Add(this.trackBarVolume);
            this.siticonePanel2.Controls.Add(this.btnPlay);
            this.siticonePanel2.Controls.Add(this.siticonePanel4);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel2.Location = new System.Drawing.Point(15, 497);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.siticonePanel2.Size = new System.Drawing.Size(565, 50);
            this.siticonePanel2.TabIndex = 4;
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
            this.btnVolume.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.btnPlay.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.siticoneCustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(595, 48);
            this.siticoneCustomGradientPanel1.TabIndex = 5;
            // 
            // lblResourceName
            // 
            this.lblResourceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResourceName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceName.Location = new System.Drawing.Point(15, 0);
            this.lblResourceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(580, 48);
            this.lblResourceName.TabIndex = 2;
            this.lblResourceName.Text = "label1";
            this.lblResourceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerVideo
            // 
            this.timerVideo.Enabled = true;
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Controls.Add(this.btnZoom);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel4.Location = new System.Drawing.Point(365, 5);
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
            this.btnZoom.Padding = new System.Windows.Forms.Padding(10);
            this.btnZoom.Size = new System.Drawing.Size(40, 40);
            this.btnZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZoom.TabIndex = 5;
            this.btnZoom.TabStop = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // itemVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "itemVideo";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Size = new System.Drawing.Size(625, 625);
            this.panContainer.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medVideo)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticonePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).EndInit();
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
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private System.Windows.Forms.PictureBox btnZoom;
    }
}
