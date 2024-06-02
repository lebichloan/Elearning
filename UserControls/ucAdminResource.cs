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
    public partial class ucAdminResource : UserControl
    {
        public CourseResource resource;
        public EventHandler evtDelete;
        public EventHandler evtEdit;
        public ucAdminResource()
        {
            InitializeComponent();
        }

        public ucAdminResource(CourseResource resource) : this()
        {
            this.resource = resource;
            this.lbName.Text = resource.resource_name;
            lbType.Text = Program.RESOURCE_TYPE[resource.resource_type];

            if (resource.resource_type == Program.TYPE_VIDEO)
            {
                this.pbIcon.Image = Properties.Resources.videoIcon;
            }
            else if (resource.resource_type == Program.TYPE_DOC)
            {
                this.pbIcon.Image = Properties.Resources.pdfIcon;
            }
            else
            {
                this.pbIcon.Image = Properties.Resources.testIcon;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        public void Reload()
        {
            this.lbName.Text = resource.resource_name;
            lbType.Text = Program.RESOURCE_TYPE[resource.resource_type];
        }

        public void DisableEdit()
        {
            this.btnEdit.Visible = false;
            this.btnDelete.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            evtDelete?.Invoke(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            evtEdit?.Invoke(this, e);
        }
    }
}
