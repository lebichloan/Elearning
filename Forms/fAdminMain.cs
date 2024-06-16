using Elearning.Entities;
using Elearning.UserControls;
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
    public partial class fAdminMain : Form
    {
        ucAdminHome ucHome;
        Account account;
        ucAdminAccount ucAccount;
        ucOverallStats ucStats;
        public fAdminMain(Account account)
        {
            InitializeComponent();
            this.account = account;

            this.lbUserFullname.Text = account.fullname;
            this.btnUserProfile.Image = Image.FromFile(Program.AVARTAR_PATH + account.avatar);
            this.btnUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ucAdminMain_Load(object sender, EventArgs e)
        {
            ucHome = new ucAdminHome(conMain);
            ucHome.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucHome);

            ucAccount = new ucAdminAccount(account);
            ucAccount.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucAccount);

            ucStats = new ucOverallStats();
            ucStats.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucStats);

            ucHome.BringToFront();
        }

        private void fAdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.ShowDialog();
        }

        private void fAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fLogin fLogin = new fLogin();
            //fLogin.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ucHome.BringToFront();
            btnCourses.Enabled = false;
            btnStatistics.Enabled = true;
            btnAccount.Enabled = true;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ucAccount.BringToFront();
            btnCourses.Enabled = true;
            btnStatistics.Enabled = true;
            btnAccount.Enabled = false;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ucStats.BringToFront();
            btnStatistics.Enabled = false;
            btnCourses.Enabled = true;
            btnAccount.Enabled = true;

        }
    }
}
