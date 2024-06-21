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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemFile));
            this.panContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.panToolBar = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnPre = new System.Windows.Forms.PictureBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnZoomOut = new System.Windows.Forms.PictureBox();
            this.btnZoomIn = new System.Windows.Forms.PictureBox();
            this.lblLinkFile = new System.Windows.Forms.Label();
            this.lblResourceName = new System.Windows.Forms.Label();
            this.panDownload = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.panContainer.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.panToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomIn)).BeginInit();
            this.panDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.BorderColor = System.Drawing.Color.Black;
            this.panContainer.BorderThickness = 1;
            this.panContainer.Controls.Add(this.siticonePanel1);
            this.panContainer.Controls.Add(this.panDownload);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(10, 10);
            this.panContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panContainer.Name = "panContainer";
            this.panContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panContainer.Size = new System.Drawing.Size(580, 880);
            this.panContainer.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.pdfViewer);
            this.siticonePanel1.Controls.Add(this.panToolBar);
            this.siticonePanel1.Controls.Add(this.lblLinkFile);
            this.siticonePanel1.Controls.Add(this.lblResourceName);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(5, 5);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(25);
            this.siticonePanel1.Size = new System.Drawing.Size(510, 870);
            this.siticonePanel1.TabIndex = 11;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(25, 158);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.ShowToolbar = false;
            this.pdfViewer.Size = new System.Drawing.Size(460, 687);
            this.pdfViewer.TabIndex = 15;
            // 
            // panToolBar
            // 
            this.panToolBar.Controls.Add(this.btnPre);
            this.panToolBar.Controls.Add(this.lblPage);
            this.panToolBar.Controls.Add(this.btnNext);
            this.panToolBar.Controls.Add(this.btnZoomOut);
            this.panToolBar.Controls.Add(this.btnZoomIn);
            this.panToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panToolBar.Location = new System.Drawing.Point(25, 108);
            this.panToolBar.Name = "panToolBar";
            this.panToolBar.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panToolBar.Size = new System.Drawing.Size(460, 50);
            this.panToolBar.TabIndex = 12;
            // 
            // btnPre
            // 
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPre.Image = ((System.Drawing.Image)(resources.GetObject("btnPre.Image")));
            this.btnPre.Location = new System.Drawing.Point(274, 5);
            this.btnPre.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Padding = new System.Windows.Forms.Padding(5);
            this.btnPre.Size = new System.Drawing.Size(40, 40);
            this.btnPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPre.TabIndex = 12;
            this.btnPre.TabStop = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lblPage
            // 
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(314, 5);
            this.lblPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(96, 40);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "label1";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(410, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(5);
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 5;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.Location = new System.Drawing.Point(57, 5);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Padding = new System.Windows.Forms.Padding(5);
            this.btnZoomOut.Size = new System.Drawing.Size(40, 40);
            this.btnZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZoomOut.TabIndex = 4;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.Location = new System.Drawing.Point(10, 5);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(5, 5, 2, 2);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Padding = new System.Windows.Forms.Padding(5);
            this.btnZoomIn.Size = new System.Drawing.Size(40, 40);
            this.btnZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // lblLinkFile
            // 
            this.lblLinkFile.AutoSize = true;
            this.lblLinkFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLinkFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkFile.Location = new System.Drawing.Point(25, 75);
            this.lblLinkFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkFile.Name = "lblLinkFile";
            this.lblLinkFile.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblLinkFile.Size = new System.Drawing.Size(56, 33);
            this.lblLinkFile.TabIndex = 10;
            this.lblLinkFile.Text = "label1";
            // 
            // lblResourceName
            // 
            this.lblResourceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResourceName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceName.Location = new System.Drawing.Point(25, 25);
            this.lblResourceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceName.Name = "lblResourceName";
            this.lblResourceName.Size = new System.Drawing.Size(460, 50);
            this.lblResourceName.TabIndex = 9;
            this.lblResourceName.Text = "label1";
            // 
            // panDownload
            // 
            this.panDownload.Controls.Add(this.btnDownload);
            this.panDownload.Dock = System.Windows.Forms.DockStyle.Right;
            this.panDownload.Location = new System.Drawing.Point(515, 5);
            this.panDownload.Margin = new System.Windows.Forms.Padding(2);
            this.panDownload.Name = "panDownload";
            this.panDownload.Size = new System.Drawing.Size(60, 870);
            this.panDownload.TabIndex = 6;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(10, 40);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(10);
            this.btnDownload.Size = new System.Drawing.Size(40, 40);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownload.TabIndex = 3;
            this.btnDownload.TabStop = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // timerEvent
            // 
            this.timerEvent.Enabled = true;
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // itemFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "itemFile";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 900);
            this.panContainer.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.panToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoomIn)).EndInit();
            this.panDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panDownload;
        private System.Windows.Forms.PictureBox btnDownload;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblLinkFile;
        private System.Windows.Forms.Label lblResourceName;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panToolBar;
        private System.Windows.Forms.PictureBox btnZoomOut;
        private System.Windows.Forms.PictureBox btnZoomIn;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.PictureBox btnPre;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.Timer timerEvent;
    }
}
