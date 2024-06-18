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

namespace Elearning.UserControls.CourseTest
{
    public partial class itemTestResult : UserControl
    {
        public itemTestResult()
        {
            InitializeComponent();
        }

        public itemTestResult(TestResult testResult)
        {
            InitializeComponent();
            InitUI(testResult);
        }

        public EventHandler viewDetailTest;
        public void InitUI(TestResult testResult)
        {
            lblTestOrdinal.Text = testResult.test_ordinal.ToString();

            TimeSpan roundedTimeSpan = TimeSpan.FromSeconds(Math.Round(testResult.test_time.TotalSeconds));

            string formattedTime = string.Format("{0:00}:{1:00}:{2:00}",
                                                (int)roundedTimeSpan.TotalHours,
                                                roundedTimeSpan.Minutes,
                                                roundedTimeSpan.Seconds);

            //lblTime.Text = testResult.test_time.ToString();
            lblTime.Text = formattedTime;
            lblScore.Text = String.Format("{0} / {1}",
                testResult.test_score.ToString(),
                testResult.CourseTest.total_score.ToString());
            if (testResult.is_passed == 0)
            {
                lblState.Text = "Not met";
                lblState.ForeColor = Color.Red;
            }
            else
            {
                lblState.Text = "Finish";
                lblState.ForeColor = Color.FromArgb(94, 148, 255);
            }
        }

        private void lblViewDetail_Click(object sender, EventArgs e)
        {
            viewDetailTest?.Invoke(this, e);
        }
    }
}
