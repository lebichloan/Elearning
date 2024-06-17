using Elearning.Entities;
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
    public partial class fFinishCourse : Form
    {
        public fFinishCourse()
        {
            InitializeComponent();
        }

        private Register register;
        private List<CourseReview> listCourseReviews;

        public fFinishCourse(Register register)
        {
            InitializeComponent();
            this.register = register;
            listCourseReviews = (
                from review in Program.provider.CourseReviews
                where review.register_id == register.register_id
                select review
                ).ToList();

            if (listCourseReviews.Count == 0)
            {
                btnRateCourse.Text = "Rate Course";
            }
            else
            {
                btnRateCourse.Text = "Edit review";
            }

        }
        private void btnRateCourse_Click(object sender, EventArgs e)
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

        private void btnViewCertificate_Click(object sender, EventArgs e)
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
