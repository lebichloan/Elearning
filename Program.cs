using Elearning.Entities;
using Elearning.Forms;
using System;
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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UpdateDiscount();
            Application.Run(new fLogin());
        }
    }
}
