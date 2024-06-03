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
            get { return idQuestion; }
            set { idQuestion = value; }
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
                panAnswer.Size = new Size(0, 0);
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

        public string questionScore
        {
            get { return lblQuestionScore.Text; }
            set { lblQuestionScore.Text = value; }
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

        public EventHandler ucTestQuestionTickClick;

        public void ucTestQuestion_LoadAnswer(int type, string choice)
        {
            if (type == 0)
            {
                string[] answerArray = choice.Split('\n');
                foreach (string answer in answerArray)
                {
                    if (answer != "")
                    {
                        CheckBox itemCheckBox = new CheckBox();
                        itemCheckBox.Text = answer;
                        itemCheckBox.Dock = DockStyle.Top;
                        panChooseAnswer.Controls.Add(itemCheckBox);
                    }
                }
            }
        }

        private void lblTick_Click(object sender, EventArgs e)
        {
            ucTestQuestionTickClick?.Invoke(this, e);
        }
    }
}
