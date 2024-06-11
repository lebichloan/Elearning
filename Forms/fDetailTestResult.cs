using Elearning.Entities;
using Elearning.UserControls.CourseTest;
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

        public fDetailTestResult(int registerID, int testID)
        {
            InitializeComponent();

            CourseResource resourceTest = (
                from resource in Program.provider.CourseResources
                where resource.resource_id == testID
                select resource
                ).ToList().FirstOrDefault();
            lblFinishTest.Text = resourceTest.resource_name;

            List<TestResult> allTestResult = (
                from result in Program.provider.TestResults
                where result.register_id == registerID 
                && result.test_id == testID
                select result
                ).ToList();

            InitUI(allTestResult);
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
                itemResult.Dock = DockStyle.Top;
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
            }
            else
            {
                lblState.Text = "Trạng thái: Đã hoàn thành";
                lblLastState.Text = "Đã hoàn thành";
            }

            lblLastScore.Text = maxResult.test_score.ToString();
            lblOrdinalPass.Text = String.Format("Lần thi thứ {0}", maxResult.test_ordinal.ToString());
        }

        private void ViewDetailTestResultWithOrdinal(object sender, EventArgs e)
        {

        }
    }
}
