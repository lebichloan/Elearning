using System.Drawing;
using System.Windows.Forms;

namespace OnlineChat
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.centerContainer = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl5 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneContainerControl4 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbVeriCodeValid = new System.Windows.Forms.Label();
            this.tbCode = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butResetPassword = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl3 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbEmailValid = new System.Windows.Forms.Label();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butSendCode = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tbEmail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneContainerControl6 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneEmailValidatingTool1 = new Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.centerContainer.SuspendLayout();
            this.siticoneContainerControl5.SuspendLayout();
            this.siticoneContainerControl4.SuspendLayout();
            this.siticoneContainerControl3.SuspendLayout();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.siticoneContainerControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // centerContainer
            // 
            this.centerContainer.BackColor = System.Drawing.Color.Transparent;
            this.centerContainer.BorderRadius = 3;
            this.centerContainer.Controls.Add(this.siticoneContainerControl5);
            this.centerContainer.Controls.Add(this.label2);
            this.centerContainer.Controls.Add(this.siticoneContainerControl4);
            this.centerContainer.Controls.Add(this.siticoneContainerControl3);
            this.centerContainer.Controls.Add(this.siticoneContainerControl2);
            this.centerContainer.CustomBorderColor = System.Drawing.Color.Silver;
            this.centerContainer.FillColor = System.Drawing.Color.Gainsboro;
            this.centerContainer.Location = new System.Drawing.Point(109, 146);
            this.centerContainer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.centerContainer.Name = "centerContainer";
            this.centerContainer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.centerContainer.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.centerContainer.Size = new System.Drawing.Size(457, 352);
            this.centerContainer.TabIndex = 2;
            this.centerContainer.Text = "siticoneContainerControl2";
            this.centerContainer.UseTransparentBackground = true;
            // 
            // siticoneContainerControl5
            // 
            this.siticoneContainerControl5.Controls.Add(this.butLogin);
            this.siticoneContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl5.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl5.Location = new System.Drawing.Point(3, 266);
            this.siticoneContainerControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl5.Name = "siticoneContainerControl5";
            this.siticoneContainerControl5.Padding = new System.Windows.Forms.Padding(91, 16, 91, 0);
            this.siticoneContainerControl5.Size = new System.Drawing.Size(451, 84);
            this.siticoneContainerControl5.TabIndex = 5;
            this.siticoneContainerControl5.Text = "siticoneContainerControl5";
            // 
            // butLogin
            // 
            this.butLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.butLogin.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.butLogin.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold);
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(91, 16);
            this.butLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(269, 46);
            this.butLogin.TabIndex = 0;
            this.butLogin.Text = "Back to login";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(3, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "_______________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneContainerControl4
            // 
            this.siticoneContainerControl4.Controls.Add(this.lbVeriCodeValid);
            this.siticoneContainerControl4.Controls.Add(this.tbCode);
            this.siticoneContainerControl4.Controls.Add(this.butResetPassword);
            this.siticoneContainerControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl4.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl4.Location = new System.Drawing.Point(3, 134);
            this.siticoneContainerControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl4.Name = "siticoneContainerControl4";
            this.siticoneContainerControl4.Padding = new System.Windows.Forms.Padding(29, 9, 29, 0);
            this.siticoneContainerControl4.Size = new System.Drawing.Size(451, 116);
            this.siticoneContainerControl4.TabIndex = 3;
            this.siticoneContainerControl4.Text = "siticoneContainerControl4";
            // 
            // lbVeriCodeValid
            // 
            this.lbVeriCodeValid.AutoSize = true;
            this.lbVeriCodeValid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbVeriCodeValid.Location = new System.Drawing.Point(29, 47);
            this.lbVeriCodeValid.Name = "lbVeriCodeValid";
            this.lbVeriCodeValid.Size = new System.Drawing.Size(0, 16);
            this.lbVeriCodeValid.TabIndex = 6;
            // 
            // tbCode
            // 
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DefaultText = "";
            this.tbCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCode.ForeColor = System.Drawing.Color.Black;
            this.tbCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCode.Location = new System.Drawing.Point(29, 9);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.PasswordChar = '\0';
            this.tbCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbCode.PlaceholderText = "Enter the verification code";
            this.tbCode.SelectedText = "";
            this.tbCode.Size = new System.Drawing.Size(393, 38);
            this.tbCode.TabIndex = 5;
            // 
            // butResetPassword
            // 
            this.butResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butResetPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butResetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.butResetPassword.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butResetPassword.ForeColor = System.Drawing.Color.White;
            this.butResetPassword.Location = new System.Drawing.Point(29, 70);
            this.butResetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butResetPassword.Name = "butResetPassword";
            this.butResetPassword.Size = new System.Drawing.Size(393, 46);
            this.butResetPassword.TabIndex = 4;
            this.butResetPassword.Text = "Reset password";
            this.butResetPassword.Click += new System.EventHandler(this.butResetPassword_Click);
            // 
            // siticoneContainerControl3
            // 
            this.siticoneContainerControl3.Controls.Add(this.lbEmailValid);
            this.siticoneContainerControl3.Controls.Add(this.siticoneContainerControl1);
            this.siticoneContainerControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl3.Location = new System.Drawing.Point(3, 65);
            this.siticoneContainerControl3.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.siticoneContainerControl3.Name = "siticoneContainerControl3";
            this.siticoneContainerControl3.Padding = new System.Windows.Forms.Padding(29, 16, 29, 16);
            this.siticoneContainerControl3.Size = new System.Drawing.Size(451, 69);
            this.siticoneContainerControl3.TabIndex = 2;
            this.siticoneContainerControl3.Text = "siticoneContainerControl3";
            // 
            // lbEmailValid
            // 
            this.lbEmailValid.AutoSize = true;
            this.lbEmailValid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmailValid.Location = new System.Drawing.Point(29, 53);
            this.lbEmailValid.Name = "lbEmailValid";
            this.lbEmailValid.Size = new System.Drawing.Size(0, 16);
            this.lbEmailValid.TabIndex = 1;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.butSendCode);
            this.siticoneContainerControl1.Controls.Add(this.tbEmail);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(29, 16);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(393, 37);
            this.siticoneContainerControl1.TabIndex = 0;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // butSendCode
            // 
            this.butSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSendCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSendCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSendCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSendCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSendCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSendCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.butSendCode.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSendCode.ForeColor = System.Drawing.Color.White;
            this.butSendCode.Location = new System.Drawing.Point(276, 0);
            this.butSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSendCode.Name = "butSendCode";
            this.butSendCode.Size = new System.Drawing.Size(117, 37);
            this.butSendCode.TabIndex = 5;
            this.butSendCode.Text = "Send code";
            this.butSendCode.Click += new System.EventHandler(this.butSendCode_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BorderRadius = 2;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(0, 0);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbEmail.PlaceholderText = "Enter your email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(276, 37);
            this.tbEmail.TabIndex = 4;
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.label3);
            this.siticoneContainerControl2.Controls.Add(this.label1);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(3, 2);
            this.siticoneContainerControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Size = new System.Drawing.Size(451, 63);
            this.siticoneContainerControl2.TabIndex = 1;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reset your password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, -62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneContainerControl6
            // 
            this.siticoneContainerControl6.BackColor = System.Drawing.SystemColors.Control;
            this.siticoneContainerControl6.Controls.Add(this.siticoneControlBox1);
            this.siticoneContainerControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl6.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl6.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl6.Name = "siticoneContainerControl6";
            this.siticoneContainerControl6.Size = new System.Drawing.Size(665, 41);
            this.siticoneContainerControl6.TabIndex = 3;
            this.siticoneContainerControl6.Text = "siticoneContainerControl6";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(609, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(56, 41);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneEmailValidatingTool1
            // 
            this.siticoneEmailValidatingTool1.EmailTextbox = this.tbEmail;
            this.siticoneEmailValidatingTool1.MessageDescription = this.lbEmailValid;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.siticoneContainerControl6;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 588);
            this.Controls.Add(this.siticoneContainerControl6);
            this.Controls.Add(this.centerContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.centerContainer.ResumeLayout(false);
            this.siticoneContainerControl5.ResumeLayout(false);
            this.siticoneContainerControl4.ResumeLayout(false);
            this.siticoneContainerControl4.PerformLayout();
            this.siticoneContainerControl3.ResumeLayout(false);
            this.siticoneContainerControl3.PerformLayout();
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.siticoneContainerControl6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl centerContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butLogin;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butResetPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private Label label1;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbCode;
        private Label lbVeriCodeValid;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl3;
        private Label lbEmailValid;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSendCode;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbEmail;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl6;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool siticoneEmailValidatingTool1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}