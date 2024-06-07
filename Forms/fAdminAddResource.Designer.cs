namespace Elearning.Forms
{
    partial class fAdminAddResource
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.siticoneContainerControl3 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.conChooseFile = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.tbPath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lbChooseFile = new System.Windows.Forms.Label();
            this.siticoneContainerControl5 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optYes = new System.Windows.Forms.RadioButton();
            this.siticoneContainerControl8 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.cbType = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneContainerControl6 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbOption = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneContainerControl3.SuspendLayout();
            this.conChooseFile.SuspendLayout();
            this.siticoneContainerControl5.SuspendLayout();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl8.SuspendLayout();
            this.siticoneContainerControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(488, 40);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add New Resource";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneContainerControl3
            // 
            this.siticoneContainerControl3.BorderColor = System.Drawing.Color.Silver;
            this.siticoneContainerControl3.BorderRadius = 4;
            this.siticoneContainerControl3.Controls.Add(this.btnSave);
            this.siticoneContainerControl3.Controls.Add(this.conChooseFile);
            this.siticoneContainerControl3.Controls.Add(this.lbChooseFile);
            this.siticoneContainerControl3.Controls.Add(this.siticoneContainerControl5);
            this.siticoneContainerControl3.Controls.Add(this.tbName);
            this.siticoneContainerControl3.Controls.Add(this.label2);
            this.siticoneContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl3.Location = new System.Drawing.Point(0, 49);
            this.siticoneContainerControl3.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneContainerControl3.Name = "siticoneContainerControl3";
            this.siticoneContainerControl3.Padding = new System.Windows.Forms.Padding(20, 5, 20, 15);
            this.siticoneContainerControl3.Size = new System.Drawing.Size(488, 255);
            this.siticoneContainerControl3.TabIndex = 2;
            this.siticoneContainerControl3.Text = "Course Name*";
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
            this.btnSave.Location = new System.Drawing.Point(27, 241);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(448, 45);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // conChooseFile
            // 
            this.conChooseFile.Controls.Add(this.tbPath);
            this.conChooseFile.Controls.Add(this.btnChooseFile);
            this.conChooseFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.conChooseFile.Location = new System.Drawing.Point(27, 179);
            this.conChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.conChooseFile.Name = "conChooseFile";
            this.conChooseFile.Size = new System.Drawing.Size(448, 36);
            this.conChooseFile.TabIndex = 7;
            this.conChooseFile.Text = "siticoneContainerControl4";
            // 
            // tbPath
            // 
            this.tbPath.BorderRadius = 5;
            this.tbPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPath.DefaultText = "";
            this.tbPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPath.Location = new System.Drawing.Point(113, 0);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.PlaceholderText = "";
            this.tbPath.ReadOnly = true;
            this.tbPath.SelectedText = "";
            this.tbPath.Size = new System.Drawing.Size(363, 36);
            this.tbPath.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChooseFile.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.Location = new System.Drawing.Point(0, 0);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(85, 36);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lbChooseFile
            // 
            this.lbChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.lbChooseFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbChooseFile.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseFile.Location = new System.Drawing.Point(20, 123);
            this.lbChooseFile.Name = "lbChooseFile";
            this.lbChooseFile.Size = new System.Drawing.Size(448, 22);
            this.lbChooseFile.TabIndex = 6;
            this.lbChooseFile.Text = "Choose resource\'s file ";
            this.lbChooseFile.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // siticoneContainerControl5
            // 
            this.siticoneContainerControl5.Controls.Add(this.siticoneContainerControl1);
            this.siticoneContainerControl5.Controls.Add(this.siticoneContainerControl8);
            this.siticoneContainerControl5.Controls.Add(this.siticoneContainerControl6);
            this.siticoneContainerControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl5.Location = new System.Drawing.Point(20, 60);
            this.siticoneContainerControl5.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl5.Name = "siticoneContainerControl5";
            this.siticoneContainerControl5.Size = new System.Drawing.Size(448, 63);
            this.siticoneContainerControl5.TabIndex = 12;
            this.siticoneContainerControl5.Text = "siticoneContainerControl5";
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.optNo);
            this.siticoneContainerControl1.Controls.Add(this.optYes);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(201, 22);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(1, 1, 3, 0);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(270, 41);
            this.siticoneContainerControl1.TabIndex = 3;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.BackColor = System.Drawing.Color.White;
            this.optNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.optNo.Location = new System.Drawing.Point(52, 1);
            this.optNo.Margin = new System.Windows.Forms.Padding(2);
            this.optNo.Name = "optNo";
            this.optNo.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.optNo.Size = new System.Drawing.Size(47, 40);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = false;
            // 
            // optYes
            // 
            this.optYes.AutoSize = true;
            this.optYes.BackColor = System.Drawing.Color.Transparent;
            this.optYes.Dock = System.Windows.Forms.DockStyle.Left;
            this.optYes.Location = new System.Drawing.Point(1, 1);
            this.optYes.Margin = new System.Windows.Forms.Padding(2);
            this.optYes.Name = "optYes";
            this.optYes.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.optYes.Size = new System.Drawing.Size(51, 40);
            this.optYes.TabIndex = 0;
            this.optYes.TabStop = true;
            this.optYes.Text = "Yes";
            this.optYes.UseVisualStyleBackColor = false;
            // 
            // siticoneContainerControl8
            // 
            this.siticoneContainerControl8.Controls.Add(this.cbType);
            this.siticoneContainerControl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticoneContainerControl8.Location = new System.Drawing.Point(0, 22);
            this.siticoneContainerControl8.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl8.Name = "siticoneContainerControl8";
            this.siticoneContainerControl8.Padding = new System.Windows.Forms.Padding(1, 1, 3, 0);
            this.siticoneContainerControl8.Size = new System.Drawing.Size(201, 41);
            this.siticoneContainerControl8.TabIndex = 2;
            this.siticoneContainerControl8.Text = "siticoneContainerControl8";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Location = new System.Drawing.Point(1, 1);
            this.cbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(197, 36);
            this.cbType.TabIndex = 0;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // siticoneContainerControl6
            // 
            this.siticoneContainerControl6.Controls.Add(this.lbOption);
            this.siticoneContainerControl6.Controls.Add(this.label7);
            this.siticoneContainerControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl6.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl6.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl6.Name = "siticoneContainerControl6";
            this.siticoneContainerControl6.Size = new System.Drawing.Size(448, 22);
            this.siticoneContainerControl6.TabIndex = 0;
            this.siticoneContainerControl6.Text = "siticoneContainerControl6";
            // 
            // lbOption
            // 
            this.lbOption.BackColor = System.Drawing.Color.Transparent;
            this.lbOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbOption.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOption.Location = new System.Drawing.Point(201, 0);
            this.lbOption.Name = "lbOption";
            this.lbOption.Size = new System.Drawing.Size(172, 22);
            this.lbOption.TabIndex = 5;
            this.lbOption.Text = "Allow Download?";
            this.lbOption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(27, 27);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(448, 38);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resource\'s name";
            // 
            // fAdminAddResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 295);
            this.Controls.Add(this.siticoneContainerControl3);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAdminAddResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.siticoneContainerControl3.ResumeLayout(false);
            this.conChooseFile.ResumeLayout(false);
            this.siticoneContainerControl5.ResumeLayout(false);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl1.PerformLayout();
            this.siticoneContainerControl8.ResumeLayout(false);
            this.siticoneContainerControl6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSave;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conChooseFile;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbPath;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lbChooseFile;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl5;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl8;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbType;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl6;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbName;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optYes;
        private System.Windows.Forms.Label lbOption;
    }
}