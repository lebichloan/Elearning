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
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            viewDetailClicked?.Invoke(this, e);
        }

        public void Reload()
        {
            lbCourseName.Text = course.course_name;
            lbLecturer.Text = course.lecturer;
            pbImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
