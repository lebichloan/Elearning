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
    public partial class ucShortAnswer : UserControl
    {
        public ucShortAnswer()
        {
            InitializeComponent();
        }

        public string questionNumber
        {
            get { return lblNumber.Text; }
            set { lblNumber.Text = value; }
        }

        public string questionState
        {
            get { return lblState.Text; }
            set { lblState.Text = value; }
        }

        public string questionContent
        {
            get { return lblQuestion.Text; }
            set { lblQuestion.Text = value; }
        }

        public string answerState
        {
            get { return lblStateAnswer.Text; }
            set { lblStateAnswer.Text = value; }
        }

        public string rightAnswer
        {
            get { return lblRightAnswer.Text; }
            set { lblRightAnswer.Text = value; }
        }
    }
}
