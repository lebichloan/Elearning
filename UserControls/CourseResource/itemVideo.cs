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
    public partial class itemVideo : UserControl
    {
        public itemVideo()
        {
            InitializeComponent();
        }

        public string resuorceName
        {
            get { return lblResourceName.Text; }
            set { lblResourceName.Text = value; }
        }
        
        public string videoURL
        {
            get { return medVideo.URL; }
            set { medVideo.URL = value; }
        }

    }
}
