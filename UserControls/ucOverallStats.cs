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
    public partial class ucOverallStats : UserControl
    {
        public ucOverallStats()
        {
            InitializeComponent();

            tableLayoutPanel1.Visible = false;
            cbMonth.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int month = cbMonth.SelectedIndex;
            int year = Convert.ToInt32(cbYear.SelectedItem);
            tableLayoutPanel1.Visible = true;

            if (month == 0)
            {
                // Show statistics for all months in the selected year
                var new_learner = Program.provider.Accounts.Where(a => a.created_at.Year == year && a.user_role == Program.ROLE_LEARNER).Count();
                var new_course = Program.provider.Courses.Where(c => ((DateTime)c.created_at).Year == year).Count();
                var new_enrollment = Program.provider.Registers.Where(en => ((DateTime)en.registered_date).Year == year).Count();
                var year_registers = Program.provider.Registers.Where(en => ((DateTime)en.registered_date).Year == year).ToList();
                var total_earnings = 0;
                if (year_registers != null && year_registers.Count > 0) total_earnings = (int)year_registers.Sum(en => en.paid);
                
                // find course that have biggest total earnings
                var top_earn_course = Program.provider.Courses.Where(c => c.Registers.Count > 0).OrderByDescending(c => c.Registers.Sum(r => r.paid)).FirstOrDefault();
                var top_earnings = top_earn_course.Registers.Sum(r => r.paid);
                // find course that have biggest number of enrollments
                var top_enroll_course = Program.provider.Courses.Where(c => c.Registers.Count > 0).OrderByDescending(c => c.Registers.Count).FirstOrDefault();
                var top_enrollments = top_enroll_course.Registers.Count;

                lbNewLearners.Text = new_learner.ToString();
                lbNewCourses.Text = new_course.ToString();
                lbNewRegistrations.Text = new_enrollment.ToString();
                lbTotalEarning.Text = total_earnings.ToString("N0") + "đ";
                lbTopEarnCourse.Text = top_earn_course.course_name + " (" + top_earnings.ToString("N0") + "đ)";
                lbMostRegisCourse.Text = top_enroll_course.course_name + " (" + top_enrollments + " registrations)";
            } 
            else
            {
                // Show statistics for the selected month in the selected year
                var new_learner = Program.provider.Accounts.Where(a => a.created_at.Year == year && a.created_at.Month == month && a.user_role == Program.ROLE_LEARNER).Count();
                var new_course = Program.provider.Courses.Where(c => ((DateTime)c.created_at).Year == year && ((DateTime)c.created_at).Month == month).Count();
                var new_enrollment = Program.provider.Registers.Where(en => ((DateTime)en.registered_date).Year == year && ((DateTime)en.registered_date).Month == month).Count();
                var total_earnings = 0;
                var month_registers = Program.provider.Registers.Where(en => ((DateTime)en.registered_date).Year == year && ((DateTime)en.registered_date).Month == month).ToList();
                if (month_registers != null && month_registers.Count > 0) total_earnings = (int)month_registers.Sum(en => en.paid);

                // find course that have biggest total earnings
                var top_earn_course = Program.provider.Courses.Where(c => c.Registers.Count > 0 && ((DateTime)c.created_at).Year == year && ((DateTime)c.created_at).Month == month).OrderByDescending(c => c.Registers.Sum(r => r.paid)).FirstOrDefault();
                var top_earnings = top_earn_course.Registers.Sum(r => r.paid);
                // find course that have biggest number of enrollments
                var top_enroll_course = Program.provider.Courses.Where(c => c.Registers.Count > 0 && ((DateTime)c.created_at).Year == year && ((DateTime)c.created_at).Month == month).OrderByDescending(c => c.Registers.Count).FirstOrDefault();
                var top_enrollments = top_enroll_course.Registers.Count;

                lbNewLearners.Text = new_learner.ToString();
                lbNewCourses.Text = new_course.ToString();
                lbNewRegistrations.Text = new_enrollment.ToString();
                lbTotalEarning.Text = total_earnings.ToString("N0") + "đ";
                lbTopEarnCourse.Text = top_earn_course.course_name + " (" + top_earnings.ToString("N0") + "đ)";
                lbMostRegisCourse.Text = top_enroll_course.course_name + " (" + top_enrollments + " registrations)";
            }   
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Show statistics for all time
            tableLayoutPanel1.Visible = true;

            var new_learner = Program.provider.Accounts.Where(a => a.user_role == Program.ROLE_LEARNER).Count();
            var new_course = Program.provider.Courses.Count();
            var new_enrollment = Program.provider.Registers.Count();
            var total_earnings = 0;
            var all_registers = Program.provider.Registers.ToList();
            if (all_registers != null && all_registers.Count > 0) total_earnings = (int)all_registers.Sum(en => en.paid);

            // find course that have biggest total earnings
            var top_earn_course = Program.provider.Courses.Where(c => c.Registers.Count > 0).OrderByDescending(c => c.Registers.Sum(r => r.paid)).FirstOrDefault();
            var top_earnings = top_earn_course.Registers.Sum(r => r.paid);
            // find course that have biggest number of enrollments
            var top_enroll_course = Program.provider.Courses.Where(c => c.Registers.Count > 0).OrderByDescending(c => c.Registers.Count).FirstOrDefault();
            var top_enrollments = top_enroll_course.Registers.Count;

            lbNewLearners.Text = new_learner.ToString();
            lbNewCourses.Text = new_course.ToString();
            lbNewRegistrations.Text = new_enrollment.ToString();
            lbTotalEarning.Text = total_earnings.ToString("N0") + "đ";
            lbTopEarnCourse.Text = top_earn_course.course_name + " (" + top_earnings.ToString("N0") + "đ)";
            lbMostRegisCourse.Text = top_enroll_course.course_name + " (" + top_enrollments + " registrations)";
        }
    }
}
