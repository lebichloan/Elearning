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
    public partial class ucCourseModule : UserControl
    {
        public ucCourseModule()
        {
            InitializeComponent();
        }

        private int moduleid;
        public int moduleID
        {
            get { return moduleid; }
            set { moduleid = value; }
        }

        public string moduleOrdinal
        {
            get { return lblModuleOrdinal.Text; }
            set { lblModuleOrdinal.Text = value; }
        }

        public string moduleName
        {
            get { return lblModuleName.Text; }
            set { lblModuleName.Text = value; }
        }

        public EventHandler courseModuleClick;
        private void ucCouseModule_Clicked(object sender, EventArgs e)
        {
            courseModuleClick?.Invoke(this, e);
        }
    }
}
