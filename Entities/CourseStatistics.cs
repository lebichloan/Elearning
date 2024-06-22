using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Entities
{
    internal class CourseStatistics
    {
        public int CourseId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TotalLearners { get; set; }
        public int Earnings { get; set; }

        public CourseStatistics(int courseId, int year, int month)
        {
            CourseId = courseId;
            Year = year;
            Month = month;

            // Get the total number of learners registered for the course in the given year and month
            // Get the total earnings of the course in the given year and month
            TotalLearners = Program.provider.Registers.Where(r => r.course_id == courseId && r.registered_date.Year == year && r.registered_date.Month == month).Count();
            var lst = Program.provider.Registers.Where(r => r.course_id == courseId && r.registered_date.Year == year && r.registered_date.Month == month).ToList();
            Earnings = lst != null ? (int)lst.Sum(r => r.paid) : 0;
        }
    }
}
