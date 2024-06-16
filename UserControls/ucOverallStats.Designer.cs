namespace Elearning.UserControls
{
    partial class ucOverallStats
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAll = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnShow = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneVSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
            this.cbYear = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbMonth = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.siticonePanel8 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbMostRegisCourse = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.siticonePanel7 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbTopEarnCourse = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbTotalEarning = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbNewRegistrations = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbNewCourses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticonePanel13 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbNewLearners = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.siticoneContainerControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.siticonePanel8.SuspendLayout();
            this.siticonePanel7.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("UTM Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1190, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Overall Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnShowAll);
            this.flowLayoutPanel1.Controls.Add(this.siticoneVSeparator1);
            this.flowLayoutPanel1.Controls.Add(this.btnShow);
            this.flowLayoutPanel1.Controls.Add(this.cbYear);
            this.flowLayoutPanel1.Controls.Add(this.cbMonth);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1190, 59);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnShowAll
            // 
            this.btnShowAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(994, 6);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(180, 45);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show all-time";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShow
            // 
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(777, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 45);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // siticoneVSeparator1
            // 
            this.siticoneVSeparator1.FillThickness = 2;
            this.siticoneVSeparator1.Location = new System.Drawing.Point(963, 6);
            this.siticoneVSeparator1.Name = "siticoneVSeparator1";
            this.siticoneVSeparator1.Size = new System.Drawing.Size(25, 45);
            this.siticoneVSeparator1.TabIndex = 2;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbYear.ItemHeight = 30;
            this.cbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cbYear.Location = new System.Drawing.Point(631, 6);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(140, 36);
            this.cbYear.TabIndex = 3;
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.Transparent;
            this.cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.cbMonth.ItemHeight = 30;
            this.cbMonth.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(485, 6);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(140, 36);
            this.cbMonth.TabIndex = 4;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.tableLayoutPanel1);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 125);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(12);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(1190, 530);
            this.siticoneContainerControl1.TabIndex = 4;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel13, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // siticonePanel8
            // 
            this.siticonePanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel8.BorderRadius = 6;
            this.siticonePanel8.BorderThickness = 1;
            this.siticonePanel8.Controls.Add(this.lbMostRegisCourse);
            this.siticonePanel8.Controls.Add(this.label18);
            this.siticonePanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel8.Location = new System.Drawing.Point(779, 255);
            this.siticonePanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel8.Name = "siticonePanel8";
            this.siticonePanel8.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.siticonePanel8.Size = new System.Drawing.Size(384, 249);
            this.siticonePanel8.TabIndex = 23;
            // 
            // lbMostRegisCourse
            // 
            this.lbMostRegisCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMostRegisCourse.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostRegisCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbMostRegisCourse.Location = new System.Drawing.Point(11, 67);
            this.lbMostRegisCourse.Name = "lbMostRegisCourse";
            this.lbMostRegisCourse.Size = new System.Drawing.Size(362, 172);
            this.lbMostRegisCourse.TabIndex = 3;
            this.lbMostRegisCourse.Text = "Introduction to C++(1000 registrations)";
            this.lbMostRegisCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label18.Location = new System.Drawing.Point(11, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(362, 57);
            this.label18.TabIndex = 2;
            this.label18.Text = "Most registered course";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel7
            // 
            this.siticonePanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel7.BorderRadius = 6;
            this.siticonePanel7.BorderThickness = 1;
            this.siticonePanel7.Controls.Add(this.lbTopEarnCourse);
            this.siticonePanel7.Controls.Add(this.label16);
            this.siticonePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel7.Location = new System.Drawing.Point(391, 255);
            this.siticonePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel7.Name = "siticonePanel7";
            this.siticonePanel7.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.siticonePanel7.Size = new System.Drawing.Size(382, 249);
            this.siticonePanel7.TabIndex = 22;
            // 
            // lbTopEarnCourse
            // 
            this.lbTopEarnCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTopEarnCourse.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopEarnCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbTopEarnCourse.Location = new System.Drawing.Point(11, 67);
            this.lbTopEarnCourse.Name = "lbTopEarnCourse";
            this.lbTopEarnCourse.Size = new System.Drawing.Size(360, 172);
            this.lbTopEarnCourse.TabIndex = 3;
            this.lbTopEarnCourse.Text = "Introduction to C++ (total 1.000.000đ)";
            this.lbTopEarnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label16.Location = new System.Drawing.Point(11, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(360, 57);
            this.label16.TabIndex = 2;
            this.label16.Text = "Top earning course";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel6.BorderRadius = 6;
            this.siticonePanel6.BorderThickness = 1;
            this.siticonePanel6.Controls.Add(this.lbTotalEarning);
            this.siticonePanel6.Controls.Add(this.label14);
            this.siticonePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel6.Location = new System.Drawing.Point(3, 255);
            this.siticonePanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.siticonePanel6.Size = new System.Drawing.Size(382, 249);
            this.siticonePanel6.TabIndex = 21;
            // 
            // lbTotalEarning
            // 
            this.lbTotalEarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalEarning.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbTotalEarning.Location = new System.Drawing.Point(11, 67);
            this.lbTotalEarning.Name = "lbTotalEarning";
            this.lbTotalEarning.Size = new System.Drawing.Size(360, 172);
            this.lbTotalEarning.TabIndex = 3;
            this.lbTotalEarning.Text = "9.999.999.999đ";
            this.lbTotalEarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label14.Location = new System.Drawing.Point(11, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(360, 57);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total Earnings";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel2.BorderRadius = 6;
            this.siticonePanel2.BorderThickness = 1;
            this.siticonePanel2.Controls.Add(this.lbNewRegistrations);
            this.siticonePanel2.Controls.Add(this.label5);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(779, 2);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.siticonePanel2.Size = new System.Drawing.Size(384, 249);
            this.siticonePanel2.TabIndex = 17;
            // 
            // lbNewRegistrations
            // 
            this.lbNewRegistrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNewRegistrations.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewRegistrations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbNewRegistrations.Location = new System.Drawing.Point(11, 67);
            this.lbNewRegistrations.Name = "lbNewRegistrations";
            this.lbNewRegistrations.Size = new System.Drawing.Size(362, 172);
            this.lbNewRegistrations.TabIndex = 3;
            this.lbNewRegistrations.Text = "20";
            this.lbNewRegistrations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 57);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Courses\' Registrations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel1.BorderRadius = 6;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.lbNewCourses);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(391, 2);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.siticonePanel1.Size = new System.Drawing.Size(382, 249);
            this.siticonePanel1.TabIndex = 16;
            // 
            // lbNewCourses
            // 
            this.lbNewCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNewCourses.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbNewCourses.Location = new System.Drawing.Point(11, 67);
            this.lbNewCourses.Name = "lbNewCourses";
            this.lbNewCourses.Size = new System.Drawing.Size(360, 172);
            this.lbNewCourses.TabIndex = 3;
            this.lbNewCourses.Text = "20";
            this.lbNewCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Courses";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel13
            // 
            this.siticonePanel13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel13.BorderRadius = 6;
            this.siticonePanel13.BorderThickness = 1;
            this.siticonePanel13.Controls.Add(this.lbNewLearners);
            this.siticonePanel13.Controls.Add(this.label10);
            this.siticonePanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel13.Location = new System.Drawing.Point(3, 2);
            this.siticonePanel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel13.Name = "siticonePanel13";
            this.siticonePanel13.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.siticonePanel13.Size = new System.Drawing.Size(382, 249);
            this.siticonePanel13.TabIndex = 15;
            // 
            // lbNewLearners
            // 
            this.lbNewLearners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNewLearners.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewLearners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbNewLearners.Location = new System.Drawing.Point(11, 67);
            this.lbNewLearners.Name = "lbNewLearners";
            this.lbNewLearners.Size = new System.Drawing.Size(360, 172);
            this.lbNewLearners.TabIndex = 3;
            this.lbNewLearners.Text = "20";
            this.lbNewLearners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label10.Location = new System.Drawing.Point(11, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(360, 57);
            this.label10.TabIndex = 2;
            this.label10.Text = "New Learners";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucOverallStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ucOverallStats";
            this.Size = new System.Drawing.Size(1190, 655);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.siticonePanel8.ResumeLayout(false);
            this.siticonePanel7.ResumeLayout(false);
            this.siticonePanel6.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnShowAll;
        private Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnShow;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbYear;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbMonth;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel8;
        private System.Windows.Forms.Label lbMostRegisCourse;
        private System.Windows.Forms.Label label18;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel7;
        private System.Windows.Forms.Label lbTopEarnCourse;
        private System.Windows.Forms.Label label16;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private System.Windows.Forms.Label lbTotalEarning;
        private System.Windows.Forms.Label label14;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label lbNewRegistrations;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lbNewCourses;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel13;
        private System.Windows.Forms.Label lbNewLearners;
        private System.Windows.Forms.Label label10;
    }
}
