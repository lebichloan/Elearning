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
        ucAdminDescription ucDescription;
        ucAdminSyllabus ucSyllabus;
        public ucAdminCourseInfo()
        {
            InitializeComponent();

            int height = Screen.GetWorkingArea(this).Height * 3 / 4;

            conDescription.AutoScroll = true;
            conDescription.VerticalScroll.Visible = true;
            conDescription.VerticalScroll.Enabled = true;
            conDescription.Height = height / 10;

            conSyllabus.AutoScroll = true;
            conSyllabus.VerticalScroll.Visible = true;
            conSyllabus.VerticalScroll.Enabled = true; 
            conSyllabus.Height = height / 10 * 5;

        }

        public ucAdminCourseInfo(Course course) : this()
        {
            this.course = course;

            LoadInfo();
            ucDescription = new ucAdminDescription(course);
            ucDescription.Dock = DockStyle.Fill;
            conDescription.Controls.Add(ucDescription);

            ucSyllabus = new ucAdminSyllabus(course);
            ucSyllabus.Dock = DockStyle.Fill;
            conSyllabus.Controls.Add(ucSyllabus);
        }

        private void ucAdminCourseInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadInfo()
        {
            this.lbCourseName.Text = course.course_name;
            this.lbLecturerName.Text = course.lecturer;
            this.lbCategory.Text = course.category;
            this.lbDifficulty.Text = course.difficulty;
            this.pbCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            this.pbCourseImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LoadSyllabus()
        {
            ucSyllabus.Reload();
        }

        private void LoadEditSyllabus()
        {
            ucAdminEditSyllabus ucEditSyllabus = new ucAdminEditSyllabus(course);
            ucEditSyllabus.evtExit += (s, ev) =>
            {
                conSyllabus.Controls.Remove(ucEditSyllabus);
                LoadSyllabus();
            };
            ucEditSyllabus.Dock = DockStyle.Fill;
            conSyllabus.Controls.Add(ucEditSyllabus);
            ucEditSyllabus.BringToFront();
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
            LoadEditSyllabus();
        }
    }
}
