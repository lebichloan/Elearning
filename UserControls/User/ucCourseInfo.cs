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
    public partial class ucCourseInfo : UserControl
    {
        public EventHandler backHomeClicked;
        private Course course;
        public ucCourseInfo()
        {
            InitializeComponent();
        }

        public ucCourseInfo(Course course)
        {
            InitializeComponent();
            this.course = course;
            InitUI(course);
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            backHomeClicked?.Invoke(this, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (course.price == 0)
            {
                DialogResult result = MessageBox.Show(
                    "Đăng ký khóa học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    backHomeClicked?.Invoke(this, e);
                }

            }
            else
            {
                RegisterPayment registerPayment = new RegisterPayment(course.price);
                registerPayment.backHomeClicked += backHomeClicked;
                registerPayment.ShowDialog();
            }
        }

        private void InitUI(Course course)
        {
            picCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            
            lblCourseName.Text = course.course_name;
            lblCourseName1.Text = course.course_name;

            lblLecturerName.Text = course.lecturer;
            lblLecturerName1.Text = course.lecturer;

            lblDifficulty.Text = course.difficulty;
            lblDifficulty1.Text = course.difficulty;

            lblCategory.Text = course.category;
            lblCategory1.Text = course.category;

            lblDescription.Text = course.course_description;

            if (course.stars != null)
            {
                lblStar.Text = course.stars.ToString();
            }
            else
            {
                lblStar.Text = "No rating";
            }

            lblPrice.Text = String.Format("{0} VNĐ", course.price.ToString());

            LoadModuleOfCourse(course);
        }

        private void LoadModuleOfCourse(Course course)
        {
            layoutModule.AutoScroll = true;
            layoutModule.VerticalScroll.Visible = true;
            layoutModule.VerticalScroll.Enabled = true;
            layoutModule.HorizontalScroll.Visible = false;
            layoutModule.HorizontalScroll.Enabled = false;
            layoutModule.RowCount = 0;
            layoutModule.RowStyles.Clear();
            layoutModule.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            int count = 0;
            List<CourseModule> allModule = Program.provider.CourseModules.ToList();
            foreach (CourseModule module in allModule)
            {
                if (module.course_id == course.course_id)
                {
                    count++;
                    ucCourseModule uc = new ucCourseModule();
                    uc.Dock = DockStyle.Top;
                    uc.moduleOrdinal = string.Format("Module {0}:", count);
                    uc.moduleName = module.module_name;
                    layoutModule.Controls.Add(uc);
                }
            }

            lblTotalModule.Text = String.Format("{0} moudules", count.ToString());
        }
    }
}
