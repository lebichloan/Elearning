using Elearning.Forms;
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
    public partial class ucCourseInfo : UserControl
    {
        public EventHandler backHomeClicked;
        public ucCourseInfo()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            backHomeClicked?.Invoke(this, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPayment registerPayment = new RegisterPayment();
            registerPayment.ShowDialog();
        }
    }
}
