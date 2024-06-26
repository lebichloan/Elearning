﻿using Elearning.Entities;
using Elearning.Forms;
using Elearning.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class fMain : Form
    {
        private ucMain ucMain;
        public fMain()
        {
            InitializeComponent();
            currentAccount = fLogin.currentAccount;
        }

        private Account currentAccount;
        private void fMain_Load(object sender, EventArgs e)
        {
            lbUserFullname.Text = currentAccount.fullname;
            btnUserProfile.Image = Image.FromFile(Program.AVARTAR_PATH + currentAccount.avatar);
            this.ucMain = new ucMain();
            this.ucMain.Dock = DockStyle.Fill;
            this.ucMain.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            this.ucMain.viewMyCourseClicked += ucMyElearning_viewMyCourseClicked;
            panelMain.Controls.Add(ucMain);
        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ucMain ucmain = sender as ucMain;
            Course course = ucmain.coursePreviewClicked;
            ucCourseInfo ucCourseInfo = new ucCourseInfo(course);
            ucCourseInfo.Dock = DockStyle.Fill;
            ucCourseInfo.backHomeClicked += ucCourseInfo_backHomeClicked;
            panelMain.Controls.Add(ucCourseInfo);
        }
        private void lbAppName_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            //panelMain.Controls.Add(this.ucMain);
            //this.ucMain = new ucMain();
            //this.ucMain.Dock = DockStyle.Fill;
            //this.ucMain.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            //this.ucMain.viewMyCourseClicked += ucMyElearning_viewMyCourseClicked;

            //this.ucMain.Load -= ucMain.ucMain_Load;
            //this.ucMain.Load += ucMain.ucMain_Load;

            this.ucMain.ucMain_Reload();

            panelMain.Controls.Add(ucMain);
        }

        private void ucCourseInfo_backHomeClicked(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            //panelMain.Controls.Add(this.ucMain);
            this.ucMain = new ucMain();
            this.ucMain.Dock = DockStyle.Fill;
            this.ucMain.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            this.ucMain.viewMyCourseClicked += ucMyElearning_viewMyCourseClicked;
            panelMain.Controls.Add(ucMain);
        }

        private void ucMyElearning_viewMyCourseClicked(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ucMain ucmain = sender as ucMain;
            Course course = ucmain.coursePreviewClicked;
            ucCourse ucCourse = new ucCourse(course);
            ucCourse.Dock = DockStyle.Fill;
            ucCourse.backHomeClicked += ucCourseInfo_backHomeClicked;
            panelMain.Controls.Add(ucCourse);
        }

        //private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    //this.Hide();
        //    //fLogin fLogin = new fLogin();
        //    //fLogin.ShowDialog();
        //    //this.Close();
        //}

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
