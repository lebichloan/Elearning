﻿using System;
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
        public EventHandler viewDetailsClicked;
        public ucMain()
        {
            InitializeComponent();
        }

        private void ucMain_Load(object sender, EventArgs e)
        {
            // set ucHome to the tabHome
            ucHome ucHome = new ucHome();
            ucHome.Dock = DockStyle.Fill;
            ucHome.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            tabHome.Controls.Add(ucHome);
        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            viewDetailsClicked?.Invoke(this, e);
        }
    }
}
