﻿using Elearning.Entities;
using Elearning.UserControls.CourseTest;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

        //display type = 0 => 1 page
        public fCourseTest(int resourceID, bool isView, Course course)
        {
            InitializeComponent();
            this.currentCourse = course;
            currentAccount = fLogin.currentAccount;
            currentRegister = (
                from register in Program.provider.Registers
                where register.learner_id == currentAccount.acc_id
                && register.course_id == currentCourse.course_id
                select register
            ).ToList().FirstOrDefault();
            var currentTest = Program.provider.CourseTests.FirstOrDefault(x => x.resource_id == resourceID);
            currentTestID = currentTest.test_id;
            testTime = currentTest.test_maxtime;
            totalTestTime = currentTest.test_maxtime;
            displayType = currentTest.display_type;
            scoreToPass = currentTest.score_to_pass;
            this.isView = isView;
            allQuestions = (
                from questions in Program.provider.TestQuestions
                join test in Program.provider.CourseTests on questions.test_id equals test.test_id
                where currentTestID == questions.test_id
                select questions
            ).ToList();

            InitUI();

            lblScoreToPass.Text = String.Format("Score to pass: {0} / {1}",
                currentTest.score_to_pass.ToString(),
                currentTest.total_score.ToString());

            if (displayType == 0)
            {
                LoadAllQuestion();
            }
            else
            {
                panPaging.Visible = true;
                panPaging.Size = new Size(874, 50);
                LoadAllControl();
                LoadQuestionWithIndex(index);
            }
        }

        private int index = 0;
        private void goToQuestionOneInPage(object sender, EventArgs e)
        {
            itemQuestion item = sender as itemQuestion;
            if (item != null)
            {
                int.TryParse(item.questionOrdinal, out index);
                index = index - 1;
                LoadQuestionWithIndex(index);
            }
        }

        private void LoadQuestionWithIndex(int questionIndex)
        {
            tbQuestion.Controls.Clear();
            tbQuestion.AutoScroll = true;
            tbQuestion.VerticalScroll.Visible = true;
            tbQuestion.VerticalScroll.Enabled = true;
            tbQuestion.HorizontalScroll.Visible = false;
            tbQuestion.HorizontalScroll.Enabled = false;
            tbQuestion.RowCount = 0;
            tbQuestion.RowStyles.Clear();
            tbQuestion.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tbQuestion.Controls.Add(listUCTestQuestion[questionIndex]);
            if (questionIndex == 0)
            {
                btnNext.Enabled = true;
                btnPre.Enabled = false;
            }
            if (questionIndex == listUCTestQuestion.Count - 1)
            {
                btnNext.Enabled = false;
                btnPre.Enabled = true;
            }
            if (questionIndex >0 && questionIndex < listUCTestQuestion.Count - 1)
            {
                btnNext.Enabled = true;
                btnPre.Enabled = true;
            }
        }

        private List<ucTestQuestion> listUCTestQuestion = new List<ucTestQuestion>();
        private void LoadAllControl()
        {
            LoadtbAllQuestion();

            int count = 1;
            foreach (TestQuestion question in allQuestions)
            {
                ucTestQuestion ucTest = new ucTestQuestion();
                ucTest.testQuestion = question;
                ucTest.ordinnal = count;
                ucTest.id = question.test_id;
                ucTest.isTickQuestion = false;
                ucTest.isViewOnly = isView;
                ucTest.SetUI();
                ucTest.questionNumber = String.Format("Question {0}:", count);
                ucTest.questionState = "Not yet";
                ucTest.questionScore = String.Format("Score: {0}",
                    question.score.ToString());
                ucTest.questionContent = question.question_description;
                ucTest.answerState = "False";
                ucTest.trueAnswer = question.answer;
                ucTest.ucTestQuestion_LoadAnswer(question.question_type, question.choices);
                ucTest.ucTestQuestionChooseAnswerClick += chooseAnswerClick;
                ucTest.ucTestQuestionTickClick += tickQuestionClick;
                ucTest.Dock = DockStyle.Top;
                listUCTestQuestion.Add(ucTest);
                count++;
            }
        }

        private void LoadtbAllQuestion()
        {
            itemQuestion item = new itemQuestion();
            int columns = (tbAllQuestion.Width - 5) / item.MaximumSize.Width;
            tbAllQuestion.ColumnCount = columns;
            tbAllQuestion.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                tbAllQuestion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tbAllQuestion.Width / columns));
            }

            for (int i = 1; i <= allQuestions.Count(); i++)
            {
                itemQuestion itemquestion = new itemQuestion();
                itemquestion.questionOrdinal = i.ToString();
                itemquestion.goToQuestionClick += goToQuestionOneInPage;
                itemquestion.Dock = DockStyle.Fill;
                tbAllQuestion.Controls.Add(itemquestion);
            }
        }

        private Course currentCourse;
        private Account currentAccount;
        private int currentTestID;
        private bool isView;
        private TimeSpan testTime;
        private TimeSpan totalTestTime;
        private int? displayType;
        private List<TestQuestion> allQuestions;
        private DateTime startTime;
        private DateTime finishTime;
        private int scoreToPass;
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

        private void GoToQuestionAll(object sender, EventArgs e)
        {

        }
        private void LoadAllQuestion()
        {
            panPaging.Visible = false;
            panPaging.Size = new Size(0, 0);

            itemQuestion item = new itemQuestion();
            int columns = (tbAllQuestion.Width - 5) / item.MaximumSize.Width;
            tbAllQuestion.ColumnCount = columns;
            tbAllQuestion.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                tbAllQuestion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tbAllQuestion.Width / columns));
            }

            for (int i=1; i<= allQuestions.Count(); i++)
            {
                itemQuestion itemquestion = new itemQuestion();
                itemquestion.questionOrdinal = i.ToString();
                itemquestion.goToQuestionClick += GoToQuestionAll;
                itemquestion.Dock = DockStyle.Fill;
                tbAllQuestion.Controls.Add(itemquestion);
            }

            int count = 1;
            foreach (TestQuestion question in allQuestions)
            {
                ucTestQuestion ucTest = new ucTestQuestion();
                ucTest.testQuestion = question;
                ucTest.ordinnal = count;
                ucTest.id = question.test_id;
                ucTest.isTickQuestion = false;
                ucTest.isViewOnly = isView;
                ucTest.SetUI();
                ucTest.questionNumber = String.Format("Question {0}:", count);
                ucTest.questionState = "Not yet";
                ucTest.questionScore = String.Format("Score: {0}",
                    question.score.ToString());
                ucTest.questionContent = question.question_description;
                ucTest.answerState = "False";
                ucTest.trueAnswer = question.answer;
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
            ucTest.ucTestQuestion_CheckAnswer();

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
                finishTime = DateTime.Now;
                TestResult testResult = SaveTestResult();
                ShowfTestResult(testResult);
                isStarted = 0;
            }
        }

        private Register currentRegister;
        private TestResult SaveTestResult()
        {
            // get register_id
            currentRegister = (
                from register in Program.provider.Registers
                where register.learner_id == currentAccount.acc_id 
                && register.course_id == currentCourse.course_id
                select register
            ).ToList().FirstOrDefault();

            // testId = currentTestID

            // get test ordinal
            List<TestResult> allResult = (
                from result in Program.provider.TestResults
                where result.register_id == currentRegister.register_id
                select result
                ).ToList();
            int testOrdinal = allResult.Count() + 1;

            // get test score
            int totalScore = 0;
            
            if (displayType == 0)
            {
                foreach (Control control in tbQuestion.Controls)
                {
                    ucTestQuestion item = control as ucTestQuestion;
                    if (item.trueScore != 0)
                    {
                        int score = (int)(item.trueScore * item.testQuestion.score / 100);
                        totalScore += score;
                    }
                }
            }
            else
            {
                foreach (ucTestQuestion item in listUCTestQuestion)
                {
                    if (item.trueScore != 0)
                    {
                        int score = (int)(item.trueScore * item.testQuestion.score / 100);
                        totalScore += score;
                    }
                }
            }

            // get Test time
            TimeSpan testTime = finishTime - startTime;

            // get isPassed
            int isPassed = 0;
            if (totalScore >= scoreToPass)
            {
                isPassed = 1;
            }

            // timestart = startTime
            // time finish = finishTime

            TestResult newTestResult = new TestResult();
            newTestResult.register_id = currentRegister.register_id;
            newTestResult.test_id = currentTestID;
            newTestResult.test_ordinal = testOrdinal;
            newTestResult.test_score = totalScore;
            newTestResult.test_time = testTime;
            newTestResult.is_passed = isPassed;
            newTestResult.time_start = startTime;
            newTestResult.time_finish = finishTime;

            Program.provider.TestResults.Add(newTestResult);
            Program.provider.SaveChanges();

            return newTestResult;
        }

        private void ShowfTestResult(TestResult result)
        {
            fTestResult testResult = new fTestResult();
            CourseResource resourceTest = (
                from resource in Program.provider.CourseResources
                join rtest in Program.provider.CourseTests
                on resource.resource_id equals(rtest.resource_id)
                select resource
                ).ToList().FirstOrDefault();

            testResult.finishTestName = String.Format("You have completed the {0}", resourceTest.resource_name);
            testResult.timeStart = result.time_start.ToString();
            testResult.timeFinish = result.time_finish.ToString();
            if (result.is_passed == 0)
            {
                testResult.testState = "Not met";
                testResult.TextStateColor = Color.Red;
            }
            else
            {
                testResult.testState = "Finish";
                testResult.TextStateColor = Color.FromArgb(94, 148, 255);
            }
            testResult.totalTime = result.test_time.ToString();
            testResult.source = result.test_score.ToString();
            testResult.testOrdinal = result.test_ordinal.ToString();

            testResult.fResultTestClose += CloseCurrentTest;

            testResult.ShowDialog();
        }

        private void CloseCurrentTest(object sender, EventArgs e)
        {
            this.Hide();

            if (CheckFinishCourse(currentCourse, currentAccount) == 1)
            {
                //  get all test mandatory of course
                List<CourseTest> listCourseTest = (
                    from test in Program.provider.CourseTests
                    join resource in Program.provider.CourseResources
                    on test.resource_id equals resource.resource_id
                    join module in Program.provider.CourseModules
                    on resource.module_id equals module.module_id
                    join course in Program.provider.Courses
                    on module.course_id equals course.course_id
                    where test.mandatory == 1
                    select test
                    ).ToList();

                double? total = 0;
                int countTest = 0;
                foreach(CourseTest test in listCourseTest)
                {
                    List<TestResult> results = (
                        from testResult in Program.provider.TestResults
                        where testResult.test_id == test.test_id
                        && testResult.register_id == currentRegister.register_id
                        select testResult
                        ).ToList();

                    if (results.Count != 0)
                    {
                        TestResult maxResult = getMaxResult(results);
                        total += maxResult.test_score;
                        countTest++;
                    }
                }

                double? completeScore = total / countTest;


                // luu thong tin
                currentRegister.completion_score = completeScore;
                currentRegister.register_status = 2;
                currentRegister.time_finish = DateTime.Now;
                Program.provider.SaveChanges();

                // da hoan thanh khoa hoc
                fFinishCourse finishCourse = new fFinishCourse(currentRegister);
                finishCourse.ShowDialog();
                SendEmail();
            }

            this.Close();
        }

        private void SendEmail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("21521083@gm.uit.edu.vn");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "csefackbesizemig");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(currentAccount.email));
            mail.IsBodyHtml = true;
            mail.Subject = "[Elearning] Finish the course" + currentRegister.Course.course_name;
            mail.Body = "You are finish the course "
                + currentRegister.Course.course_name
                + ". Please sign in to view certificate.";

            smtp.Send(mail);
        }

        private TestResult getMaxResult(List<TestResult> allTestResult)
        {
            TestResult maxResult = allTestResult.FirstOrDefault();
            foreach (TestResult result in allTestResult)
            {
                if (result.test_score > maxResult.test_score)
                {
                    maxResult = result;
                }
            }
            return maxResult;
        }

        private int isStarted = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            tbQuestion.Visible = true;
            tbAllQuestion.Enabled = true;
            timerTest.Enabled = true;
            timerTest.Start();
            startTime = DateTime.Now;
            isStarted = 1;
            btnDone.Visible = true;
            lblScoreToPass.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            timerTest.Stop();
            finishTime = DateTime.Now;
            TestResult testResult = SaveTestResult();
            ShowfTestResult(testResult);
            isStarted = 0;
        }

        private void fCourseTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isStarted == 1)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to end the test?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    timerTest.Stop();
                    finishTime = DateTime.Now;
                    TestResult testResult = SaveTestResult();
                    ShowfTestResult(testResult);
                    this.Close();
                }
            }
        }

        private void fCourseTest_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private int CheckFinishCourse(Course course, Account account)
        {
            List<CourseTest> listTestOfCourse = (
                from test in Program.provider.CourseTests
                where test.CourseResource.CourseModule.course_id == course.course_id
                && test.mandatory == 1
                select test
                ).ToList();

            foreach (CourseTest test in listTestOfCourse)
            {
                // get test result
                List<TestResult> listTestResult = (
                    from result in Program.provider.TestResults
                    where result.test_id == test.test_id
                    && result.Register.learner_id == account.acc_id
                    && result.is_passed == 1
                    select result
                    ).ToList();

                if (listTestResult.Count == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (index >= 1)
            {
                index--;
                LoadQuestionWithIndex(index - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index <= listUCTestQuestion.Count() - 1)
            {
                index++;
                LoadQuestionWithIndex(index - 1);
            }
        }
    }
}
