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

namespace Elearning.UserControls
{
    public partial class ucAdminQstMCM : UserControl
    {
        TestQuestion question;
        public ucAdminQstMCM()
        {
            InitializeComponent();

            this.flpChoices.AutoScroll = true;
            this.flpChoices.VerticalScroll.Visible = true;
            this.flpChoices.HorizontalScroll.Visible = false;
        }

        public ucAdminQstMCM(TestQuestion question) : this()
        {
            this.question = question;
            tbQuestion.Text = question.question_description;
            tbPoint.Text = question.score.ToString();

            if (question.choices != null)
            {
                string[] choices = question.choices.Split('\n');
                string[] correctChoices = question.answer.Split(';');

                for (int i = 0; i < choices.Length - 1; i++)
                {
                    var uc = newUcAdminChoice(choices[i]);
                    flpChoices.Controls.Add(uc);

                    if (correctChoices.Contains(i.ToString()))
                    {
                        uc.Checked();
                    }
                }
            }

        }

        private ucAdminChoice newUcAdminChoice(string choice)
        {
            var uc = new ucAdminChoice(choice);
            uc.Dock = DockStyle.Top;
            uc.evtChecked += ucChoice_Checked;
            return uc;
        }

        private void btnAddChoice_Click(object sender, EventArgs e)
        {
            string choice = tbChoice.Text;
            var uc = newUcAdminChoice(choice);
            flpChoices.Controls.Add(uc);

            if (flpChoices.Controls.Count == 1)
            {
                uc.Checked();
            }

            tbChoice.Text = "";
        }

        private void ucChoice_Checked(object sender, EventArgs e)
        {
            var uc = sender as ucAdminChoice;
            if (uc.IsChecked())
            {
                // check if there is other checked choice
                bool found = false;
                foreach (var control in flpChoices.Controls)
                {
                    var choice = control as ucAdminChoice;
                    if (choice != uc && choice.IsChecked())
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return;
                }
                uc.Unchecked();
            }
            else
            {
                uc.Checked();
            }
        }

        public string ChoicesToString()
        {
            string ret = "";
            foreach (ucAdminChoice uc in flpChoices.Controls)
            {
                ret += uc.GetChoice() + "\n";
            }
            return ret;
        }

        public string GetCorrectChoices()
        {
            string ret = "";
            int i = 0;
            foreach (ucAdminChoice uc in flpChoices.Controls)
            {
                if (uc.IsChecked())
                {
                    ret += i + ";";
                }
                i++;
            }
            return ret;
        }

        public string GetDescription()
        {
            return tbQuestion.Text;
        }

        public int GetScore()
        {
            if (tbPoint.Text == "")
            {
                return 0;
            }
            return int.Parse(tbPoint.Text);
        }

        public void UpdateQuestion()
        {
            question.question_description = GetDescription();
            question.score = GetScore();
            question.choices = ChoicesToString();
            question.answer = GetCorrectChoices();
        }
    }
}
