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
    public partial class ucTestQuestion : UserControl
    {
        public ucTestQuestion()
        {
            InitializeComponent();
        }

        private int idQuestion;
        public int id
        {
            get { return id; }
            set { id = value; }
        }

        private bool isTick = false;
        public bool isTickQuestion
        {
            get { return isTick; }
            set { isTick = value; }
        }

        private bool isView = false;
        public bool isViewOnly
        {
            get {  return isView; }
            set { isView = value; }
        }

        public void SetUI()
        {
            if (isView == true)
            {
                panAnswer.Visible = true;
                lblTick.Enabled = false;
                picTick.Visible = false;
                panContent.Enabled = false;
                lblQuestionScore.Visible = true;
                return;
            }
            else
            {
                panAnswer.Visible = false;
                picTick.Visible = false;
                lblTick.Enabled = true;
                panContent.Enabled = true;
                lblQuestionScore.Visible = false;
            }
            
            if (isTick == true)
            {
                picTick.Visible = true;
                lblTick.ForeColor = Color.Red;
            }
            else
            {
                picTick.Visible = false;
                lblTick.ForeColor = Color.Black;
            }
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

        public string trueAnswer
        {
            get { return lblTrueAnswer.Text; }
            set { lblTrueAnswer.Text = value; }
        }

        public EventHandler ucTestQuestionLoadAnswer;

        public EventHandler ucTestQuestionTickClick;

        private void ucTestQuestion_Load(object sender, EventArgs e)
        {
            ucTestQuestionLoadAnswer?.Invoke(this, e);
        }

        private void lblTick_Click(object sender, EventArgs e)
        {
            ucTestQuestionTickClick?.Invoke(this, e);
        }
    }
}
