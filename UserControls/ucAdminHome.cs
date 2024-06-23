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

            // Load course difficulties to cbFilterDiff
            cbFilterDiff.Items.Add("All");
            foreach (string difficulty in Program.COURSE_DIFFICULTIES)
            {
                cbFilterDiff.Items.Add(difficulty);
            }
            cbFilterDiff.SelectedIndex = 0;

            // Load course categories to cbFilterCategory
            cbFilterCategory.Items.Add("All");
            foreach (string category in Program.COURSE_CATEGORIES)
            {
                cbFilterCategory.Items.Add(category);
            }
            cbFilterCategory.SelectedIndex = 0;
        }

        public ucAdminCoursePreview NewUcAdminCoursePreview(Course course)
        {
            ucAdminCoursePreview ucCoursePreview = new ucAdminCoursePreview(course);
            ucCoursePreview.Dock = DockStyle.Top;
            ucCoursePreview.viewDetailClicked += ucPreview_viewDetailClicked;
            return ucCoursePreview;
        }

        public void Reload()
        {
            var courses = Program.provider.Courses.ToList();
            for (int i = layoutCourses.Controls.Count - 1; i >= 0; --i)
            {
                if (layoutCourses.Controls[i] is ucAdminCoursePreview)
                {
                    var uc = layoutCourses.Controls[i] as ucAdminCoursePreview;
                    var course = courses[i];
                    uc.Reload(course);
                    uc.Visible = true;
                }
            }

            tbSearch.Text = "";
            cbFilterDiff.SelectedIndex = 0;
            cbFilterCategory.SelectedIndex = 0;
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
            ucAdminCourseInfo courseInfo = new ucAdminCourseInfo(course, ucCoursePreview);
            courseInfo.backClicked += ucInfo_backClicked;
            courseInfo.Dock = DockStyle.Fill;
            containerMain.Controls.Add(courseInfo);
            courseInfo.BringToFront();
        }

        private void ucInfo_backClicked(object sender, EventArgs e)
        {
            Reload();
            containerMain.Controls.Remove((ucAdminCourseInfo)sender);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for the course with the keyword
            string keyword = tbSearch.Text;
            keyword = keyword.Trim();
            if (keyword == "")
            {
                return;
            }

            foreach (Control control in layoutCourses.Controls)
            {
                if (control is ucAdminCoursePreview)
                {
                    ucAdminCoursePreview ucCourse = (ucAdminCoursePreview)control;
                    if (ucCourse.course.course_name.ToLower().Contains(keyword.ToLower()) || 
                        ucCourse.course.lecturer.ToLower().Contains(keyword.ToLower()))
                    {
                        ucCourse.Visible = true;
                    }
                    else
                    {
                        ucCourse.Visible = false;
                    }
                }
            }

        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // if the user presses Enter key, search for the course
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Program.provider = new ELearningDbEntities();
            Reload();
        }

        private void cbFilterDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            var difficulty = cbFilterDiff.SelectedItem.ToString();
            foreach (Control control in layoutCourses.Controls)
            {
                if (control is ucAdminCoursePreview)
                {
                    ucAdminCoursePreview ucCourse = (ucAdminCoursePreview)control;
                    if (difficulty != "All" && ucCourse.course.difficulty != difficulty)
                    {
                        ucCourse.Visible = false;
                    }
                    else
                    {
                        ucCourse.Visible = true;
                    }
                }
            }

            if (cbFilterCategory.SelectedItem == null) return;

            var category = cbFilterCategory.SelectedItem.ToString();
            foreach (Control control in layoutCourses.Controls)
            {
                if (control is ucAdminCoursePreview)
                {
                    ucAdminCoursePreview ucCourse = (ucAdminCoursePreview)control;
                    if (category != "All" && ucCourse.course.category != category)
                    {
                        ucCourse.Visible = false;
                    }
                }
            }
        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = cbFilterCategory.SelectedItem.ToString();
            foreach (Control control in layoutCourses.Controls)
            {
                if (control is ucAdminCoursePreview)
                {
                    ucAdminCoursePreview ucCourse = (ucAdminCoursePreview)control;
                    if (category != "All" && ucCourse.course.category != category)
                    {
                        ucCourse.Visible = false;
                    }
                    else
                    {
                        ucCourse.Visible = true;
                    }
                }
            }

            if (cbFilterDiff.SelectedItem == null) return;

            var difficulty = cbFilterDiff.SelectedItem.ToString();
            foreach (Control control in layoutCourses.Controls)
            {
                if (control is ucAdminCoursePreview)
                {
                    ucAdminCoursePreview ucCourse = (ucAdminCoursePreview)control;
                    if (difficulty != "All" && ucCourse.course.difficulty != difficulty)
                    {
                        ucCourse.Visible = false;
                    }
                }
            }
        }
    }
}
