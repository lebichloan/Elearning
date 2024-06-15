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
    public partial class ucAdminQstShortAns : UserControl
    {
        TestQuestion question;
        public ucAdminQstShortAns()
        {
            InitializeComponent();
        }

        public ucAdminQstShortAns(TestQuestion question) : this()
        {
            this.question = question;
            tbQuestion.Text = question.question_description;
            tbPoint.Text = question.score.ToString();
            tbAnswer.Text = question.answer;
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
            question.question_description = tbQuestion.Text;
            question.score = GetScore();
            question.choices = "";
            question.answer = tbAnswer.Text;
        }
    }
}
