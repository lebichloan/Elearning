using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elearning.Entities;
using Elearning.Forms;
using Microsoft.Win32;
using System.Globalization;

namespace Elearning.UserControls.User
{
    public partial class ucCertificate: UserControl
    {
        public ucCertificate()
        {
            InitializeComponent();
        }

        private Register currentRegister;
        public ucCertificate(Register register)
        {
            InitializeComponent();
            currentRegister = register;
            picCourseImage.Image = Image.FromFile(
                Program.COURSES_IMG_PATH
                + register.Course.course_image);
            lblCourseName.Text = register.Course.course_name;
            lblTimeFinish.Text = String.Format("Time finish: ",
                register.time_finish.Value.ToString("dd/MM/yy")
                );
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            fDetailCourseRegisted detailCourseRegisted = new fDetailCourseRegisted(currentRegister);
            detailCourseRegisted.ShowDialog();
        }

        private void btnViewCertificate_Click(object sender, EventArgs e)
        {
            fCertification certification = new fCertification();
            certification.fullName = currentRegister.Account.fullname;
            certification.courseName = currentRegister.Course.course_name;
            if (currentRegister.time_finish != null)
            {
                certification.timeFinish = currentRegister.time_finish.Value.ToString("dd/MM/yy", CultureInfo.InvariantCulture);
            }
            certification.lecturer = currentRegister.Course.lecturer;
            certification.ShowDialog();
        }
    }
}
