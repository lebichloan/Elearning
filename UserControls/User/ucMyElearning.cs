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
    public partial class ucMyElearning : UserControl
    {
        public EventHandler viewDetailsClicked;
        public ucMyElearning()
        {
            InitializeComponent();
            layoutMyCourses.AutoScroll = true;
            layoutMyCourses.VerticalScroll.Visible = true;
            layoutMyCourses.VerticalScroll.Enabled = true;
            layoutMyCourses.HorizontalScroll.Visible = false;
            layoutMyCourses.HorizontalScroll.Enabled = false;
            layoutMyCourses.RowCount = 0;
            layoutMyCourses.RowStyles.Clear();
            layoutMyCourses.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void ucMyElearning_Load(object sender, EventArgs e)
        {
            ucCoursePreview ucCoursePreview = new ucCoursePreview();
            int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            layoutMyCourses.ColumnCount = columns;
            layoutMyCourses.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                layoutMyCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            }

            var courses = Program.provider.Courses.ToList();
            foreach (Course course in courses)
            {
                ucCoursePreview ucCourse = new ucCoursePreview();
                ucCourse.coursePreviewClicked = course;
                ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                ucCourse.courseLecturer = course.lecturer;
                ucCourse.courseName = course.course_name;
                ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                layoutMyCourses.Controls.Add(ucCourse);
            }
        }

        private Course courseView;
        public Course courseViewClicked
        {
            get { return courseView; }
            set { courseView = value; }
        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            ucCoursePreview ucCourse = sender as ucCoursePreview;
            courseView = ucCourse.coursePreviewClicked;
            viewDetailsClicked?.Invoke(this, e);
        }

    }
}