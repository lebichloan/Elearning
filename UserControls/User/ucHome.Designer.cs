namespace Elearning.UserControls
{
    partial class ucHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHome));
            this.panTop = new System.Windows.Forms.Panel();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.cmbDifficulty = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cmbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.layoutCourses = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnFilter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panTop.SuspendLayout();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.Controls.Add(this.siticoneCustomGradientPanel1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(881, 48);
            this.panTop.TabIndex = 3;
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.flowLayoutPanel1);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(107, 0);
            this.siticoneCustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(774, 48);
            this.siticoneCustomGradientPanel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(373, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Size = new System.Drawing.Size(24, 24);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.BackColor = System.Drawing.Color.White;
            this.cmbDifficulty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.cmbDifficulty.BorderRadius = 5;
            this.cmbDifficulty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDifficulty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDifficulty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDifficulty.ForeColor = System.Drawing.Color.Black;
            this.cmbDifficulty.ItemHeight = 30;
            this.cmbDifficulty.Location = new System.Drawing.Point(401, 5);
            this.cmbDifficulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(136, 36);
            this.cmbDifficulty.TabIndex = 5;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.cmbCategory.BorderRadius = 5;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Location = new System.Drawing.Point(541, 5);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(179, 36);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(320, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // layoutCourses
            // 
            this.layoutCourses.BackColor = System.Drawing.Color.White;
            this.layoutCourses.ColumnCount = 4;
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCourses.Location = new System.Drawing.Point(0, 48);
            this.layoutCourses.Name = "layoutCourses";
            this.layoutCourses.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.layoutCourses.RowCount = 2;
            this.layoutCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCourses.Size = new System.Drawing.Size(881, 486);
            this.layoutCourses.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFilter);
            this.flowLayoutPanel1.Controls.Add(this.cmbCategory);
            this.flowLayoutPanel1.Controls.Add(this.cmbDifficulty);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.txtSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Elearning.Properties.Resources.search_white;
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(328, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BorderRadius = 8;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::Elearning.Properties.Resources.search_white;
            this.btnFilter.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFilter.Location = new System.Drawing.Point(725, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(40, 35);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutCourses);
            this.Controls.Add(this.panTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(881, 534);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.panTop.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.TableLayoutPanel layoutCourses;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbDifficulty;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbCategory;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFilter;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSearch;
    }
}
