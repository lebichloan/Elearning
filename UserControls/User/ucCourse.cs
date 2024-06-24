using Elearning.Entities;
using Elearning.Forms;
using Elearning.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Elearning.UserControls
{
    public partial class ucCourse : UserControl
    {
        public EventHandler backHomeClicked;
        private Course course;
        private List<CourseModule> listModule = new List<CourseModule>();
        public ucCourse()
        {
            InitializeComponent();
            InitUI();
        }

        private Register currentRegister;
        public ucCourse(Course course)
        {
            InitializeComponent();
            this.course = course;
            currentRegister = (
                from register in Program.provider.Registers
                where register.learner_id == fLogin.currentAccount.acc_id
                && register.course_id == course.course_id
                select register
            ).ToList().FirstOrDefault();

            InitUI();
            LoadAllModule(course);
        }

        private void InitUI()
        {
            picCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            lblCourseName.Text = course.course_name;
            lblLecturerName.Text = course.lecturer;

            if (currentRegister.register_status == 2)
            {
                lblDone.Text = "Finish";
                lblDone.ForeColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                lblDone.Text = "Not met";
                lblDone.ForeColor = Color.Red;
            }

            layoutModule.AutoScroll = true;
            layoutModule.VerticalScroll.Visible = true;
            layoutModule.VerticalScroll.Enabled = true;
            layoutModule.HorizontalScroll.Visible = false;
            layoutModule.HorizontalScroll.Enabled = false;
            layoutModule.RowCount = 0;
            layoutModule.RowStyles.Clear();
            layoutModule.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            layoutResource.AutoScroll = true;
            layoutResource.VerticalScroll.Visible = true;
            layoutResource.VerticalScroll.Enabled = true;
            layoutResource.HorizontalScroll.Visible = false;
            layoutResource.HorizontalScroll.Enabled = false;
            layoutResource.RowCount = 0;
            layoutResource.RowStyles.Clear();
            layoutResource.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void LoadAllModule(Course course)
        {
            int count = 0;
            List<CourseModule> allModule = Program.provider.CourseModules.ToList();
            foreach (CourseModule module in allModule)
            {
                if (module.course_id == course.course_id)
                {
                    count++;
                    ucCourseModule uc = new ucCourseModule();
                    uc.Dock = DockStyle.Top;
                    uc.moduleID = module.module_id;
                    uc.moduleOrdinal = string.Format("Module {0}:", count);
                    uc.moduleName = module.module_name;
                    uc.moduleDescription = module.description;
                    uc.courseModuleClick += ucCourseModule_viewModuleClicked;
                    if (count == 1)
                    {
                        LoadResourceOfModule(module.module_id);
                        uc.backColor = Color.FromArgb(228, 230, 233);
                    }
                    layoutModule.Controls.Add(uc);
                }
            }
        }

        private void LoadResourceOfModule(int idModule)
        {
            layoutResource.Controls.Clear();
            layoutResource.AutoScroll = true;
            layoutResource.VerticalScroll.Visible = true;
            layoutResource.VerticalScroll.Enabled = true;
            layoutResource.HorizontalScroll.Visible = false;
            layoutResource.HorizontalScroll.Enabled = false;
            layoutResource.RowCount = 0;
            layoutResource.RowStyles.Clear();
            layoutResource.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            List<CourseResource> allResource = Program.provider.CourseResources.ToList();
            foreach (CourseResource resource in allResource)
            {
                if (idModule == resource.module_id)
                {
                    if (resource.resource_type == 0)
                    {
                        itemVideo itemvideo = new itemVideo();
                        itemvideo.Dock = DockStyle.Top;
                        itemvideo.resuorceName = resource.resource_name;
                        string resourcefilename = resource.resource_filename;
                        itemvideo.videoURL = Program.RESOURCES_PATH + resource.resource_filename;
                        itemvideo.HideContextMenu();
                        layoutResource.Controls.Add(itemvideo);
                    }
                    else if (resource.resource_type == 1)
                    {
                        itemFile itemfile = new itemFile();
                        itemfile.Dock = DockStyle.Top;
                        itemfile.resuorceName= resource.resource_name;
                        itemfile.resourceFileName = resource.resource_filename;
                        itemfile.canDownload = resource.allow_download;
                        itemfile.SetCanDownload();
                        itemfile.LoadPDF(Program.RESOURCES_PATH + resource.resource_filename);
                        layoutResource.Controls.Add(itemfile);
                    }
                    else if (resource.resource_type == 2)
                    {
                        itemTest itemtest = new itemTest();
                        itemtest.Dock = DockStyle.Top;
                        itemtest.resourceId = resource.resource_id;
                        itemtest.testName = resource.resource_name;
                        //itemtest.goToTest += GoToTest;

                        List<TestResult> testResults = (
                            from result in Program.provider.TestResults
                            join test in Program.provider.CourseTests
                            on result.test_id equals test.test_id
                            where result.register_id == currentRegister.register_id
                            && test.resource_id == resource.resource_id
                            select result
                            ).ToList();

                        if (testResults.Count > 0)
                        {
                            itemtest.HideViewDetail(1);
                            itemtest.viewDetailTestResult += ViewDetailTestResult;

                            if (getMaxResult(testResults).is_passed == 1)
                            {
                                itemtest.SetTestState(2);
                                itemtest.goToTest += GoToTest;
                            }
                            else
                            {
                                itemtest.SetTestState(1);
                                itemtest.goToTest += GoToTest;
                            }
                        }
                        else
                        {
                            itemtest.HideViewDetail(0);
                            itemtest.SetTestState(0);
                            itemtest.goToTest += GoToTest;
                        }

                        layoutResource.Controls.Add(itemtest);
                    }
                }
            }
        }

        //private int CheckPassTheTest(CourseResource resource, TestResult maxResult)
        //{
        //    int scoreToPass = (
        //        from test in Program.provider.CourseTests
        //        where test.resource_id == resource.resource_id
        //        select test
        //        ).ToList().FirstOrDefault().score_to_pass;

        //    if (maxResult.tes)
        //}

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

        private void GoToTest(object sender, EventArgs e)
        {
            itemTest itemtest = (itemTest)sender;
            fCourseTest courseTest = new fCourseTest(itemtest.resourceId, false, course);
            courseTest.FormClosed += CourseTest_FormClosed;
            courseTest.ShowDialog();
        }

        private void CourseTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(Control control in layoutResource.Controls)
            {
                itemTest itemtest = control as itemTest;
                if (itemtest != null)
                {
                    itemtest.viewDetailTestResult -= ViewDetailTestResult;
                    itemtest.goToTest -= GoToTest;

                    List<TestResult> testResults = (
                        from result in Program.provider.TestResults
                        join test in Program.provider.CourseTests
                                        on result.test_id equals test.test_id
                        where result.register_id == currentRegister.register_id
                        && test.resource_id == itemtest.resourceId
                    select result
                    ).ToList();

                    if (testResults.Count > 0)
                    {
                        itemtest.HideViewDetail(1);
                        itemtest.viewDetailTestResult += ViewDetailTestResult;

                        if (getMaxResult(testResults).is_passed == 1)
                        {
                            itemtest.SetTestState(2);
                            itemtest.goToTest += GoToTest;
                        }
                        else
                        {
                            itemtest.SetTestState(1);
                            itemtest.goToTest += GoToTest;
                        }
                    }
                    else
                    {
                        itemtest.HideViewDetail(0);
                        itemtest.SetTestState(0);
                        itemtest.goToTest += GoToTest;
                    }
                }
            }
        }

        private void ViewDetailTestResult(object sender, EventArgs e)
        {
            itemTest item = (itemTest)sender;

            // get test id
            int testID = (
                from test in Program.provider.CourseTests
                where test.resource_id == item.resourceId
                select test
                ).ToList().FirstOrDefault().test_id;

            fDetailTestResult fDetailTest = new fDetailTestResult(currentRegister.register_id, testID);
            fDetailTest.ShowDialog();
        }

        private void ucCourseModule_viewModuleClicked(object sender, EventArgs e)
        {
            ucCourseModule ucCourseModule = sender as ucCourseModule;
            LoadResourceOfModule(ucCourseModule.moduleID);

            foreach(Control control in layoutModule.Controls)
            {
                if (control is ucCourseModule)
                {
                    if (control != sender)
                    {
                        ucCourseModule item = control as ucCourseModule;
                        item.backColor = Color.White;
                    }
                    else
                    {
                        ucCourseModule item = control as ucCourseModule;
                        item.backColor = Color.FromArgb(228, 230, 233);
                    }

                }
            }
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            backHomeClicked?.Invoke(this, e);
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            fDetailCourseRegisted fDetail = new fDetailCourseRegisted(currentRegister);
            fDetail.ShowDialog();
        }
    }
}
