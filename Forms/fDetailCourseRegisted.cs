using Elearning.Entities;
using Elearning.UserControls;
using Elearning.UserControls.CourseTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fDetailCourseRegisted : Form
    {
        public fDetailCourseRegisted()
        {
            InitializeComponent();
        }

        private Register register;
        public fDetailCourseRegisted(Register register)
        {
            InitializeComponent();
            this.register = register;
            listCourseReviews = (
                from review in Program.provider.CourseReviews
                where review.register_id == register.register_id
                select review
                ).ToList();
            SetUI();
            GetDataForTable();
        }

        private void SetUI()
        {
            picCourseImage.Image = Image.FromFile(
                Program.COURSES_IMG_PATH
                + register.Course.course_image
                );

            lblCourseName.Text = register.Course.course_name;
            lblLecturerName.Text = register.Course.lecturer;
            lblDifficulty.Text = register.Course.difficulty;
            lblCategory.Text = register.Course.category;
            lblRegister.Text = String.Format("Date register: {0}", register.registered_date.ToString());
            if (register.register_status == 2)
            {
                lblFinish.Visible = true;
                lblCompletionScore.Text = register.completion_score.ToString();
                lblFinish.Text = String.Format("Date finish: {0}", register.time_finish.ToString());
                lblCompletionState.Text = "Finish";
                lblCompletionState.ForeColor = Color.FromArgb(94, 148, 255);
                btnViewCertification.Visible = true;
            }
            else
            {
                lblFinish.Visible = false;
                lblCompletionState.Text = "Unfinished";
                lblCompletionState.ForeColor = Color.Red;
                btnViewCertification.Visible = false;
            }

            if (listCourseReviews.Count == 0)
            {
                btnAddReview.Text = "Add Review";
            }
            else
            {
                btnAddReview.Text = "Edit review";
            }
        }

        private void GetDataForTable()
        {
            tbAllModule.AutoScroll = true;
            tbAllModule.VerticalScroll.Visible = true;
            tbAllModule.VerticalScroll.Enabled = true;
            tbAllModule.HorizontalScroll.Visible = false;
            tbAllModule.HorizontalScroll.Enabled = false;

            Course course = register.Course;
            List<CourseModule> courseModules = course.CourseModules.ToList();

            int rows = courseModules.Count();
            tbAllModule.RowCount = rows;
            tbAllModule.RowStyles.Clear();
            for (int i = 0; i < rows; i++)
            {
                tbAllModule.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            int count = 1;
            foreach (CourseModule module in courseModules)
            {
                itemModuleTestResult item = new itemModuleTestResult(module, register);
                item.moduleName = String.Format("Module {0}: {1}", count, module.module_name);
                item.Dock = DockStyle.Fill;
                tbAllModule.Controls.Add(item);
                count++;
            }
        }

        private List<CourseReview> listCourseReviews;

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (listCourseReviews.Count == 0)
            {
                fRateCourse rateCourse = new fRateCourse(register.Course);
                rateCourse.ShowDialog();
            }
            else
            {
                fRateCourse rateCourse = new fRateCourse(listCourseReviews.FirstOrDefault());
                rateCourse.ShowDialog();
            }
        }

        private void fRateCourseCloseForm(object sender, EventArgs e)
        {
            listCourseReviews = (
                from review in Program.provider.CourseReviews
                where review.register_id == register.register_id
                select review
                ).ToList();

            if (listCourseReviews.Count == 0)
            {
                btnAddReview.Text = "Rate course";
            }
            else
            {
                btnAddReview.Text = "Edit rate";
            }
        }

        private CourseReview getCourseReview(Course course, Account account)
        {
            List<CourseReview> courseReviews = (
                from review in Program.provider.CourseReviews
                where review.Register.course_id == course.course_id
                && review.Register.learner_id == account.acc_id
                select review
                ).ToList();

            if (courseReviews.Count == 0)
            {
                return null;
            }
            return courseReviews.FirstOrDefault();
        }


        private void btnViewCertification_Click(object sender, EventArgs e)
        {
            fCertification certification = new fCertification();
            certification.fullName = register.Account.fullname;
            certification.courseName = register.Course.course_name;
            if (register.time_finish != null)
            {
                certification.timeFinish = String.Format("Date: {0}",
                    register.time_finish.Value.ToString("dd/MM/yy", CultureInfo.InvariantCulture));
            }
            certification.lecturer = register.Course.lecturer;
            certification.ShowDialog();
        }
    }
}
