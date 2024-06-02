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
    public partial class ucAdminChoice : UserControl
    {
        public EventHandler evtChecked;
        bool isCorrect;
        public ucAdminChoice()
        {
            InitializeComponent();

            isCorrect = false;
        }

        public ucAdminChoice(string opt) : this()
        {
            lbChoice.Text = opt;
        }

        public bool IsChecked()
        {
            return this.isCorrect;
        }

        public void Checked()
        {
            this.checkbox.BackgroundImage = Properties.Resources.correct;
            this.isCorrect = true;
        }

        public void Unchecked()
        {
            this.checkbox.BackgroundImage = Properties.Resources.wrong;
            this.isCorrect = false;
        }

        private void checkbox_Click(object sender, EventArgs e)
        {
            evtChecked?.Invoke(this, e);
        }

        public string GetChoice()
        {
            return lbChoice.Text;
        }
    }
}
