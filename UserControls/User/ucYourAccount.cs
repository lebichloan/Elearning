using Elearning.Entities;
using Elearning.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls.User
{
    public partial class ucYourAccount : UserControl
    {
        public ucYourAccount()
        {
            InitializeComponent();
            this.currentAccount = fLogin.currentAccount;
            InitUI();
        }

        private Account currentAccount;
        private void InitUI()
        {
            txtFullName.Text = currentAccount.fullname;
            txtUserName.Text = currentAccount.username;
            txtEmail.Text = currentAccount.email;
            txtPassword.Text = currentAccount.user_password;

            List<Register> allCoursesRegister = (
                from course in Program.provider.Courses
                join register in Program.provider.Registers on course.course_id equals register.course_id
                join account in Program.provider.Accounts on register.learner_id equals account.acc_id
                select register
            ).ToList();

            lblTotalCourse.Text = allCoursesRegister.Count().ToString();

            int countComplete = 0;
            int countStudying = 0;
            int countPending = 0;
            foreach (Register register in allCoursesRegister)
            {
                if (register.register_status == 0)
                {
                    countPending++;
                }
                else if (register.register_status == 1)
                {
                    countStudying++;
                }
                else if (register.register_status == 2)
                {
                    countComplete++;
                }
            }
            lblTotalCetiificate.Text = countComplete.ToString();
            lblStudying.Text = countStudying.ToString();
            lblPending.Text = countPending.ToString();

            panYourAccount.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Full name must be fill.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email must be fill.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                currentAccount.fullname = txtFullName.Text;
                currentAccount.email = txtEmail.Text;
                Program.provider.SaveChanges();

                MessageBox.Show("Update your profile sucessfull.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
