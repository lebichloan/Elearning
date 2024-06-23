using Elearning.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls
{
    public partial class ucCourseStatistics : UserControl
    {
        Course course;
        public ucCourseStatistics(Course course)
        {
            InitializeComponent();
            this.course = course;
            tbChart.Visible = false;

            // make three columns of the table layout panel have the same width
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 33.33f;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 33.33f;
            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 33.33f;

            if (!Program.courseStats.ContainsKey(course.course_id))
            {
                // if the course has not been loaded yet, reload all the courses' statistics
                Program.LoadCoursesStatistics();
            }
            Program.CourseStats stat = Program.courseStats[course.course_id];
            lbRankByRegister.Text = stat.rank_by_learners.ToString();
            lbRankByComRate.Text = stat.rank_by_completion_rate.ToString();
            lbRankByRatings.Text = stat.rank_by_rating.ToString();

            cbYear.SelectedIndex = 1;

            chartEarnings.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            chartEarnings.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Earnings",
                LabelFormatter = value => value.ToString("N0") + "đ"
            });
            chartEarnings.LegendLocation = LiveCharts.LegendLocation.None;

            chartLearners.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            chartLearners.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Learners",
                LabelFormatter = value => value.ToString("N0")
            });
            chartLearners.LegendLocation = LiveCharts.LegendLocation.None;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbChart.Visible = true;
            int year = int.Parse(cbYear.SelectedItem.ToString());
            var stats = new List<CourseStatistics>();
            for (int i = 1; i <= 12; i++)
            {
                stats.Add(new CourseStatistics(course.course_id, year, i));
            }

            chartEarnings.Series.Clear();
            chartLearners.Series.Clear();
            bindSrcCourseStats.DataSource = stats;

            var seriesEarnings = new LiveCharts.Wpf.LineSeries
            {
                Values = new LiveCharts.ChartValues<int>(stats.Select(s => s.Earnings)),
                PointGeometry = null,
                AreaLimit = 0
            };

            var seriesLearners = new LiveCharts.Wpf.LineSeries
            {
                Values = new LiveCharts.ChartValues<int>(stats.Select(s => s.TotalLearners)),
                PointGeometry = null,
                AreaLimit = 0
            };

            chartEarnings.Series.Add(seriesEarnings);
            chartLearners.Series.Add(seriesLearners);
        }
    }
}
