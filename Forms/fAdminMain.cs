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
            ucAdminHome ucHome = new ucAdminHome(conMain);
            ucHome.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucHome);
        }
    }
}
