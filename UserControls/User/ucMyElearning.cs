using Elearning.Entities;
using Elearning.Forms;
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
using System.Windows.Input;

namespace Elearning.UserControls.User
{
    public partial class ucMyElearning : UserControl
    {
        public EventHandler viewDetailsClicked;
        
        public ucMyElearning()
        {
            InitializeComponent();
            layoutMyCourses.Controls.Clear();

            layoutMyCourses.AutoScroll = true;
            layoutMyCourses.VerticalScroll.Visible = true;
            layoutMyCourses.VerticalScroll.Enabled = true;
            layoutMyCourses.HorizontalScroll.Visible = false;
            layoutMyCourses.HorizontalScroll.Enabled = false;
            layoutMyCourses.RowCount = 0;
            layoutMyCourses.RowStyles.Clear();
            layoutMyCourses.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void ucCoursePreview_ViewCertificateClick(object sender, EventArgs e)
        {
            ucCoursePreview item = sender as ucCoursePreview;
            courseView = item.coursePreviewClicked;
            Register register = (
                from regis in Program.provider.Registers
                where regis.course_id == courseView.course_id
                && regis.learner_id == fLogin.currentAccount.acc_id
                select regis
                ).ToList().FirstOrDefault();
            ShowCertificate(register);
        }

        private void ShowCertificate(Register register)
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

        public void ucMyElearning_Load(object sender, EventArgs e)
        {
            ucCoursePreview ucCoursePreview = new ucCoursePreview();
            int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            layoutMyCourses.ColumnCount = columns;
            layoutMyCourses.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                layoutMyCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            }

            Account currentAccount = fLogin.currentAccount;

            List<Course> allCourses = (
                from course in Program.provider.Courses
                join register in Program.provider.Registers on course.course_id equals register.course_id
                where register.register_status != 0 && register.learner_id == currentAccount.acc_id
                select course
            ).ToList();

            LoadData(allCourses, currentAccount);
        }

        public static string FormatDecimal(decimal? value)
        {
            if (!value.HasValue)
            {
                return string.Empty;
            }

            decimal roundedValue = Math.Round(value.Value, 1);

            if (roundedValue == Math.Floor(roundedValue))
            {
                return roundedValue.ToString("0");
            }
            else
            {
                return roundedValue.ToString("0.0");
            }
        }

