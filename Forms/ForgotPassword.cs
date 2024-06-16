using Elearning.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChat
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void butSendCode_Click(object sender, EventArgs e)
        {
            
        }

        private void butResetPassword_Click(object sender, EventArgs e)
        {
            if (tbCode.Text == "")
            {
                MessageBox.Show("Please enter the code", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin login = new fLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
