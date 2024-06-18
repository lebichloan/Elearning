namespace Elearning.Forms
{
    partial class fCourseTestOnlyQuestionInView
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
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnStart = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picAvatar = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnDone = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panQuestion = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tbAllQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panPaging = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnPre = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel5 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnNext = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tbQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.panQuestion.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            this.panPaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.btnStart);
            this.siticonePanel2.Controls.Add(this.lblTimer);
            this.siticonePanel2.Controls.Add(this.label2);
            this.siticonePanel2.Controls.Add(this.lblName);
            this.siticonePanel2.Controls.Add(this.picAvatar);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(982, 76);
            this.siticonePanel2.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 19);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(66, 30);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(45, 19);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(840, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 28, 16, 0);
            this.lblName.Size = new System.Drawing.Size(66, 47);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // picAvatar
            // 
            this.picAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(906, 0);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picAvatar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(76, 76);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // timerTest
            // 
            this.timerTest.Enabled = true;
            this.timerTest.Interval = 1000;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.btnDone);
            this.siticonePanel1.Controls.Add(this.panQuestion);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 76);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(259, 467);
            this.siticonePanel1.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(132, 381);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 40);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "Finish";
            this.btnDone.Visible = false;
            // 
            // panQuestion
            // 
            this.panQuestion.BorderColor = System.Drawing.Color.Gray;
            this.panQuestion.BorderThickness = 1;
            this.panQuestion.Controls.Add(this.tbAllQuestion);
            this.panQuestion.Controls.Add(this.label4);
            this.panQuestion.Location = new System.Drawing.Point(12, 16);
            this.panQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panQuestion.Name = "panQuestion";
            this.panQuestion.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.panQuestion.Size = new System.Drawing.Size(240, 360);
            this.panQuestion.TabIndex = 1;
            // 
            // tbAllQuestion
            // 
            this.tbAllQuestion.BackColor = System.Drawing.Color.White;
            this.tbAllQuestion.ColumnCount = 1;
            this.tbAllQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAllQuestion.Enabled = false;
            this.tbAllQuestion.Location = new System.Drawing.Point(12, 39);
            this.tbAllQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAllQuestion.Name = "tbAllQuestion";
            this.tbAllQuestion.RowCount = 1;
            this.tbAllQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllQuestion.Size = new System.Drawing.Size(216, 309);
            this.tbAllQuestion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "All Question";
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.siticonePanel4);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(259, 76);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.siticonePanel3.Size = new System.Drawing.Size(723, 467);
            this.siticonePanel3.TabIndex = 5;
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.BorderColor = System.Drawing.Color.Black;
            this.siticonePanel4.BorderThickness = 1;
            this.siticonePanel4.Controls.Add(this.panPaging);
            this.siticonePanel4.Controls.Add(this.tbQuestion);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel4.Location = new System.Drawing.Point(12, 12);
            this.siticonePanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticonePanel4.Size = new System.Drawing.Size(699, 443);
            this.siticonePanel4.TabIndex = 0;
            // 
            // panPaging
            // 
            this.panPaging.Controls.Add(this.btnPre);
            this.panPaging.Controls.Add(this.siticonePanel5);
            this.panPaging.Controls.Add(this.btnNext);
            this.panPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panPaging.Location = new System.Drawing.Point(4, 399);
            this.panPaging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panPaging.Name = "panPaging";
            this.panPaging.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.panPaging.Size = new System.Drawing.Size(691, 40);
            this.panPaging.TabIndex = 3;
            this.panPaging.Visible = false;
            // 
            // btnPre
            // 
            this.btnPre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPre.Location = new System.Drawing.Point(611, 4);
            this.btnPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(32, 32);
            this.btnPre.TabIndex = 23;
            this.btnPre.Visible = false;
            // 
            // siticonePanel5
            // 
            this.siticonePanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel5.Location = new System.Drawing.Point(643, 4);
            this.siticonePanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel5.Name = "siticonePanel5";
            this.siticonePanel5.Size = new System.Drawing.Size(8, 32);
            this.siticonePanel5.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(651, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 20;
            this.btnNext.Visible = false;
            // 
            // tbQuestion
            // 
            this.tbQuestion.ColumnCount = 1;
            this.tbQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestion.Location = new System.Drawing.Point(4, 4);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.RowCount = 1;
            this.tbQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuestion.Size = new System.Drawing.Size(691, 435);
            this.tbQuestion.TabIndex = 2;
            this.tbQuestion.Visible = false;
            // 
            // fCourseTestOnlyQuestionInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 543);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticonePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCourseTestOnlyQuestionInView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.panQuestion.ResumeLayout(false);
            this.panQuestion.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel4.ResumeLayout(false);
            this.panPaging.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox picAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerTest;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panQuestion;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.TableLayoutPanel tbAllQuestion;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private System.Windows.Forms.TableLayoutPanel tbQuestion;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnStart;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDone;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panPaging;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNext;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPre;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel5;
    }
}