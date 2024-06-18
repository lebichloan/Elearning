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
    public partial class ucCoursePreview : UserControl
    {
        public EventHandler viewDetailsClicked;
        public ucCoursePreview()
        {
            InitializeComponent();
        }

        private Course coursePreview;
        public Course coursePreviewClicked
        {
            get { return coursePreview; }
            set { coursePreview = value; }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            viewDetailsClicked?.Invoke(this, e);
        }

        public Image courseImage
        {
            get { return picImage.Image; }
            set { picImage.Image = value; }
        }

        public string courseLecturer
        {
            get { return lbLecturer.Text; }
            set { lbLecturer.Text = value; }
        }

        public string courseName
        {
            get { return lbCourseName.Text; }
            set { lbCourseName.Text = value; }
        }

        public EventHandler btnRateClick;
        private void btnRate_Click(object sender, EventArgs e)
        {
            btnRateClick?.Invoke(this, e);
        }

        public void SetUIRate(int flag, int isComplete)
        {
            if (flag == 0)
            {
                panMoreOption.Visible = false;
                panMoreOption.Size = new Size(0, 0);

                btnViewDetails.Size = new Size(285, 50);

                //btnRate.Visible = false;
                //btnRate.Size = new Size(0, 0);
            }
            else if (flag == 1)
            {
                panMoreOption.Visible = true;
                panMoreOption.Size = new Size(285, 45);

                btnRate.Visible = true;
                btnRate.Text = "Rate course";

                btnViewDetails.Size = new Size(220, 45);

                if (isComplete == 0)
                {
                    btnRate.Size = new Size(220, 45);
                    panMargin.Size = new Size(0, 0);
                    btnViewCertificate.Size = new Size(0, 0);
                }
                else
                {
                    btnRate.Size = new Size(105, 45);
                    panMargin.Size = new Size(5, 45);
                    btnViewCertificate.Size = new Size(140, 45);
                }
            }
            else if (flag == 2)
            {
                panMoreOption.Visible = true;
                panMoreOption.Size = new Size(285, 45);

                btnRate.Visible = true;
                btnRate.Text = "Edit rate";

                btnViewDetails.Size = new Size(220, 45);

                if (isComplete == 0)
                {
                    btnRate.Size = new Size(220, 45);
                    panMargin.Size = new Size(0, 0);
                    btnViewCertificate.Size = new Size(0, 0);
                }
                else
                {
                    btnRate.Size = new Size(105, 45);
                    panMargin.Size = new Size(5, 45);
                    btnViewCertificate.Size = new Size(105, 45);
                }
            }
        }

        public string btnViewDetailText
        {
            get { return btnViewDetails.Text; }
            set { btnViewDetails.Text = value; }
        }

        public EventHandler btnViewCertificateClick;
        private void btnViewCertificate_Click(object sender, EventArgs e)
        {
            btnViewCertificateClick?.Invoke(this, e);
        }
    }
}
