namespace Elearning.UserControls.CourseTest
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
            this.panQuestion = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.picTick = new System.Windows.Forms.PictureBox();
            this.lblQuestionScore = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panContent = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panAnswer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblTrueAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStateAnswer = new System.Windows.Forms.Label();
            this.panQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            this.panContent.SuspendLayout();
            this.panAnswer.SuspendLayout();
            this.SuspendLayout();
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
            this.panQuestion.Location = new System.Drawing.Point(19, 19);
            this.panQuestion.Name = "panQuestion";
            this.panQuestion.Padding = new System.Windows.Forms.Padding(5);
            this.panQuestion.Size = new System.Drawing.Size(150, 200);
            this.panQuestion.TabIndex = 23;
            // 
            // picTick
            // 
            this.picTick.Image = ((System.Drawing.Image)(resources.GetObject("picTick.Image")));
            this.picTick.Location = new System.Drawing.Point(76, 76);
            this.picTick.Name = "picTick";
            this.picTick.Padding = new System.Windows.Forms.Padding(5);
            this.picTick.Size = new System.Drawing.Size(30, 30);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTick.TabIndex = 23;
            this.picTick.TabStop = false;
            this.picTick.Visible = false;
            // 
            // lblQuestionScore
            // 
            this.lblQuestionScore.AutoSize = true;
            this.lblQuestionScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionScore.Location = new System.Drawing.Point(15, 112);
            this.lblQuestionScore.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblQuestionScore.Name = "lblQuestionScore";
            this.lblQuestionScore.Size = new System.Drawing.Size(113, 23);
            this.lblQuestionScore.TabIndex = 22;
            this.lblQuestionScore.Text = "Đạt được: 0/1";
            this.lblQuestionScore.Visible = false;
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTick.Location = new System.Drawing.Point(15, 80);
            this.lblTick.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(60, 23);
            this.lblTick.TabIndex = 21;
            this.lblTick.Text = "Đặt cờ";
            this.lblTick.Click += new System.EventHandler(this.lblTick_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(15, 48);
            this.lblState.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(102, 23);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "Hoàn thành";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(15, 15);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(60, 23);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "Câu 1:";
            // 
            // panContent
            // 
            this.panContent.AutoSize = true;
            this.panContent.Controls.Add(this.lblQuestion);
            this.panContent.Location = new System.Drawing.Point(176, 19);
            this.panContent.Name = "panContent";
            this.panContent.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panContent.Size = new System.Drawing.Size(680, 275);
            this.panContent.TabIndex = 24;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(20, 20);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 23);
            this.lblQuestion.TabIndex = 18;
            this.lblQuestion.Text = "Câu 1:";
            // 
            // panAnswer
            // 
            this.panAnswer.Controls.Add(this.lblTrueAnswer);
            this.panAnswer.Controls.Add(this.label3);
            this.panAnswer.Controls.Add(this.lblStateAnswer);
            this.panAnswer.Location = new System.Drawing.Point(176, 300);
            this.panAnswer.Name = "panAnswer";
            this.panAnswer.Size = new System.Drawing.Size(680, 120);
            this.panAnswer.TabIndex = 25;
            this.panAnswer.Visible = false;
            // 
            // lblTrueAnswer
            // 
            this.lblTrueAnswer.AutoSize = true;
            this.lblTrueAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueAnswer.Location = new System.Drawing.Point(20, 81);
            this.lblTrueAnswer.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblTrueAnswer.Name = "lblTrueAnswer";
            this.lblTrueAnswer.Size = new System.Drawing.Size(161, 23);
            this.lblTrueAnswer.TabIndex = 20;
            this.lblTrueAnswer.Text = "Câu trả lời đúng là: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Câu trả lời đúng là: ";
            // 
            // lblStateAnswer
            // 
            this.lblStateAnswer.AutoSize = true;
            this.lblStateAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAnswer.Location = new System.Drawing.Point(20, 15);
            this.lblStateAnswer.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblStateAnswer.Name = "lblStateAnswer";
            this.lblStateAnswer.Size = new System.Drawing.Size(200, 23);
            this.lblStateAnswer.TabIndex = 18;
            this.lblStateAnswer.Text = "Câu trả lời của bạn đúng";
            // 
            // ucTestQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panQuestion);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panAnswer);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucTestQuestion";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(875, 438);
            this.Load += new System.EventHandler(this.ucTestQuestion_Load);
            this.panQuestion.ResumeLayout(false);
            this.panQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.panAnswer.ResumeLayout(false);
            this.panAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panQuestion;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNumber;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panContent;
        private System.Windows.Forms.Label lblQuestion;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panAnswer;
        private System.Windows.Forms.Label lblTrueAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStateAnswer;
        private System.Windows.Forms.Label lblQuestionScore;
        private System.Windows.Forms.PictureBox picTick;
    }
}
