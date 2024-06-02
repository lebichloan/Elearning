using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elearning.Entities;
using Elearning.UserControls;

namespace Elearning.Forms
{
    public partial class fAdminEditTest : Form
    {
        Elearning.Entities.CourseTest test;
        public EventHandler evtReload;
        public fAdminEditTest()
        {
            InitializeComponent();

            this.flpQuestions.AutoScroll = true;
            this.flpQuestions.VerticalScroll.Visible = true;
            this.flpQuestions.HorizontalScroll.Visible = false;
        }

        public fAdminEditTest(Elearning.Entities.CourseTest test) : this()
        {
            this.test = test;
            this.tbTestName.Text = test.CourseResource.resource_name;
            if (test.mandatory == 1)
            {
                this.optYes.Checked = true;
            }
            else
            {
                this.optNo.Checked = true;
            }

            // load types from Program.QUESTION_TYPE to combobox
            this.cbQstType.DataSource = Program.QUESTION_TYPE;
            this.cbQstType.SelectedIndex = 0;

            this.tbTime.Text = test.test_maxtime.ToString();
            this.tbPointToPass.Text = test.score_to_pass.ToString();
            this.lbTotalScore.Text = " / " + test.total_score.ToString() + " points";
            // load questions
            LoadQuestions();
        }

        private ucAdminQuestion newUcAdminQuestion(TestQuestion question)
        {
            var uc = new ucAdminQuestion(question, conDetails);
            uc.Dock = DockStyle.Top;
            uc.evtClicked += ucQuestion_Click;
            uc.evtDelete += ucQuestion_Delete;
            return uc;
        }

        private void ucQuestion_Click(object sender, EventArgs e)
        {
            var ucQuestion = (ucAdminQuestion)sender;
            var question = ucQuestion.question;
        }

        private void ucQuestion_Delete(object sender, EventArgs e)
        {
            var ucQuestion = (ucAdminQuestion)sender;
            var question = ucQuestion.question;
            // update the order of the questions
            test.TestQuestions.Remove(question);
            this.flpQuestions.Controls.Remove(ucQuestion);
            for (int i = 0; i < this.flpQuestions.Controls.Count; i++)
            {
                var uc = (ucAdminQuestion)this.flpQuestions.Controls[i];
                uc.UpdateOrder(i + 1);
            }
        }

        void LoadQuestions()
        {
            this.flpQuestions.Controls.Clear();
            foreach (var question in test.TestQuestions)
            {
                var ucQuestion = newUcAdminQuestion(question);
                this.flpQuestions.Controls.Add(ucQuestion);
            }
        }

        private void update()
        {
            test.CourseResource.resource_name = tbTestName.Text;
            test.mandatory = optYes.Checked ? 1 : 0;
            test.test_maxtime = TimeSpan.Parse(tbTime.Text);
            test.score_to_pass = int.Parse(tbPointToPass.Text);
            test.total_score = 0;

            for (int i = 0; i < this.flpQuestions.Controls.Count; i++)
            {
                var ucQuestion = (ucAdminQuestion)this.flpQuestions.Controls[i];
                ucQuestion.UpdateQuestion();

            }

            foreach (var question in test.TestQuestions)
            {
                System.Diagnostics.Debug.WriteLine(question.score);
                test.total_score += question.score;
            }
        }

        private void btnSaveCont_Click(object sender, EventArgs e)
        {
            update();

            Program.provider.SaveChanges();
            MessageBox.Show("Changes have been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            evtReload?.Invoke(this, e);
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            update();
            Program.provider.SaveChanges();
            MessageBox.Show("Changes have been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            evtReload?.Invoke(this, e);
        }

        private void btnAddQst_Click(object sender, EventArgs e)
        {
            // get the type of the question
            int type = this.cbQstType.SelectedIndex;

            // create a new question
            var question = new TestQuestion()
            {
                question_order = test.TestQuestions.Count + 1,
                question_type = type,
                score = 0,
                CourseTest = test
            };

            // add the question to the test
            test.TestQuestions.Add(question);

            // add the question to the flow layout panel
            var ucQuestion = newUcAdminQuestion(question);
            this.flpQuestions.Controls.Add(ucQuestion);

        }
    }
}
