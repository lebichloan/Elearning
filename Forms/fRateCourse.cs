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

namespace Elearning.Forms
{
    public partial class fRateCourse : Form
    {
        public fRateCourse()
        {
            InitializeComponent();
        }

        public fRateCourse(Course course)
        {
            InitializeComponent();
            this.currentCourse = course;
            InitUI(course);

            Account currentUser = fLogin.currentAccount;
            register = (
                from registers in Program.provider.Registers
                where registers.course_id == course.course_id
                && currentUser.acc_id == registers.learner_id
                select registers
                ).ToList().FirstOrDefault();
        }

        private int? rate = 5;
        private Register register;
        private Course currentCourse;
        private void btnStar1_Click(object sender, EventArgs e)
        {
            btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");

            rate = 1;
        }

        private void btnStar2_Click(object sender, EventArgs e)
        {
            btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");

            rate = 2;
        }

        private void btnStar3_Click(object sender, EventArgs e)
        {
            btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");
            btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");

            rate = 3;
        }

        private void btnStar4_Click(object sender, EventArgs e)
        {
            btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_solid.png");

            rate = 4;
        }

        private void btnStar5_Click(object sender, EventArgs e)
        {
            btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");

            rate = 5;
        }

        private void InitUI(Course course)
        {
            picCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            lblCourseName.Text = course.course_name;
            lblLecturerName.Text = course.lecturer;
            lblDifficulty.Text = course.difficulty;
            lblCategory.Text = course.category;

            btnStar1.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar2.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar3.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar4.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            btnStar5.Image = Image.FromFile(Program.ICONS_PATH + "star_fill.png");
            rate = 5;
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            CourseReview review = new CourseReview();
            review.register_id = register.register_id;
            review.review_time = DateTime.Now;
            review.content = txtReview.Text.ToString();
            review.stars = rate;

            Program.provider.CourseReviews.Add(review);
            Program.provider.SaveChanges();

            SetRateCourse(currentCourse);

            DialogResult result = MessageBox.Show(
                "Thêm nhận xét thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void SetRateCourse(Course course)
        {
            List<CourseReview> listCourseReview = (
                from review in Program.provider.CourseReviews
                where review.Register.Course.course_id == course.course_id
                select review
                ).ToList();

            if (listCourseReview.Count > 1)
            {
                int? totalRate = 0;

                foreach (CourseReview courseReview in listCourseReview)
                {
                    totalRate += courseReview.stars;
                }

                double? star = (double?)totalRate.Value / listCourseReview.Count();
                course.stars = (decimal?)star;
                Program.provider.SaveChanges();
            }
            else
            {
                course.stars = listCourseReview.FirstOrDefault().stars;
                Program.provider.SaveChanges();
            }
        }

    }
}
