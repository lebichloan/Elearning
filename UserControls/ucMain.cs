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
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(66, 135, 245);
            btnMyLearning.BackColor = Color.White;

            // set ucHome to the panelMain
        }

        private void btnMyLearning_Click(object sender, EventArgs e)
        {
            btnMyLearning.BackColor = Color.FromArgb(66, 135, 245);
            btnHome.BackColor = Color.White;

            // set ucMyLearning to the panelMain
        }

        private void ucMain_Load(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(66, 135, 245);
            btnMyLearning.BackColor = Color.White;

            // set ucHome to the panelMain
        }
    }
}
