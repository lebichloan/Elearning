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
    public partial class ucAdminHome : UserControl
    {
        ContainerControl containerMain;
        public ucAdminHome()
        {
            InitializeComponent();
            layoutCourses.AutoScroll = true;
            layoutCourses.VerticalScroll.Visible = true;
            layoutCourses.VerticalScroll.Enabled = true;
            layoutCourses.HorizontalScroll.Visible = false;
            layoutCourses.HorizontalScroll.Enabled = false;
            layoutCourses.RowCount = 0;
            layoutCourses.RowStyles.Clear();
            layoutCourses.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        public ucAdminHome(ContainerControl container) : this()
        {
            this.containerMain = container;
        }

        private void ucAdminHome_Load(object sender, EventArgs e)
        {
            // calculate the number of columns needed to show appropriate number of courses in one row
            ucAdminCoursePreview ucCoursePreview = new ucAdminCoursePreview();
            System.Diagnostics.Debug.WriteLine(layoutCourses.ClientSize.Width + " " + ucCoursePreview.MaximumSize.Width);
            int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            layoutCourses.ColumnCount = columns;
            layoutCourses.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                layoutCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            }

            // Load courses from the database
            var courses = Program.provider.Courses.ToList();
            foreach (Course course in courses)
            {
                ucAdminCoursePreview ucCourse = NewUcAdminCoursePreview(course);
                layoutCourses.Controls.Add(ucCourse);
            }
        }

        public ucAdminCoursePreview NewUcAdminCoursePreview(Course course)
        {
            ucAdminCoursePreview ucCoursePreview = new ucAdminCoursePreview(course);
            ucCoursePreview.Dock = DockStyle.Top;
            ucCoursePreview.viewDetailClicked += ucPreview_viewDetailClicked;
            return ucCoursePreview;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            fAdminAddCourse addCourse = new fAdminAddCourse();
            addCourse.evtReload += (s, ev) =>
            {
                // add the new course to the layout. To get the new course, get the course with the created_at time is the latest
                var course = Program.provider.Courses.OrderByDescending(c => c.created_at).First();
                ucAdminCoursePreview ucCourse = NewUcAdminCoursePreview(course);
                layoutCourses.Controls.Add(ucCourse);
            };
            addCourse.ShowDialog();
        }

        private void ucPreview_viewDetailClicked(object sender, EventArgs e)
        {
            ucAdminCoursePreview ucCoursePreview = (ucAdminCoursePreview)sender;
            Course course = ucCoursePreview.course;
            ucAdminCourseInfo courseInfo = new ucAdminCourseInfo(course);
            courseInfo.backClicked += ucInfo_backClicked;
            courseInfo.Dock = DockStyle.Fill;
            containerMain.Controls.Add(courseInfo);
            courseInfo.BringToFront();
        }

        private void ucInfo_backClicked(object sender, EventArgs e)
        {
            containerMain.Controls.Remove((ucAdminCourseInfo)sender);
        }
    }
}
