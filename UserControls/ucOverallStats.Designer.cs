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
            this.components = new System.ComponentModel.Container();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindSrcOverallStats = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbTotalLearners = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbTotalEarnings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pieEarnByCategory = new LiveCharts.WinForms.PieChart();
            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.chartNewLearners = new LiveCharts.WinForms.CartesianChart();
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.chartNewCourses = new LiveCharts.WinForms.CartesianChart();
            this.label4 = new System.Windows.Forms.Label();
            this.siticonePanel5 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.chartEarnings = new LiveCharts.WinForms.CartesianChart();
            this.label7 = new System.Windows.Forms.Label();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShow = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbYear = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneContainerControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcOverallStats)).BeginInit();
            this.siticonePanel6.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.siticonePanel4.SuspendLayout();
            this.siticonePanel5.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.tableLayoutPanel1);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 50);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(1091, 627);
            this.siticoneContainerControl1.TabIndex = 4;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 607);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel6.BorderRadius = 6;
            this.siticonePanel6.BorderThickness = 1;
            this.siticonePanel6.Controls.Add(this.lbTotalLearners);
            this.siticonePanel6.Controls.Add(this.label14);
            this.siticonePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel6.Location = new System.Drawing.Point(2, 305);
            this.siticonePanel6.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.Padding = new System.Windows.Forms.Padding(8);
            this.siticonePanel6.Size = new System.Drawing.Size(353, 300);
            this.siticonePanel6.TabIndex = 22;
            // 
            // lbTotalLearners
            // 
            this.lbTotalLearners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalLearners.Font = new System.Drawing.Font("Segoe UI Variable Display", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalLearners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbTotalLearners.Location = new System.Drawing.Point(8, 54);
            this.lbTotalLearners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalLearners.Name = "lbTotalLearners";
            this.lbTotalLearners.Size = new System.Drawing.Size(337, 238);
            this.lbTotalLearners.TabIndex = 3;
            this.lbTotalLearners.Text = "20";
            this.lbTotalLearners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label14.Location = new System.Drawing.Point(8, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(337, 46);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total New Learners";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel1.BorderRadius = 6;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.lbTotalEarnings);
            this.siticonePanel1.Controls.Add(this.label3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(359, 305);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(8);
            this.siticonePanel1.Size = new System.Drawing.Size(353, 300);
            this.siticonePanel1.TabIndex = 23;
            // 
            // lbTotalEarnings
            // 
            this.lbTotalEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalEarnings.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEarnings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbTotalEarnings.Location = new System.Drawing.Point(8, 54);
            this.lbTotalEarnings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalEarnings.Name = "lbTotalEarnings";
            this.lbTotalEarnings.Size = new System.Drawing.Size(337, 238);
            this.lbTotalEarnings.TabIndex = 3;
            this.lbTotalEarnings.Text = "20";
            this.lbTotalEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Earnings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel2.BorderRadius = 6;
            this.siticonePanel2.BorderThickness = 1;
            this.siticonePanel2.Controls.Add(this.pieEarnByCategory);
            this.siticonePanel2.Controls.Add(this.label5);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel2.Location = new System.Drawing.Point(716, 305);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Padding = new System.Windows.Forms.Padding(8);
            this.siticonePanel2.Size = new System.Drawing.Size(355, 300);
            this.siticonePanel2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 46);
            this.label5.TabIndex = 2;
            this.label5.Text = "Earnings By Category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pieEarnByCategory
            // 
            this.pieEarnByCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieEarnByCategory.Location = new System.Drawing.Point(8, 54);
            this.pieEarnByCategory.Name = "pieEarnByCategory";
            this.pieEarnByCategory.Size = new System.Drawing.Size(339, 238);
            this.pieEarnByCategory.TabIndex = 3;
            this.pieEarnByCategory.Text = "pieChart1";
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel3.BorderRadius = 6;
            this.siticonePanel3.BorderThickness = 1;
            this.siticonePanel3.Controls.Add(this.chartNewLearners);
            this.siticonePanel3.Controls.Add(this.label6);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(2, 2);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Padding = new System.Windows.Forms.Padding(2);
            this.siticonePanel3.Size = new System.Drawing.Size(353, 299);
            this.siticonePanel3.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 46);
            this.label6.TabIndex = 2;
            this.label6.Text = "New Learners";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartNewLearners
            // 
            this.chartNewLearners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartNewLearners.Location = new System.Drawing.Point(2, 48);
            this.chartNewLearners.Name = "chartNewLearners";
            this.chartNewLearners.Size = new System.Drawing.Size(349, 249);
            this.chartNewLearners.TabIndex = 3;
            this.chartNewLearners.Text = "cartesianChart2";
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel4.BorderRadius = 6;
            this.siticonePanel4.BorderThickness = 1;
            this.siticonePanel4.Controls.Add(this.chartNewCourses);
            this.siticonePanel4.Controls.Add(this.label4);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel4.Location = new System.Drawing.Point(359, 2);
            this.siticonePanel4.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Padding = new System.Windows.Forms.Padding(2);
            this.siticonePanel4.Size = new System.Drawing.Size(353, 299);
            this.siticonePanel4.TabIndex = 26;
            // 
            // chartNewCourses
            // 
            this.chartNewCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartNewCourses.Location = new System.Drawing.Point(2, 48);
            this.chartNewCourses.Name = "chartNewCourses";
            this.chartNewCourses.Size = new System.Drawing.Size(349, 249);
            this.chartNewCourses.TabIndex = 3;
            this.chartNewCourses.Text = "cartesianChart2";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Courses";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel5
            // 
            this.siticonePanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel5.BorderRadius = 6;
            this.siticonePanel5.BorderThickness = 1;
            this.siticonePanel5.Controls.Add(this.chartEarnings);
            this.siticonePanel5.Controls.Add(this.label7);
            this.siticonePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel5.Location = new System.Drawing.Point(716, 2);
            this.siticonePanel5.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel5.Name = "siticonePanel5";
            this.siticonePanel5.Padding = new System.Windows.Forms.Padding(2);
            this.siticonePanel5.Size = new System.Drawing.Size(355, 299);
            this.siticonePanel5.TabIndex = 27;
            // 
            // chartEarnings
            // 
            this.chartEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEarnings.Location = new System.Drawing.Point(2, 48);
            this.chartEarnings.Name = "chartEarnings";
            this.chartEarnings.Size = new System.Drawing.Size(351, 249);
            this.chartEarnings.TabIndex = 3;
            this.chartEarnings.Text = "cartesianChart2";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label7.Location = new System.Drawing.Point(2, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 46);
            this.label7.TabIndex = 2;
            this.label7.Text = "Earnings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.flp);
            this.siticoneContainerControl2.Controls.Add(this.label1);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Size = new System.Drawing.Size(1091, 50);
            this.siticoneContainerControl2.TabIndex = 5;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("UTM Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Overall Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flp
            // 
            this.flp.Controls.Add(this.btnShow);
            this.flp.Controls.Add(this.cbYear);
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp.Location = new System.Drawing.Point(438, 0);
            this.flp.Name = "flp";
            this.flp.Padding = new System.Windows.Forms.Padding(3);
            this.flp.Size = new System.Drawing.Size(653, 50);
            this.flp.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.BorderRadius = 6;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(528, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 38);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.BorderRadius = 6;
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.ForeColor = System.Drawing.Color.Black;
            this.cbYear.ItemHeight = 30;
            this.cbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cbYear.Location = new System.Drawing.Point(382, 6);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(140, 36);
            this.cbYear.TabIndex = 1;
            // 
            // ucOverallStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.siticoneContainerControl2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucOverallStats";
            this.Size = new System.Drawing.Size(1091, 677);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcOverallStats)).EndInit();
            this.siticonePanel6.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.siticonePanel4.ResumeLayout(false);
            this.siticonePanel5.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bindSrcOverallStats;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lbTotalEarnings;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private System.Windows.Forms.Label lbTotalLearners;
        private System.Windows.Forms.Label label14;
        private LiveCharts.WinForms.PieChart pieEarnByCategory;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel5;
        private LiveCharts.WinForms.CartesianChart chartEarnings;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private LiveCharts.WinForms.CartesianChart chartNewCourses;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.CartesianChart chartNewLearners;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnShow;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbYear;
        private System.Windows.Forms.Label label1;
    }
}
