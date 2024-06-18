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
    public partial class ucCourseModule : UserControl
    {
        public EventHandler courseModuleClick;
        public ucCourseModule()
        {
            InitializeComponent();
        }

        public Color backColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        private int moduleId;
        public ucCourseModule(int moduleID)
        {
            InitializeComponent();
            this.moduleId = moduleID;
        }

        public int moduleID
        {
            get { return this.moduleId; }
            set { moduleId = value; }
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

        private void ucCourseModule_Click(object sender, EventArgs e)
        {
            courseModuleClick.Invoke(this, e);
        }
    }
}
