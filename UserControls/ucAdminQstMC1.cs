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
    public partial class ucAdminQstMC1 : UserControl
    {
        TestQuestion question;

        public ucAdminQstMC1()
        {
            InitializeComponent();

            this.flpChoices.AutoScroll = true;
            this.flpChoices.VerticalScroll.Visible = true;
            this.flpChoices.HorizontalScroll.Visible = false;
        }

        public ucAdminQstMC1(TestQuestion question) : this()
        {
            this.question = question;
            tbQuestion.Text = question.question_description;
            tbPoint.Text = question.score.ToString();

            if (question.choices != null)
            {
                string[] choices = question.choices.Split('\n');
                int correctChoice = int.Parse(question.answer);

                for (int i = 0; i < choices.Length - 1; i++)
                {
                    var uc = newUcAdminChoice(choices[i]);
                    flpChoices.Controls.Add(uc);

                    if (i == correctChoice)
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
        }

        private void ucChoice_Checked(object sender, EventArgs e)
        {
            var checkedUc = (ucAdminChoice)sender;
            if (checkedUc.IsChecked())
            {
                return;
            }

            foreach (ucAdminChoice uc in flpChoices.Controls)
            {
                if (uc != checkedUc)
                {
                    uc.Unchecked();
                }
            }

            checkedUc.Checked();

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

        public int GetCorrectChoice()
        {
            for (int i = 0; i < flpChoices.Controls.Count; i++)
            {
                var uc = (ucAdminChoice)flpChoices.Controls[i];
                if (uc.IsChecked())
                {
                    return i;
                }
            }
            return -1;
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
            question.answer = GetCorrectChoice().ToString();
        }
    }
}
