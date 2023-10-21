using EducationAutomationSystem.Admin;
using EducationAutomationSystem.Applications;
using EducationAutomationSystem.Lesson;
using EducationAutomationSystem.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomationSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLanguage());
        }
    }
}
