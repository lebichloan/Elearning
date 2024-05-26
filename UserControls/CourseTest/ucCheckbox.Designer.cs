namespace Elearning.UserControls.CourseTest
{
    partial class ucCheckbox
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lblStateAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRightAnswer = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.lblTick);
            this.siticonePanel1.Controls.Add(this.lblState);
            this.siticonePanel1.Controls.Add(this.lblNumber);
            this.siticonePanel1.Location = new System.Drawing.Point(20, 20);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(5);
            this.siticonePanel1.Size = new System.Drawing.Size(150, 200);
            this.siticonePanel1.TabIndex = 20;
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
            // siticonePanel2
            // 
            this.siticonePanel2.AutoSize = true;
            this.siticonePanel2.Controls.Add(this.lblQuestion);
            this.siticonePanel2.Location = new System.Drawing.Point(177, 20);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(680, 275);
            this.siticonePanel2.TabIndex = 21;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(20, 15);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 23);
            this.lblQuestion.TabIndex = 18;
            this.lblQuestion.Text = "Câu 1:";
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.lblRightAnswer);
            this.siticonePanel3.Controls.Add(this.label3);
            this.siticonePanel3.Controls.Add(this.lblStateAnswer);
            this.siticonePanel3.Location = new System.Drawing.Point(177, 301);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(680, 120);
            this.siticonePanel3.TabIndex = 22;
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
            // lblRightAnswer
            // 
            this.lblRightAnswer.AutoSize = true;
            this.lblRightAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswer.Location = new System.Drawing.Point(20, 81);
            this.lblRightAnswer.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblRightAnswer.Name = "lblRightAnswer";
            this.lblRightAnswer.Size = new System.Drawing.Size(161, 23);
            this.lblRightAnswer.TabIndex = 20;
            this.lblRightAnswer.Text = "Câu trả lời đúng là: ";
            // 
            // ucCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticonePanel2);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucCheckbox";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(875, 449);
            this.Load += new System.EventHandler(this.ucCheckbox_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTick;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lblQuestion;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label lblStateAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRightAnswer;
    }
}
