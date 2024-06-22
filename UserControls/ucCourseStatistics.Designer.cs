namespace Elearning.UserControls
{
    partial class ucCourseStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.siticonePanel8 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbRankByRatings = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.siticonePanel7 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbRankByComRate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.siticonePanel6 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbRankByRegister = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbChart = new System.Windows.Forms.TableLayoutPanel();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnView = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbYear = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.bindSrcCourseStats = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel4 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.chartLearners = new LiveCharts.WinForms.CartesianChart();
            this.lb = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.chartEarnings = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneContainerControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.siticonePanel8.SuspendLayout();
            this.siticonePanel7.SuspendLayout();
            this.siticonePanel6.SuspendLayout();
            this.tbChart.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCourseStats)).BeginInit();
            this.siticonePanel4.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("UTM Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course\'s Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.tableLayoutPanel1);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 326);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(910, 159);
            this.siticoneContainerControl1.TabIndex = 2;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticonePanel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // siticonePanel8
            // 
            this.siticonePanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel8.BorderRadius = 6;
            this.siticonePanel8.BorderThickness = 1;
            this.siticonePanel8.Controls.Add(this.lbRankByRatings);
            this.siticonePanel8.Controls.Add(this.label18);
            this.siticonePanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel8.Location = new System.Drawing.Point(542, 2);
            this.siticonePanel8.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel8.Name = "siticonePanel8";
            this.siticonePanel8.Padding = new System.Windows.Forms.Padding(8);
            this.siticonePanel8.Size = new System.Drawing.Size(266, 135);
            this.siticonePanel8.TabIndex = 23;
            // 
            // lbRankByRatings
            // 
            this.lbRankByRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRankByRatings.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRankByRatings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbRankByRatings.Location = new System.Drawing.Point(8, 54);
            this.lbRankByRatings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRankByRatings.Name = "lbRankByRatings";
            this.lbRankByRatings.Size = new System.Drawing.Size(250, 73);
            this.lbRankByRatings.TabIndex = 3;
            this.lbRankByRatings.Text = "20";
            this.lbRankByRatings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label18.Location = new System.Drawing.Point(8, 8);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(250, 46);
            this.label18.TabIndex = 2;
            this.label18.Text = "Rank By Ratings";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel7
            // 
            this.siticonePanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel7.BorderRadius = 6;
            this.siticonePanel7.BorderThickness = 1;
            this.siticonePanel7.Controls.Add(this.lbRankByComRate);
            this.siticonePanel7.Controls.Add(this.label16);
            this.siticonePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel7.Location = new System.Drawing.Point(272, 2);
            this.siticonePanel7.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel7.Name = "siticonePanel7";
            this.siticonePanel7.Padding = new System.Windows.Forms.Padding(8);
            this.siticonePanel7.Size = new System.Drawing.Size(266, 135);
            this.siticonePanel7.TabIndex = 22;
            // 
            // lbRankByComRate
            // 
            this.lbRankByComRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRankByComRate.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRankByComRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbRankByComRate.Location = new System.Drawing.Point(8, 54);
            this.lbRankByComRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRankByComRate.Name = "lbRankByComRate";
            this.lbRankByComRate.Size = new System.Drawing.Size(250, 73);
            this.lbRankByComRate.TabIndex = 3;
            this.lbRankByComRate.Text = "20";
            this.lbRankByComRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label16.Location = new System.Drawing.Point(8, 8);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 46);
            this.label16.TabIndex = 2;
            this.label16.Text = "Rank By Completion Rate";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel6
            // 
            this.siticonePanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel6.BorderRadius = 6;
            this.siticonePanel6.BorderThickness = 1;
            this.siticonePanel6.Controls.Add(this.lbRankByRegister);
            this.siticonePanel6.Controls.Add(this.label14);
            this.siticonePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel6.Location = new System.Drawing.Point(2, 2);
            this.siticonePanel6.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel6.Name = "siticonePanel6";
            this.siticonePanel6.Padding = new System.Windows.Forms.Padding(8);
            this.siticonePanel6.Size = new System.Drawing.Size(266, 135);
            this.siticonePanel6.TabIndex = 21;
            // 
            // lbRankByRegister
            // 
            this.lbRankByRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRankByRegister.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRankByRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lbRankByRegister.Location = new System.Drawing.Point(8, 54);
            this.lbRankByRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRankByRegister.Name = "lbRankByRegister";
            this.lbRankByRegister.Size = new System.Drawing.Size(250, 73);
            this.lbRankByRegister.TabIndex = 3;
            this.lbRankByRegister.Text = "20";
            this.lbRankByRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label14.Location = new System.Drawing.Point(8, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 46);
            this.label14.TabIndex = 2;
            this.label14.Text = "Rank By Registrations";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbChart
            // 
            this.tbChart.ColumnCount = 2;
            this.tbChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbChart.Controls.Add(this.siticonePanel1, 0, 0);
            this.tbChart.Controls.Add(this.siticonePanel4, 0, 0);
            this.tbChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChart.Location = new System.Drawing.Point(0, 49);
            this.tbChart.Name = "tbChart";
            this.tbChart.Padding = new System.Windows.Forms.Padding(50, 8, 50, 8);
            this.tbChart.RowCount = 1;
            this.tbChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbChart.Size = new System.Drawing.Size(910, 277);
            this.tbChart.TabIndex = 3;
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.flowLayoutPanel1);
            this.siticoneContainerControl2.Controls.Add(this.label1);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(910, 49);
            this.siticoneContainerControl2.TabIndex = 4;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnView);
            this.flowLayoutPanel1.Controls.Add(this.cbYear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(245, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 49);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.BorderRadius = 6;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.btnView.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(489, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(123, 36);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.cbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbYear.ItemHeight = 30;
            this.cbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cbYear.Location = new System.Drawing.Point(347, 3);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(136, 36);
            this.cbYear.TabIndex = 1;
            // 
            // siticonePanel4
            // 
            this.siticonePanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel4.BorderRadius = 6;
            this.siticonePanel4.BorderThickness = 1;
            this.siticonePanel4.Controls.Add(this.chartLearners);
            this.siticonePanel4.Controls.Add(this.lb);
            this.siticonePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel4.Location = new System.Drawing.Point(52, 10);
            this.siticonePanel4.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel4.Name = "siticonePanel4";
            this.siticonePanel4.Padding = new System.Windows.Forms.Padding(2);
            this.siticonePanel4.Size = new System.Drawing.Size(401, 257);
            this.siticonePanel4.TabIndex = 27;
            // 
            // chartLearners
            // 
            this.chartLearners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartLearners.Location = new System.Drawing.Point(2, 48);
            this.chartLearners.Name = "chartLearners";
            this.chartLearners.Size = new System.Drawing.Size(397, 207);
            this.chartLearners.TabIndex = 3;
            this.chartLearners.Text = "cartesianChart2";
            // 
            // lb
            // 
            this.lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.lb.Location = new System.Drawing.Point(2, 2);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(397, 46);
            this.lb.TabIndex = 2;
            this.lb.Text = "New registrations";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.siticonePanel1.BorderRadius = 6;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.chartEarnings);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(457, 10);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Size = new System.Drawing.Size(401, 257);
            this.siticonePanel1.TabIndex = 28;
            // 
            // chartEarnings
            // 
            this.chartEarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEarnings.Location = new System.Drawing.Point(2, 48);
            this.chartEarnings.Name = "chartEarnings";
            this.chartEarnings.Size = new System.Drawing.Size(397, 207);
            this.chartEarnings.TabIndex = 3;
            this.chartEarnings.Text = "cartesianChart2";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Earnings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucCourseStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbChart);
            this.Controls.Add(this.siticoneContainerControl2);
            this.Controls.Add(this.siticoneContainerControl1);
            this.Name = "ucCourseStatistics";
            this.Size = new System.Drawing.Size(910, 485);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.siticonePanel8.ResumeLayout(false);
            this.siticonePanel7.ResumeLayout(false);
            this.siticonePanel6.ResumeLayout(false);
            this.tbChart.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCourseStats)).EndInit();
            this.siticonePanel4.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel8;
        private System.Windows.Forms.Label lbRankByRatings;
        private System.Windows.Forms.Label label18;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel7;
        private System.Windows.Forms.Label lbRankByComRate;
        private System.Windows.Forms.Label label16;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel6;
        private System.Windows.Forms.Label lbRankByRegister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tbChart;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnView;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbYear;
        private System.Windows.Forms.BindingSource bindSrcCourseStats;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private LiveCharts.WinForms.CartesianChart chartEarnings;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel4;
        private LiveCharts.WinForms.CartesianChart chartLearners;
        private System.Windows.Forms.Label lb;
    }
}
