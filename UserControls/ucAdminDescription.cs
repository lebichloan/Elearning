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
    public partial class ucAdminDescription : UserControl
    {
        Course course;
        public ucAdminDescription()
        {
            InitializeComponent();
        }

        public ucAdminDescription(Course course) : this()
        {
            this.course = course;
            this.lbDescription.Text = course.course_description;
        }

        public void Reload()
        {
            this.lbDescription.Text = course.course_description;
        }
    }
}
