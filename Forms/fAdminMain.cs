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
        public fAdminMain()
        {
            InitializeComponent();
        }

        private void ucAdminMain_Load(object sender, EventArgs e)
        {
            ucAdminHome ucHome = new ucAdminHome(conMain);
            ucHome.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucHome);
        }
    }
}
