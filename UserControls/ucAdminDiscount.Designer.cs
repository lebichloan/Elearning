namespace Elearning.UserControls
{
    partial class ucAdminDiscount
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.lbDiscount = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl3 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbDiscountEndDate = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lbDiscounted = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneContainerControl2.SuspendLayout();
            this.siticoneContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPrice
            // 
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPrice.Location = new System.Drawing.Point(0, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(130, 35);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Price: ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiscount
            // 
            this.lbDiscount.BorderRadius = 5;
            this.lbDiscount.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lbDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lbDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lbDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lbDiscount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lbDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lbDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.White;
            this.lbDiscount.Location = new System.Drawing.Point(20, 5);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(125, 38);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "50%";
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 83);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(141, 45);
            this.siticoneContainerControl1.TabIndex = 5;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.lbDiscount);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(20, 5, 160, 5);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(305, 48);
            this.siticoneContainerControl2.TabIndex = 6;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // siticoneContainerControl3
            // 
            this.siticoneContainerControl3.Controls.Add(this.lbPrice);
            this.siticoneContainerControl3.Controls.Add(this.lbDiscounted);
            this.siticoneContainerControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl3.Location = new System.Drawing.Point(0, 48);
            this.siticoneContainerControl3.Name = "siticoneContainerControl3";
            this.siticoneContainerControl3.Size = new System.Drawing.Size(305, 35);
            this.siticoneContainerControl3.TabIndex = 7;
            this.siticoneContainerControl3.Text = "siticoneContainerControl3";
            // 
            // lbDiscountEndDate
            // 
            this.lbDiscountEndDate.AutoSize = false;
            this.lbDiscountEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDiscountEndDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDiscountEndDate.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscountEndDate.Location = new System.Drawing.Point(141, 82);
            this.lbDiscountEndDate.Name = "lbDiscountEndDate";
            this.lbDiscountEndDate.Size = new System.Drawing.Size(164, 46);
            this.lbDiscountEndDate.TabIndex = 1;
            this.lbDiscountEndDate.Text = "until";
            // 
            // lbDiscounted
            // 
            this.lbDiscounted.AutoSize = false;
            this.lbDiscounted.BackColor = System.Drawing.Color.Transparent;
            this.lbDiscounted.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDiscounted.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscounted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDiscounted.Location = new System.Drawing.Point(130, 0);
            this.lbDiscounted.Name = "lbDiscounted";
            this.lbDiscounted.Size = new System.Drawing.Size(175, 35);
            this.lbDiscounted.TabIndex = 0;
            this.lbDiscounted.Text = "discounted";
            this.lbDiscounted.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAdminDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDiscountEndDate);
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.siticoneContainerControl3);
            this.Controls.Add(this.siticoneContainerControl2);
            this.Name = "ucAdminDiscount";
            this.Size = new System.Drawing.Size(305, 128);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.siticoneContainerControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPrice;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton lbDiscount;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbDiscounted;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbDiscountEndDate;
    }
}
