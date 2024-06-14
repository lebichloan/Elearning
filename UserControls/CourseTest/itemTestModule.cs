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
    public partial class itemTestModule : UserControl
    {
        public itemTestModule()
        {
            InitializeComponent();
        }

        public itemTestModule(TestResult testResult)
        {
            InitializeComponent();
            InitUI(testResult);
        }

        public string testName
        {
            get { return lblTestName.Text; }
            set { lblTestName.Text = value; }
        }

        public string timeFinish
        {
            get { return lblTimeFinish.Text; }
            set { lblTimeFinish.Text = value; }
        }

        public string totalScore
        {
            get { return lblTotalScore.Text; }
            set { lblTotalScore.Text = value; }
        }

        public string mandatory
        {
            get { return lblMandatory.Text; }
            set { lblMandatory.Text = value; }
        }

        public string state
        {
            get { return lblState.Text; }
            set { lblState.Text = value; }
        }

        public void SetColorState(int isPass)
        {
            if (isPass == 0)
            {
                lblState.ForeColor = Color.Red;
            }
            else
            {
                lblState.ForeColor = Color.FromArgb(94, 148, 255);
            }
        }

        public void InitUI(TestResult testResult)
        {
            lblTimeFinish.Text = testResult.time_finish.ToString();
            lblTotalScore.Text = testResult.test_score.ToString();

            if (testResult.CourseTest.mandatory == 1)
            {
                lblMandatory.Text = "x";
            }
            else
            {
                lblMandatory.Text = "";
            }

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

    }
}
