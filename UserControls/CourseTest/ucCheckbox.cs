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
    public partial class ucCheckbox : UserControl
    {
        public ucCheckbox()
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

        public EventHandler ucCheckBoxLoadAnswer;
        private void ucCheckbox_Load(object sender, EventArgs e)
        {
            ucCheckBoxLoadAnswer?.Invoke(this, e);
        }

        public EventHandler ucCheckBoxTickClick;
        private void lblTick_Click(object sender, EventArgs e)
        {
            ucCheckBoxTickClick?.Invoke(this, e);
        }
    }
}
