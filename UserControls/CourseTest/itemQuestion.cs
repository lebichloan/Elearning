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

        public Color buttonColor
        {
            get { return btnQuestionOrdinal.FillColor; }
            set { btnQuestionOrdinal.FillColor = value; }
        }

        public Color textColor
        {
            get { return btnQuestionOrdinal.ForeColor; }
            set { btnQuestionOrdinal.ForeColor = value; }
        }

    }
}
