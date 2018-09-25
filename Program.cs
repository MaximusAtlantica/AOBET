using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOBET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Arena());
        }

        public static List<string> HeroList = new List<string> { "Alexandra", "Alkinarpay", "Beatrice", "ChuckYeon", "Cleopatra", "Frank", "GuanChang", "Hasard", "Jeanne", "Michelangelo", "Raphael", "Saijo", "Sarasate" };
    }
}
