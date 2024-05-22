using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls.CourseResource
{
    public partial class itemFile : UserControl
    {
        public itemFile()
        {
            InitializeComponent();
            SetCanDownload();
        }

        private int candownload = 0;
        public string resuorceName
        {
            get { return lblResourceName.Text; }
            set { lblResourceName.Text = value; }
        }

        public string resourceFileName
        {
            get { return lblLinkFile.Text; }
            set { lblLinkFile.Text = value; }
        }

        public int canDownload
        {
            get { return candownload; }
            set { candownload = value; }
        }

        private void SetCanDownload()
        {
            if (canDownload == 0)
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }
    }
}
