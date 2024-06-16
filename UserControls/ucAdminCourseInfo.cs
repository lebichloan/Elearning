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
        ucAdminEditSyllabus ucEditSyllabus;
        ucAdminCoursePreview ucPreview;
        ucAdminDiscount ucDiscount;
        ucAdminReviews ucReviews;
        ucCourseStatistics ucStats;
        public ucAdminCourseInfo()
        {
            InitializeComponent();

            int height = Screen.GetWorkingArea(this).Height * 3 / 4;

            conDescription.AutoScroll = true;
            conDescription.VerticalScroll.Visible = true;
            conDescription.VerticalScroll.Enabled = true;
            conDescription.Height = height / 10;

            conMain.AutoScroll = true;
            conMain.VerticalScroll.Visible = true;
            conMain.VerticalScroll.Enabled = true; 
            conMain.Height = height / 10 * 5;
        }

        public ucAdminCourseInfo(Course course, ucAdminCoursePreview ucPreview) : this()
        {
            this.course = course;

            ucDescription = new ucAdminDescription(course);
            ucDescription.Dock = DockStyle.Fill;
            conDescription.Controls.Add(ucDescription);

            ucSyllabus = new ucAdminSyllabus(course);
            ucSyllabus.Dock = DockStyle.Fill;
            ucSyllabus.editClicked += (s, ev) =>
            {
                System.Diagnostics.Debug.WriteLine("Edit clicked");
                LoadEditSyllabus();
            };
            conMain.Controls.Add(ucSyllabus);

            ucEditSyllabus = new ucAdminEditSyllabus(course);
            ucEditSyllabus.evtExit += (s, ev) =>
            {
                ucSyllabus.Reload();
                LoadSyllabus();
            };
            ucEditSyllabus.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucEditSyllabus);

            this.ucPreview = ucPreview;

            ucReviews = new ucAdminReviews(course);
            ucReviews.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucReviews);

            ucStats = new ucCourseStatistics(course);
            ucStats.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucStats);

            ucSyllabus.BringToFront();

            ucDiscount = new ucAdminDiscount(course);
            ucDiscount.Dock = DockStyle.Fill;
            conDiscount.Controls.Add(ucDiscount);
            LoadInfo();
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

            if (this.course.price == 0)
            {
                btnEditDiscount.Visible = false;
            }
            else
            {
                btnEditDiscount.Visible = true;
            }

            ucDescription.Reload();
            ucDiscount.Reload();
        }

        private void LoadSyllabus()
        {
            ucSyllabus.BringToFront();
        }

        private void LoadEditSyllabus()
        {
            ucEditSyllabus.BringToFront();
        }

        private void LoadStatstics()
        {
            ucStats.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, e);
        }

        private void btnEditInfor_Click(object sender, EventArgs e)
        {
            fAdminEditCourse fEditCourse = new fAdminEditCourse(course);
            fEditCourse.evtSetImageToNone += (s, ev) =>
            {
                pbCourseImage.Image.Dispose();
                pbCourseImage.Image = null;
                ucPreview.SetImageToNone();
            };
            fEditCourse.evtReload += (s, ev) =>
            {
                LoadInfo();
            };
            fEditCourse.ShowDialog();
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            fAdminEditDiscount fEditDiscount = new fAdminEditDiscount(course);  
            fEditDiscount.ShowDialog();
            ucDiscount.Reload();
        }

        private void btnViewReviews_Click(object sender, EventArgs e)
        {
            ucReviews.BringToFront();
        }

        private void btnViewSyllabus_Click(object sender, EventArgs e)
        {
            LoadSyllabus();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            LoadStatstics();
        }
    }
}
