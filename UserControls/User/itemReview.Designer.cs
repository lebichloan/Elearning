namespace Elearning.UserControls.User
{
    partial class itemReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemReview));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.picAvatar = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.panStar = new System.Windows.Forms.Panel();
            this.btnStar5 = new System.Windows.Forms.PictureBox();
            this.btnStar4 = new System.Windows.Forms.PictureBox();
            this.btnStar3 = new System.Windows.Forms.PictureBox();
            this.btnStar2 = new System.Windows.Forms.PictureBox();
            this.btnStar1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.siticonePanel3.SuspendLayout();
            this.panStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Black;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.Location = new System.Drawing.Point(10, 149);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(570, 1);
            this.siticonePanel1.TabIndex = 26;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.picAvatar);
            this.siticonePanel2.Controls.Add(this.siticonePanel3);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.Location = new System.Drawing.Point(10, 5);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(570, 138);
            this.siticonePanel2.TabIndex = 29;
            // 
            // picAvatar
            // 
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(0, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.TabIndex = 33;
            this.picAvatar.TabStop = false;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.lblDateTime);
            this.siticonePanel3.Controls.Add(this.lblReview);
            this.siticonePanel3.Controls.Add(this.panStar);
            this.siticonePanel3.Controls.Add(this.lblName);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel3.Location = new System.Drawing.Point(78, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.siticonePanel3.Size = new System.Drawing.Size(492, 138);
            this.siticonePanel3.TabIndex = 32;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(20, 121);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(72, 17);
            this.lblDateTime.TabIndex = 31;
            this.lblDateTime.Text = "13/06/2024";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(20, 63);
            this.lblReview.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(56, 23);
            this.lblReview.TabIndex = 30;
            this.lblReview.Text = "Câu 1:";
            // 
            // panStar
            // 
            this.panStar.Controls.Add(this.btnStar5);
            this.panStar.Controls.Add(this.btnStar4);
            this.panStar.Controls.Add(this.btnStar3);
            this.panStar.Controls.Add(this.btnStar2);
            this.panStar.Controls.Add(this.btnStar1);
            this.panStar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panStar.Location = new System.Drawing.Point(20, 23);
            this.panStar.Name = "panStar";
            this.panStar.Size = new System.Drawing.Size(472, 40);
            this.panStar.TabIndex = 26;
            // 
            // btnStar5
            // 
            this.btnStar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStar5.Image = ((System.Drawing.Image)(resources.GetObject("btnStar5.Image")));
            this.btnStar5.Location = new System.Drawing.Point(160, 0);
            this.btnStar5.Name = "btnStar5";
            this.btnStar5.Padding = new System.Windows.Forms.Padding(5);
            this.btnStar5.Size = new System.Drawing.Size(40, 40);
            this.btnStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStar5.TabIndex = 29;
            this.btnStar5.TabStop = false;
            // 
            // btnStar4
            // 
            this.btnStar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStar4.Image = ((System.Drawing.Image)(resources.GetObject("btnStar4.Image")));
            this.btnStar4.Location = new System.Drawing.Point(120, 0);
            this.btnStar4.Name = "btnStar4";
            this.btnStar4.Padding = new System.Windows.Forms.Padding(5);
            this.btnStar4.Size = new System.Drawing.Size(40, 40);
            this.btnStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStar4.TabIndex = 28;
            this.btnStar4.TabStop = false;
            // 
            // btnStar3
            // 
            this.btnStar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStar3.Image = ((System.Drawing.Image)(resources.GetObject("btnStar3.Image")));
            this.btnStar3.Location = new System.Drawing.Point(80, 0);
            this.btnStar3.Name = "btnStar3";
            this.btnStar3.Padding = new System.Windows.Forms.Padding(5);
            this.btnStar3.Size = new System.Drawing.Size(40, 40);
            this.btnStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStar3.TabIndex = 27;
            this.btnStar3.TabStop = false;
            // 
            // btnStar2
            // 
            this.btnStar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStar2.Image = ((System.Drawing.Image)(resources.GetObject("btnStar2.Image")));
            this.btnStar2.Location = new System.Drawing.Point(40, 0);
            this.btnStar2.Name = "btnStar2";
            this.btnStar2.Padding = new System.Windows.Forms.Padding(5);
            this.btnStar2.Size = new System.Drawing.Size(40, 40);
            this.btnStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStar2.TabIndex = 26;
            this.btnStar2.TabStop = false;
            // 
            // btnStar1
            // 
            this.btnStar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStar1.Image = ((System.Drawing.Image)(resources.GetObject("btnStar1.Image")));
            this.btnStar1.Location = new System.Drawing.Point(0, 0);
            this.btnStar1.Name = "btnStar1";
            this.btnStar1.Padding = new System.Windows.Forms.Padding(5);
            this.btnStar1.Size = new System.Drawing.Size(40, 40);
            this.btnStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStar1.TabIndex = 25;
            this.btnStar1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 23);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Câu 1:";
            // 
            // itemReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticonePanel2);
            this.Name = "itemReview";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Size = new System.Drawing.Size(590, 155);
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel3.PerformLayout();
            this.panStar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox picAvatar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Panel panStar;
        private System.Windows.Forms.PictureBox btnStar5;
        private System.Windows.Forms.PictureBox btnStar4;
        private System.Windows.Forms.PictureBox btnStar3;
        private System.Windows.Forms.PictureBox btnStar2;
        private System.Windows.Forms.PictureBox btnStar1;
        private System.Windows.Forms.Label lblName;
    }
}
