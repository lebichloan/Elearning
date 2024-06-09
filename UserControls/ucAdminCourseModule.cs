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
            this.lbDescription.Text = module.description;

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
                ucResource.evtDelete += ucResource_Delete;
                ucResource.evtEdit += ucResource_Edit;
                ucResource.Width = this.flpItems.ClientSize.Width - 60;
                this.flpItems.Controls.Add(ucResource);
            }
        }

        public void ReLoadItems()
        {
            foreach (ucAdminResource ucResource in this.flpItems.Controls)
            {
                ucResource.Reload();
            }
        }

        public void DisableEdit()
        {
            this.btnDelete.Visible = false;
            this.btnAdd.Visible = false;

            foreach (ucAdminResource ucResource in this.flpItems.Controls)
            {
                ucResource.DisableEdit();
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

        private void ucResource_Delete(object sender, EventArgs e)
        {
            ucAdminResource ucResource = (ucAdminResource)sender;

            Program.provider.CourseResources.Remove(ucResource.resource);
            Program.provider.SaveChanges();

            flpItems.Controls.Remove(ucResource);
        }

        private void ucResource_Edit(object sender, EventArgs e)
        {
            ucAdminResource ucResource = (ucAdminResource)sender;
            if (ucResource.resource.resource_type == Program.TYPE_TEST)
            {
                // get the test corresponding to the resource
                var test = Program.provider.CourseTests.Where(t => t.resource_id == ucResource.resource.resource_id).FirstOrDefault();
                fAdminEditTest fAdminEditTest = new fAdminEditTest(test);
                fAdminEditTest.evtReload += (s, ev) =>
                {
                    ReLoadItems();
                };
                fAdminEditTest.ShowDialog();
            }
            else
            {
                fAdminAddResource fAdminAddResource = new fAdminAddResource(ucResource.resource);
                fAdminAddResource.evtReload += (s, ev) =>
                {
                    LoadItems();
                };
                fAdminAddResource.ShowDialog();
            }
        }
    }
}
