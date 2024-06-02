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
    public partial class ucAdminSyllabus : UserControl
    {
        Course course;
        public ucAdminSyllabus()
        {
            InitializeComponent();

            this.tlpModules.RowCount = 0;
            this.tlpModules.RowStyles.Clear();
            this.tlpModules.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            this.tlpModules.AutoScroll = true;
            this.tlpModules.VerticalScroll.Visible = true;
            this.tlpModules.VerticalScroll.Enabled = true;
        }

        public ucAdminSyllabus(Course course) : this()
        {
            this.course = course;
            LoadModules();
        }

        private ucAdminCourseModule NewUcAdminCourseModule(CourseModule module)
        {
            ucAdminCourseModule ucModule = new ucAdminCourseModule(module);
            ucModule.Dock = DockStyle.Top;
            ucModule.DisableEdit();
            return ucModule;
        }

        private void LoadModules()
        {
            var modules = Program.provider.CourseModules.Where(x => x.course_id == course.course_id).ToList();
            foreach (var module in modules)
            {
                tlpModules.Controls.Add(NewUcAdminCourseModule(module));
            }
        }

        public void Reload()
        {
            tlpModules.Controls.Clear();
            LoadModules();
        }
    }
}
