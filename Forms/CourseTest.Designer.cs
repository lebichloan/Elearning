namespace Elearning.Forms
{
    partial class CourseTest
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
            this.panQuestion = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flpAllQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.panQuestion.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panQuestion
            // 
            this.panQuestion.BorderColor = System.Drawing.Color.Gray;
            this.panQuestion.BorderThickness = 1;
            this.panQuestion.Controls.Add(this.label4);
            this.panQuestion.Location = new System.Drawing.Point(12, 110);
            this.panQuestion.Name = "panQuestion";
            this.panQuestion.Size = new System.Drawing.Size(300, 450);
            this.panQuestion.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng câu hỏi";
            // 
            // flpAllQuestion
            // 
            this.flpAllQuestion.AutoScroll = true;
            this.flpAllQuestion.Location = new System.Drawing.Point(318, 110);
            this.flpAllQuestion.Margin = new System.Windows.Forms.Padding(15);
            this.flpAllQuestion.Name = "flpAllQuestion";
            this.flpAllQuestion.Size = new System.Drawing.Size(898, 557);
            this.flpAllQuestion.TabIndex = 1;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Controls.Add(this.label3);
            this.siticonePanel2.Controls.Add(this.label2);
            this.siticonePanel2.Controls.Add(this.label1);
            this.siticonePanel2.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(1228, 95);
            this.siticonePanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian còn lại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1078, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(1143, 12);
            this.siticoneCirclePictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(75, 75);
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // timerTest
            // 
            this.timerTest.Enabled = true;
            // 
            // CourseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1228, 679);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.flpAllQuestion);
            this.Controls.Add(this.panQuestion);
            this.Name = "CourseTest";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panQuestion.ResumeLayout(false);
            this.panQuestion.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panQuestion;
        private System.Windows.Forms.FlowLayoutPanel flpAllQuestion;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Label label4;
    }
}