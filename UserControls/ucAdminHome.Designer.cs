namespace Elearning.UserControls
{
    partial class ucAdminHome
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
            this.conTop = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.layoutTools = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneVSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
            this.cbFilterCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbFilterDiff = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.tbSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.layoutCourses = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCourse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnRefresh = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.conTop.SuspendLayout();
            this.layoutTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // conTop
            // 
            this.conTop.BackColor = System.Drawing.Color.Transparent;
            this.conTop.Controls.Add(this.layoutTools);
            this.conTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.conTop.FillColor = System.Drawing.Color.Transparent;
            this.conTop.Location = new System.Drawing.Point(0, 0);
            this.conTop.Margin = new System.Windows.Forms.Padding(2);
            this.conTop.Name = "conTop";
            this.conTop.Padding = new System.Windows.Forms.Padding(4);
            this.conTop.Size = new System.Drawing.Size(997, 58);
            this.conTop.TabIndex = 0;
            this.conTop.Text = "siticoneContainerControl1";
            // 
            // layoutTools
            // 
            this.layoutTools.Controls.Add(this.btnAddCourse);
            this.layoutTools.Controls.Add(this.siticoneVSeparator1);
            this.layoutTools.Controls.Add(this.cbFilterCategory);
            this.layoutTools.Controls.Add(this.cbFilterDiff);
            this.layoutTools.Controls.Add(this.btnSearch);
            this.layoutTools.Controls.Add(this.tbSearch);
            this.layoutTools.Controls.Add(this.btnRefresh);
            this.layoutTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTools.Location = new System.Drawing.Point(4, 4);
            this.layoutTools.Margin = new System.Windows.Forms.Padding(2);
            this.layoutTools.Name = "layoutTools";
            this.layoutTools.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.layoutTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutTools.Size = new System.Drawing.Size(989, 50);
            this.layoutTools.TabIndex = 0;
            // 
            // siticoneVSeparator1
            // 
            this.siticoneVSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneVSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticoneVSeparator1.Location = new System.Drawing.Point(849, 7);
            this.siticoneVSeparator1.Name = "siticoneVSeparator1";
            this.siticoneVSeparator1.Size = new System.Drawing.Size(10, 36);
            this.siticoneVSeparator1.TabIndex = 6;
            // 
            // cbFilterCategory
            // 
            this.cbFilterCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterCategory.ForeColor = System.Drawing.Color.Black;
            this.cbFilterCategory.ItemHeight = 30;
            this.cbFilterCategory.Location = new System.Drawing.Point(673, 7);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(170, 36);
            this.cbFilterCategory.TabIndex = 4;
            this.cbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cbFilterCategory_SelectedIndexChanged);
            // 
            // cbFilterDiff
            // 
            this.cbFilterDiff.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterDiff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterDiff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterDiff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterDiff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterDiff.ForeColor = System.Drawing.Color.Black;
            this.cbFilterDiff.ItemHeight = 30;
            this.cbFilterDiff.Location = new System.Drawing.Point(495, 7);
            this.cbFilterDiff.Name = "cbFilterDiff";
            this.cbFilterDiff.Size = new System.Drawing.Size(172, 36);
            this.cbFilterDiff.TabIndex = 5;
            this.cbFilterDiff.SelectedIndexChanged += new System.EventHandler(this.cbFilterDiff_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(98, 6);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(265, 37);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // layoutCourses
            // 
            this.layoutCourses.ColumnCount = 4;
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCourses.Location = new System.Drawing.Point(0, 58);
            this.layoutCourses.Name = "layoutCourses";
            this.layoutCourses.Padding = new System.Windows.Forms.Padding(3);
            this.layoutCourses.RowCount = 2;
            this.layoutCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCourses.Size = new System.Drawing.Size(997, 456);
            this.layoutCourses.TabIndex = 1;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BorderRadius = 8;
            this.btnAddCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCourse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Image = global::Elearning.Properties.Resources.add_white;
            this.btnAddCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddCourse.Location = new System.Drawing.Point(864, 6);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddCourse.Size = new System.Drawing.Size(123, 37);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddCourse.TextOffset = new System.Drawing.Point(3, 0);
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Elearning.Properties.Resources.search_white;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.Location = new System.Drawing.Point(367, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(123, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Elearning.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(57, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ucAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutCourses);
            this.Controls.Add(this.conTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAdminHome";
            this.Size = new System.Drawing.Size(997, 514);
            this.Load += new System.EventHandler(this.ucAdminHome_Load);
            this.conTop.ResumeLayout(false);
            this.layoutTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conTop;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddCourse;
        private System.Windows.Forms.FlowLayoutPanel layoutTools;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSearch;
        private System.Windows.Forms.TableLayoutPanel layoutCourses;
        private Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbFilterCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbFilterDiff;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRefresh;
    }
}
