using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class ucOverallStats : UserControl
    {
        public ucOverallStats()
        {
            InitializeComponent();

            tableLayoutPanel1.Visible = false;
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

            chartNewLearners.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            chartNewLearners.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "New Learners",
                LabelFormatter = value => value.ToString("N0")
            });
            chartNewLearners.LegendLocation = LiveCharts.LegendLocation.None;

            chartNewCourses.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            chartNewCourses.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "New Courses",
                LabelFormatter = value => value.ToString("N0")
            });
            chartNewCourses.LegendLocation = LiveCharts.LegendLocation.None;

            pieEarnByCategory.LegendLocation = LiveCharts.LegendLocation.Right;

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;

            int year = Convert.ToInt32(cbYear.SelectedItem);

            var stats = new List<Elearning.Entities.OverallStatistics>();

            int totalEarnings = 0;
            int totalNewLearners = 0;
            for (int i = 1; i <= 12; i++)
            {
                stats.Add(new Elearning.Entities.OverallStatistics(year, i));
                totalEarnings += stats[i - 1].Earnings;
                totalNewLearners += stats[i - 1].NewLearners;
            }

            lbTotalEarnings.Text = totalEarnings.ToString("N0") + "VND";
            lbTotalLearners.Text = totalNewLearners.ToString("N0");

            chartEarnings.Series.Clear();
            chartNewLearners.Series.Clear();
            chartNewCourses.Series.Clear();
            bindSrcOverallStats.DataSource = stats;

            var seriesEarnings = new LiveCharts.Wpf.LineSeries
            {
                Values = new LiveCharts.ChartValues<int>(stats.Select(s => s.Earnings)),
                PointGeometry = null,
                AreaLimit = 0
            };

            var seriesNewLearners = new LiveCharts.Wpf.LineSeries
            {
                Values = new LiveCharts.ChartValues<int>(stats.Select(s => s.NewLearners)),
                PointGeometry = null,
                AreaLimit = 0
            };

            var seriesNewCourses = new LiveCharts.Wpf.LineSeries
            {
                Values = new LiveCharts.ChartValues<int>(stats.Select(s => s.NewCourses)),
                PointGeometry = null,
                AreaLimit = 0
            };

            chartEarnings.Series.Add(seriesEarnings);
            chartNewLearners.Series.Add(seriesNewLearners);
            chartNewCourses.Series.Add(seriesNewCourses);

            // Pie chart: Earnings by category
            var data = new SeriesCollection();
            foreach (var category in Program.COURSE_CATEGORIES)
            {
                var lst = Program.provider.Registers.Where(r => r.Course.category == category && r.registered_date.Year == year).ToList();
                var total = lst != null ? lst.Sum(r => r.paid) : 0;
                System.Diagnostics.Debug.WriteLine(category + ": " + total);
                if (total > 0)
                {
                    data.Add(new PieSeries()
                    {
                        Title = category,
                        Values = new ChartValues<int> { (int)total },
                        DataLabels = true,
                        LabelPoint = point => string.Format("{0} ({1:P})", point.Y.ToString("N0"), point.Participation)
                    });
                }
            }
            pieEarnByCategory.Series = data;
        }
    }
}
