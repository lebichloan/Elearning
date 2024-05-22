using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls.CourseTest
{
    public partial class ucTotal : UserControl
    {
        public ucTotal()
        {
            InitializeComponent();
        }

        public string timeStart
        {
            get { return lblStart.Text; }
            set { lblStart.Text = value; }
        }

        public string timeFinish
        {
            get { return lblFinish.Text; }
            set { lblFinish.Text = value; }
        }

        public string testState
        {
            get { return lblState.Text; }
            set { lblState.Text = value; }
        }

        public string totalTime
        {
            get { return lblTotalTime.Text; }
            set { lblTotalTime.Text = value; }
        }

        public string source
        {
            get { return lblSource.Text; }
            set { lblSource.Text = value; }
        }

        public string totalSource
        {
            get { return lblSource10.Text; }
            set { lblSource10.Text = value; }
        }
    }
}
