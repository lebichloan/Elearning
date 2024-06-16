using Elearning.Entities;
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
    public partial class ucCourseStatistics : UserControl
    {
        Course course;
        public ucCourseStatistics(Course course)
        {
            InitializeComponent();
            this.course = course;

            // make three columns of the table layout panel have the same width
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 33.33f;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 33.33f;
            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 33.33f;

            Program.CourseStats stat = Program.courseStats[course.course_id];
            lbNumRegister.Text = stat.total_learners.ToString();
            lbNumComplete.Text = stat.total_completed.ToString();
            lbComRate.Text = stat.completion_rate.ToString() + "%";
            lbRankByRegister.Text = stat.rank_by_learners.ToString();
            lbRankByComRate.Text = stat.rank_by_completion_rate.ToString();
            lbRankByRatings.Text = stat.rank_by_rating.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
