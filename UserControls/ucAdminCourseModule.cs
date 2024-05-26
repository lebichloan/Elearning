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
    public partial class ucAdminCourseModule : UserControl
    {
        public CourseModule module;
        public EventHandler evtDelete;
        public EventHandler evtAdd;
        public ucAdminCourseModule()
        {
            InitializeComponent();
        }

        public ucAdminCourseModule(CourseModule module)
        {
            InitializeComponent();
            this.module = module;
            this.lbModuleName.Text = module.module_name;

            this.flpItems.AutoScroll = true;
            this.flpItems.VerticalScroll.Visible = true;
            this.flpItems.VerticalScroll.Enabled = true;
            LoadItems();
        }

        public void LoadItems()
        {
            this.flpItems.Controls.Clear();
            foreach (CourseResource resource in module.CourseResources)
            {
                ucAdminResource ucResource = new ucAdminResource(resource);
                ucResource.Dock = DockStyle.Top;
                this.flpItems.Controls.Add(ucResource);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            evtDelete?.Invoke(this, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            evtAdd?.Invoke(this, e);
        }
    }
}
