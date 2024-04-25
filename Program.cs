using Elearning.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Elearning
{
    internal static class Program
    {
        // Paths to folders in the project
        public static string AVARTAR_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\images\\avatars\\";
        public static string RESOURCES_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\resources\\";
        public static string COURSES_IMG_PATH = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) 
                                            + "\\images\\courses_images\\";

        // Create a new instance of the ELEARNINGEntities, use this instance to interact with the database
        // example: var accounts = Program.provider.ACCOUNTs.ToList();
        public static ELEARNINGEntities provider = new ELEARNINGEntities();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }
}
