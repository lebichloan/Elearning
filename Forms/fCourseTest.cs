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
            this.isView = isView;
            InitUI();
            LoadAllQuestion();
        }

        private Account currentAccount;
        private int currentTestID;
        private bool isView;
        private void InitUI()
        {
            lblName.Text = currentAccount.fullname;
            picAvatar.Image = Image.FromFile(Program.AVARTAR_PATH + currentAccount.avatar);

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

            for (int i=0; i< allQuestions.Count(); i++)
            {
                itemQuestion itemquestion = new itemQuestion();
                itemquestion.questionOrdinal = (i + 1).ToString();
                itemquestion.Dock = DockStyle.Fill;
                tbAllQuestion.Controls.Add(itemquestion);
            }

            int count = 1;
            foreach (TestQuestion question in allQuestions)
            {
                ucTestQuestion ucTest = new ucTestQuestion();
                ucTest.id = question.test_id;
                ucTest.isTickQuestion = false;
                ucTest.isViewOnly = isView;
                ucTest.SetUI();
                ucTest.questionNumber = String.Format("Question {0}:", count);
                ucTest.questionState = "";
                ucTest.questionContent = question.question_description;
                ucTest.ucTestQuestion_LoadAnswer(question.question_type, question.choices);
                ucTest.Dock = DockStyle.Top;
                tbQuestion.Controls.Add(ucTest);
                count++;
            }
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {

        }
    }
}
