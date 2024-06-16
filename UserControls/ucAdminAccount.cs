using Elearning.Entities;
using OnlineChat;
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
    public partial class ucAdminAccount : UserControl
    {
        Account account;
        public ucAdminAccount(Account account)
        {
            InitializeComponent();
            this.account = account;

            lbUsername.Text = account.username;
            lbName.Text = account.fullname;
            tbFullname.Text = account.fullname;
            tbEmail.Text = account.email;
            pbAvatar.Image = Image.FromFile(Program.AVARTAR_PATH + account.avatar);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            // calculate the total courses created by the account
            var courses_created = Program.provider.Courses.Where(c => c.created_by == account.acc_id).ToList();
            var courses_created_this_month = courses_created.Where(c => c.created_at != null && ((DateTime)c.created_at).Month == DateTime.Now.Month && ((DateTime)c.created_at).Year == DateTime.Now.Year).ToList();
            lbTotalCourse.Text = courses_created.Count.ToString();
            lbCourseThisMonth.Text = courses_created_this_month.Count.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check if fullname and email are filled
            if (tbFullname.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if email is valid
            if (!emailValid.IsValid)
            {
                MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // update account in database
            account.fullname = tbFullname.Text;
            account.email = tbEmail.Text;
            Program.provider.SaveChanges();
            MessageBox.Show("Account updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup(true);
            signup.ShowDialog();
        }
    }
}
