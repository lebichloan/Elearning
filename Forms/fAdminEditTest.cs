using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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

            if (test.display_type == Program.TEST_DISPLAY_ALL)
            {
                this.optDisplayAll.Checked = true;
            }
            else
            {
                this.optDisplayOne.Checked = true;
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
            uc.pointChange += TotalPointChange;
            return uc;
        }

        private void ucQuestion_Click(object sender, EventArgs e)
        {
            var ucQuestion = (ucAdminQuestion)sender;

            foreach (ucAdminQuestion uc in this.flpQuestions.Controls)
            {
                uc.SetDefaultColor();
            }
            ucQuestion.SetCheckedColor();
        }

        private void ucQuestion_Delete(object sender, EventArgs e)
        {
            var ucQuestion = (ucAdminQuestion)sender;
            var question = ucQuestion.question;
            // update the order of the questions
            Program.provider.TestQuestions.Remove(question);

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

        private void CalculateTotalScore()
        {
            test.total_score = 0;
            foreach (var question in test.TestQuestions)
            {
                test.total_score += question.score;
            }
        }

        private void update()
        {
            test.CourseResource.resource_name = tbTestName.Text;
            test.mandatory = optYes.Checked ? 1 : 0;
            test.display_type = optDisplayAll.Checked ? Program.TEST_DISPLAY_ALL : Program.TEST_DISPLAY_ONE_BY_ONE;
            test.test_maxtime = TimeSpan.Parse(tbTime.Text);
            test.score_to_pass = int.Parse(tbPointToPass.Text);

            for (int i = 0; i < this.flpQuestions.Controls.Count; i++)
            {
                var ucQuestion = (ucAdminQuestion)this.flpQuestions.Controls[i];
                ucQuestion.UpdateQuestion();
            }

            CalculateTotalScore();
        }

        private void btnSaveCont_Click(object sender, EventArgs e)
        {
            update();
            if (test.total_score < test.score_to_pass)
            {
                MessageBox.Show("Total score must be greater than or equal to the score to pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Program.provider.SaveChanges();
                MessageBox.Show("Changes have been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                evtReload?.Invoke(this, e);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            update();
            if (test.total_score < test.score_to_pass)
            {
                MessageBox.Show("Total score must be greater than or equal to the score to pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void TotalPointChange(object sender, EventArgs e)
        {
            update();
            System.Diagnostics.Debug.WriteLine("Total point change");
            this.lbTotalScore.Text = " / " + test.total_score.ToString() + " points";
        }

        private void tbPointToPass_Enter(object sender, EventArgs e)
        {
        }

        // only allow numbers to be entered in the tbPointToPass
        private void tbPointToPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
