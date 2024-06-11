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
            lblTime.Text = testResult.test_time.ToString();
            lblScore.Text = testResult.test_score.ToString();
            if (testResult.is_passed == 0)
            {
                lblState.Text = "Chưa đạt";
                lblState.ForeColor = Color.Red;
            }
            else
            {
                lblState.Text = "Hoàn thành";
                lblState.ForeColor = Color.FromArgb(94, 148, 255);
            }
        }

        private void lblViewDetail_Click(object sender, EventArgs e)
        {
            viewDetailTest?.Invoke(this, e);
        }
    }
}
