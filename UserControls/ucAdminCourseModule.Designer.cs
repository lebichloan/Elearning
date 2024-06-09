namespace Elearning.UserControls
{
    partial class ucAdminCourseModule
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
            this.lbModuleName = new System.Windows.Forms.Label();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl3 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.lbDescription = new System.Windows.Forms.Label();
            this.siticoneContainerControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.siticoneContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbModuleName
            // 
            this.lbModuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModuleName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModuleName.Location = new System.Drawing.Point(0, 0);
            this.lbModuleName.Name = "lbModuleName";
            this.lbModuleName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbModuleName.Size = new System.Drawing.Size(665, 39);
            this.lbModuleName.TabIndex = 0;
            this.lbModuleName.Text = "Module name";
            this.lbModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpItems
            // 
            this.flpItems.AutoSize = true;
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(3, 85);
            this.flpItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpItems.MaximumSize = new System.Drawing.Size(0, 300);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(791, 208);
            this.flpItems.TabIndex = 1;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.lbModuleName);
            this.siticoneContainerControl1.Controls.Add(this.lbDescription);
            this.siticoneContainerControl1.Controls.Add(this.tableLayoutPanel1);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(3, 2);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(791, 69);
            this.siticoneContainerControl1.TabIndex = 2;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(665, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(119, 69);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Elearning.Properties.Resources.remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(62, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 55);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Elearning.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(8, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticoneContainerControl2.BorderRadius = 8;
            this.siticoneContainerControl2.BorderThickness = 1;
            this.siticoneContainerControl2.Controls.Add(this.flpItems);
            this.siticoneContainerControl2.Controls.Add(this.siticoneContainerControl3);
            this.siticoneContainerControl2.Controls.Add(this.siticoneContainerControl1);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(797, 295);
            this.siticoneContainerControl2.TabIndex = 0;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // siticoneContainerControl3
            // 
            this.siticoneContainerControl3.Controls.Add(this.siticoneSeparator1);
            this.siticoneContainerControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl3.Location = new System.Drawing.Point(3, 71);
            this.siticoneContainerControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneContainerControl3.Name = "siticoneContainerControl3";
            this.siticoneContainerControl3.Size = new System.Drawing.Size(791, 14);
            this.siticoneContainerControl3.TabIndex = 3;
            this.siticoneContainerControl3.Text = "siticoneContainerControl3";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneSeparator1.Location = new System.Drawing.Point(0, 0);
            this.siticoneSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(791, 14);
            this.siticoneSeparator1.TabIndex = 0;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(0, 39);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbDescription.Size = new System.Drawing.Size(665, 30);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "Module description";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAdminCourseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.siticoneContainerControl2);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(600, 111);
            this.Name = "ucAdminCourseModule";
            this.Size = new System.Drawing.Size(797, 295);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.siticoneContainerControl2.PerformLayout();
            this.siticoneContainerControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbModuleName;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl3;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private System.Windows.Forms.Label lbDescription;
    }
}
