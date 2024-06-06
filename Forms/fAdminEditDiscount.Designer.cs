namespace Elearning.Forms
{
    partial class fAdminEditDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiscount = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEnd = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.btnSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscount.DefaultText = "";
            this.tbDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscount.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.ForeColor = System.Drawing.Color.Black;
            this.tbDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscount.Location = new System.Drawing.Point(20, 94);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.PasswordChar = '\0';
            this.tbDiscount.PlaceholderText = "";
            this.tbDiscount.SelectedText = "";
            this.tbDiscount.Size = new System.Drawing.Size(490, 38);
            this.tbDiscount.TabIndex = 3;
            this.tbDiscount.TextChanged += new System.EventHandler(this.tbDiscount_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount (%)";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "End date";
            // 
            // dateEnd
            // 
            this.dateEnd.Checked = true;
            this.dateEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateEnd.ForeColor = System.Drawing.Color.Black;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateEnd.Location = new System.Drawing.Point(20, 149);
            this.dateEnd.MaxDate = new System.DateTime(2045, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(2024, 6, 6, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Padding = new System.Windows.Forms.Padding(3);
            this.dateEnd.Size = new System.Drawing.Size(490, 39);
            this.dateEnd.TabIndex = 5;
            this.dateEnd.Value = new System.DateTime(2024, 6, 6, 21, 49, 58, 276);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(490, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbCourseName
            // 
            this.lbCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCourseName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(20, 46);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(490, 31);
            this.lbCourseName.TabIndex = 11;
            this.lbCourseName.Text = "Discount (%)";
            // 
            // fAdminEditDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCourseName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAdminEditDiscount";
            this.Padding = new System.Windows.Forms.Padding(20, 6, 20, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateEnd;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSave;
        private System.Windows.Forms.Label lbCourseName;
    }
}