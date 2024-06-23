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

namespace Elearning.UserControls
{
    public partial class ucAdminCoursePreview : UserControl
    {
        public Course course;
        public EventHandler viewDetailClicked;
        public ucAdminCoursePreview()
        {
            InitializeComponent();
        }

        public ucAdminCoursePreview(Course course)
        {
            InitializeComponent();
            this.course = course;

            lbCourseName.Text = course.course_name;
            lbLecturer.Text = course.lecturer;
            pbImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            if (course.discount == 0)
            {
                lbOriginalPrice.Text = course.price.ToString("N0") + "đ";
                lbFinalPrice.Visible = false;
                lbOriginalPrice.Font = new Font(lbOriginalPrice.Font, FontStyle.Bold);
            }
            else
            {
                lbOriginalPrice.Text = course.price.ToString("N0") + "đ";
                // cross out the original price
                lbOriginalPrice.Font = new Font(lbOriginalPrice.Font, FontStyle.Strikeout);
                lbFinalPrice.Visible = true;

                // calculate the final price, round to the nearest 1000
                if (course.discount != null)
                {
                    int finalPrice = (int)(course.price - course.price * (int)course.discount / 100.0);
                    lbFinalPrice.Text = finalPrice.ToString("N0") + "đ";
                }
                else
                {
                    lbFinalPrice.Text = course.price.ToString("N0") + "đ";
                }
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            viewDetailClicked?.Invoke(this, e);
        }

        public void Reload(Course course)
        {
            this.course = course;
            lbCourseName.Text = course.course_name;
            lbLecturer.Text = course.lecturer;
            pbImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            if (course.discount == 0)
            {
                lbOriginalPrice.Text = course.price.ToString("N0") + "đ";
                lbFinalPrice.Visible = false;
            }
            else
            {
                lbOriginalPrice.Text = course.price.ToString("N0") + "đ";
                // cross out the original price
                lbOriginalPrice.Font = new Font(lbOriginalPrice.Font, FontStyle.Strikeout);
                lbFinalPrice.Visible = true;

                // calculate the final price, round to the nearest 1000
                if (course.discount != null)
                {
                    int finalPrice = (int)(course.price - course.price * (int)course.discount / 100.0);
                    lbFinalPrice.Text = finalPrice.ToString("N0") + "đ";
                }
                else
                {
                    lbFinalPrice.Text = course.price.ToString("N0") + "đ";
                }
            }
        }

        public void SetImageToNone()
        {
            pbImage.Image.Dispose();
            pbImage.Image = null;
        }
    }
}