        private int CheckComplete(Course course)
        {
            List<Register> listRegis = (
                from register in Program.provider.Registers
                where register.Course.course_id == course.course_id
                && register.learner_id == fLogin.currentAccount.acc_id
                && register.register_status == 2
                select register
            ).ToList();

            if (listRegis.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private Course courseView;
        public Course courseViewClicked
        {
            get { return courseView; }
            set { courseView = value; }
        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            ucCoursePreview ucCourse = sender as ucCoursePreview;
            courseView = ucCourse.coursePreviewClicked;
            viewDetailsClicked?.Invoke(this, e);
        }

        private void ucCoursePreview_btnRatingClick(object sender, EventArgs e)
        {
            ucCoursePreview ucCourse = sender as ucCoursePreview;
            courseView = ucCourse.coursePreviewClicked;
            
            fRateCourse rateCourse = new fRateCourse(courseView);
            rateCourse.FormClosed += fRateCourse_ClosedForm;
            rateCourse.ShowDialog();
        }

        private void fRateCourse_ClosedForm(object sender, EventArgs e)
        {
            foreach(Control control in layoutMyCourses.Controls)
            {
                ucCoursePreview item = control as ucCoursePreview;
                if (item.coursePreviewClicked == courseView)
                {
                    if (getCourseReview(courseView, fLogin.currentAccount) != null)
                    {
                        item.SetUIRate(2, CheckComplete(courseView));
                        item.btnRateClick -= ucCoursePreview_btnRatingClick;
                        item.btnRateClick += ucCoursePreview_btnEditRatingClick;
                    }
                }
            }
        }

        private void ucCoursePreview_btnEditRatingClick(object sender, EventArgs e)
        {
            ucCoursePreview ucCourse = sender as ucCoursePreview;
            courseView = ucCourse.coursePreviewClicked;

            CourseReview review = getCourseReview(courseView, fLogin.currentAccount);
            fRateCourse rateCourse = new fRateCourse(review);
            rateCourse.FormClosed += fRateCourse_ClosedForm;
            rateCourse.ShowDialog();
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            SetUIFilter(0);

            Account currentAccount = fLogin.currentAccount;
            System.Diagnostics.Debug.WriteLine(currentAccount.username);

            // Get all courses that the current account has registered
            List<Course> allCourses = (
                from course in Program.provider.Courses
                join register in Program.provider.Registers on course.course_id equals register.course_id
                where register.register_status != 0 && register.learner_id == currentAccount.acc_id
                select course
            ).ToList();

            LoadData(allCourses, currentAccount);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            SetUIFilter(1);

            Account currentAccount = fLogin.currentAccount;

            List<Course> allCourses = (
                from course in Program.provider.Courses
                join register in Program.provider.Registers on course.course_id equals register.course_id
                where register.register_status == 2 && register.learner_id == currentAccount.acc_id
                select course
            ).ToList();

            LoadData(allCourses, currentAccount);
        }

        private void btnNotYet_Click(object sender, EventArgs e)
        {
            SetUIFilter(2);

            Account currentAccount = fLogin.currentAccount;

            List<Course> allCourses = (
                from course in Program.provider.Courses
                join register in Program.provider.Registers on course.course_id equals register.course_id
                where register.register_status == 1 && register.learner_id == currentAccount.acc_id
                select course
            ).ToList();

            LoadData(allCourses, currentAccount);
        }

        private void SetUIFilter (int type)
        {
            if (type == 0)
            {
                btnAll.FillColor = Color.FromArgb(29, 36, 202);
                btnAll.BorderColor = Color.FromArgb(29, 36, 202);
                btnAll.ForeColor = Color.White;

                btnComplete.FillColor = Color.White;
                btnComplete.BorderColor = Color.FromArgb(29, 36, 202);
                btnComplete.ForeColor = Color.FromArgb(29, 36, 202);

                btnNotYet.FillColor = Color.White;
                btnNotYet.BorderColor = Color.FromArgb(29, 36, 202);
                btnNotYet.ForeColor = Color.FromArgb(29, 36, 202);
            }
            else if (type == 1)
            {
                btnComplete.FillColor = Color.FromArgb(29, 36, 202);
                btnComplete.BorderColor = Color.FromArgb(29, 36, 202);
                btnComplete.ForeColor = Color.White;

                btnAll.FillColor = Color.White;
                btnAll.BorderColor = Color.FromArgb(29, 36, 202);
                btnAll.ForeColor = Color.FromArgb(29, 36, 202);

                btnNotYet.FillColor = Color.White;
                btnNotYet.BorderColor = Color.FromArgb(29, 36, 202);
                btnNotYet.ForeColor = Color.FromArgb(29, 36, 202);
            }
            else
            {
                btnNotYet.FillColor = Color.FromArgb(29, 36, 202);
                btnNotYet.BorderColor = Color.FromArgb(29, 36, 202);
                btnNotYet.ForeColor = Color.White;

                btnComplete.FillColor = Color.White;
                btnComplete.BorderColor = Color.FromArgb(29, 36, 202);
                btnComplete.ForeColor = Color.FromArgb(29, 36, 202);

                btnAll.FillColor = Color.White;
                btnAll.BorderColor = Color.FromArgb(29, 36, 202);
                btnAll.ForeColor = Color.FromArgb(29, 36, 202);
            }
        }

        private void LoadData(List<Course> allCourses, Account currentAccount)
        {
            layoutMyCourses.Controls.Clear();

            layoutMyCourses.AutoScroll = true;
            layoutMyCourses.VerticalScroll.Visible = true;
            layoutMyCourses.VerticalScroll.Enabled = true;
            layoutMyCourses.HorizontalScroll.Visible = false;
            layoutMyCourses.HorizontalScroll.Enabled = false;
            layoutMyCourses.RowCount = 0;
            layoutMyCourses.RowStyles.Clear();
            layoutMyCourses.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            ucCoursePreview ucCoursePreview = new ucCoursePreview();
            int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            layoutMyCourses.ColumnCount = columns;
            layoutMyCourses.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                layoutMyCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            }

            foreach (Course course in allCourses)
            {
                ucCoursePreview ucCourse = new ucCoursePreview();
                ucCourse.coursePreviewClicked = course;
                ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                ucCourse.courseLecturer = course.lecturer;
                ucCourse.courseName = course.course_name;
                ucCourse.btnViewDetailText = "Go to course";
                if (course.stars != null)
                {
                    ucCourse.rating = String.Format("{0}/5",
                        FormatDecimal(course.stars.Value));
                }
                else
                {
                    ucCourse.rating = "No reviews";
                }

                if (course.discount != 0)
                {
                    ucCourse.price = course.price.ToString("N0") + "đ";
                    int finalPrice = (int)(course.price - course.price * (int)course.discount / 100.0);
                    ucCourse.finalPrice = finalPrice.ToString("N0") + "đ";
                    // cross out the original price
                }
                else
                {
                    ucCourse.finalPrice = course.price.ToString("N0") + "đ";
                    ucCourse.price = "";
                }
                ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                ucCourse.btnViewCertificateClick += ucCoursePreview_ViewCertificateClick;
                if (getCourseReview(course, currentAccount) == null)
                {
                    ucCourse.SetUIRate(1, CheckComplete(course));
                    ucCourse.btnRateClick += ucCoursePreview_btnRatingClick;
                }
                else
                {
                    ucCourse.SetUIRate(2, CheckComplete(course));
                    ucCourse.btnRateClick += ucCoursePreview_btnEditRatingClick;
                }
                layoutMyCourses.Controls.Add(ucCourse);
            }

        }
    }
}
