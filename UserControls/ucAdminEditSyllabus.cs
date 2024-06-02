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
    public partial class ucAdminEditSyllabus : UserControl
    {
        public Course course;
        public EventHandler evtExit;
        public ucAdminEditSyllabus()
        {
            InitializeComponent();

            tbpModules.AutoScroll = true;
            tbpModules.VerticalScroll.Visible = true;
            tbpModules.VerticalScroll.Enabled = true;

            tbpModules.RowCount = 0;
            tbpModules.RowStyles.Clear();
            tbpModules.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }
        public ucAdminEditSyllabus(Course course) : this()
        {
            this.course = course;
            LoadModules();
        }

        private ucAdminCourseModule NewUcAdminCourseModule(CourseModule module)
        {
            ucAdminCourseModule ucModule = new ucAdminCourseModule(module);
            ucModule.Dock = DockStyle.Top;
            ucModule.evtDelete += ucCourseModule_Delete;
            ucModule.evtAdd += ucCourseModule_Add;
            return ucModule;
        }

        private void ucCourseModule_Delete(object sender, EventArgs e)
        {
            ucAdminCourseModule ucModule = (ucAdminCourseModule)sender;
            Program.provider.CourseModules.Remove(ucModule.module);
            tbpModules.Controls.Remove(ucModule);
        }

        private void ucCourseModule_Add(object sender, EventArgs e)
        {
            fAdminAddResource fAdminAddResource = new fAdminAddResource(((ucAdminCourseModule)sender).module);
            fAdminAddResource.evtReload += (s, ev) =>
            {
                LoadModules();
            };
            fAdminAddResource.ShowDialog();

        }

        private void LoadModules()
        {
            tbpModules.Controls.Clear();
            var modules = Program.provider.CourseModules.Where(m => m.course_id == course.course_id).ToList();
            foreach (CourseModule module in modules)
            {
                ucAdminCourseModule ucModule = NewUcAdminCourseModule(module);
                tbpModules.Controls.Add(ucModule);
            }
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            if (tbModuleName.Text == "")
            {
                return;
            }

            CourseModule module = new CourseModule()
            {
                module_name = tbModuleName.Text,
                course_id = course.course_id
            };

            Program.provider.CourseModules.Add(module);
            Program.provider.SaveChanges();

            ucAdminCourseModule ucModule = NewUcAdminCourseModule(module);
            tbpModules.Controls.Add(ucModule);
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Program.provider.SaveChanges();
            evtExit?.Invoke(this, e);
        }
    }
}
