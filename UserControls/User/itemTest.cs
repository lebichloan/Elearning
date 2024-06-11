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
    }
}
