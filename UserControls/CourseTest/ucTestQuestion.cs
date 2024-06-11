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

namespace Elearning.UserControls.CourseTest
{
    public partial class ucTestQuestion : UserControl
    {
        public ucTestQuestion()
        {
            InitializeComponent();
        }

        private TestQuestion thisTestQuestion;
        public TestQuestion testQuestion
        {
            get { return thisTestQuestion; }
            set { thisTestQuestion = value; }
        }

        private int questionOrdinal;
        public int ordinnal
        {
            get { return questionOrdinal; }
            set { questionOrdinal = value; }
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

        public double trueScore = 0;

        public EventHandler ucTestQuestionTickClick;

        public void ucTestQuestion_LoadAnswer(int type, string choice)
        {
            if (type == 0)
            {
                string[] answerArray = choice.Split('\n');
                for (int i=answerArray.Length-1; i >= 0; i--)
                {
                    string answer = answerArray[i];
                    if (answer != "")
                    {
                        RadioButton itemCheckBox = new RadioButton();
                        itemCheckBox.Text = answer;
                        itemCheckBox.Click += OneChoiceCheckBoxClick;
                        itemCheckBox.Checked = false;
                        //itemCheckBox.Padding = new Padding(0, 10, 0, 10);
                        itemCheckBox.Dock = DockStyle.Top;
                        panChooseAnswer.Controls.Add(itemCheckBox);
                    }
                }
                done = 0;
            }
            else if (type == 1)
            {
                string[] answerArray = choice.Split('\n');
                for ( int i=answerArray.Length-1;i >= 0; i--)
                {
                    string answer = answerArray[i];
                    if (answer != "")
                    {
                        CheckBox itemCheckBox = new CheckBox();
                        itemCheckBox.Text = answer;
                        itemCheckBox.Click += MutiChoiceCheckBoxClick;
                        itemCheckBox.Checked = false;
                        //itemCheckBox.Padding = new Padding(0, 10, 0, 10);
                        itemCheckBox.Dock = DockStyle.Top;
                        panChooseAnswer.Controls.Add(itemCheckBox);
                    }
                }
                done = 0;
            }
            else if (type == 2)
            {
                TextBox textBox = new TextBox();
                textBox.Dock = DockStyle.Fill;
                textBox.LostFocus += ShortAnswerFill;
                panChooseAnswer.Controls.Add(textBox);

                done = 0;
            }
        }

        public void ucTestQuestion_CheckAnswer()
        {
            if (testQuestion.question_type == 0)
            {
                int index = int.Parse(testQuestion.answer);
                index = panChooseAnswer.Controls.Count - index - 1;
                Control control = panChooseAnswer.Controls[index];
                RadioButton item = control as RadioButton;
                if (item.Checked == true)
                {
                    answerState = "True";
                    trueScore = 100;
                }
            }
            else if (testQuestion.question_type == 1)
            {
                int count = 0;
                string[] answerArray = testQuestion.answer.Split(';');
                int total = answerArray.Count() - 1;
                foreach(string answer in answerArray)
                {
                    if (answer == "")
                    {
                        continue;
                    }
                    int index = int.Parse(answer);
                    index = panChooseAnswer.Controls.Count - index - 1;
                    Control control = panChooseAnswer.Controls[index];
                    CheckBox item = control as CheckBox;
                    if (item.Checked == true)
                    {
                        count++;
                    }

                }
                if (count != 0) 
                {
                    answerState = "True";
                    trueScore = (double)count / total * 100;
                }
            }
            else if (testQuestion.question_type == 2)
            {                
                foreach (Control textBox in panChooseAnswer.Controls)
                {
                    TextBox item = textBox as TextBox;
                    if (item == null)
                    {
                        continue;
                    }
                    if (textBox.Text == testQuestion.answer)
                    {
                        answerState = "True";
                        trueScore = 100;
                        break;
                    }
                }
            }

            if (trueScore == 0)
            {
                answerState = "False";
            }
        }

        private int done = 0;
        public int isDone {
            get { return done; }
            set { done = value; }
        }

        public EventHandler ucTestQuestionChooseAnswerClick;
        public void OneChoiceCheckBoxClick(object sender, EventArgs e)
        {
            done = 1;
            lblState.Text = "Done";
            lblState.Visible = true;
            ucTestQuestionChooseAnswerClick?.Invoke(this, e);
        }

        public void MutiChoiceCheckBoxClick(object sender, EventArgs e)
        {
            done = 1;
            lblState.Text = "Done";
            lblState.Visible = true;
            ucTestQuestionChooseAnswerClick?.Invoke(this, e);
        }

        public void ShortAnswerFill(object sender, EventArgs e)
        {
            done = 1;
            lblState.Text = "Done";
            lblState.Visible = true;
            ucTestQuestionChooseAnswerClick?.Invoke(this, e);
        }

        private void lblTick_Click(object sender, EventArgs e)
        {
            ucTestQuestionTickClick?.Invoke(this, e);
        }
    }
}
