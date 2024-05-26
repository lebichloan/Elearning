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

namespace Elearning.UserControls
{
    public partial class ucAdminCourseInfo : UserControl
    {
        public EventHandler backClicked;
        public Course course;
        public ucAdminCourseInfo()
        {
            InitializeComponent();
        }

        public ucAdminCourseInfo(Course course) : this()
        {
            this.course = course;
        }

        private void ucAdminCourseInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            this.lbCourseName.Text = course.course_name;
            this.lbDescription.Text = course.course_description;
            this.lbLecturerName.Text = course.lecturer;
            this.lbCategory.Text = course.category;
            this.lbDifficulty.Text = course.difficulty;
            this.pbCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            this.pbCourseImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LoadSyllabus()
        {
            conSyllabus.Controls.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, e);
        }

        private void btnEditInfor_Click(object sender, EventArgs e)
        {
            fAdminEditCourse fEditCourse = new fAdminEditCourse(course);
            fEditCourse.evtReload += (s, ev) =>
            {
                LoadInfo();
            };
            fEditCourse.ShowDialog();
        }

        private void btnEditSyllabus_Click(object sender, EventArgs e)
        {
            ucAdminEditSyllabus ucEditSyllabus = new ucAdminEditSyllabus(course);
            ucEditSyllabus.evtExit += (s, ev) =>
            {
                this.Controls.Remove(ucEditSyllabus);
                LoadSyllabus();
            };
            ucEditSyllabus.Dock = DockStyle.Fill;
            conSyllabus.Controls.Add(ucEditSyllabus);
        }
    }
}
