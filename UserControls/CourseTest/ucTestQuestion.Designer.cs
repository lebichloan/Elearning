﻿namespace Elearning.UserControls.CourseTest
{
    partial class ucTestQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTestQuestion));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panQuestion = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.picTick = new System.Windows.Forms.PictureBox();
            this.lblQuestionScore = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panContent = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panChooseAnswer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panAnswer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTrueAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStateAnswer = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.panQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.panContent.SuspendLayout();
            this.panChooseAnswer.SuspendLayout();
            this.panAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.panQuestion);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(12, 12);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.siticonePanel1.Size = new System.Drawing.Size(136, 256);
            this.siticonePanel1.TabIndex = 26;
            // 
            // panQuestion
            // 
            this.panQuestion.BorderColor = System.Drawing.Color.Gray;
            this.panQuestion.BorderThickness = 1;
            this.panQuestion.Controls.Add(this.picTick);
            this.panQuestion.Controls.Add(this.lblQuestionScore);
            this.panQuestion.Controls.Add(this.lblTick);
            this.panQuestion.Controls.Add(this.lblState);
            this.panQuestion.Controls.Add(this.lblNumber);
            this.panQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panQuestion.Location = new System.Drawing.Point(8, 8);
            this.panQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panQuestion.Name = "panQuestion";
            this.panQuestion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panQuestion.Size = new System.Drawing.Size(120, 160);
            this.panQuestion.TabIndex = 24;
            // 
            // picTick
            // 
            this.picTick.Image = ((System.Drawing.Image)(resources.GetObject("picTick.Image")));
            this.picTick.Location = new System.Drawing.Point(61, 61);
            this.picTick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picTick.Name = "picTick";
            this.picTick.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTick.Size = new System.Drawing.Size(24, 24);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTick.TabIndex = 23;
            this.picTick.TabStop = false;
            this.picTick.Visible = false;
            // 
            // lblQuestionScore
            // 
            this.lblQuestionScore.AutoSize = true;
            this.lblQuestionScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionScore.Location = new System.Drawing.Point(12, 90);
            this.lblQuestionScore.Margin = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.lblQuestionScore.Name = "lblQuestionScore";
            this.lblQuestionScore.Size = new System.Drawing.Size(96, 19);
            this.lblQuestionScore.TabIndex = 22;
            this.lblQuestionScore.Text = "Đạt được: 0/1";
            this.lblQuestionScore.Visible = false;
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTick.Location = new System.Drawing.Point(12, 64);
            this.lblTick.Margin = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(51, 19);
            this.lblTick.TabIndex = 21;
            this.lblTick.Text = "Đặt cờ";
            this.lblTick.Click += new System.EventHandler(this.lblTick_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(12, 38);
            this.lblState.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(82, 19);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "Hoàn thành";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 12);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 19);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "Câu 1:";
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.AutoSize = true;
            this.siticonePanel2.Controls.Add(this.panContent);
            this.siticonePanel2.Controls.Add(this.siticonePanel3);
            this.siticonePanel2.Controls.Add(this.panAnswer);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(148, 12);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.siticonePanel2.Size = new System.Drawing.Size(786, 256);
            this.siticonePanel2.TabIndex = 27;
            // 
            // panContent
            // 
            this.panContent.BorderColor = System.Drawing.Color.Black;
            this.panContent.BorderThickness = 1;
            this.panContent.Controls.Add(this.panChooseAnswer);
            this.panContent.Controls.Add(this.lblQuestion);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(8, 8);
            this.panContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panContent.Name = "panContent";
            this.panContent.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.panContent.Size = new System.Drawing.Size(770, 224);
            this.panContent.TabIndex = 30;
            // 
            // panChooseAnswer
            // 
            this.panChooseAnswer.Controls.Add(this.lblError);
            this.panChooseAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChooseAnswer.Location = new System.Drawing.Point(16, 31);
            this.panChooseAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panChooseAnswer.Name = "panChooseAnswer";
            this.panChooseAnswer.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panChooseAnswer.Size = new System.Drawing.Size(738, 177);
            this.panChooseAnswer.TabIndex = 19;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 142);
            this.lblError.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 20;
            this.lblError.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(16, 8);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblQuestion.Size = new System.Drawing.Size(46, 23);
            this.lblQuestion.TabIndex = 18;
            this.lblQuestion.Text = "Câu 1:";
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel3.Location = new System.Drawing.Point(8, 232);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(770, 8);
            this.siticonePanel3.TabIndex = 29;
            // 
            // panAnswer
            // 
            this.panAnswer.BorderColor = System.Drawing.Color.Black;
            this.panAnswer.BorderThickness = 1;
            this.panAnswer.Controls.Add(this.lblTrueAnswer);
            this.panAnswer.Controls.Add(this.label3);
            this.panAnswer.Controls.Add(this.lblStateAnswer);
            this.panAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panAnswer.Location = new System.Drawing.Point(8, 240);
            this.panAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panAnswer.Name = "panAnswer";
            this.panAnswer.Size = new System.Drawing.Size(770, 8);
            this.panAnswer.TabIndex = 27;
            this.panAnswer.Visible = false;
            // 
            // lblTrueAnswer
            // 
            this.lblTrueAnswer.AutoSize = true;
            this.lblTrueAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueAnswer.Location = new System.Drawing.Point(16, 65);
            this.lblTrueAnswer.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.lblTrueAnswer.Name = "lblTrueAnswer";
            this.lblTrueAnswer.Size = new System.Drawing.Size(134, 19);
            this.lblTrueAnswer.TabIndex = 20;
            this.lblTrueAnswer.Text = "Câu trả lời đúng là: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Câu trả lời đúng là: ";
            // 
            // lblStateAnswer
            // 
            this.lblStateAnswer.AutoSize = true;
            this.lblStateAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAnswer.Location = new System.Drawing.Point(16, 12);
            this.lblStateAnswer.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.lblStateAnswer.Name = "lblStateAnswer";
            this.lblStateAnswer.Size = new System.Drawing.Size(165, 19);
            this.lblStateAnswer.TabIndex = 18;
            this.lblStateAnswer.Text = "Câu trả lời của bạn đúng";
            // 
            // ucTestQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "ucTestQuestion";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Size = new System.Drawing.Size(946, 280);
            this.siticonePanel1.ResumeLayout(false);
            this.panQuestion.ResumeLayout(false);
            this.panQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.panChooseAnswer.ResumeLayout(false);
            this.panChooseAnswer.PerformLayout();
            this.panAnswer.ResumeLayout(false);
            this.panAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panQuestion;
        private System.Windows.Forms.PictureBox picTick;
        private System.Windows.Forms.Label lblQuestionScore;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNumber;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panContent;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panChooseAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label lblError;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panAnswer;
        private System.Windows.Forms.Label lblTrueAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStateAnswer;
    }
}
