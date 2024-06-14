using Elearning.Entities;
using Elearning.UserControls.CourseTest;
using Elearning.UserControls.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fDetailTestResult : Form
    {
        public fDetailTestResult()
        {
            InitializeComponent();
        }

        private int resourceID;
        private Course course;
        public fDetailTestResult(int registerID, int testID)
        {
            InitializeComponent();

            CourseResource resourceTest = (
                from resource in Program.provider.CourseResources
                where resource.resource_id == testID
                select resource
                ).ToList().FirstOrDefault();
            resourceID = resourceTest.resource_id;
            lblFinishTest.Text = resourceTest.resource_name;

            course = (
                from registers in Program.provider.Registers
                where registers.register_id == registerID
                select registers
                ).ToList().FirstOrDefault().Course;

            List<TestResult> allTestResult = (
                from result in Program.provider.TestResults
                where result.register_id == registerID 
                && result.test_id == testID
                select result
                ).ToList();

            if (allTestResult.Count() != 0)
            {
                InitUI(allTestResult);
                int mandatory = (
                    from test in Program.provider.CourseTests
                    where test.resource_id == resourceID
                    select test
                    ).ToList().FirstOrDefault().mandatory;
                if (allTestResult.Count() < mandatory)
                {
                    btnDoTest.Visible = true;
                }
                else
                {
                    btnDoTest.Visible = false;
                    panButton.Size = new Size(0, 0);
                }
            }
            else
            {
                lblLastState.Text = "Bạn chưa thực hiện bài test này";
                lblLastState.ForeColor = Color.Red;
                lblState.Text = "Trạng thái: Chưa đạt";
                lblState.ForeColor = Color.Red;
                btnDoTest.Visible = true;
            }
        }

        private void InitUI(List<TestResult> allTestResult)
        {
            tbDetailTestResult.AutoScroll = true;
            tbDetailTestResult.VerticalScroll.Visible = true;
            tbDetailTestResult.VerticalScroll.Enabled = true;
            tbDetailTestResult.HorizontalScroll.Visible = false;
            tbDetailTestResult.HorizontalScroll.Enabled = false;

            itemTestResult item = new itemTestResult();
            int rows = (tbDetailTestResult.MaximumSize.Height - 5) / item.MaximumSize.Height;
            tbDetailTestResult.RowCount = rows;
            tbDetailTestResult.RowStyles.Clear();
            for (int i = 0; i < rows; ++i)
            {
                tbDetailTestResult.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows));
            }

            TestResult maxResult = allTestResult.FirstOrDefault();
            foreach (TestResult result in allTestResult)
            {
                itemTestResult itemResult = new itemTestResult(result);
                itemResult.Dock = DockStyle.Fill;
                itemResult.viewDetailTest += ViewDetailTestResultWithOrdinal;
                tbDetailTestResult.Controls.Add(itemResult);

                if (result.test_score > maxResult.test_score)
                {
                    maxResult = result;
                }
            }

            if (maxResult.is_passed == 0)
            {
                lblState.Text = "Trạng thái: Chưa đạt";
                lblLastState.Text = "Chưa đạt";
                lblLastState.ForeColor = Color.Red;
            }
            else
            {
                lblState.Text = "Trạng thái: Đã hoàn thành";
                lblLastState.Text = "Đã hoàn thành";
                lblLastState.ForeColor = Color.FromArgb(94, 148, 255);
            }

            lblLastScore.Text = maxResult.test_score.ToString();
            lblOrdinalPass.Text = String.Format("Lần thi thứ {0}", maxResult.test_ordinal.ToString());
        }

        private void ViewDetailTestResultWithOrdinal(object sender, EventArgs e)
        {

        }

        private void btnDoTest_Click(object sender, EventArgs e)
        {
            fCourseTest courseTest = new fCourseTest(resourceID, false, course);
            courseTest.ShowDialog();
        }
    }
}
