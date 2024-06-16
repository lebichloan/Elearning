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

namespace Elearning.UserControls.User
{
    public partial class ucMyElearning : UserControl
    {
        public EventHandler viewDetailsClicked;
        
        public ucMyElearning()
        {
            InitializeComponent();
            layoutMyCourses.AutoScroll = true;
            layoutMyCourses.VerticalScroll.Visible = true;
            layoutMyCourses.VerticalScroll.Enabled = true;
            layoutMyCourses.HorizontalScroll.Visible = false;
            layoutMyCourses.HorizontalScroll.Enabled = false;
            layoutMyCourses.RowCount = 0;
            layoutMyCourses.RowStyles.Clear();
            layoutMyCourses.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void ucMyElearning_Load(object sender, EventArgs e)
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
                join account in Program.provider.Accounts on register.learner_id equals account.acc_id
                select course
            ).ToList();

            foreach (Course course in allCourses)
            {
                ucCoursePreview ucCourse = new ucCoursePreview();
                ucCourse.coursePreviewClicked = course;
                ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                ucCourse.courseLecturer = course.lecturer;
                ucCourse.courseName = course.course_name;
                ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                if (getCourseReview(course, currentAccount) == null)
                {
                    ucCourse.SetUIRate(1);
                    ucCourse.btnRateClick += ucCoursePreview_btnRatingClick;
                }
                else
                {
                    ucCourse.SetUIRate(2);
                    ucCourse.btnRateClick += ucCoursePreview_btnEditRatingClick;
                }
                layoutMyCourses.Controls.Add(ucCourse);
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
            rateCourse.ShowDialog();
        }

        private void ucCoursePreview_btnEditRatingClick(object sender, EventArgs e)
        {
            ucCoursePreview ucCourse = sender as ucCoursePreview;
            courseView = ucCourse.coursePreviewClicked;

            CourseReview review = getCourseReview(courseView, fLogin.currentAccount);
            fRateCourse rateCourse = new fRateCourse(review);
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
    }
}
