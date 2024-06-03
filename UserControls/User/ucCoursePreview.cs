﻿using Elearning.Entities;
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

        private Course coursePreview;
        public Course coursePreviewClicked
        {
            get { return coursePreview; }
            set { coursePreview = value; }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            viewDetailsClicked?.Invoke(this, e);
        }

        public Image courseImage
        {
            get { return picImage.Image; }
            set { picImage.Image = value; }
        }

        public string courseLecturer
        {
            get { return lbLecturer.Text; }
            set { lbLecturer.Text = value; }
        }

        public string courseName
        {
            get { return lbCourseName.Text; }
            set { lbCourseName.Text = value; }
        }
    }
}