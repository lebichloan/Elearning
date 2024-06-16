namespace Elearning.UserControls
{
    partial class ucAdminEditSyllabus
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
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbModuleName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tbModuleDescription = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnAddModule = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSaveAll = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tbpModules = new System.Windows.Forms.TableLayoutPanel();
            this.siticoneContainerControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("UTM Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1478, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Syllabus (Edit mode)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.flowLayoutPanel1);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 59);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(150, 0, 100, 0);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(1478, 52);
            this.siticoneContainerControl1.TabIndex = 4;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbModuleName);
            this.flowLayoutPanel1.Controls.Add(this.tbModuleDescription);
            this.flowLayoutPanel1.Controls.Add(this.btnAddModule);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(150, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1228, 52);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tbModuleName
            // 
            this.tbModuleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbModuleName.BorderRadius = 8;
            this.tbModuleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbModuleName.DefaultText = "";
            this.tbModuleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbModuleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbModuleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbModuleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbModuleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbModuleName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModuleName.ForeColor = System.Drawing.Color.Black;
            this.tbModuleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbModuleName.Location = new System.Drawing.Point(3, 2);
            this.tbModuleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModuleName.Name = "tbModuleName";
            this.tbModuleName.PasswordChar = '\0';
            this.tbModuleName.PlaceholderText = "Enter new module\'s name";
            this.tbModuleName.SelectedText = "";
            this.tbModuleName.Size = new System.Drawing.Size(358, 43);
            this.tbModuleName.TabIndex = 0;
            // 
            // tbModuleDescription
            // 
            this.tbModuleDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbModuleDescription.BorderRadius = 8;
            this.tbModuleDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbModuleDescription.DefaultText = "";
            this.tbModuleDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbModuleDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbModuleDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbModuleDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbModuleDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbModuleDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbModuleDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModuleDescription.ForeColor = System.Drawing.Color.Black;
            this.tbModuleDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbModuleDescription.Location = new System.Drawing.Point(367, 2);
            this.tbModuleDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModuleDescription.Name = "tbModuleDescription";
            this.tbModuleDescription.PasswordChar = '\0';
            this.tbModuleDescription.PlaceholderText = "Enter new module\'s description";
            this.tbModuleDescription.SelectedText = "";
            this.tbModuleDescription.Size = new System.Drawing.Size(856, 43);
            this.tbModuleDescription.TabIndex = 2;
            // 
            // btnAddModule
            // 
            this.btnAddModule.BorderRadius = 6;
            this.btnAddModule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddModule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddModule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddModule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddModule.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddModule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAddModule.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModule.ForeColor = System.Drawing.Color.White;
            this.btnAddModule.Location = new System.Drawing.Point(3, 49);
            this.btnAddModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(170, 0);
            this.btnAddModule.TabIndex = 1;
            this.btnAddModule.Text = "Add new module";
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAll.BorderRadius = 4;
            this.btnSaveAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Location = new System.Drawing.Point(1328, 4);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(140, 50);
            this.btnSaveAll.TabIndex = 1;
            this.btnSaveAll.Text = "Save";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // tbpModules
            // 
            this.tbpModules.ColumnCount = 2;
            this.tbpModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpModules.Location = new System.Drawing.Point(0, 111);
            this.tbpModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpModules.Name = "tbpModules";
            this.tbpModules.Padding = new System.Windows.Forms.Padding(147, 4, 333, 4);
            this.tbpModules.RowCount = 2;
            this.tbpModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpModules.Size = new System.Drawing.Size(1478, 555);
            this.tbpModules.TabIndex = 7;
            // 
            // ucAdminEditSyllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.tbpModules);
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucAdminEditSyllabus";
            this.Size = new System.Drawing.Size(1478, 666);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddModule;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbModuleName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSaveAll;
        private System.Windows.Forms.TableLayoutPanel tbpModules;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbModuleDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
