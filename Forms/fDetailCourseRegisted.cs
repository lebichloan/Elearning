using Elearning.Entities;
using Elearning.UserControls.CourseTest;
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
    public partial class fDetailCourseRegisted : Form
    {
        public fDetailCourseRegisted()
        {
            InitializeComponent();
        }

        private Register register;
        public fDetailCourseRegisted(Register register)
        {
            InitializeComponent();
            this.register = register;
            SetUI();
            GetDataForTable();
        }

        private void SetUI()
        {
            picCourseImage.Image = Image.FromFile(
                Program.COURSES_IMG_PATH
                + register.Course.course_image
                );

            lblCourseName.Text = register.Course.course_name;
            lblLecturerName.Text = register.Course.lecturer;
            lblDifficulty.Text = register.Course.difficulty;
            lblCategory.Text = register.Course.category;
            lblRegister.Text = String.Format("Ngày đăng ký: {0}", register.registered_date.ToString());
            if (register.register_status == 2)
            {
                lblFinish.Visible = true;
                lblFinish.Text = String.Format("Ngày hoàn thành {0}");
                lblCompletionState.Text = "Hoàn thành";
                lblCompletionState.ForeColor = Color.FromArgb(94, 148, 255);
                btnViewCertification.Visible = true;
            }
            else
            {
                lblFinish.Visible = false;
                lblCompletionState.Text = "Chưa hoàn thành";
                lblCompletionState.ForeColor = Color.Red;
                btnViewCertification.Visible = false;
            }
        }

        private void GetDataForTable()
        {
            tbAllModule.AutoScroll = true;
            tbAllModule.VerticalScroll.Visible = true;
            tbAllModule.VerticalScroll.Enabled = true;
            tbAllModule.HorizontalScroll.Visible = false;
            tbAllModule.HorizontalScroll.Enabled = false;

            Course course = register.Course;
            List<CourseModule> courseModules = course.CourseModules.ToList();

            int rows = courseModules.Count();
            tbAllModule.RowCount = rows;
            tbAllModule.RowStyles.Clear();
            for (int i = 0; i < rows; i++)
            {
                tbAllModule.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            int count = 1;
            foreach (CourseModule module in courseModules)
            {
                itemModuleTestResult item = new itemModuleTestResult(module, register);
                item.moduleName = String.Format("Module {0}: {1}", count, module.module_name);
                item.Dock = DockStyle.Fill;
                tbAllModule.Controls.Add(item);
                count++;
            }
        }
    }
}
