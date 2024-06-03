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
    public partial class ucAdminQuestion : UserControl
    {
        public TestQuestion question;
        public EventHandler evtClicked;
        public EventHandler evtDelete;
        ContainerControl conDetails;
        UserControl ucDetails;
        public ucAdminQuestion()
        {
            InitializeComponent();
        }

        public ucAdminQuestion(TestQuestion question, ContainerControl conDetails) : this()
        {
            this.question = question;
            this.conDetails = conDetails;

            if (question.question_type == Program.QUESTION_MULTIPLE_CHOICE_ONE_ANSWER)
            {
                ucDetails = new ucAdminQstMC1(this.question);
            } else if (question.question_type == Program.QUESTION_MULTIPLE_CHOICE_MULTIPLE_ANSWERS)
            {
                ucDetails = new ucAdminQstMCM(this.question);
            } else if (question.question_type == Program.QUESTION_SHORT_ANSWER)
            {
                ucDetails = new ucAdminQstShortAns(this.question);
            }
            
            ucDetails.Dock = DockStyle.Fill;
            LoadQuestion();
        }

        public void LoadQuestion()
        {
            this.lbName.Text = "Question " + question.question_order;
            this.lbType.Text = Program.QUESTION_TYPE[question.question_type];
        }

        public int GetScore()
        {
            return question.score;
        }

        private void question_Click(object sender, EventArgs e)
        {
            conDetails.Controls.Clear();
            conDetails.Controls.Add(ucDetails);
            evtClicked?.Invoke(this, e);
        }

        public void UpdateQuestion()
        {
            if (question.question_type == Program.QUESTION_MULTIPLE_CHOICE_ONE_ANSWER)
            {
                ((ucAdminQstMC1)ucDetails).UpdateQuestion();
            } else if (question.question_type == Program.QUESTION_MULTIPLE_CHOICE_MULTIPLE_ANSWERS)
            {
                ((ucAdminQstMCM)ucDetails).UpdateQuestion();
            } else if (question.question_type == Program.QUESTION_SHORT_ANSWER)
            {
                ((ucAdminQstShortAns)ucDetails).UpdateQuestion();
            }
        }

        public void UpdateOrder(int order)
        {
            question.question_order = order;
            LoadQuestion();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            evtDelete?.Invoke(this, e);
        }

        public void SetCheckedColor()
        {
            this.siticoneContainerControl1.FillColor = Color.FromArgb(151, 170, 232);
        }

        public void SetDefaultColor()
        {
            this.siticoneContainerControl1.FillColor = Color.White;
        }
    }
}
