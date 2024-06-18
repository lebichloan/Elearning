namespace Elearning.UserControls
{
    partial class ucCourse
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
            this.panTop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnViewDetail = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lblDone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.picCourseImage = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.btnBackHome = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.layoutResource = new System.Windows.Forms.TableLayoutPanel();
            this.layoutModule = new System.Windows.Forms.TableLayoutPanel();
            this.panTop.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticoneContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseImage)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.SystemColors.Window;
            this.panTop.Controls.Add(this.btnViewDetail);
            this.panTop.Controls.Add(this.siticonePanel4);
            this.panTop.Controls.Add(this.siticonePanel3);
            this.panTop.Controls.Add(this.btnBackHome);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(880, 40);
            this.panTop.TabIndex = 0;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BorderRadius = 2;
            this.btnViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnViewDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnViewDetail.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Location = new System.Drawing.Point(655, 0);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(120, 40);
            this.btnViewDetail.TabIndex = 17;
            this.btnViewDetail.Text = "View detail";
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel4.Location = new System.Drawing.Point(775, 0);
            this.siticonePanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Size = new System.Drawing.Size(7, 40);
            this.siticonePanel4.TabIndex = 12;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.siticoneContainerControl1);
            this.siticonePanel3.Controls.Add(this.picCourseImage);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.siticonePanel3.Size = new System.Drawing.Size(782, 40);
            this.siticonePanel3.TabIndex = 11;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.lblDone);
            this.siticoneContainerControl1.Controls.Add(this.panel2);
            this.siticoneContainerControl1.Controls.Add(this.lblLecturerName);
            this.siticoneContainerControl1.Controls.Add(this.panel1);
            this.siticoneContainerControl1.Controls.Add(this.lblCourseName);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(40, 0);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(742, 32);
            this.siticoneContainerControl1.TabIndex = 4;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.lblDone.ForeColor = System.Drawing.Color.Red;
            this.lblDone.Location = new System.Drawing.Point(246, 8);
            this.lblDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblDone.Size = new System.Drawing.Size(57, 21);
            this.lblDone.TabIndex = 12;
            this.lblDone.Text = "Done";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(245, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 24);
            this.panel2.TabIndex = 11;
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLecturerName.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerName.Location = new System.Drawing.Point(126, 8);
            this.lblLecturerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblLecturerName.Size = new System.Drawing.Size(119, 21);
            this.lblLecturerName.TabIndex = 10;
            this.lblLecturerName.Text = "Lecturer name";
            this.lblLecturerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(125, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 24);
            this.panel1.TabIndex = 9;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(8, 8);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblCourseName.Size = new System.Drawing.Size(117, 21);
            this.lblCourseName.TabIndex = 8;
            this.lblCourseName.Text = "Course Name";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCourseImage
            // 
            this.picCourseImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCourseImage.ImageRotate = 0F;
            this.picCourseImage.Location = new System.Drawing.Point(8, 0);
            this.picCourseImage.Margin = new System.Windows.Forms.Padding(0);
            this.picCourseImage.Name = "picCourseImage";
            this.picCourseImage.Size = new System.Drawing.Size(32, 32);
            this.picCourseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseImage.TabIndex = 1;
            this.picCourseImage.TabStop = false;
            // 
            // btnBackHome
            // 
            this.btnBackHome.BorderRadius = 2;
            this.btnBackHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBackHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnBackHome.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.ForeColor = System.Drawing.Color.White;
            this.btnBackHome.Location = new System.Drawing.Point(782, 0);
            this.btnBackHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(98, 40);
            this.btnBackHome.TabIndex = 10;
            this.btnBackHome.Text = "Back";
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Controls.Add(this.layoutResource);
            this.siticonePanel1.Controls.Add(this.layoutModule);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 40);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(880, 480);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Black;
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel2.Location = new System.Drawing.Point(370, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1, 480);
            this.siticonePanel2.TabIndex = 5;
            // 
            // layoutResource
            // 
            this.layoutResource.ColumnCount = 1;
            this.layoutResource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutResource.Location = new System.Drawing.Point(370, 0);
            this.layoutResource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutResource.Name = "layoutResource";
            this.layoutResource.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.layoutResource.RowCount = 2;
            this.layoutResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutResource.Size = new System.Drawing.Size(510, 480);
            this.layoutResource.TabIndex = 4;
            // 
            // layoutModule
            // 
            this.layoutModule.ColumnCount = 1;
            this.layoutModule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutModule.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutModule.Location = new System.Drawing.Point(0, 0);
            this.layoutModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutModule.Name = "layoutModule";
            this.layoutModule.RowCount = 2;
            this.layoutModule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutModule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutModule.Size = new System.Drawing.Size(370, 480);
            this.layoutModule.TabIndex = 3;
            // 
            // ucCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.panTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucCourse";
            this.Size = new System.Drawing.Size(880, 520);
            this.panTop.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseImage)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panTop;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.TableLayoutPanel layoutResource;
        private System.Windows.Forms.TableLayoutPanel layoutModule;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBackHome;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox picCourseImage;
        private System.Windows.Forms.Label lblLecturerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnViewDetail;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
    }
}
