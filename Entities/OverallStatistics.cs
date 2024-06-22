using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities
{
    internal class OverallStatistics
    {
        public int Year { get; set; }
        public int Month { get; set; }

        public int NewLearners { get; set; }
        public int NewCourses { get; set; }

        public int NewRegistrations { get; set; }

        public int Earnings { get; set; }

        public OverallStatistics(int year, int month)
        {
            Year = year;
            Month = month;

            // Get the total number of new learners registered in the given year and month
            NewLearners = Program.provider.Accounts.Where(a => a.user_role == Program.ROLE_LEARNER && a.created_at.Year == year && a.created_at.Month == month).Count();

            // Get the total number of new courses created in the given year and month
            NewCourses = Program.provider.Courses.Where(c => ((DateTime)c.created_at).Year == year && ((DateTime)c.created_at).Month == month).Count();

            // Get the total number of new registrations in the given year and month
            NewRegistrations = Program.provider.Registers.Where(r => r.registered_date.Year == year && r.registered_date.Month == month).Count();

            // Get the total earnings in the given year and month
            var lst = Program.provider.Registers.Where(r => r.registered_date.Year == year && r.registered_date.Month == month).ToList();
            Earnings = lst != null ? (int)lst.Sum(r => r.paid) : 0;
        }
    }
}
