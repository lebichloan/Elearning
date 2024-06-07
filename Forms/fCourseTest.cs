using Elearning.Entities;
using Elearning.UserControls.CourseTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fCourseTest : Form
    {
        public fCourseTest()
        {
            InitializeComponent();
        }

        public fCourseTest(int resourceID, bool isView)
        {
            InitializeComponent();
            currentAccount = fLogin.currentAccount;
            var currentTest = Program.provider.CourseTests.FirstOrDefault(x => x.resource_id == resourceID);
            currentTestID = currentTest.test_id;
            testTime = currentTest.test_maxtime;
            totalTestTime = currentTest.test_maxtime;
            this.isView = isView;
            InitUI();
            LoadAllQuestion();
        }

        private Account currentAccount;
        private int currentTestID;
        private bool isView;
        private TimeSpan testTime;
        private TimeSpan totalTestTime;
        private void InitUI()
        {
            lblName.Text = currentAccount.fullname;
            picAvatar.Image = Image.FromFile(Program.AVARTAR_PATH + currentAccount.avatar);
            lblTimer.Text = testTime.ToString();

            tbAllQuestion.Controls.Clear();
            tbAllQuestion.AutoScroll = true;
            tbAllQuestion.VerticalScroll.Visible = true;
            tbAllQuestion.VerticalScroll.Enabled = true;
            tbAllQuestion.HorizontalScroll.Visible = false;
            tbAllQuestion.HorizontalScroll.Enabled = false;
            tbAllQuestion.RowCount = 0;
            tbAllQuestion.RowStyles.Clear();
            tbAllQuestion.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tbQuestion.Controls.Clear();
            tbQuestion.AutoScroll = true;
            tbQuestion.VerticalScroll.Visible = true;
            tbQuestion.VerticalScroll.Enabled = true;
            tbQuestion.HorizontalScroll.Visible = false;
            tbQuestion.HorizontalScroll.Enabled = false;
            tbQuestion.RowCount = 0;
            tbQuestion.RowStyles.Clear();
            tbQuestion.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void LoadAllQuestion()
        {
            itemQuestion item = new itemQuestion();
            int columns = (tbAllQuestion.Width - 5) / item.MaximumSize.Width;
            tbAllQuestion.ColumnCount = columns;
            tbAllQuestion.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                tbAllQuestion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tbAllQuestion.Width / columns));
            }

            List<TestQuestion> allQuestions = (
                from question in Program.provider.TestQuestions
                join test in Program.provider.CourseTests on question.test_id equals test.test_id
                where currentTestID == question.test_id
                select question
            ).ToList();

            for (int i=1; i<= allQuestions.Count(); i++)
            {
                itemQuestion itemquestion = new itemQuestion();
                itemquestion.questionOrdinal = i.ToString();
                itemquestion.Dock = DockStyle.Fill;
                tbAllQuestion.Controls.Add(itemquestion);
            }

            int count = 1;
            foreach (TestQuestion question in allQuestions)
            {
                ucTestQuestion ucTest = new ucTestQuestion();
                ucTest.ordinnal = count;
                ucTest.id = question.test_id;
                ucTest.isTickQuestion = false;
                ucTest.isViewOnly = isView;
                ucTest.SetUI();
                ucTest.questionNumber = String.Format("Question {0}:", count);
                ucTest.questionState = "";
                ucTest.questionContent = question.question_description;
                ucTest.ucTestQuestion_LoadAnswer(question.question_type, question.choices);
                ucTest.ucTestQuestionChooseAnswerClick += chooseAnswerClick;
                ucTest.ucTestQuestionTickClick += tickQuestionClick;
                ucTest.Dock = DockStyle.Top;
                tbQuestion.Controls.Add(ucTest);
                count++;
            }
        }

        private void chooseAnswerClick(object sender, EventArgs e)
        {
            ucTestQuestion ucTest = sender as ucTestQuestion;
            foreach(Control control in tbAllQuestion.Controls)
            {
                itemQuestion item = control as itemQuestion;
                if (item.questionOrdinal == ucTest.ordinnal.ToString())
                {
                    item.textColor = Color.White;
                    item.buttonColor = Color.FromArgb(94, 148, 255);
                    break;
                }
            }
        }

        private void tickQuestionClick(object sender, EventArgs e)
        {
            ucTestQuestion ucTest = sender as ucTestQuestion;
            if (ucTest.isTickQuestion == true)
            {
                ucTest.isTickQuestion = false;
                ucTest.SetUI();

                foreach (Control control in tbAllQuestion.Controls)
                {
                    itemQuestion item = control as itemQuestion;
                    if (item.questionOrdinal == ucTest.ordinnal.ToString())
                    {
                        if (ucTest.isDone == 0)
                        {
                            item.textColor = Color.Black;
                            item.buttonColor = Color.White;
                        }
                        else
                        {
                            item.textColor = Color.White;
                            item.buttonColor = Color.FromArgb(94, 148, 255);
                        }
                        break;
                    }
                }
            }
            else
            {
                ucTest.isTickQuestion= true;
                ucTest.SetUI();
                ucTest.questionState = "Mark";

                foreach (Control control in tbAllQuestion.Controls)
                {
                    itemQuestion item = control as itemQuestion;
                    if (item.questionOrdinal == ucTest.ordinnal.ToString())
                    {
                        item.textColor = Color.White;
                        item.buttonColor = Color.Gray;
                        break;
                    }
                }
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            testTime = testTime.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Text = testTime.ToString();

            if (testTime <= TimeSpan.FromTicks((long)(totalTestTime.Ticks * 0.5)))
            {
                btnDone.Visible = true;
            }

            if (testTime <= TimeSpan.FromTicks((long)(totalTestTime.Ticks * 0.1)))
            {
                lblTimer.ForeColor = Color.Red;
            }

            if (testTime <= TimeSpan.Zero)
            {
                timerTest.Stop();
                DialogResult result = MessageBox.Show(
                    "Đã hết thời gian làm bài. Hệ thống sẽ tự động quay về trang chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            tbQuestion.Visible = true;
            tbAllQuestion.Enabled = true;
            timerTest.Start();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn nộp bài ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                );
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
