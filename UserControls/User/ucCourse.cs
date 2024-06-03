using Elearning.Entities;
using Elearning.UserControls.User;
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
    public partial class ucCourse : UserControl
    {
        public EventHandler backHomeClicked;
        private Course course;
        private List<CourseModule> listModule = new List<CourseModule>();
        public ucCourse()
        {
            InitializeComponent();
            InitUI();
        }

        public ucCourse(Course course)
        {
            InitializeComponent();
            this.course = course;
            InitUI();
            LoadAllModule(course);
        }

        private void InitUI()
        {
            picCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            lblCourseName.Text = course.course_name;
            lblLecturerName.Text = course.lecturer;

            layoutModule.AutoScroll = true;
            layoutModule.VerticalScroll.Visible = true;
            layoutModule.VerticalScroll.Enabled = true;
            layoutModule.HorizontalScroll.Visible = false;
            layoutModule.HorizontalScroll.Enabled = false;
            layoutModule.RowCount = 0;
            layoutModule.RowStyles.Clear();
            layoutModule.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            layoutResource.AutoScroll = true;
            layoutResource.VerticalScroll.Visible = true;
            layoutResource.VerticalScroll.Enabled = true;
            layoutResource.HorizontalScroll.Visible = false;
            layoutResource.HorizontalScroll.Enabled = false;
            layoutResource.RowCount = 0;
            layoutResource.RowStyles.Clear();
            layoutResource.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void LoadAllModule(Course course)
        {
            int count = 0;
            List<CourseModule> allModule = Program.provider.CourseModules.ToList();
            foreach (CourseModule module in allModule)
            {
                if (module.course_id == course.course_id)
                {
                    count++;
                    if (count == 1)
                    {
                        LoadResourceOfModule(module.module_id);
                    }
                    ucCourseModule uc = new ucCourseModule();
                    uc.Dock = DockStyle.Top;
                    uc.moduleID = module.module_id;
                    uc.moduleOrdinal = string.Format("Module {0}:", count);
                    uc.moduleName = module.module_name;
                    uc.courseModuleClick += ucCourseModule_viewModuleClicked;
                    layoutModule.Controls.Add(uc);
                }
            }
        }

        private void LoadResourceOfModule(int idModule)
        {
            layoutResource.Controls.Clear();
            layoutResource.AutoScroll = true;
            layoutResource.VerticalScroll.Visible = true;
            layoutResource.VerticalScroll.Enabled = true;
            layoutResource.HorizontalScroll.Visible = false;
            layoutResource.HorizontalScroll.Enabled = false;
            layoutResource.RowCount = 0;
            layoutResource.RowStyles.Clear();
            layoutResource.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            List<CourseResource> allResource = Program.provider.CourseResources.ToList();
            foreach (CourseResource resource in allResource)
            {
                if (idModule == resource.module_id)
                {
                    if (resource.resource_type == 0)
                    {
                        itemVideo itemvideo = new itemVideo();
                        itemvideo.Dock = DockStyle.Top;
                        itemvideo.resuorceName = resource.resource_name;
                        string resourcefilename = resource.resource_filename;
                        itemvideo.videoURL = Program.RESOURCES_PATH + resource.resource_filename;
                        itemvideo.HideContextMenu();
                        layoutResource.Controls.Add(itemvideo);
                    }
                    else if (resource.resource_type == 1)
                    {
                        itemFile itemfile = new itemFile();
                        itemfile.Dock = DockStyle.Top;
                        itemfile.resuorceName= resource.resource_name;
                        itemfile.resourceFileName = resource.resource_filename;
                        itemfile.canDownload = resource.allow_download;
                        itemfile.SetCanDownload();
                        layoutResource.Controls.Add(itemfile);
                    }
                    else if (resource.resource_type == 2)
                    {

                    }
                }
            }
        }

        private void ucCourseModule_viewModuleClicked(object sender, EventArgs e)
        {
            ucCourseModule ucCourseModule = sender as ucCourseModule;
            LoadResourceOfModule(ucCourseModule.moduleID);
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            backHomeClicked?.Invoke(this, e);
        }
    }
}
