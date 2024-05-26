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
            this.btnAddCourse = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tbSearch = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.layoutCourses = new System.Windows.Forms.TableLayoutPanel();
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
            this.conTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conTop.Name = "conTop";
            this.conTop.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.conTop.Size = new System.Drawing.Size(1215, 71);
            this.conTop.TabIndex = 0;
            this.conTop.Text = "siticoneContainerControl1";
            // 
            // layoutTools
            // 
            this.layoutTools.Controls.Add(this.btnAddCourse);
            this.layoutTools.Controls.Add(this.btnSearch);
            this.layoutTools.Controls.Add(this.tbSearch);
            this.layoutTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTools.Location = new System.Drawing.Point(5, 5);
            this.layoutTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutTools.Name = "layoutTools";
            this.layoutTools.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.layoutTools.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutTools.Size = new System.Drawing.Size(1205, 61);
            this.layoutTools.TabIndex = 0;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCourse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(1038, 7);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(164, 46);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(868, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(509, 7);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(353, 46);
            this.tbSearch.TabIndex = 3;
            // 
            // layoutCourses
            // 
            this.layoutCourses.ColumnCount = 4;
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCourses.Location = new System.Drawing.Point(0, 71);
            this.layoutCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutCourses.Name = "layoutCourses";
            this.layoutCourses.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutCourses.RowCount = 2;
            this.layoutCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCourses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCourses.Size = new System.Drawing.Size(1215, 562);
            this.layoutCourses.TabIndex = 1;
            // 
            // ucAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutCourses);
            this.Controls.Add(this.conTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucAdminHome";
            this.Size = new System.Drawing.Size(1215, 633);
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
    }
}
