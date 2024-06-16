using Elearning.Entities;
using Elearning.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Elearning
{
    internal static class Program
    {
        //public static string ICONS_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."))
        //                            + "\\images\\icons\\";

        // Paths to folders in the project
        public static string AVARTAR_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\images\\avatars\\";
        public static string RESOURCES_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\images\\resources\\";
        public static string COURSES_IMG_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\images\\courses_images\\";
        public static string ICONS_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\images\\icons\\";

        public static int TYPE_VIDEO = 0;
        public static int TYPE_DOC = 1;
        public static int TYPE_TEST = 2;

        public static int ROLE_ADMIN = 1;
        public static int ROLE_LEARNER = 0;

        public static int QUESTION_MULTIPLE_CHOICE_ONE_ANSWER = 0;
        public static int QUESTION_MULTIPLE_CHOICE_MULTIPLE_ANSWERS = 1;
        public static int QUESTION_SHORT_ANSWER = 2;

        public static int TEST_DISPLAY_ALL = 0;
        public static int TEST_DISPLAY_ONE_BY_ONE = 1;

        public static string[] COURSE_DIFFICULTIES = {"Beginner", "Intermediate", "Advanced" };
        public static string[] COURSE_CATEGORIES = { "Development", "Business", "IT & Software", "Office Productivity", "Personal Development", "Design", "Marketing", "Lifestyle", "Photography", "Health & Fitness", "Music", "Teaching & Academics" };
        public static string[] RESOURCE_TYPE = { "Video", "Document", "Test" };
        public static string[] QUESTION_TYPE = { "Multiple choice - One answer", "Multiple choice - Multiple answers", "Short answer" };

        public struct CourseStats
        {
            public int total_learners;
            public int total_completed;
            public float completion_rate;
            public int rank_by_learners;
            public int rank_by_completion_rate;
            public int rank_by_rating;
        }
        // define a map to map course_id to course's stats
        public static Dictionary<int, CourseStats> courseStats = new Dictionary<int, CourseStats>();

        // Create a new instance of the ELEARNINGEntities, use this instance to interact with the database
        // example: var accounts = Program.provider.ACCOUNTs.ToList();
        public static ELearningDbEntities provider = new ELearningDbEntities();

        public static void RollBack()
        {
            // rollback all changes made to the database
            var changedEntries = provider.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        private static void UpdateDiscount()
        {
            // Check if the discount is expired of all course.
            // If the discount is expired, set the discount to 0
            var courses = provider.Courses.ToList();
            foreach (var course in courses)
            {
                if (course.discount != 0 && course.discount_end_date < DateTime.Now)
                {
                    course.discount = 0;
                    course.discount_end_date = null;
                }
            }
            provider.SaveChanges();
        }

        private static void CalculateCoursesStatistics()
        {
            // Calculate the statistics of all courses
            var courses = provider.Courses.ToList();
            foreach (var course in courses)
            {
                CourseStats stats = new CourseStats();
                stats.total_learners = provider.Registers.Where(e => e.course_id == course.course_id).Count();
                stats.total_completed = provider.Registers.Where(e => e.course_id == course.course_id && e.completion_score != null && e.completion_score != 0).Count();
                stats.completion_rate = stats.total_learners == 0 ? 0 : (float)stats.total_completed / stats.total_learners;
                courseStats.Add(course.course_id, stats);
            }

            foreach (var course in courses)
            {
                var stat = courseStats[course.course_id];
                stat.rank_by_learners = courseStats.Where(e => e.Value.total_learners > stat.total_learners).Count() + 1;
                stat.rank_by_completion_rate = courseStats.Where(e => e.Value.completion_rate > stat.completion_rate).Count() + 1;
                stat.rank_by_rating = provider.Courses.Where(e => e.stars > course.stars).Count() + 1;

                courseStats[course.course_id] = stat;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UpdateDiscount();
            CalculateCoursesStatistics();
            Application.Run(new fLogin());
        }
    }
}
