using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *Author: Hassan Kobeissi
 * Co-Author: Tom T
 * Date Created: 2016-08-19
 * Date Modified: 2016-08-19
 * Program Description: Main File.
 */
namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //SplshForm will load before AbilityGenerator
            Application.Run(new SplashForm());
            Application.Run(new AbilityGeneratorForm());
        }
    }
}
