using Elearning.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fLogin : Form
    {
        public static Account currentAccount = null;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check if username and password are filled
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // search account in database using Program.provider.Accounts
            var account = Program.provider.Accounts.FirstOrDefault(a => a.username == tbUsername.Text && a.user_password == tbPassword.Text);
            if (account != null)
            {
                currentAccount = account;
                if (account.user_role == Program.ROLE_ADMIN)
                {
                    // open admin form
                    fAdminMain f = new fAdminMain(account);
                    f.FormClosed += CloseMainForm;
                    f.ShowDialog();
                }
                else
                {
                    // open student form
                    fMain f = new fMain();
                    f.FormClosed += CloseMainForm;
                    f.ShowDialog();
                }
                this.Close();
            }
            else
            {
                // show error message
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

        }

        private void CloseMainForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // search account in database using Program.provider.Accounts
                var account = Program.provider.Accounts.FirstOrDefault(a => a.username == tbUsername.Text && a.user_password == tbPassword.Text);
                if (account != null)
                {
                    currentAccount = account;
                    if (account.user_role == Program.ROLE_ADMIN)
                    {
                        // open admin form
                        fAdminMain f = new fAdminMain(account);
                        f.FormClosed += CloseMainForm;
                        f.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        // open student form
                        fMain f = new fMain();
                        f.FormClosed += CloseMainForm;
                        f.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    // show error message
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
