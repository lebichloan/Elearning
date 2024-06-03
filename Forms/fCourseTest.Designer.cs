namespace Elearning.Forms
{
    partial class fCourseTest
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picAvatar = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panQuestion = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tbAllQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tbQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.panQuestion.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.lblTimer);
            this.siticonePanel2.Controls.Add(this.label2);
            this.siticonePanel2.Controls.Add(this.lblName);
            this.siticonePanel2.Controls.Add(this.picAvatar);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1228, 95);
            this.siticonePanel2.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(83, 38);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(55, 23);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1054, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 35, 20, 0);
            this.lblName.Size = new System.Drawing.Size(79, 58);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // picAvatar
            // 
            this.picAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(1133, 0);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(10);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Padding = new System.Windows.Forms.Padding(10);
            this.picAvatar.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(95, 95);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // timerTest
            // 
            this.timerTest.Enabled = true;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.panQuestion);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 95);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(324, 584);
            this.siticonePanel1.TabIndex = 4;
            // 
            // panQuestion
            // 
            this.panQuestion.BorderColor = System.Drawing.Color.Gray;
            this.panQuestion.BorderThickness = 1;
            this.panQuestion.Controls.Add(this.tbAllQuestion);
            this.panQuestion.Controls.Add(this.label4);
            this.panQuestion.Location = new System.Drawing.Point(15, 20);
            this.panQuestion.Name = "panQuestion";
            this.panQuestion.Padding = new System.Windows.Forms.Padding(15);
            this.panQuestion.Size = new System.Drawing.Size(300, 450);
            this.panQuestion.TabIndex = 1;
            // 
            // tbAllQuestion
            // 
            this.tbAllQuestion.BackColor = System.Drawing.Color.White;
            this.tbAllQuestion.ColumnCount = 1;
            this.tbAllQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAllQuestion.Location = new System.Drawing.Point(15, 48);
            this.tbAllQuestion.Name = "tbAllQuestion";
            this.tbAllQuestion.RowCount = 1;
            this.tbAllQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbAllQuestion.Size = new System.Drawing.Size(270, 387);
            this.tbAllQuestion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label4.Size = new System.Drawing.Size(108, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "All Question";
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.siticonePanel4);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(324, 95);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(15);
            this.siticonePanel3.Size = new System.Drawing.Size(904, 584);
            this.siticonePanel3.TabIndex = 5;
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.BorderColor = System.Drawing.Color.Black;
            this.siticonePanel4.BorderThickness = 1;
            this.siticonePanel4.Controls.Add(this.tbQuestion);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel4.Location = new System.Drawing.Point(15, 15);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Padding = new System.Windows.Forms.Padding(5);
            this.siticonePanel4.Size = new System.Drawing.Size(874, 554);
            this.siticonePanel4.TabIndex = 0;
            // 
            // tbQuestion
            // 
            this.tbQuestion.ColumnCount = 1;
            this.tbQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestion.Location = new System.Drawing.Point(5, 5);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.RowCount = 1;
            this.tbQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuestion.Size = new System.Drawing.Size(864, 544);
            this.tbQuestion.TabIndex = 2;
            // 
            // fCourseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 679);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticonePanel2);
            this.Name = "fCourseTest";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.panQuestion.ResumeLayout(false);
            this.panQuestion.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel4.ResumeLayout(false);
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
    }
}