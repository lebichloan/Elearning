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
    public partial class ucCoursePreview : UserControl
    {
        public EventHandler viewDetailsClicked;
        public ucCoursePreview()
        {
            InitializeComponent();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            viewDetailsClicked?.Invoke(this, e);
        }
    }
}
