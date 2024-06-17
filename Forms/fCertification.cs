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
    public partial class fCertification : Form
    {
        public fCertification()
        {
            InitializeComponent();
        }

        public string fullName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string courseName
        {
            get { return lblCourseName.Text; }
            set { lblCourseName.Text = value; }
        }

        public string timeFinish
        {
            get { return lblTimeFinish.Text; }
            set { lblTimeFinish.Text = value; }
        }

        public string lecturer
        {
            get { return lblLecturer.Text; }
            set { lblLecturer.Text = value; }
        }
    }
}
