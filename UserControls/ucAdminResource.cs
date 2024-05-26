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
        CourseResource resource;
        public ucAdminResource()
        {
            InitializeComponent();
        }

        public ucAdminResource(CourseResource resource) : this()
        {
            this.resource = resource;
            this.lbName.Text = resource.resource_name;

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
    }
}
