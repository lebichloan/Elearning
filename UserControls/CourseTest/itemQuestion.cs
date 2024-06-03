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
    public partial class itemQuestion : UserControl
    {
        public itemQuestion()
        {
            InitializeComponent();
        }

        public string questionOrdinal
        {
            get { return btnQuestionOrdinal.Text; }
            set { btnQuestionOrdinal.Text = value; }
        }
    }
}
