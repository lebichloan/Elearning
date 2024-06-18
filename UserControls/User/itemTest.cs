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
    public partial class itemTest : UserControl
    {
        public itemTest()
        {
            InitializeComponent();
        }

        private int resource_id;
        public int resourceId
        {
            get { return resource_id; }
            set { resource_id = value; }
        }

        public string testName
        {
            get { return lblTestName.Text; }
            set { lblTestName.Text = value; }
        }

        public EventHandler goToTest;
        private void GoToTest_Click(object sender, EventArgs e)
        {
            goToTest?.Invoke(this, e);
        }

        public EventHandler viewDetailTestResult;
        private void lblViewDetail_Click(object sender, EventArgs e)
        {
            viewDetailTestResult?.Invoke(this, e);
        }

        public void SetTestState(int isFinish)
        {
            if (isFinish == 0)
            {
                //not started
                lblState.Text = "Not yet";
                lblState.ForeColor = Color.Red;
            }
            else if (isFinish == 1)
            {
                // not pass
                lblState.Text = "Not meeting the requirements";
                lblState.ForeColor = Color.Red;
            }
            else
            {
                // pass
                lblState.Text = "Finish";
                lblState.ForeColor = Color.FromArgb(94, 148, 255);
            }
        }

        public void HideViewDetail(int flag)
        {
            if (flag == 0)
            {
                lblViewDetail.Visible = false;
            }
            else
            {
                lblViewDetail.Visible = true;
            }
        }
    }
}
