using Elearning.Entities;
using Elearning.Forms;
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
    public partial class itemModuleTestResult : UserControl
    {
        public itemModuleTestResult()
        {
            InitializeComponent();
        }

        public itemModuleTestResult(CourseModule courseModule, Register register)
        {
            InitializeComponent();
            InitUI(courseModule, register);
        }

        public string moduleName
        {
            get { return lblModuleName.Text; }
            set { lblModuleName.Text = value; }
        }

        private void InitUI(CourseModule courseModule, Register register)
        {
            tbAllTest.AutoScroll = true;
            tbAllTest.VerticalScroll.Visible = true;
            tbAllTest.VerticalScroll.Enabled = true;
            tbAllTest.HorizontalScroll.Visible = false;
            tbAllTest.HorizontalScroll.Enabled = false;

            //itemTestModule itemTest = new itemTestModule();
            //int rows = (tbAllTest.MaximumSize.Height - 5) / itemTest.MaximumSize.Height;
            //tbAllTest.RowCount = rows;
            //tbAllTest.RowStyles.Clear();
            //for (int i = 0; i < rows; ++i)
            //{
            //    tbAllTest.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows));
            //}

            int total = 0;
            int done = 0;
            List<CourseResource> listCourseTest = (
                from test in Program.provider.CourseResources
                where test.module_id == courseModule.module_id
                && test.resource_type == Program.TYPE_TEST
                select test
                ).ToList();

            tbAllTest.RowCount = listCourseTest.Count;
            tbAllTest.RowStyles.Clear();
            for (int i = 0; i < listCourseTest.Count; i++)
            {
                tbAllTest.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            foreach (CourseResource courseResource in listCourseTest)
            {
                List<TestResult> results = (
                    from testResult in Program.provider.TestResults
                    where testResult.CourseTest.resource_id == courseResource.resource_id
                    && testResult.register_id == register.register_id
                    select testResult
                    ).ToList();
                if (results.Count() != 0) {
                    TestResult result = getMaxResult(results);
                    itemTestModule item = new itemTestModule(result);
                    item.testName = courseResource.resource_name;
                    item.Dock = DockStyle.Fill;
                    tbAllTest.Controls.Add(item);
                    done++;
                }
                else
                {
                    itemTestModule item = new itemTestModule();
                    item.testName = courseResource.resource_name;
                    item.timeFinish = "";
                    item.totalScore = "";

                    if (courseResource.CourseTests.ToList().FirstOrDefault().mandatory == 1)
                    {
                        item.mandatory = "x";
                    }
                    else
                    {
                        item.mandatory = "";
                    }

                    item.state = "Not met";
                    item.SetColorState(0);
                    item.Dock = DockStyle.Fill;

                    tbAllTest.Controls.Add(item);
                }
                total++;
            }

            if (total != done)
            {
                lblModuleState.Text = "Not met";
                lblModuleState.ForeColor = Color.Red;
            }
            else
            {
                lblModuleState.Text = "Finish";
                lblModuleState.ForeColor = Color.FromArgb(94, 148, 255);
            }
        }

        private TestResult getMaxResult(List<TestResult> allTestResult)
        {
            TestResult maxResult = allTestResult.FirstOrDefault();
            foreach (TestResult result in allTestResult)
            {
                if (result.test_score > maxResult.test_score)
                {
                    maxResult = result;
                }
            }
            return maxResult;
        }
    }
}
