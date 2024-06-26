﻿using Elearning.Entities;
using Elearning.UserControls.User;
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
        public EventHandler viewDetailsClicked;
        public EventHandler viewMyCourseClicked;
        public ucMain()
        {
            InitializeComponent();
        }

        private ucHome ucHome;
        private ucMyElearning ucMyElearning;
        private ucProfile ucProfile;
        private void ucMain_Load(object sender, EventArgs e)
        {
            this.ucHome = new ucHome();
            ucHome.Dock = DockStyle.Fill;
            ucHome.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            conMain.Controls.Add(ucHome);

            this.ucMyElearning = new ucMyElearning();
            ucMyElearning.Dock = DockStyle.Fill;
            ucMyElearning.viewDetailsClicked += ucCoursePreview_viewMyCourse;
            conMain.Controls.Add(ucMyElearning);

            this.ucProfile = new ucProfile();
            ucProfile.Dock = DockStyle.Fill;
            conMain.Controls.Add(ucProfile);

            ucHome.BringToFront();

            btnHome.Enabled = false;
        }

        public void ucMain_Reload()
        {
            ucMyElearning.Load -= ucMyElearning.ucMyElearning_Load;
            ucMyElearning.Load += ucMyElearning.ucMyElearning_Load;

            ucProfile.InitUI();
        }

        private Course coursePreview;
        public Course coursePreviewClicked
        {
            get { return coursePreview; }
            set { coursePreview = value; }
        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            ucHome ucHome = sender as ucHome;
            coursePreview = ucHome.coursePreviewClicked;
            viewDetailsClicked?.Invoke(this, e);
        }

        private void ucCoursePreview_viewMyCourse(object sender, EventArgs e)
        {
            ucMyElearning ucMyElearning = sender as ucMyElearning;
            coursePreview = ucMyElearning.courseViewClicked;
            viewMyCourseClicked?.Invoke(this, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucMain_Reload();
            //if (tabControl.SelectedIndex == 0)
            //{
            //    //ucHome ucHome = new ucHome();
            //    //ucHome.Dock = DockStyle.Fill;
            //    //ucHome.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            //    //tabHome.Controls.Add(ucHome);
            //    tabHome.Controls.Add(ucHome);
            //}
            //else if (tabControl.SelectedIndex == 1)
            //{
            //    //ucMyElearning ucMyElearning = new ucMyElearning();
            //    //ucMyElearning.Dock = DockStyle.Fill;
            //    //ucMyElearning.viewDetailsClicked += ucCoursePreview_viewMyCourse;
            //    //tabMyLearning.Controls.Add(ucMyElearning);
            //}
            //else if (tabControl.SelectedIndex == 2)
            //{
            //    //ucProfile ucProfile = new ucProfile();
            //    //ucProfile.Dock = DockStyle.Fill;
            //    //tabAccount.Controls.Add(ucProfile);
            //}
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.Enabled = false;
            btnAccount.Enabled = true;
            btnMyLearning.Enabled = true;
            ucHome.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome.Enabled = true;
            btnAccount.Enabled = false;
            btnMyLearning.Enabled = true;
            ucProfile.BringToFront();
        }

        private void btnMyLearning_Click(object sender, EventArgs e)
        {
            btnHome.Enabled = true;
            btnAccount.Enabled = true;
            btnMyLearning.Enabled = false;
            ucMyElearning.BringToFront();
        }
    }
}