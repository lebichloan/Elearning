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

namespace Elearning.Forms
{
    public partial class fChangePassword : Form
    {
        Account account;
        public fChangePassword(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check if old password is correct
            if (account.user_password != tbOldPassword.Text)
            {
                MessageBox.Show("Old password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = tbOldPassword;
                return;
            }

            // check if new password is empty
            if (tbNewPassword.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = tbNewPassword;
                return;
            }

            // check if new password and confirm password are the same
            if (tbNewPassword.Text != tbConfirm.Text)
            {
                MessageBox.Show("New password and confirm password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = tbConfirm;
                return;
            }

            // update password in database
            account.user_password = tbNewPassword.Text;
            Program.provider.SaveChanges();

            MessageBox.Show("Password updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
