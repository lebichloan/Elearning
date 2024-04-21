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
    public partial class ucHome : UserControl
    {
        public EventHandler viewDetailsClicked;
        public ucHome()
        {
            InitializeComponent();
            this.flowLayout.AutoScroll = true;
            this.flowLayout.VerticalScroll.Visible = true;
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ucCoursePreview item = new ucCoursePreview();
                item.Dock = DockStyle.Top;
                item.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                this.flowLayout.Controls.Add(item);
            }

        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            viewDetailsClicked?.Invoke(this, e);
        }
    }
}
