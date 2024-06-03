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
    public partial class fLogin : Form
    {
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
                if (account.user_role == Program.ROLE_ADMIN)
                {
                    // open admin form
                    fAdminMain f = new fAdminMain(account);
                    f.ShowDialog();
                }
                else
                {
                    // open student form
                    fMain f = new fMain();
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
    }
}
